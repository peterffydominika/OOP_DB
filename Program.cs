using MySql.Data.MySqlClient;
using OOP_DB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem az adatbázis nevét: ");
            string dbName = Console.ReadLine();
            Connect conn = new Connect(dbName);
            ILibrary dataBase = new Library();
            dataBase.GetAllData(dbName);

            

            foreach (var item in dataBase.GetAllData(dbName)) {
                var books = item.GetType().GetProperties();
                Console.WriteLine($"Id= {books[0].Name}={books[0].GetValue(item)}, Title= {books[1].Name}={books[1].GetValue(item)}");
            }
            Console.WriteLine(dataBase.GetAllData(dbName));
        }
    }
}
