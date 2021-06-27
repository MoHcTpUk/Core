using System;
using MongoDB.Bson;

namespace Core.Module.MongoDb.Entities
{
    public abstract class MongoDBAbstractEntity : IMongoDBEntity
    {
        public ObjectId Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool isDeleted { get; set; }
    }
}