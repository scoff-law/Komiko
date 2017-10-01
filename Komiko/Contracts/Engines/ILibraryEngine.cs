using System.Collections.Generic;
using Komiko.Models;

namespace Komiko.Contracts.Engines
{
    interface ILibraryEngine
    {
        void BuildLibrary();

        List<Comic> GetComics(string path);
    }
}
