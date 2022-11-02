using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Domain.Entities.Courses;

namespace RaqamliAvlod.DataAccess.Interfaces.Courses
{
    public interface ICourseVideoRepository : IRepository<CourseVideo>
    {
        public Task<PagedList<CourseVideo>> GetAllByCourseIdAsync(long courseId, PaginationParams @params);
    }
}