using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RehberApp.DataAccess.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberApp.DataAccess.Context
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<MongoSettings> setting)
        {
            var client = new MongoClient(setting.Value.ConnectionString);
            _database = client.GetDatabase(setting.Value.Database);
        }

        public IMongoCollection<TEntity> GetCollection<TEntity>()
        {
            return _database.GetCollection<TEntity>(typeof(TEntity).Name.Trim());
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }
    }
}
