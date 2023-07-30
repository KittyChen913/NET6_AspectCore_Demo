using AspectCore.DynamicProxy;

namespace NET6_AspectCore_Demo;

public class SingleInterceptorAttribute : AbstractInterceptorAttribute
{
    private readonly ILogger<SingleInterceptorAttribute> logger;

    public SingleInterceptorAttribute(ILogger<SingleInterceptorAttribute> logger)
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
