using RaqamliAvlod.Application.Exceptions;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.Questions;
using RaqamliAvlod.Application.ViewModels.Users;
using RaqamliAvlod.DataAccess.Interfaces;
using RaqamliAvlod.Domain.Entities.Questions;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Questions;
using System.Net;

namespace RaqamliAvlod.Infrastructure.Service.Services.Questions;

public class QuestionService : IQuestionService
{
    private readonly IUnitOfWork _unitOfWork;

    public QuestionService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> CreateAsync(long userId, QuestionCreateDto dto)
    {
        var user = await _unitOfWork.Users.FindByIdAsync(userId);

        if (user is null)
        {
            throw new StatusCodeException(HttpStatusCode.BadRequest, "User Not Found!");
        }
        var question = (Question)dto;

        var result = await _unitOfWork.Questions.CreateAsync(question);

        return result is not null ? true : false;
    }

    public async Task<bool> DeleteAsync(long questionId)
    {
        var question = await _unitOfWork.Questions.FindByIdAsync(questionId);

        if (question is null)
        {
            throw new StatusCodeException(HttpStatusCode.BadRequest, "Question Not Found!");
        }

        var result = await _unitOfWork.Questions.DeleteAsync(questionId);

        return result is not null ? true : false;
    }

    public async Task<IEnumerable<QuestionViewModel>> GetAllAsync(PaginationParams @params)
    {
        var questions = await _unitOfWork.Questions.GetAllAsync(@params);

        var questionViewModels = new List<QuestionViewModel>();

        foreach (var question in questions)
        {
            var owner = (await _unitOfWork.Users.FindByIdAsync(question.OwnerId))!;
            var ownerViewModel = (OwnerViewModel)owner;

            var questionViewModel = (QuestionViewModel)question;
            questionViewModel.Owner = ownerViewModel;

            questionViewModels.Add(questionViewModel);
        }

        return questionViewModels;
    }

    public async Task<QuestionViewModel> GetAsync(long questionId)
    {
        var question = await _unitOfWork.Questions.FindByIdAsync(questionId);

        if (question is null)
        {
            throw new StatusCodeException(HttpStatusCode.BadRequest, "Question Not Found!");
        }

        var owner = await _unitOfWork.Users.FindByIdAsync(question.OwnerId);

        if (owner is null)
        {
            throw new StatusCodeException(HttpStatusCode.BadRequest, "Question Owner Not Found!");
        }

        var ownerViewModel = (OwnerViewModel)owner;

        var questionViewModel = (QuestionViewModel)question;

        questionViewModel.Owner = ownerViewModel;

        return questionViewModel;
    }

    public async Task<bool> UpdateAsync(long questionId, QuestionCreateDto dto)
    {
        var question = _unitOfWork.Questions.FindByIdAsync(questionId);

        if (question is null)
        {
            throw new StatusCodeException(HttpStatusCode.BadRequest, "Question Not Found!");
        }

        var editedQuestion = (Question)dto;
        editedQuestion.Id = question.Id;

        var result = await _unitOfWork.Questions.UpdateAsync(questionId, editedQuestion);

        return result is not null ? true : false;
    }
}
