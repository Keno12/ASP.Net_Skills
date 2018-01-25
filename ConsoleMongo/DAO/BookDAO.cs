using ConsoleMongo.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMongo.DAO
{
    public class BookDAO
    {
        private MongoClient mongoClient;
        private IMongoCollection<Book> bookCollection;
        public BookDAO()
        {
            mongoClient = new MongoClient("mongodb://127.0.0.1:27017");
            var database = mongoClient.GetDatabase("bookStore");
            bookCollection = database.GetCollection<Book>("Book");
        }

        public void FindAll()
        {
            var books = bookCollection.AsQueryable().ToList();
            foreach (var book in books)
            {
                Console.WriteLine("id:", book.Id);
                Console.WriteLine("ISBN:", book.ISBN);
                Console.WriteLine("Title:", book.Title);
                Console.WriteLine("Publisher:", book.Publisher);
                Console.WriteLine("========================");
            }
        }
        public void FindOne(string id)
        {
            var bookId = new ObjectId(id);
            var book = bookCollection.AsQueryable().SingleOrDefault(b => b.Id == bookId);
            Console.WriteLine("id:", book.Id);
            Console.WriteLine("ISBN:", book.ISBN);
            Console.WriteLine("Title:", book.Title);
            Console.WriteLine("Publisher:", book.Publisher);
            Console.WriteLine("========================");
        }
        public void FindByTitle(string name)
        {
            var books = bookCollection.AsQueryable().Where(b => b.Title.Contains(name)).ToList();
            foreach (var book in books)
            {
                Console.WriteLine("id:", book.Id);
                Console.WriteLine("ISBN:", book.ISBN);
                Console.WriteLine("Title:", book.Title);
                Console.WriteLine("Publisher:", book.Publisher);
                Console.WriteLine("========================");
            }
        }

        public void Create()
        {
            Book book = new Book()
            {
                ISBN = "sdgfghfgdf34657687",
                Title = "这个杀手",
                Publisher = "北京邮电出版社"
            };
            bookCollection.InsertOne(book);
        }

        public void Update()
        {
            var result = bookCollection.UpdateOne(filter: Builders<Book>.Filter.Eq("_id", ObjectId.Parse("5a69907d08baf82500517d49")), update: Builders<Book>.Update.Set("Title", "中华民族的崛起").Set("Publisher", "张三丰"));
            Console.WriteLine("Updated: " + result.ModifiedCount);
        }
    }
}
