using Array.Application;
using Array.Application.Contract;

namespace Array.webapi{
	public static class CustomServices{
		public static IServiceCollection AddCustomServices(this IServiceCollection services){

			services.AddScoped<IApplication, MyApplication>();
			services.AddScoped<ISolution, Solution>();

			return services;
		}
	}
}
