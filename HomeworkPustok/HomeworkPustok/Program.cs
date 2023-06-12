using HomeworkPustok.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PustokDbContext>(opt=>opt.UseSqlServer("Server=LAPTOP-RJLDMUKC\\SQLEXPRESS;Database=Pustok;Trusted_Connection=True"));

var app = builder.Build();


app.UseStaticFiles();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
