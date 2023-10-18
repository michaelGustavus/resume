using GC.RESUME.CORE.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ResumeContext>(options => options
 .UseSqlServer(builder.Configuration.GetConnectionString("dbConnectionString"), sqlServerOptions =>
 sqlServerOptions
 .CommandTimeout(300)
 .EnableRetryOnFailure()
 ));

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
   
//}

app.UseSwagger();
app.UseSwaggerUI();
app.UseDeveloperExceptionPage();

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
