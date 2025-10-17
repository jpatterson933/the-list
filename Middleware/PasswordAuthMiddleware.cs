using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace LaAdventuresList.Middleware;

public class PasswordAuthMiddleware
{
    private readonly RequestDelegate _next;
    private readonly string _secretPassword;
    private const string SessionKey = "IsAuthenticated";

    public PasswordAuthMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        _next = next;
        _secretPassword = configuration["SECRET_PASSWORD"] ?? "default_password_change_me";
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Allow access to login page and static files
        var path = context.Request.Path.Value?.ToLower() ?? "";
        if (path == "/auth/login" || path.StartsWith("/css/") || path.StartsWith("/js/") || path.StartsWith("/images/"))
        {
            await _next(context);
            return;
        }

        // Check if already authenticated
        var isAuthenticated = context.Session.GetString(SessionKey);
        if (isAuthenticated == "true")
        {
            await _next(context);
            return;
        }

        // Handle login POST
        if (context.Request.Method == "POST" && path == "/auth/authenticate")
        {
            context.Request.EnableBuffering();
            var form = await context.Request.ReadFormAsync();
            var password = form["password"].ToString();

            if (password == _secretPassword)
            {
                context.Session.SetString(SessionKey, "true");
                context.Response.Redirect("/");
                return;
            }
            else
            {
                context.Response.Redirect("/auth/login?error=true");
                return;
            }
        }

        // Redirect to login if not authenticated
        context.Response.Redirect("/auth/login");
    }
}
