using AspectCore.DynamicProxy;

namespace NET6_AspectCore_Demo;

public class CustomInterceptorAttribute : AbstractInterceptorAttribute
{
    private readonly ILogger<CustomInterceptorAttribute> logger;

    public CustomInterceptorAttribute(ILogger<CustomInterceptorAttribute> logger)
    {
        this.logger = logger;
    }

    public override async Task Invoke(AspectContext context, AspectDelegate next)
    {
        try
        {
            logger.LogInformation("Invoking Interceptor");
            await next(context);
        }
        catch (Exception ex)
        {
            logger.LogError($"Interceptor Exception{ex}");
            throw;
        }
    }
}
