using BookStore.Application.BookOperations.Commands;
using FluentValidation;

namespace BookStore.Application.Validators.BookValidators;

public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
{
    public DeleteBookCommandValidator()
    {
        RuleFor(command => command.BookId).GreaterThan(0);
    }
}