using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppGuide.Shared.Dto
{
    public class GenreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GenreDtoValidator : AbstractValidator<GenreDto>
    {
        public GenreDtoValidator()
        {
            RuleFor(g => g.Name)
                .NotEmpty()
                .MaximumLength(15)
                .WithName("Genre");
        }
    }
}
