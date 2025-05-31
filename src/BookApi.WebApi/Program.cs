using System.Text.Json.Serialization;
using BookApi.Application;
using BookApi.Application.Interfaces;
using BookApi.EntityFrameworkCore.Data;
using BookApi.EntityFrameworkCore.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// setting up db
builder.Services.AddDbContext<CategoryContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// adding services
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddAutoMapper(typeof(MapperProfile));

// making null values in json response to not appear 
builder.Services.AddControllers().AddJsonOptions((options) => {
    options.JsonSerializerOptions.WriteIndented = true;
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// TODO: stop doing this. for demo purposes we are doing a migration and data seeding on startup
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<CategoryContext>();
    db.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
