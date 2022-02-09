using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RehberApp.DataAccess.Abstract;
using RehberApp.DataAccess.Context;
using RehberApp.DataAccess.Repository;
using RehberApp.DataAccess.Settings;
using RehberApp.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberApp.DataAccess.Concrete
{
    public class RehberDataAccess : MongoRepositoryBase<Rehber>, IRehberDataAccess
    {
        private readonly MongoDbContext _context;
        private readonly IMongoCollection<Rehber> _collection;

        public RehberDataAccess(IOptions<MongoSettings> settings): base(settings)
        {
            _context = new MongoDbContext(settings);
            _collection = _context.GetCollection<Rehber>();
        }
    }
}
