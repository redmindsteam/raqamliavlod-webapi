using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces;
using RaqamliAvlod.DataAccess.Interfaces.Contests;
using RaqamliAvlod.DataAccess.Interfaces.Courses;
using RaqamliAvlod.DataAccess.Interfaces.ProblemSets;
using RaqamliAvlod.DataAccess.Interfaces.Questions;
using RaqamliAvlod.DataAccess.Interfaces.Submissions;
using RaqamliAvlod.DataAccess.Interfaces.Users;
using RaqamliAvlod.DataAccess.Repositories.Contests;
using RaqamliAvlod.DataAccess.Repositories.Courses;
using RaqamliAvlod.DataAccess.Repositories.ProblemSets;
using RaqamliAvlod.DataAccess.Repositories.Questions;
using RaqamliAvlod.DataAccess.Repositories.Submissions;
using RaqamliAvlod.DataAccess.Repositories.Users;

namespace RaqamliAvlod.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        public IContestRepository Contests { get; }
        public IContestStandingsRepository ContestStandings { get; }
        public IContestSubmissionInfoRepository ContestSubmissionInfo { get; }
        public ICourseCommentRepository CourseComments { get; }
        public ICourseRepository Courses { get; }
        public ICourseVideoRepository CourseVideos { get; }
        public IProblemSetRepository ProblemSets { get; }
        public IProblemSetTestRepository ProblemSetTests { get; }
        public IQuestionAnswerRepository QuestionAnswers { get; }
        public IQuestionRepository Questions { get; }
        public IQuestionTagRepository QuestionTags { get; }
        public ITagRepository Tags { get; }
        public ISubmissionRepository Submissions { get; }
        public IUserRepository Users { get; }

        public UnitOfWork(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            Contests = new ContestRepository(_dbContext);
            ContestStandings = new ContestStandingsRepository(_dbContext);
            ContestSubmissionInfo = new ContestSubmissionInfoRepository(_dbContext);
            Courses = new CourseRepository(_dbContext);
            CourseComments = new CourseCommentRepository(_dbContext);
            CourseVideos = new CourseVideoRepository(_dbContext);
            ProblemSets = new ProblemSetRepository(_dbContext);
            ProblemSetTests = new ProblemSetTestRepository(_dbContext);
            QuestionAnswers = new QuestionAnswerRepository(_dbContext);
            Questions = new QuestionRepository(_dbContext);
            QuestionTags = new QuestionTagRepository(_dbContext);
            Tags = new TagRepository(_dbContext);
            Submissions = new SubmissionRepository(_dbContext);
            Users = new UserRepository(_dbContext);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}