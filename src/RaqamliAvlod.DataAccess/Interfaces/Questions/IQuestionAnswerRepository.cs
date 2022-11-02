using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Domain.Entities.Questions;

namespace RaqamliAvlod.DataAccess.Interfaces.Questions
{
    public interface IQuestionAnswerRepository : IRepository<QuestionAnswer>
    {
        public Task<PagedList<QuestionAnswer>> GetAllByCourseIdAsync(long questionId, PaginationParams @params);
    }
}
