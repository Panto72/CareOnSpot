using CareOnSpot.DBConncetion;
using CareOnSpot.Services;
using CareOnSpot.Services.Base;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
{
    option.ExpireTimeSpan = TimeSpan.FromMinutes(60 * 1);
    option.LoginPath = "/Account/Login";
    option.AccessDeniedPath = "/Account/Login";
});
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromMinutes(5);
    option.Cookie.HttpOnly = true;
    option.Cookie.IsEssential = true;
});

builder.Services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
builder.Services.AddScoped<IHospitalService, HospitalService>();
builder.Services.AddScoped<IBloodTypeService, BloodTypeService>();
builder.Services.AddScoped<IBloodDonationService, BloodDonationService>();
builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IMedicalShopService, MedicalShopService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ISpecialitieService, SpecialitieService>();
builder.Services.AddScoped<IDoctorAppointmentService, DoctorAppointmentService>();
builder.Services.AddScoped<IMedicalTestService, MedicalTestService>();
builder.Services.AddScoped<IAmbulanceService, AmbulanceService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
