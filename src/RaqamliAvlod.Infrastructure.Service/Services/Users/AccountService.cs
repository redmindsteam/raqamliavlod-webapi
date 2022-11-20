using Microsoft.Extensions.Caching.Memory;
using RaqamliAvlod.Application.Exceptions;
using RaqamliAvlod.DataAccess.Interfaces;
using RaqamliAvlod.Domain.Entities.Users;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Helpers;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Users;
using RaqamliAvlod.Infrastructure.Service.Security;
using System.Net;

namespace RaqamliAvlod.Infrastructure.Service.Services.Users
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthManager _authManager;
        private readonly IMemoryCache _cache;
        private readonly IEmailService _emailService;
        private readonly IFileService _fileService;

        public AccountService(IUnitOfWork unitOfWork, IAuthManager authManager,
            IMemoryCache cache, IEmailService emailService, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _authManager = authManager;
            _cache = cache;
            _emailService = emailService;
            _fileService = fileService;
        }
        
        public async Task<string> LogInAsync(AccountLoginDto accountLogin)
        {
            var user = accountLogin.EmailOrUsername.Contains('@') ?
                  await _unitOfWork.Users.GetByEmailAsync(accountLogin.EmailOrUsername.ToLower().Trim())
                : await _unitOfWork.Users.GetByUsernameAsync(accountLogin.EmailOrUsername.Trim());

            if (user is null) throw new StatusCodeException(HttpStatusCode.NotFound, message: "Email or Username is wrong");

            if (user.EmailConfirmed is false)
                throw new StatusCodeException(HttpStatusCode.BadRequest, message: "email did not verified");

            if (PasswordHasher.Verify(accountLogin.Password, user.Salt, user.PasswordHash))
                return _authManager.GenerateToken(user);
            else throw new StatusCodeException(HttpStatusCode.BadRequest, message: "password is wrong");
        }

        public async Task<bool> RegisterAsync(AccountCreateDto accountCreate)
        {
            var user = await _unitOfWork.Users.GetByEmailAsync(accountCreate.Email.ToLower());
            if (user is not null) throw new StatusCodeException(HttpStatusCode.BadRequest, message: "user already exist");

            var newUser = (User)accountCreate;
            var hashResult = PasswordHasher.Hash(accountCreate.Password);
            newUser.Salt = hashResult.Salt;
            newUser.PasswordHash = hashResult.Hash;
            newUser.ImagePath = $"{_fileService.ImageFolderName}/IMG_bf6218f9-dd17-44ce-8d39-e9b9d374a903.jpg";
            newUser.CreatedAt = TimeHelper.GetCurrentDateTime();
            newUser.UpdatedAt = TimeHelper.GetCurrentDateTime();

            await _unitOfWork.Users.CreateAsync(newUser);

            var email = new SendToEmailDto();
            email.Email = accountCreate.Email;

            await SendCodeAsync(email);

            return true;
        }

        public async Task SendCodeAsync(SendToEmailDto sendToEmail)
        {
            int code = new Random().Next(10000, 99999);

            _cache.Set(sendToEmail.Email, code, TimeSpan.FromMinutes(10));

            var message = new EmailMessage()
            {
                To = sendToEmail.Email,
                Subject = "Verifcation code",
                Body = code.ToString()
            };

            await _emailService.SendAsync(message);
        }

        public async Task<bool> VerifyEmailAsync(VerifyEmailDto verifyEmail)
        {
            var user = await _unitOfWork.Users.GetByEmailAsync(verifyEmail.Email);

            if (user is null)
                throw new StatusCodeException(HttpStatusCode.NotFound, message: "User not found");

            if (_cache.TryGetValue(verifyEmail.Email, out int expectedCode) is false)
                throw new StatusCodeException(HttpStatusCode.BadRequest, message: "Code is expired");

            if (expectedCode != verifyEmail.Code)
                throw new StatusCodeException(HttpStatusCode.BadRequest, message: "Code is wrong");

            user.EmailConfirmed = true;
            await _unitOfWork.Users.UpdateAsync(user.Id, user);
            return true;
        }

        public async Task<bool> VerifyPasswordAsync(UserResetPasswordDto userResetPassword)
        {
            var user = await _unitOfWork.Users.GetByEmailAsync(userResetPassword.Email);

            if (user is null)
                throw new StatusCodeException(HttpStatusCode.NotFound, message: "User not found");

            if (user.EmailConfirmed is false)
                throw new StatusCodeException(HttpStatusCode.BadRequest, message: "Email did not verified");

            var changedPassword = PasswordHasher.Hash(userResetPassword.Password, user.Salt);

            user.PasswordHash = changedPassword;

            await _unitOfWork.Users.UpdateAsync(user.Id, user);

            return true;
        }
    }
}
