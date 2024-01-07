using BookStore.BookOperations.GetBookDetail;
using FluentValidation;

namespace BookStore.BookOperations.Validators;

public class GetBookDetailQueryValidator : AbstractValidator<GetBookDetailQuery>
{
    public GetBookDetailQueryValidator()
    {
        RuleFor(command => command.BookId).GreaterThan(0);
    }
}