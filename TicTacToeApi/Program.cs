using TicTacToeApi;
using TicTacToeApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Automapper
builder.Services.AddAutoMapper(typeof(MapProfile).Assembly);

builder.Services.AddTransient<IGameService, GameService>();

builder.Services.AddCors(option =>
    option.AddDefaultPolicy(cfg => cfg.AllowAnyHeader()
                                      .AllowAnyMethod()
                                      .AllowAnyOrigin()));

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

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

