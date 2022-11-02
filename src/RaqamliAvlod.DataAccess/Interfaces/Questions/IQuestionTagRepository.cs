using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Domain.Entities.Questions;

namespace RaqamliAvlod.DataAccess.Interfaces.Questions
{
    public interface IQuestionTagRepository : IRepository<QuestionTag>
    {
        public Task<PagedList<QuestionTag>> GetAllTagsFromQuestionAsync(long questionId, PaginationParams @params);
    }
}