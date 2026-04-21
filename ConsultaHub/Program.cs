var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthentication();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    
}

app.UseHttpsRedirection();


app.MapControllers();


app.UseAuthorization();

app.MapStaticAssets();



app.Run();
