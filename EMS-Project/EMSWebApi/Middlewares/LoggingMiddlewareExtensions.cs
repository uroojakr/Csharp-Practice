using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EMSWebApi.Middlewares
{
    public static class LoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }
}
