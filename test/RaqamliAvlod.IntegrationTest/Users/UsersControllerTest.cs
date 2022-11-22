using AngleSharp.Io;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RaqamliAvlod.Api.Controllers;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Users;
using System.Threading.Tasks;
using Xunit;

namespace RaqamliAvlod.IntegrationTest.Users
{
    public class UsersControllerTest 
    {
        private readonly Mock<IUserService> _userService;
        private readonly Mock<IIdentityHelperService> _identityHelper;
        private readonly UsersController _controller;

        public UsersControllerTest()
        {
            _userService = new Mock<IUserService>();
            _identityHelper = new Mock<IIdentityHelperService>();
            _controller = new UsersController(_userService.Object, _identityHelper.Object);
        }

        [Fact]
        public async Task ReturnUsersAsync()
        {
            PaginationParams @params = new PaginationParams(1, 10);
            var result = await _controller.GetAllAsync(@params);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task ReturnNotAuthorizedInDeleteUserAsync()
        {
            var response = await _controller.DeleteAsync(1);
            Assert.IsType<UnauthorizedResult>(response);
        }

        [Fact]
        public async Task ReturnNotAuthorizedInRUserAsync()
        {
            var response = await _controller.GetR();

            Assert.IsType<UnauthorizedResult>(response);
        }

        [Fact]
        public async Task ReturnNotFoundAsync()
        {
            var response = await _controller.GetIdAsync(-111);
            var result = Assert.IsType<ObjectResult>(response);
            Assert.Equal(404, result.StatusCode);
        }
    }
}
