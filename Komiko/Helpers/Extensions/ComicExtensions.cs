using System.Collections.Generic;
using System.Linq;

namespace Komiko.Helpers.Extensions
{
    public static class ComicExtensions
    {
        public static List<string> StripPath(this IEnumerable<string> paths, string libraryPath) =>
            paths.Select(path => path.Replace($@"{libraryPath}\", string.Empty).Replace(libraryPath, string.Empty)).ToList();
    }
}
