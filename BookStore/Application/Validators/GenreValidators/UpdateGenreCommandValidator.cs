using BookStore.Application.GenreOperations.Commands;
using FluentValidation;

namespace BookStore.Application.Validators.GenreValidators;

public class UpdateGenreCommandValidator : AbstractValidator<UpdateGenreCommand>
{
    public UpdateGenreCommandValidator()
    {
        RuleFor(command => command.Model.Name).MinimumLength(4).When(x => x.Model.Name != string.Empty);
    }
}