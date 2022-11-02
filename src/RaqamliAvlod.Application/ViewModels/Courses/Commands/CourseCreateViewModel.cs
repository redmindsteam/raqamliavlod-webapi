using Microsoft.AspNetCore.Http;
using RaqamliAvlod.Application.Attributes;
using RaqamliAvlod.Domain.Entities.Courses;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Application.ViewModels.Courses.Commands
{
    public class CourseCreateViewModel
    {
        [Required, MinLength(5)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Info { get; set; } = string.Empty;

        [Required]
        public string Type { get; set; } = string.Empty;

        [AllowedFiles(new string[] { ".jpg", ".png", ".jpeg" })]
        public IFormFile Image { get; set; }

        public float Price { get; set; }

        [Required]
        public long OwnerId { get; set; }

        public static implicit operator Course(CourseCreateViewModel courseCreateViewModel)
        {
            return new Course()
            {
                Title = courseCreateViewModel.Title,
                Info = courseCreateViewModel.Info,
                Type = courseCreateViewModel.Type,
                ImagePath = courseCreateViewModel.Image.ToString()!,
                Price = courseCreateViewModel.Price,
                OwnerId = courseCreateViewModel.OwnerId
            };
        }
    }
}
