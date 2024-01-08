using BookStore.Application.BookOperations.Queries;
using FluentValidation;

namespace BookStore.Application.Validators.BookValidators;

public class GetBookDetailQueryValidator : AbstractValidator<GetBookDetailQuery>
{
    public GetBookDetailQueryValidator()
    {
        RuleFor(command => command.BookId).GreaterThan(0);
    }
}