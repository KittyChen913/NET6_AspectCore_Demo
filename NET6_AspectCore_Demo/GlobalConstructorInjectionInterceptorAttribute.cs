using AspectCore.DynamicProxy;

namespace NET6_AspectCore_Demo;

public class GlobalConstructorInjectionInterceptorAttribute : AbstractInterceptorAttribute
{
    private readonly ILogger<GlobalConstructorInjectionInterceptorAttribute> logger;

    public GlobalConstructorInjectionInterceptorAttribute(ILogger<GlobalConstructorInjectionInterceptorAttribute> logger)
    {
        this.logger = logger;
    }

    public override async Task Invoke(AspectContext context, AspectDelegate next)
    {
        try
        {
            logger.LogInformation("Invoking Constructor Injection Global Interceptor");
            await next(context);
        }
        catch (Exception ex)
        {
            logger.LogError($"Constructor Injection Global Interceptor Exception{ex}");
            throw;
        }
    }
}
