using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Questions;
using RaqamliAvlod.Domain.Entities.Questions;


namespace RaqamliAvlod.DataAccess.Repositories.Questions
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
