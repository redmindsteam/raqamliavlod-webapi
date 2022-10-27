using Microsoft.EntityFrameworkCore;
using RaqamliAvlod.DataAccess.Configurations;
using RaqamliAvlod.Domain.Entities.Contests;
using RaqamliAvlod.Domain.Entities.Courses;
using RaqamliAvlod.Domain.Entities.ProblemSets;
using RaqamliAvlod.Domain.Entities.Questions;
using RaqamliAvlod.Domain.Entities.Submissions;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.DataAccess.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Contest> Contests { get; set; } = null!;
        public virtual DbSet<ContestStandings> ContestStandings { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<CourseComment> CourseComments { get; set; } = null!;
        public virtual DbSet<CourseVideo> CourseVideos { get; set; } = null!;
        public virtual DbSet<ProblemSet> ProblemSets { get; set; } = null!;
        public virtual DbSet<ProblemSetTest> ProblemSetTests { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; } = null!;
        public virtual DbSet<Submission> Submissions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
