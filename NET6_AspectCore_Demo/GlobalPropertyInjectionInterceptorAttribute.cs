using AspectCore.DependencyInjection;
using AspectCore.DynamicProxy;

namespace NET6_AspectCore_Demo;

public class GlobalPropertyInjectionInterceptorAttribute : AbstractInterceptorAttribute
{
    [FromServiceContext]
    public ILogger<GlobalPropertyInjectionInterceptorAttribute> Logger { get; set; }

    public override async Task Invoke(AspectContext context, AspectDelegate next)
    {
        try
        {
            Logger.LogInformation("Invoking Property Injection Global Interceptor");
            await next(context);
        }
        catch (Exception ex)
        {
            Logger.LogError($"Property Injection Global Interceptor Exception{ex}");
            throw;
        }
    }
}
