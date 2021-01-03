namespace website.Models
{
    public class PicturesStoreDatabaseSettings : IPicturesStoreDatabaseSettings
    {
        public string PicturesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IPicturesStoreDatabaseSettings
    {
        string PicturesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }

}