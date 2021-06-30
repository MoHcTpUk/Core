using MongoDB.Driver;

namespace Core.Module.MongoDb
{
    public interface IMongoDatabaseFactory
    {
        IMongoDatabase GetMongoDatabase();
    }
}