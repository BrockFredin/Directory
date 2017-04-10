using SimpleInjector;

namespace Accenture.DirectoryStatistics.SimpleInjector
{
    public static class DependencyInjection
    {
        /// <summary>
        ///     Instance
        /// </summary>
        private static Container _instance;

        /// <summary>
        ///     Object
        /// </summary>
        private static readonly object SyncObj = new object();

        /// <summary>
        ///     Method to get the container instance
        /// </summary>
        /// <returns></returns>
        public static Container GetContainerInstance()
        {
            //Verifica se o objeto já existe
            if (_instance == null)
                lock (SyncObj)
                {
                    //Verifica se o objeto já existe
                    if (_instance == null)
                    {
                        //Inicializa a variáel
                        _instance = new Container();
                        _instance.Options.AllowOverridingRegistrations = true;
                    }
                }

            //Return the instance
            return _instance;
        }
    }
}