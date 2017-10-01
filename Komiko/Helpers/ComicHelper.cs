using System;
using System.Collections.Generic;
using System.Linq;

namespace Komiko.Helpers
{
    public class ComicHelper
    {
        public delegate string Namer<in T>(T input);

        private static readonly Namer<string> StringNamer = name => name;

        public static List<string> SortByName(List<string> names, bool asc) => SortByName(names, StringNamer, asc);

        public static List<T> SortByName<T>(List<T> input, Namer<T> getNameFrom, bool asc) => input.OrderBy(named =>
        {
            var name = getNameFrom(named);
            return name.StartsWith("A ", StringComparison.OrdinalIgnoreCase) ||
                   name.StartsWith("The ", StringComparison.OrdinalIgnoreCase)
                ? name.Substring(name.IndexOf(" ", StringComparison.OrdinalIgnoreCase) + 1)
                : name;
        }).ToList();
    }
}
