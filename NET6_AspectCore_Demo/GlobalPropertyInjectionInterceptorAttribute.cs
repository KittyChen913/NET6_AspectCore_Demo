using AspectCore.DependencyInjection;
using AspectCore.DynamicProxy;
using System.Reflection;

namespace NET6_AspectCore_Demo;

public class GlobalPropertyInjectionInterceptorAttribute : AbstractInterceptorAttribute
{
    [FromServiceContext]
    public ILogger<GlobalPropertyInjectionInterceptorAttribute> Logger { get; set; }

    public override async Task Invoke(AspectContext context, AspectDelegate next)
    {
        if (context.ServiceMethod.GetCustomAttributes<DisableGlobalInterceptor>(inherit: true).Any())
        {
            await next(context);
            return;
        }

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
public sealed class DisableGlobalInterceptor : Attribute { }