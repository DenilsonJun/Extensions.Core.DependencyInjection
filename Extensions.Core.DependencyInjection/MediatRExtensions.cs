using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Extensions.Core.DependencyInjection;

public static class MediatRExtensions
{
    public static IServiceCollection AddMediatR<T>(this IServiceCollection services)
        => services.AddMediatR(typeof(T));

    public static IServiceCollection AddMediatR<T, T1>(this IServiceCollection services)
        => services.AddMediatR(typeof(T), typeof(T1));

    public static IServiceCollection AddMediatR<T, T1, T2>(this IServiceCollection services)
        => services.AddMediatR(typeof(T), typeof(T1), typeof(T2));
}