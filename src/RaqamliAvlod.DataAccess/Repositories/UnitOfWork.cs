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
        public IContestRepository Contests { get; }
        public IContestStandingsRepository ContestStandings { get; }
        public IContestStandingDetailRepository ContestStandingDetails { get; }
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
            Contests = new ContestRepository(appDbContext);
            ContestStandings = new ContestStandingsRepository(appDbContext);
            ContestStandingDetails = new ContestStandingDetailRepository(appDbContext);
            Courses = new CourseRepository(appDbContext);
            CourseComments = new CourseCommentRepository(appDbContext);
            CourseVideos = new CourseVideoRepository(appDbContext);
            ProblemSets = new ProblemSetRepository(appDbContext);
            ProblemSetTests = new ProblemSetTestRepository(appDbContext);
            QuestionAnswers = new QuestionAnswerRepository(appDbContext);
            Questions = new QuestionRepository(appDbContext);
            QuestionTags = new QuestionTagRepository(appDbContext);
            Tags = new TagRepository(appDbContext);
            Submissions = new SubmissionRepository(appDbContext);
            Users = new UserRepository(appDbContext);
        }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}