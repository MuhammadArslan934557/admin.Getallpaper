using Infrastructure.Implementation;
using Infrastructure.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllHeaders",
          builder =>
          {
              builder.WithOrigins("*")
                     .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
          });
});
/////////////Adding middle ware for custom service ////////////// 
builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddTransient<ILeedService, LeedService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IRevisionsService, RevisionsService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseCors();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=login}/{id?}");

app.Run();
