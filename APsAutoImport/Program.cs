using APsAutoImport.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICatergoryRepository, CatergoryRepository>();
builder.Services.AddScoped<ICarRepository, CarRepository>();

builder.Services.AddDbContext<APsAutoImportDbContext>(options =>
{
   options.UseSqlServer(
        builder.Configuration["ConnectionStrings:APsAutoImportDbContextConnection"]);

});

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home})/{ action = Index}/{id?}");
//if (app.Environment.IsDevelopment())
//{
//    app.UseDeveloperExceptionPage();
//}

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home})/{ action = Index}/{id?}");

DbInitializer.Seed(app);
app.Run();
