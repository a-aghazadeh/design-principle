namespace Solid.DI.Demo01.Resolve;

internal static class ServiceManager
{
    private static ServiceProvider? _serviceProvider;
    public static ServiceProvider BuildServiceProvider()
    {
        _serviceProvider = new ServiceCollection()
        .AddSingleton<IPresentation, Presentation>()
        .AddSingleton<IBusiness, Business>()
        .AddSingleton<IDataAccess, DataAccess>()
        .BuildServiceProvider();
        return _serviceProvider;
    }
    public static ServiceProvider ServiceProvider
    {
        get => _serviceProvider ?? BuildServiceProvider();
        set => _serviceProvider = value;
    }


}

