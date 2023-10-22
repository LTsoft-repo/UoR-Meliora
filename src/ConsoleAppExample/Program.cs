using Autofac;
using ConsoleAppExample.Infrastructure;
using ConsoleAppExample.Services;
using JetBrains.Annotations;

namespace ConsoleAppExample;

[ UsedImplicitly ]
public class Program
{
    private static async Task Main( string[] args )
    {
        var serviceProvider = new ContainerBuilder().RegisterServices();

        var application = serviceProvider.Resolve<AppLogic>();
        await application.RunAsync( args );
    }
}