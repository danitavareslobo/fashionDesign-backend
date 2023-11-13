using AutoMapper;
using System.Reflection;

namespace fashionDesign.Mapper
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            var profiles = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.BaseType == typeof(Profile))
                .ToArray();

            services.AddAutoMapper(profiles);
        }
    }
}
