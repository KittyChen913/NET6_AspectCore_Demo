using AspectCore.Extensions.DependencyInjection;
using AspectCore_Scrutor_DemoProject.Services;
using NET6_AspectCore_Demo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IWeatherService, WeatherService>();
builder.Services.AddScoped<CustomInterceptorAttribute>();
builder.Services.ConfigureDynamicProxy();
//Replace the default IOC container with the AspectCore one.
builder.Host.UseServiceProviderFactory(new DynamicProxyServiceProviderFactory());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
