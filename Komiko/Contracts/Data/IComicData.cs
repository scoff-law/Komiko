using System.Collections.Generic;
using Komiko.Models;

namespace Komiko.Contracts.Data
{
    public interface IComicData
    {
        Comic GetComic(string path);

        List<string> GetComicPaths(Folder folder);
    }
}