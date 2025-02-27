namespace CSharpConcepts_Sol.MiddleWare
{
    //Middleware acts on response and requests and need to be specified in the order we need to apply them.
    //Here this is specified in the program.cs. It basically has a single responsibility and each middleware 
    //acts on the response of the previous middleware's output.
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //invoke method are by default present in the middleware and returns a task using
        //await _next(context) where context is the HttpContext
        public async Task Invoke(HttpContext context)
        {
            // Storing data in HttpContext.Items
            context.Items["CustomData"] = "Data from FirstMiddleware";
            await _next(context);
        }
    }

    public class CustomMiddleware2
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware2(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Retrieving data from HttpContext.Items
            var customData = context.Items["CustomData"] as string;
            // Log or use the data as needed
            Console.WriteLine($"Data in SecondMiddleware: {customData}");

            await _next(context);
        }
    }

    //this is another way to implement multiple customer middlewares, here we are referencing the current IapplicationBuilder and using that to associate multiple custom middlewares
    // this is just like the lines used in program.cs. Advnatege of this is that it keeps program.cs clean
    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyCustomMiddlewares(this IApplicationBuilder builder) 
        {
            var app =  builder.UseMiddleware<CustomMiddleware>();
             app =  builder.UseMiddleware<CustomMiddleware2>();

            return app;
        }
    }
}
