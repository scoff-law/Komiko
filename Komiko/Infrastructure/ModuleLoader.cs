using Komiko.Contracts.Data;
using Komiko.Contracts.Engines;
using Komiko.Data;
using Komiko.Engines;
using SimpleInjector;

namespace Komiko.Infrastructure
{
    public static class ModuleLoader
    {
        public static Container LoadModules(Container container)
        {
            // Data
            container.Register<IComicData, ComicData>();
            
            // Engines
            container.Register<ILibraryEngine, LibraryEngine>();

            return container;
        }
    }
}