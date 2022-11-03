using Microsoft.AspNetCore.Http;
using RaqamliAvlod.Attributes;
using RaqamliAvlod.Domain.Entities.Courses;
using System.ComponentModel.DataAnnotations;

namespace RaqamliAvlod.Infrastructure.Service.Dtos
{
    public class CourseCreateDto
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

        public static implicit operator Course(CourseCreateDto courseCreateDto)
        {
            return new Course()
            {
                Title = courseCreateDto.Title,
                Info = courseCreateDto.Info,
                Type = courseCreateDto.Type,
                ImagePath = courseCreateDto.Image.ToString()!,
                Price = courseCreateDto.Price,
                OwnerId = courseCreateDto.OwnerId
            };
        }
    }
}
