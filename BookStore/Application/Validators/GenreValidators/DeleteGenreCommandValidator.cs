using BookStore.Application.GenreOperations.Commands;
using FluentValidation;

namespace BookStore.Application.Validators.GenreValidators;

public class DeleteGenreCommandValidator : AbstractValidator<DeleteGenreCommand>
{
    public DeleteGenreCommandValidator()
    {
        RuleFor(command => command.GenreId).GreaterThan(0);
    }
}