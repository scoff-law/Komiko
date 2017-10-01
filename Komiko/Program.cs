using System;
using Komiko.Infrastructure;
using SimpleInjector;

namespace Komiko
{
    /// <summary>
    /// Main application class for Komiko comic library
    /// </summary>
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            var container = Bootstrap();

            RunApplication(container);
        }

        private static Container Bootstrap()
        {
            var container = new Container();
            
            // Register types
            ModuleLoader.LoadModules(container);

            container.Verify();
            return container;
        }

        private static void RunApplication(Container container)
        {
            try
            {
                var app = new App();
                var mainWindow = container.GetInstance<MainWindow>();
                app.Run(mainWindow);
            }
            catch (Exception ex)
            {
                // TODO Log the exception and exit
            }
        }
    }
}
