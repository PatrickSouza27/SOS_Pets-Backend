using Microsoft.EntityFrameworkCore;
using SOSPets.Infra.Data.SQLite;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<SQLiteContext>(optionsBuilde => optionsBuilde.UseSqlite("DataSource=app; Cache=Shared"));
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
