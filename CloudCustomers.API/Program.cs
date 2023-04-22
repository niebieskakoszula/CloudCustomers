using CloudCustomers.API.Config;
using CloudCustomers.API.Services;
using CloudCustomers.API.Services.Interfaces;

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

void ConfigureServices(IServiceCollection services)
{
	services.AddTransient<IUsersService, UsersService>();
	services.AddHttpClient<IUsersService, UsersService>();
	services.Configure<UsersApiOptions>(
		builder.Configuration.GetSection("UsersApiConfiguration")
	);
}