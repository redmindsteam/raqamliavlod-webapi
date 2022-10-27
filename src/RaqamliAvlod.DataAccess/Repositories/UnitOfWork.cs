using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces;
using RaqamliAvlod.DataAccess.Interfaces.Contests;
using RaqamliAvlod.DataAccess.Interfaces.Courses;
using RaqamliAvlod.DataAccess.Interfaces.ProblemSets;
using RaqamliAvlod.DataAccess.Interfaces.Questions;
using RaqamliAvlod.DataAccess.Interfaces.Submissions;
using RaqamliAvlod.DataAccess.Interfaces.Users;

namespace RaqamliAvlod.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IContestRepository Contests { get; }
        public IContestStandingsRepository ContestStandings { get; }
        public ICourseCommentRepository CourseComments { get; }
        public ICourseRepository Courses { get; }
        public IProblemSetRepository ProblemSets { get; }
        public IProblemSetTestRepository ProblemSetTests { get; }
        public IQuestionAnswerRepository QuestionAnswers { get; }
        public IQuestionRepository Questions { get; }
        public ISubmissionRepository Submissions { get; }
        public IUserRepository Users { get; }
        public AppDbContext dbContext { get; }

        public UnitOfWork(IContestRepository contests, IContestStandingsRepository contestStandings, 
            ICourseCommentRepository courseComments, ICourseRepository courses, IProblemSetRepository problemSets, 
            IProblemSetTestRepository problemSetTests, IQuestionAnswerRepository questionAnswers, 
            IQuestionRepository questions, ISubmissionRepository submissions, IUserRepository users,
            AppDbContext dbContext)
        {
            Contests = contests;
            ContestStandings = contestStandings;
            CourseComments = courseComments;
            Courses = courses;
            ProblemSets = problemSets;
            ProblemSetTests = problemSetTests;
            QuestionAnswers = questionAnswers;
            Questions = questions;
            Submissions = submissions;
            Users = users;
            this.dbContext = dbContext;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}