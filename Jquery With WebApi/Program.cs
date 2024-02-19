using Jquery_With_WebApi.Models;
using Jquery_With_WebApi.Repositiories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(
     opt => {
         opt.AddDefaultPolicy(p => {
             p.AllowAnyHeader();
             p.AllowAnyMethod();
             p.AllowAnyOrigin();
         });
     }
    );
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<CompanyContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("scon"))
    );
builder.Services.AddScoped<ICourse, CourseRepo>();
var app = builder.Build();
app.UseCors();

app.MapControllers();


app.Run();
