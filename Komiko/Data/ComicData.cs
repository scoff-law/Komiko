using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Komiko.Contracts.Data;
using Komiko.Helpers;
using Komiko.Models;
using SharpCompress.Archives;

namespace Komiko.Data
{
    /// <summary>
    /// Data access which interracts with comic data (physical, disk)
    /// </summary>
    public class ComicData : IComicData
    {
        public Comic GetComic(string path)
        {
            return ReadComic(path);
        }

        public List<string> GetComicPaths(Folder folder)
        {
            var files = Directory.GetFiles(folder.Path);
            var paths = files.Where(FileHelpers.IsValidComicType).ToList();

            // Add folders containing images as comics
            // TODO add flag to affect image folder thresholds for comic detection
            if (files.Any(FileHelpers.IsValidComicImageType)) paths.Add(folder.Path);

            // Add folders recursively
            if (!folder.Recursive) return paths;
            var directories = Directory.GetDirectories(folder.Path);
            foreach (var directory in directories)
            {
                try
                {
                    paths.AddRange(GetComicPaths(new Folder {Path = directory, Recursive = true}));
                }
                catch
                {
                    // ignore permission issues
                }
            }
            return paths;
        }

        #region Private Helpers

        private static Comic ReadComic(string path)
        {
            if (!FileHelpers.IsValidComicType(path)) return null;

            using (var stream = new FileStream(path, FileMode.Open))
            using (var reader = ArchiveFactory.Open(stream))
            {
                foreach (var entry in reader.Entries)
                {
                    if (!entry.IsDirectory)
                    {
                        Console.WriteLine(entry);
                    }
                }
            }
            return new Comic();
        }

        #endregion
    }
}