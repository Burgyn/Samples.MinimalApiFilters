using FluentValidation;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddValidator<TDto, TValidator>(this IServiceCollection services)
        where TValidator : class, IValidator<TDto>
        => services.AddScoped<IValidator<TDto>, TValidator>();
}