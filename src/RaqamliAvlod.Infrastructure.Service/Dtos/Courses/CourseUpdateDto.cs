using Microsoft.AspNetCore.Http;
using RaqamliAvlod.Attributes;
using RaqamliAvlod.Domain.Entities.Courses;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class CourseUpdateDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Info { get; set; } = string.Empty;
        [Required]
        public string Type { get; set; } = string.Empty;
        [Required]
        [AllowedFiles(new string[] { ".jpg", ".png", ".jpeg" })]
        public IFormFile Image { get; set; }
        public float Price { get; set; }

        [Required]
        public long OwnerId { get; set; }

        public static implicit operator Course(CourseUpdateDto course)
        {
            return new Course()
            {
                Title = course.Title,
                Info = course.Info,
                Type = course.Type,
                ImagePath = course.Image.ToString()!,
                Price = course.Price,
                OwnerId = course.OwnerId
            };
        }
    }
}
