using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Validator.Category;
using BusinessLayer.Validator.Director;
using BusinessLayer.Validator.Films;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DtoLayer.ViewModel.CategoryVM;
using DtoLayer.ViewModel.Director;
using DtoLayer.ViewModel.FilmVM;
using FluentValidation;
using FluentValidation.AspNetCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddFluentValidation();

// Add services to the container.
builder.Services.AddMvc();

#region Addscoped


builder.Services.AddScoped<IFilmService,FilmManager>();
builder.Services.AddScoped<IFilmDal,EfFilmDal>();

builder.Services.AddScoped<ICategoryService,CategoryManager>();
builder.Services.AddScoped<ICategoryDal,EfCategoryDal>();

builder.Services.AddScoped<IDirectorService,DirectorManager>();
builder.Services.AddScoped<IDirectorDal,EfDirectorDal>();

#endregion



#region validator

builder.Services.AddTransient<IValidator<CreateFilmVM>,CreateFilmValidator>();
builder.Services.AddTransient<IValidator<UpdateFilmVM>,UpdateFilmValidator>();

builder.Services.AddTransient<IValidator<CreateDirectorVM>, CreateDirectorValidator>();
builder.Services.AddTransient<IValidator<UpdateDirectorVM>, UpdateDirectorValidator>();


builder.Services.AddTransient<IValidator<CreateCategoryVM>,CreateCategoryValidator>();
builder.Services.AddTransient<IValidator<UpdateCategoryVM>,UpdateCategoryValidator>();
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
