using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Questions;
using RaqamliAvlod.Domain.Entities.Questions;

namespace RaqamliAvlod.DataAccess.Repositories.Questions
{
    public class QuestionAnswerRepository : BaseRepository<QuestionAnswer>, IQuestionAnswerRepository
    {
        public QuestionAnswerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<PagedList<QuestionAnswer>> GetAllByCourseIdAsync(long questionId, PaginationParams @params)
        {
            var questionAnswers = _dbSet.Where(answers => answers.QuestionId == questionId);

            return await PagedList<QuestionAnswer>.ToPagedListAsync(questionAnswers, @params.PageNumber, @params.PageSize);
        }
    }
}
