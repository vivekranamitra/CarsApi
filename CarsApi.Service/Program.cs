using CarsApi.Data.Contexts;
using CarsApi.Domain.Repositories;
using CarsApi.Service.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.RegisterRepos();
builder.Services.AddDbContext<CarContext>(options =>
{
    var cnstring = builder.Configuration.GetConnectionString("CarsDb");
    options.UseSqlServer(cnstring);
});

var app = builder.Build();

//run migration
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<CarContext>();
    dbContext.Database.Migrate();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
