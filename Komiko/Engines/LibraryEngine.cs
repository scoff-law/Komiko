using System.Collections.Generic;
using System.Linq;
using Komiko.Contracts.Data;
using Komiko.Contracts.Engines;

namespace Komiko.Engines
{
    public class LibraryEngine : ILibraryEngine
    {
        private readonly IComicData _comicData;
        private readonly ILibraryData _libraryData;

        // TODO settings

        public LibraryEngine(IComicData comicData, ILibraryData libraryData)
        {
            _comicData = comicData;
            _libraryData = libraryData;
        }

        public void BuildLibrary()
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetComics()
        {
            var libraryFolders = _libraryData.GetLibraryFolders();
            var comics = libraryFolders.SelectMany(_comicData.GetComicPaths);

            return comics.ToList();
        }
    }
}
