using Application.Configurations;
using Infrastructure.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// --------------------------------------------------------
// I prefer that every part of solution manage your ow IoC
// --------------------------------------------------------
builder.Services.AddInfrastructure();
builder.Services.AddApplication();
// --------------------------------------------------------
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
// }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
