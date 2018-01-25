using ConsoleMongo.DAO;
using ConsoleMongo.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMongo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookDAO bookDAO = new BookDAO();
            //bookDAO.FindAll();
            //bookDAO.FindOne("5a69907d08baf82500517d49");
            //bookDAO.FindByTitle("Mongodb for C# ");
            //bookDAO.Create();
            bookDAO.Update();
            Console.WriteLine("success");
        }
    }

}
