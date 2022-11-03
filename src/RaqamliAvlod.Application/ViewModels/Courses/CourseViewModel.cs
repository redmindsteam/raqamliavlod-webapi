using RaqamliAvlod.Domain.Entities.Courses;

namespace RaqamliAvlod.Application.ViewModels.Courses
{
    public class CourseViewModel
    {
        public string Title { get; set; } = string.Empty;
        public string Info { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public float Price { get; set; }

        public string OwnerName { get; set; } = string.Empty;

        public static implicit operator CourseViewModel(Course course)
        {
            return new CourseViewModel()
            {
                Title = course.Title,
                Info = course.Info,
                Type = course.Type,
                ImagePath = course.ImagePath,
                Price = course.Price,
            };
        }
    }
}
