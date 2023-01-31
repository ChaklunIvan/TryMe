using TryMe.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
       .Services.AddAuthentication("CookieAuthentication")
       .AddCookie("CookieAuthentication", options =>
       {
           options.Cookie.Name = "CookieAuthentication";
       })
       .Services.ConfigureSqliteContext(builder.Configuration);

var app = builder.Build();

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();
