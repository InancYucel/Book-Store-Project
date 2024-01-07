using BookStore.BookOperations.UpdateBook;
using FluentValidation;

namespace BookStore.BookOperations.Validators;

public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
{
    public UpdateBookCommandValidator() 
    {
        RuleFor(command => command.BookId).GreaterThan(0);
        RuleFor(command => command.Model.GenreID).GreaterThan(0);
        RuleFor(command => command.Model.Title).MinimumLength(4);
    }
}