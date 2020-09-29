using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ffc_backend.Model.database
{
    public class FFCDatabaseSettings : IDBConnectionSettings
    {
        public string collectionName { get; set; }
        public string connectionString { get; set; }
        public string databaseName { get; set; }
    }

    public interface IDBConnectionSettings
    {
        string collectionName { get; set; }
        string connectionString { get; set; }
        string databaseName { get; set; }
    }
}
