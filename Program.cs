using SportsRec.Club.Interfaces;
using SportsRec.Club.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios para controladores y vistas (MVC)
builder.Services.AddControllersWithViews();

// Registrar la inyección de dependencias
builder.Services.AddScoped<ICourtManager, CourtManager>();

var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();