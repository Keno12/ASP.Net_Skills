using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDemo
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // MongoDB服务器 连接串
            var connectString = "mongodb://127.0.0.1:27017";
            var client = new MongoClient(connectString);
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<BsonDocument>("bar");

             collection.InsertOne(new BsonDocument("Name", "Jack"));

            var list = collection.Find(new BsonDocument("Name", "Jack")).ToListAsync();

            //foreach (var document in list)
            //{
            //    Console.WriteLine(document["Name"]);
            //}

        }
    }
}