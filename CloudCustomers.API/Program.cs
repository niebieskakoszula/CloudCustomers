using CloudCustomers.API.Config;
using CloudCustomers.API.Services;
using CloudCustomers.API.Services.Interfaces;
using System.Diagnostics.CodeAnalysis;

public class Program
{
	[ExcludeFromCodeCoverage]
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.

		ConfigureServices(builder.Services);

		builder.Services.AddControllers();

		var app = builder.Build();

		// Configure the HTTP request pipeline.

		app.UseHttpsRedirection();

		app.UseAuthorization();


		app.MapControllers();

		app.Run();
	}

	[ExcludeFromCodeCoverage]
	static void ConfigureServices(IServiceCollection services)
	{
		services.AddTransient<IUsersService, UsersService>();
		services.AddHttpClient<IUsersService, UsersService>();
		services.Configure<UsersApiOptions>(
			builder.Configuration.GetSection("UsersApiConfiguration")
		);
	}
}