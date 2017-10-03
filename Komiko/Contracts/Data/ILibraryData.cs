using System.Collections.Generic;
using Komiko.Models;

namespace Komiko.Contracts.Data
{
    public interface ILibraryData
    {
        IEnumerable<Folder> GetLibraryFolders();
    }
}
