using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
namespace RaqamliAvlod.Attributes
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file is not null)
            {
                if ((file.Length / 1024) > _maxFileSize)
                    return new ValidationResult($"File must be less than {_maxFileSize} kB");
            }

            return ValidationResult.Success;
        }
    }
}
