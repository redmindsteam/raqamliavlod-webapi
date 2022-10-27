using CodePower.DataAccess.Common.Interfaces;
using RaqamliAvlod.DataAccess.Common.Interfaces;
using RaqamliAvlod.Domain.Entities.Courses;

namespace RaqamliAvlod.DataAccess.Interfaces.Courses
{
    public interface ICourseCommentRepository 
        : ICreateable<CourseComment>, IUpdateable<CourseComment>, IDeleteable<CourseComment>, IFindable<CourseComment>
    {

    }
}
