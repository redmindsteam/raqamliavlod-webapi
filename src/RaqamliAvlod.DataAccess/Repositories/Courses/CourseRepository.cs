using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Courses;
using RaqamliAvlod.Domain.Entities.Courses;


namespace RaqamliAvlod.DataAccess.Repositories.Courses
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
