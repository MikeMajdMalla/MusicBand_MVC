using APIcountry.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. 

//SQL-server 
//builder.Services.AddDbContext<CarContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//SQLite 
builder.Services.AddEntityFrameworkSqlite().AddDbContext<CountryContext>();

//Finns redan 
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

app.UseAuthorization();

app.MapControllers();

app.Run();