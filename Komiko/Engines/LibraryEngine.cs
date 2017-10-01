using System.Collections.Generic;
using Komiko.Contracts.Data;
using Komiko.Contracts.Engines;
using Komiko.Helpers.Extensions;

namespace Komiko.Engines
{
    public class LibraryEngine : ILibraryEngine
    {
        private readonly IComicData _comicData;

        // TODO settings

        #region Settings

        public const string LibraryPath = @"C:\Users\Ben\Comics";

        public const bool Recursive = true;

        #endregion

        public LibraryEngine(IComicData comicData)
        {
            _comicData = comicData;
        }

        public void BuildLibrary()
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetComics()
        {
            return _comicData.GetComicPaths(LibraryPath, Recursive).StripPath(LibraryPath);
        }
    }
}
