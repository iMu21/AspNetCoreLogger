﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using WebApp.Logger.Models;
using WebApp.Logger.Providers.Mongos;

namespace WebApp.Logger.Loggers.Providers.Mongos
{
    [BsonCollection("ErrorLog")]
    public class ErrorLogDocument : ErrorModel, IDocument
    {
        public ObjectId Id { get; set; }
        public DateTime CreatedDateUtc => Id.CreationTime;
    }
}
