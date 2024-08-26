using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using MiniMoviesApp.Data.Db;
using MiniMoviesApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, option =>
    {
        option.LogoutPath = "/Account/Login";
        option.AccessDeniedPath = "/Denied";
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("GraduatedOnly", policy => policy.RequireClaim("GraduationYear", "2010", "2012", "2015"));
});

// Add Db Context
builder.Services.AddDbContext<MovieContext>(option =>
{
    option.UseInMemoryDatabase("Movie");
});

builder.Services.AddScoped<IServiceMovie, MovieService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();


app.Run();
