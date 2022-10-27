using Newtonsoft.Json;
using RaqamliAvlod.Application.Exceptions;
using RaqamliAvlod.Application.ViewModels.Common;

namespace RaqamliAvlod.Api.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _env;

        public ExceptionHandlerMiddleware(RequestDelegate next, IWebHostEnvironment env)
        {
            this._next = next;
            this._env = env;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (StatusCodeException exception)
            {
                await ClientErrorHandleAsync(httpContext, exception);
            }
            catch (Exception exception)
            {
                await SystemErrorHandleAsync(httpContext, exception);
            }
        }

        public async Task ClientErrorHandleAsync(HttpContext httpContext, StatusCodeException exception)
        {
            httpContext.Response.ContentType = "application/json";
            ErrorResponseViewModel result = new()
            {
                Message = exception.Message,
                StatusCode = (int)exception.HttpStatusCode
            };
            httpContext.Response.StatusCode = (int)exception.HttpStatusCode;
            await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(result));
        }

        public async Task SystemErrorHandleAsync(HttpContext httpContext, Exception exception)
        {
            httpContext.Response.ContentType = "application/json";
            ErrorResponseViewModel result = new();
            if (_env.IsProduction())
            {
                result.Message = exception.Message;
                result.StatusCode = 500;
            }
            else
            {
                result.Message = exception.ToString();
                result.StatusCode = 500;
            }
            httpContext.Response.StatusCode = 500;
            await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(result));
        }
    }
}
