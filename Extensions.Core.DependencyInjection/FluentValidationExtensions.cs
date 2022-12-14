using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Extensions.Core.DependencyInjection;

public static class FluentValidationExtensions
{
    public static IServiceCollection AddFluentValidation(this IServiceCollection services, params Assembly[] assemblies)

        => services.AddValidatorsFromAssemblies(assemblies);

    public static IServiceCollection AddFluentValidation<T>(this IServiceCollection services)
        => services.AddFluentValidation(typeof(T).Assembly);

    public static IServiceCollection AddFluentValidation<T, T1>(this IServiceCollection service)
        => service.AddFluentValidation(typeof(T).Assembly, typeof(T1).Assembly);

    public static IServiceCollection AddFluentValidation<T, T1, T2>(this IServiceCollection service)
        => service.AddFluentValidation(typeof(T).Assembly, typeof(T1).Assembly, typeof(T2).Assembly);
}
