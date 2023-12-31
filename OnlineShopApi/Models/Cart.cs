﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace OnlineShopApi.Models
{
    public class Cart
    {
        public Cart()
        {
            Id = ObjectId.GenerateNewId().ToString();
        }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public  string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]

        public string UserId { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();
    }
    public class CartItem
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
