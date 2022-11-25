using RaqamliAvlod.DataAccess.Interfaces.Contests;
using RaqamliAvlod.DataAccess.Interfaces.Courses;
using RaqamliAvlod.DataAccess.Interfaces.ProblemSets;
using RaqamliAvlod.DataAccess.Interfaces.Questions;
using RaqamliAvlod.DataAccess.Interfaces.Submissions;
using RaqamliAvlod.DataAccess.Interfaces.Users;

namespace RaqamliAvlod.DataAccess.Interfaces
{
    public interface IUnitOfWork
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
    }
}