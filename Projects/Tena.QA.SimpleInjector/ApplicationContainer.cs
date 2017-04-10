using SimpleInjector;
using Accenture.DirectoryStatistics.Service.Logging;
using Accenture.DirectoryStatistics.Scenarios.Service;
using Accenture.DirectoryStatistics.Scenarios;

namespace Accenture.DirectoryStatistics.SimpleInjector
{
    public class ApplicationContainer
    {
        public static void RegisterComponents()
        {
            var simpleInjectorContainer = DependencyInjection.GetContainerInstance();

            simpleInjectorContainer.Register<ILoggingService, LoggingService>(Lifestyle.Singleton);
            simpleInjectorContainer.Register<IPath, Path>(Lifestyle.Singleton);
            simpleInjectorContainer.Register<IDirectoryStatistics<Path>, DirectoryStatistics<Path>>(
                Lifestyle.Singleton);
        }
    }
}