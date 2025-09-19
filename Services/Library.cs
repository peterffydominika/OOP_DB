using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OOP_DB.Services
{
    internal class Library : ISqlStatements
    {
        public object AddNewItem(object newRecod)
        {
            throw new NotImplementedException();
        }

        public object DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

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
                    id = dr.GetBodyDefinition(dr.GetName(0)),
                    title = dr.GetBodyDefinition(dr.GetName(1)),
                    author = dr.GetBodyDefinition(dr.GetName(2)),
                    releaseDate = dr.GetBodyDefinition(dr.GetName(3))
                };
                books.Add(book);
            }

            conn.Connnection.Close();
            return books;
        }

        public object getById(int id)
        {
            throw new NotImplementedException();
        }

        public object UpdateItem(object updateRecord)
        {
            throw new NotImplementedException();
        }
    }
}
