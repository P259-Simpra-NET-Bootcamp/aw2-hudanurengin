using SimpraHafta2Odev.Infrastructure.Filters;
using SimpraHafta2Odev.Persistence;
using FluentValidation.AspNetCore;
using SimpraHafta2Odev.Application.Validators.Staffs;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddPersistenceServices();
builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<Create_Staff_Validator>())
    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<Update_Staff_Validator>())
    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
