using TryMe.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
       .Services.ConfigureCookieAuthentication()
       .ConfigureSqliteContext(builder.Configuration)
       .ConfigureProblemDetails(builder.Environment)
       .AddServices()
       .AddAutoMapper(typeof(Program));

var app = builder.Build();

app.UseCors(x => x
    .WithOrigins("http://localhost:4200")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();
