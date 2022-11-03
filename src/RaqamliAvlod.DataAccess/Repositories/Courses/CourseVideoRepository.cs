using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Courses;
using RaqamliAvlod.Domain.Entities.Courses;

namespace RaqamliAvlod.DataAccess.Repositories.Courses
{
    public class CourseVideoRepository : BaseRepository<CourseVideo>, ICourseVideoRepository
    {
        public CourseVideoRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<PagedList<CourseVideo>> GetAllByCourseIdAsync(long courseId, PaginationParams @params)
        {
            var courseVideos = _dbSet.Where(video => video.CourseId == courseId);
            return await PagedList<CourseVideo>.ToPagedListAsync(courseVideos, @params.PageNumber, @params.PageSize);
        }
    }
}
