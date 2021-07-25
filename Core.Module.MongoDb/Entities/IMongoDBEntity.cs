using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Module.MongoDb.Entities
{
    public interface IMongoDBEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
