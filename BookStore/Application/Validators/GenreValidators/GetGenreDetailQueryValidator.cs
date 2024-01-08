using BookStore.Application.GenreOperations.Queries;
using FluentValidation;

namespace BookStore.Application.Validators.GenreValidators;

public class GetGenreDetailQueryValidator : AbstractValidator<GetGenreDetailQuery>
{
    public GetGenreDetailQueryValidator()
    {
        RuleFor(query => query.GenreId).GreaterThan(0);
    }
}