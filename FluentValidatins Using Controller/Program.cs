using System.Text.Json.Serialization;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidatins_Using_Controller.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
//for fluent validation

builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddValidatorsFromAssemblyContaining<CreateProductRequestValidator>();

var app = builder.Build();

app.MapControllers();

app.Run();
