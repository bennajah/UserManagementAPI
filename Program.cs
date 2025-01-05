var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseMiddleware<UserManagementAPI.Middleware.ErrorHandlingMiddleware>();
app.UseMiddleware<UserManagementAPI.Middleware.AuthenticationMiddleware>();
app.UseMiddleware<UserManagementAPI.Middleware.RequestLoggingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();