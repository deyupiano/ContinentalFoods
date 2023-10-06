﻿using ContinentalFoods.Domain.Aggregates.PostAggregate;
using FluentValidation;

namespace ContinentalFoods.Domain.Validators.PostValidators;

public class PostValidator : AbstractValidator<Post>
{
    public PostValidator()
    {
        RuleFor(p => p.TextContent)
            .NotNull().WithMessage("Post text content can't be null")
            .NotEmpty().WithMessage("Post text content can't be empty");
    }
}