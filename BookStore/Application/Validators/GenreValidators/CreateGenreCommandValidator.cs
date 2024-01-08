using BookStore.Application.GenreOperations.Commands;
using FluentValidation;

namespace BookStore.Application.Validators.GenreValidators;

public class CreateGenreCommandValidator : AbstractValidator<CreateGenreCommand>
{
    public CreateGenreCommandValidator()
    {
        RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(4);
    }
}