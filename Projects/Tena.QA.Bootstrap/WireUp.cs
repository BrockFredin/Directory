using Accenture.DirectoryStatistics.SimpleInjector;

namespace Accenture.Bootstrap
{
    public class WireUp
    {
        public static void Main()
        {
            Config();

            var simpleInjectorContainer = DependencyInjection.GetContainerInstance();

            //var someTest =
            //    simpleInjectorContainer.GetInstance<IPlatformTest>();

            //someTest.PositiveTest();
        }

        private static void Config()
        {
            //Register dependencies
            ApplicationContainer.RegisterComponents();
        }
    }
}