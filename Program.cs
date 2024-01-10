using MC_FiveToSeven___Endpoints.Services.MadLib;
using MC_FiveToSeven___Endpoints.Services.OddOrEven;
using MC_FiveToSeven___Endpoints.Services.ReverseItAlpha;
using MC_FiveToSeven___Endpoints.Services.ReverseItNums;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseItAlphaService, ReverseItAlphaService>();
builder.Services.AddScoped<IReverseItNumsService, ReverseItNumsService>();


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
