using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Validator.Films;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DtoLayer.ViewModel.FilmVM;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Addscoped


builder.Services.AddScoped<IFilmService,FilmManager>();
builder.Services.AddScoped<IFilmDal,EfFilmDal>();

builder.Services.AddScoped<ICategoryService,CategoryManager>();
builder.Services.AddScoped<ICategoryDal,EfCategoryDal>();



#endregion
#region validator

builder.Services.AddTransient<IValidator<CreateFilmVM>,CreateFilmValidator>();

#endregion


builder.Services.AddDbContext<Context>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



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
