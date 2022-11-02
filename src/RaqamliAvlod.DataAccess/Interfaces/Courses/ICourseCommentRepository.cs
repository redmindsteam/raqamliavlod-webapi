using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Domain.Entities.Courses;

namespace RaqamliAvlod.DataAccess.Interfaces.Courses
{
    public interface ICourseCommentRepository
        : IRepository<CourseComment>
    {
        public Task<PagedList<CourseComment>> GetAllByCourseIdAsync(long courseId, PaginationParams @params);
    }
}
