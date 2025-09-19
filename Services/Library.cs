using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OOP_DB.Services
{
    internal class Library : ILibrary
    {
        public List<object> GetAllData(string dbName)
        {
            Connect conn = new Connect("library");
            List<object> books = new List<object>();
            conn.Connnection.Open();
            string sql = "SELECT * FROM books";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connnection);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            while (dr.Read())
            {
                var book = new
                {
                    id = dr.GetInt32("id"),
                    title = dr.GetString("title"),
                    author = dr.GetString("author"),
                    releaseDate = dr.GetDateTime("releaseDate")
                };
                books.Add(book);
            }

            conn.Connnection.Close();
            return books;
        }
    }
}
