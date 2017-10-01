using System.Collections.Generic;
using Komiko.Contracts.Data;
using Komiko.Contracts.Engines;
using Komiko.Models;

namespace Komiko.Engines
{
    public class LibraryEngine : ILibraryEngine
    {
        private readonly IComicData _comicData;

        public LibraryEngine(IComicData comicData)
        {
            _comicData = comicData;
        }

        public void BuildLibrary()
        {
            throw new System.NotImplementedException();
        }

        public List<Comic> GetComics(string path)
        {
            throw new System.NotImplementedException();
        }
    }
}
