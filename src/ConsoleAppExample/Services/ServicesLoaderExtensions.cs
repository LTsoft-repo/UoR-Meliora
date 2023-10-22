using Autofac;
using ConsoleAppExample.Infrastructure;
using NumberUtils.Numbers;
using NumberUtils.TextProviders;

namespace ConsoleAppExample.Services;

public static class ServicesLoaderExtensions
{
    public static IContainer RegisterServices( this ContainerBuilder builder )
    {
        builder.RegisterType<AppLogic>();

        #region Custom registrations
        builder.RegisterType<MultipleCheckerSupportingZero>().As<IMultipleChecker>();
        builder.RegisterType<MelioraTextProvider>().As<ITextProvider<int>>();

        builder.RegisterType<NumbersProvider>().As<INumbersProvider<int>>();
        builder.RegisterType<MelioraNumbersProvider>().As<INumbersProvider<string>>();
        #endregion

        return builder.Build();
    }
}