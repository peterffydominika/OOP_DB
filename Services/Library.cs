using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
namespace OOP_DB.Services
{
    internal class Library : ISqlStatements
    {
        public object getById(int id)
        {
             Connect conn = new Connect("library");

            conn.Connnection.Open();

            string sql = "SELECT * FROM `books` WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connnection);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            var record = new
            {
                id = dr.GetBodyDefinition(dr.GetName(0)),
                title = dr.GetBodyDefinition(dr.GetName(1)),
                author = dr.GetBodyDefinition(dr.GetName(2)),
                releaseDate = dr.GetBodyDefinition(dr.GetName(3))
            };

            conn.Connnection.Close();

            return record;
        }

        public object UpdateItem(object updateRecord)
        {
            throw new NotImplementedException();
        }
        public object AddNewItem(object newRecord)
        {
            Connect conn = new Connect("library");
            conn.Connnection.Open();
            string sql = "INSERT INTO `books` (title, author, releaseDate) VALUES (@title, @author, @releaseDate)";
            MySqlCommand cmd = new MySqlCommand(sql, conn.Connnection);

            var book = newRecord.GetType().GetProperties();
            cmd.Parameters.AddWithValue("@title", book[0].GetValue(newRecord));
            cmd.Parameters.AddWithValue("@author", book[1].GetValue(newRecord));
            cmd.Parameters.AddWithValue("@releaseDate", book[2].GetValue(newRecord));
            cmd.ExecuteNonQuery();

            conn.Connnection.Close();
            var result = new {
                message = "Sikeres felvétel.",
                result = newRecord
            };
            return result;
        }

        public object DeleteItem(int id)
        {
            Connect conn = new Connect("library");

            conn.Connnection.Open();

            string sql = "DELETE FROM `books` WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connnection);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conn.Connnection.Close();
            var result = new
            {
                message = "Sikeres törlés.",
            };
            return result;
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
    }
}
