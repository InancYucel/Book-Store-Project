using BookStore.BookOperations.DeleteBook;
using FluentValidation;

namespace BookStore.BookOperations.Validators;

public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
{
    public DeleteBookCommandValidator()
    {
        RuleFor(command => command.BookId).GreaterThan(0);
    }
}