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
            

            ISqlStatements dataBase = new Library();
            Console.Write("Kérem a record id-jét: ");
            int id  = int.Parse(Console.ReadLine());
            Console.Write("Kérem a record title-jét: ");
            string title = Console.ReadLine();
            Console.Write("Kérem a record author-ját: ");
            string author = Console.ReadLine();
            Console.Write("Kérem a record rdate-jét: ");
            string rdate = Console.ReadLine();
            
            var UpdateBook = new
            {
                Title = title,
                Author = author,
                ReleaseDate = rdate
            };
            Console.WriteLine(dataBase.UpdateItem(id, UpdateBook));
            //Console.Write("Kérem az adatbázis nevét: ");
            //string dbName = Console.ReadLine();

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
