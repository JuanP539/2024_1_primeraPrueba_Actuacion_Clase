using DogApi.Filters;
using ServiceFactory;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(option =>
{
    //TODO Filters.Add
    option.Filters.Add<CustomExceptionFilter>();
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//TODO AddServices
DogServiceFactory.AddServices(builder.Services);


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
