using AspectCore.DynamicProxy;

namespace NET6_AspectCore_Demo;

public class CustomInterceptorAttribute : AbstractInterceptorAttribute
{
    public override async Task Invoke(AspectContext context, AspectDelegate next)
    {
        Console.WriteLine("Invoking Interceptor");
        await next(context);
    }
}
