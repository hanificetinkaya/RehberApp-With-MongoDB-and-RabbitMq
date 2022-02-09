using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberApp.Entities.Concrate
{
    public class Iletisim
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string BilgiTipi { get; set; }
        public string BilgiIcerigi { get; set; }
    }
}
