namespace ffc_backend.Model.database
{
    public class FFCDatabaseSettings : IDBConnectionSettings
    {
        public string connectionString { get; set; }
        public string databaseName { get; set; }
    }

    public interface IDBConnectionSettings
    {
        string connectionString { get; set; }
        string databaseName { get; set; }
    }
}
