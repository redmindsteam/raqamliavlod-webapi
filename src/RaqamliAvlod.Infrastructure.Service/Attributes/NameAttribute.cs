using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RaqamliAvlod.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NameAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null) return new ValidationResult("Name cannot be null!");
            else
            {
                string name = value.ToString()!;

                Regex regex = new Regex(@"^(?=.{1,40}$)[a-zA-Z]+(?:[-'\s][a-zA-Z]+)*$");

                if (regex.Match(name).Success)
                    return ValidationResult.Success;

                return new ValidationResult("Please enter valid name. Name must be contains only letters or ' character");
            }
        }
    }
}
