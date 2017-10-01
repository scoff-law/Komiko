using System.Collections.Generic;
using Komiko.Models;

namespace Komiko.Contracts.Engines
{
    public interface ILibraryEngine
    {
        void BuildLibrary();

        List<string> GetComics();
    }
}
