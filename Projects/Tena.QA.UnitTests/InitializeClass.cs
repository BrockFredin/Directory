using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleInjector;
using Accenture.DirectoryStatistics.Service.Logging;

namespace Accenture.DirectoryStatistics.UnitTests
{
    [TestClass]
    public class InitializeClass
    {
        [AssemblyInitialize]
        public static void Initialize(TestContext testContext)
        {
            var container = SimpleInjector.DependencyInjection.GetContainerInstance();

            //Logging
            {
                container.Register<ILoggingService, LoggingService>(Lifestyle.Singleton);
            }

        }
    }
}