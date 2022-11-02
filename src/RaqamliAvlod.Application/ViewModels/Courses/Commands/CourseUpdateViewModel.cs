using Microsoft.AspNetCore.Http;
using RaqamliAvlod.Application.Attributes;
using RaqamliAvlod.Domain.Entities.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Application.ViewModels.Courses.Commands
{
    public class CourseUpdateViewModel
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

        public static implicit operator Course(CourseUpdateViewModel course)
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
