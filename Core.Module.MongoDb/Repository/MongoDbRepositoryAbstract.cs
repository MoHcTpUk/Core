using Core.Module.MongoDb.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Module.MongoDb.Repository
{
    public class MongoDbRepositoryAbstract<TEntity> : IMongoDbRepository<TEntity> where TEntity : MongoDBAbstractEntity
    {
        private string User { get; }
        private string Pass { get; }
        private string Host { get; }
        private string Port { get; }
        private string DbName { get; }

        private string ConnectionString { get; }
        private MongoClient Client { get; }
        private IMongoDatabase Db { get; }

        public MongoDbRepositoryAbstract()
        {
            User = "admin";
            Pass = "";
            Host = "localhost";
            Port = "27017";
            DbName = "test";

            //  mongodb://[username:password@]hostname[:port][/[database][?options]]
            ConnectionString = @$"mongodb://{User}:{Pass}@{Host}:{Port}/";

            Client = new MongoClient(ConnectionString);
            Db = Client.GetDatabase(DbName);
        }

        public async Task<TEntity> CreateAsync(TEntity item)
        {
            var collection = Db.GetCollection<TEntity>(typeof(TEntity).Name);
            await collection.InsertOneAsync(item);

            return item;
        }

        public Task<bool> DeleteAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate)
        {
            var collection = Db.GetCollection<TEntity>(typeof(TEntity).Name);
            var filter = new BsonDocument();

            return collection.Find(filter).ToEnumerable();
        }

        public TEntity Get(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            var collection = Db.GetCollection<TEntity>(typeof(TEntity).Name);
            var filter = new BsonDocument();

            return collection.Find(filter).ToEnumerable();
        }

        public Task<TEntity> UpdateAsync(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}