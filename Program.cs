using AirportAPI.DAL;
using AirportAPI.Entities;
using AirportAPI.Mappers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApiContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));
builder.WebHost.UseSentry(o =>
{
    o.Dsn = "https://d639dfb4b7c847a4b4647c214db16291@o4504912081518592.ingest.sentry.io/4504912083615744";
    o.Debug = true;
    o.TracesSampleRate = 1.0;
});
builder.Services.AddAutoMapper(typeof(MapperProfiles));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSentryTracing();

app.MapControllers();

app.Run();
