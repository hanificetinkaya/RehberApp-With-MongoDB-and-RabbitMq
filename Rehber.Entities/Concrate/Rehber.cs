using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberApp.Entities.Concrate
{
    public class Rehber
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Firma { get; set; }
        public ICollection<Iletisim> IletisimBilgisi { get; set; }
    }
}
