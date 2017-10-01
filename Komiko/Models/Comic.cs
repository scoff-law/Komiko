using System;
using System.Collections.Generic;

namespace Komiko.Models
{
    public class Comic
    {
        public string Name;

        public List<Issue> Issues;
    }

    public class Series
    {
        public int Id;

        public string Name;
    }

    public class Issue
    {
        public int Id;

        public string Name;

        public DateTime Date;

        public int Number;
    }

    public class SeriesIssue : Issue
    {
        public int SeriesId;

        public int Part;
    }
}