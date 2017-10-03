namespace Komiko.Models
{
    public class Folder
    {
        /// <summary>
        /// Folder path
        /// </summary>
        public string Path { get; set; }
        
        /// <summary>
        /// Represents whether the path should be scanned recursively
        /// </summary>
        public bool Recursive { get; set; }
    }
}
