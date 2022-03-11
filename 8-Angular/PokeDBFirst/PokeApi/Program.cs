using Microsoft.EntityFrameworkCore;
using PokeBL;
using PokeDL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMemoryCache();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DbContext class that we just made since we depend on DbContext class
//options.UseSQlServer() will create DbContextOptions class that holds our connection string information (as well as other options correlating with SQLServer)
// builder.Services.AddDbContext<PokeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Reference2DB")));

// builder.Services.AddScoped<IRepository, DbContextRespository>();
builder.Services.AddScoped<IPokemonBL, PokemonBL>();

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
