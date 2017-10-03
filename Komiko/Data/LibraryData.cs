using System.Collections.Generic;
using Komiko.Contracts.Data;
using Komiko.Models;
using Komiko.Models.Constants;
using Komiko.Properties;
using LiteDB;

namespace Komiko.Data
{
    /// <summary>
    /// Data access which interracts with library (database, memory)
    /// </summary>
    public class LibraryData : ILibraryData
    {
        public IEnumerable<Folder> GetLibraryFolders()
        {
            // TODO connection string
            using (var db = new LiteDatabase(Settings.Default.SettingsDatabase))
            {
                return db.GetCollection<Folder>(DatabaseKeys.LibraryFolders).FindAll();
            }
        }
    }
}