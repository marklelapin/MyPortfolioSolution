using Microsoft.AspNetCore.Mvc.Razor;
using MyClassLibrary.Email;
using MyClassLibrary.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.PageViewLocationFormats.Add("/Pages/Projects/{0}" + RazorViewEngine.ViewExtension);
    options.PageViewLocationFormats.Add("/Pages/Sections/{0}" + RazorViewEngine.ViewExtension);
});

builder.Services.AddTransient<IEmailClient, HotmailClient>();

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
