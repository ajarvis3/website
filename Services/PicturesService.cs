using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using website.Models;

namespace website.Services
{
    public class PicturesService
    {
        private readonly IMongoCollection<Pictures> _pictures;

        public PicturesService(IPicturesStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _pictures = database.GetCollection<Pictures>(settings.PicturesCollectionName);
        }

        public List<Pictures> Get() =>
            _pictures.Find(pic => true).ToList();

        public Pictures Get(string id) =>
            _pictures.Find<Pictures>(pic => pic.Id == id).FirstOrDefault();

        public Pictures Create(Pictures pic)
        {
            _pictures.InsertOne(pic);
            return pic;
        }

        public void Update(string id, Pictures picIn) =>
            _pictures.ReplaceOne(pic => pic.Id == id, picIn);

        public void Remove(Pictures picIn) =>
            _pictures.DeleteOne(pic => pic.Id == picIn.Id);

        public void Remove(string id) => 
            _pictures.DeleteOne(pic => pic.Id == id);
    }
}