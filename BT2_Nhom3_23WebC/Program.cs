using BT2_Nhom3_23WebC.Models;
using BT2_Nhom3_23WebC.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI for AddStaticAssets
//DI cau 2;
builder.Services.AddScoped<ProductService>();//co the dung AddSingleton

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();// For the wwwroot folder
app.UseRouting();
app.UseAuthorization();

// Đọc danh sách sản phẩm từ db.json qua Middleware
app.UseMiddleware<ProductDbMiddleware>(Path.Combine(app.Environment.ContentRootPath, "db.json"));

app.MapStaticAssets();



app.UseEndpoints(endpoints =>
{
    // Routing cho Area (Admin)
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    // Routing mặc định cho người dùng
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});



app.Run();
