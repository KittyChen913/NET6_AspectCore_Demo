using AspectCore.DynamicProxy;

namespace NET6_AspectCore_Demo;

public class GlobalInterceptorAttribute : AbstractInterceptorAttribute
{
    private readonly ILogger<GlobalInterceptorAttribute> logger;

    public GlobalInterceptorAttribute(ILogger<GlobalInterceptorAttribute> logger)
    {
        this.logger = logger;
    }

    public override async Task Invoke(AspectContext context, AspectDelegate next)
    {
        try
        {
            logger.LogInformation("Invoking Global Interceptor");
            await next(context);
        }
        catch (Exception ex)
        {
            logger.LogError($"Global Interceptor Exception{ex}");
            throw;
        }
    }
}
