﻿using FluentValidation;

namespace WebApplication1.Validators;

public static class Validators
{
    public static void RegisterValidators(this IServiceCollection services)
    {
        //services.AddValidatorsFromAssemblyContaining();
        //services.AddValidatorsFromAssemblyContaining<AnimalReplaceRequestValidator>();
    }
}