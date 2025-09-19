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
            Console.Write("Kérem az adatbázis nevét: ");
            string dbName = Console.ReadLine();

            ISqlStatements dataBase = new Library();

            /*foreach (var item in dataBase.GetAllData(dbName))
            {
                var books = item.GetType().GetProperties();
                Console.WriteLine($"{books[0].Name}={books[0].GetValue(item)}, {books[1].Name}={books[1].GetValue(item)}");
            }*/

            //Console.Write("Kérem a rekord id-jét: ");
            //Console.WriteLine(dataBase.getById(int.Parse(Console.ReadLine())));

            //var book = new
            //{
            //    title = "A kis herceg",
            //    author = "Antoine de Saint-Exupéry",
            //    releaseDate = "1943-09-15"
            //};
            //dataBase.AddNewItem(book);

            dataBase.DeleteItem(101);
        }
    }
}
