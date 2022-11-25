using Microsoft.EntityFrameworkCore;
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
        public virtual DbSet<ContestStanding> ContestStandings { get; set; } = null!;
        public virtual DbSet<ContestStandingDetail> ContestSubmissionsInfos { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<CourseComment> CourseComments { get; set; } = null!;
        public virtual DbSet<CourseVideo> CourseVideos { get; set; } = null!;
        public virtual DbSet<ProblemSet> ProblemSets { get; set; } = null!;
        public virtual DbSet<ProblemSetTest> ProblemSetTests { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; } = null!;
        public virtual DbSet<QuestionTag> QuestionTags { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;
        public virtual DbSet<Submission> Submissions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            #region Contests
            modelBuilder.Entity<Contest>().HasIndex(x => x.Title).IsUnique();
            modelBuilder.Entity<ContestStanding>().HasIndex(entity =>
                new { entity.UserId, entity.ContestId }
            ).IsUnique();
            modelBuilder.Entity<ContestStandingDetail>()
                .HasIndex(entity => new { entity.ProblemSetId, entity.ContestStandingId }
            ).IsUnique();
            #endregion

            #region Courses
            modelBuilder.Entity<CourseVideo>().HasIndex(entity =>
                new
                {
                    entity.CourseId,
                    entity.YouTubeLink
                }).IsUnique();
            #endregion

            #region ProblemSets
            modelBuilder.Entity<ProblemSet>().HasIndex(entity => entity.Name).IsUnique();
            modelBuilder.Entity<ProblemSet>().HasIndex(entity => new
            {
                entity.ContestIdentifier,
                entity.ContestId
            }).IsUnique();

            #endregion

            #region Questions
            modelBuilder.Entity<QuestionTag>().HasIndex(entity => new
            {
                entity.TagId,
                entity.QuestionId
            }).IsUnique();
            #endregion

            #region Tags
            modelBuilder.Entity<Tag>().HasIndex(x => x.TagName).IsUnique();
            #endregion

            #region Users
            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<User>().HasIndex(x => x.PhoneNumber).IsUnique();
            modelBuilder.Entity<User>().HasIndex(x => x.Username).IsUnique();
            #endregion
        }
    }
}
