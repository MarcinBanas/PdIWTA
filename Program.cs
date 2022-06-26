using FluentValidation.AspNetCore;
using PdiwtA;
using PdiwtA.DTO.Validators;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IProductsRepository, ProductsInMemoryRepository>();
builder.Services.AddSingleton<IUserRepository, UsersInMemoryRepository>();

builder.Services.AddControllers();
builder.Services.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<AddProductDTOValidator>());
builder.Services.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<UpdateDTOValidator>());
builder.Services.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<TestUserDTOValidator>());

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
