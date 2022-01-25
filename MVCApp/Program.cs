using Microsoft.EntityFrameworkCore;
using MVCApp.Context;
using MVCApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MVCContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EFConnection"));
});

builder.Services.AddScoped<ISubjectServices, SubjectServices>();
builder.Services.AddScoped<IMailService, MailService2>();
builder.Services.AddScoped<ITeacherServices, TeacherServices>();
builder.Services.AddScoped<IStudentServices, StudentServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
