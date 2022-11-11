using RaqamliAvlod.Application.Exceptions;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.ProblemSets;
using RaqamliAvlod.DataAccess.Interfaces;
using RaqamliAvlod.Domain.Entities.ProblemSets;
using RaqamliAvlod.Domain.Enums;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.ProblemSets;
using System;
using System.Net;

namespace RaqamliAvlod.Infrastructure.Service.Services.ProblemSets
{
    public class ProblemSetService : IProblemSetService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaginatorService _paginator;
        public ProblemSetService(IUnitOfWork unitOfWork, IPaginatorService paginator)
        {
            this._unitOfWork = unitOfWork;
            this._paginator = paginator;
        }

        public async Task<bool> CreateAsync(ProblemSetCreateDto createDto)
        {
            var oldProblemSet = await _unitOfWork.ProblemSets.FindByNameAsync(createDto.Name);
            if (oldProblemSet is not null) throw new StatusCodeException(HttpStatusCode.BadRequest, $"There is alredy exist problemset named by {createDto.Name}");

            var ownerUser = await _unitOfWork.Users.FindByIdAsync(createDto.OwnerId);
            if (ownerUser is null) throw new StatusCodeException(HttpStatusCode.NotFound, $"Owner is not known. Owner id = {createDto.OwnerId} is not valid");

            if (ownerUser.Role != UserRole.Admin || ownerUser.Role != UserRole.SuperAdmin)
                throw new StatusCodeException(HttpStatusCode.BadRequest, "This user can't create problem set");

            var problemSet = (ProblemSet)createDto;
            problemSet.ContestIdentifier = 'A';
            await _unitOfWork.ProblemSets.CreateAsync(problemSet);
            return true;
        }

        public async Task<bool> DeleteAsync(long problemSetId)
        {
            var problemSet = await _unitOfWork.ProblemSets.FindByIdAsync(problemSetId);
            if (problemSet is null) throw new StatusCodeException(HttpStatusCode.NotFound, "ProblemSet is not found");
            await _unitOfWork.ProblemSets.DeleteAsync(problemSetId);
            return true;
        }

        public async Task<IEnumerable<ProblemSetBaseViewModel>> GetAllAsync(PaginationParams @params, long? userId)
        {
            var pagedProblemSets = await _unitOfWork.ProblemSets.GetAllViewAsync(@params, (userId is null)?0:userId.Value);
            _paginator.ToPagenator(pagedProblemSets.MetaData);
            return pagedProblemSets;
        }

        public async Task<ProblemSetViewModel> GetAsync(long problemSetId)
        {
            var problemSet = await _unitOfWork.ProblemSets.FindByIdAsync(problemSetId);
            if (problemSet is null) throw new StatusCodeException(HttpStatusCode.NotFound, "ProblemSet is not found");

            return (ProblemSetViewModel) problemSet;
        }

        public async Task<bool> UpdateAsync(long problemSetId, ProblemSetCreateDto updateDto)
        {
            var oldProblemSet = await _unitOfWork.ProblemSets.FindByIdAsync(problemSetId);
            if (oldProblemSet is null) throw new StatusCodeException(HttpStatusCode.NotFound, "ProblemSet is not found");

            var ownerUser = await _unitOfWork.Users.FindByIdAsync(updateDto.OwnerId);
            if (ownerUser is null) throw new StatusCodeException(HttpStatusCode.NotFound, $"Owner is not known. Owner id = {updateDto.OwnerId} is not valid");

            var problemSet = (ProblemSet)updateDto;
            problemSet.ContestIdentifier = oldProblemSet.ContestIdentifier;
            problemSet.CreatedAt = oldProblemSet.CreatedAt;
            await _unitOfWork.ProblemSets.UpdateAsync(problemSetId, problemSet);
            return true;
        }
    }
}