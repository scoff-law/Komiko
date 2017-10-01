using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Komiko.Helpers
{
    static class FileHelpers
    {
        // Currently all comic files are assumed to be zip archives
        private static readonly List<string> ValidComicFileTypes = new List<string>
        {
            ".cpb",
            ".zip"
        };

        private static readonly List<string> ValidComicImageFileTypes = new List<string>
        {
            ".jpg", ".jpeg",
            ".gif",
            ".png",
            ".bmp"
        };

        private static bool IsValidType(string path, List<string> validTypes) => validTypes.Any(type =>
            string.Equals(Path.GetExtension(path), type, StringComparison.InvariantCultureIgnoreCase));

        public static bool IsValidComicType(string path) => IsValidType(path, ValidComicFileTypes);

        public static bool IsValidComicImageType(string path) => IsValidType(path, ValidComicImageFileTypes);
    }
}
