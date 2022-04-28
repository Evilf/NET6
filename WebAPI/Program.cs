using Playground.BaseClasses;
using Playground.StaticClasses;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("/person", () => GetRandomPerson());

app.MapGet("/people", (int count) => GetPeople(count));


Person GetRandomPerson() =>
    RandomPersonGenerator.GetRandomPerson();

List<Person> GetPeople(int count) =>
    RandomPersonGenerator.GetPeople(count);

app.Run();