using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Questions;
using RaqamliAvlod.Domain.Entities.Questions;

namespace RaqamliAvlod.DataAccess.Repositories.Questions
{
    public class QuestionTagRepository : BaseRepository<QuestionTag>, IQuestionTagRepository
    {
        public QuestionTagRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<PagedList<QuestionTag>> GetAllTagsFromQuestionAsync(long questionId, PaginationParams @params)
        {
            var questionTags = _dbSet.Where(tag => tag.QuestionId == questionId);

            return await PagedList<QuestionTag>.ToPagedListAsync(questionTags, @params.PageNumber, @params.PageSize);
        }
    }
}
