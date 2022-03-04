using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainCadCli.Collections
{
    public abstract class CollectionMongo
    {
        protected CollectionMongo()
        {
            DataCriacaoColecao = DateTime.Now.AddHours(-3);
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }

        public DateTime DataCriacaoColecao { get; protected set; }
    }
}
