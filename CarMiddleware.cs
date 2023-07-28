namespace part2_HW2
{
    public class CarMiddleware : IManagementCars
    {
        private readonly RequestDelegate requestDelegate;
        public CarMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task GetCarName(HttpContext context)
        {
            await context.Response.WriteAsync($"Car name is very simple and well-known");
        }
        public async Task GetCarEngine(HttpContext context)
        {
            await context.Response.WriteAsync($"Car engine is very powerful");
        }
        public async Task GetCarAge(HttpContext context)
        {
            await context.Response.WriteAsync($"Car age is nobody's business");
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if(context.Request.Path=="/name")
                await GetCarName(context);
            else if(context.Request.Path=="/engine")
                await GetCarEngine(context);
            else if(context.Request.Path=="/age")
                await GetCarAge(context);
            else
                await requestDelegate.Invoke(context);
        }
    }
}
