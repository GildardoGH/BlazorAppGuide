using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppGuide.Shared.Dto
{
    public class ActorDto
    {
        public int Id { get; set; }
        public string Picture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int YearsActive { get; set; }
        public string BiographyFit
        {
            get
            {
                if (string.IsNullOrEmpty(Biography))
                {
                    return null;
                }
                if (Biography.Length > 47)
                {
                    return Biography.Substring(0, 47) + "...";
                }
                else
                {
                    return Biography;
                }
            }
        }
    }

    public class ActorDtoValidator : AbstractValidator<ActorDto>
    {
        public ActorDtoValidator()
        {
            RuleFor(a => a.FirstName)
                .NotEmpty()
                .MaximumLength(15)
                .WithName("First Name");

            RuleFor(a => a.LastName)
                .NotEmpty()
                .WithName("Last Name");

            RuleFor(a => a.Biography)
                .NotEmpty()
                .WithName("Biography");

            RuleFor(a => a.DateOfBirth)
                .NotEmpty()
                .WithName("Date of Birth");

            RuleFor(a => a.YearsActive)
                .NotEmpty()
                .WithName("Years Active");
        }
    }
}
