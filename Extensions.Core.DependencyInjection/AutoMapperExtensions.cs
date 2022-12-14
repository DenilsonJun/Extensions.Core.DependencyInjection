using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Extensions.Core.DependencyInjection;

public static class AutoMapperExtensions
{
    public static IServiceCollection AddAutoMapper<T>(this IServiceCollection services) where T : Profile
        => services.AddAutoMapper(typeof(T).Assembly);

    public static IServiceCollection AddAutoMapper<T, T1>(this IServiceCollection services) where T : Profile where T1 : Profile
        => services.AddAutoMapper(typeof(T).Assembly, typeof(T1).Assembly);

    public static IServiceCollection AddAutoMapper<T, T1, T2>(this IServiceCollection services) where T : Profile where T1 : Profile where T2 : Profile
        => services.AddAutoMapper(typeof(T).Assembly, typeof(T1).Assembly, typeof(T2).Assembly);
}