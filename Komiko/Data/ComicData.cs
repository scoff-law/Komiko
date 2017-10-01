using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Komiko.Contracts.Data;
using Komiko.Helpers;
using Komiko.Models;

namespace Komiko.Data
{
    public class ComicData : IComicData
    {
        public Comic GetComic(string path)
        {
            throw new NotImplementedException();
        }

        public List<string> GetComicPaths(string path, bool recursive)
        {
            var files = Directory.GetFiles(path);
            var paths = files.Where(FileHelpers.IsValidComicType).ToList();

            // Add folders containing images as comics
            // TODO add flag to affect image folder thresholds for comic detection
            if (files.Any(FileHelpers.IsValidComicImageType)) paths.Add(path);

            // Add folders recursively
            if (!recursive) return paths;
            var directories = Directory.GetDirectories(path);
            foreach (var directory in directories)
            {
                try
                {
                    paths.AddRange(GetComicPaths(directory, true));
                }
                catch
                {
                    // ignore permission issues
                }
            }
            return paths;
        }
    }
}