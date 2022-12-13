using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Extensions.Core.DependencyInjection;

public static class MediatRExtensions
{
    public static IServiceCollection AddMediatR<T>(this IServiceCollection services)
        => services.AddMediatR(typeof(T));
}