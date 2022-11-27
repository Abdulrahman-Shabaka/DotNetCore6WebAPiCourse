
using Microsoft.EntityFrameworkCore;
using Shcool;
using Shcool.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SchoolDbContext>(option => option.UseSqlServer(
    builder.Configuration.GetConnectionString("defaultConnectionstring")));

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


//School

//school has many students
//each student has his own laptop
//each student takes some subjects
//each subjects taken by many students

//class school
//class student
//class laptop
//class subjects

//one to many school - students
//one to one  student - laptop
//many to many sudent - subjects


