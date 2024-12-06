using Microsoft.EntityFrameworkCore;
using SchoolProjectWeb.Data;

var builder = WebApplication.CreateBuilder(args);

// Configura la cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registra el DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Agrega Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Configura el pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
