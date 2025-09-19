using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OOP_DB.Services
{
    internal class Cars : ISqlStatements
    {
        public List<object> GetAllData(string dbName)
        {
            Connect conn = new Connect(dbName);
            List<object> cars = new List<object>();
            conn.Connnection.Open();
            string sql = "SELECT * FROM cars";
            MySqlCommand cmd = new MySqlCommand(sql, conn.Connnection);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            while (dr.Read())
            {
                var car = new
                {
                    id = dr.GetInt32("id"),
                    brand = dr.GetString("brand"),
                    type = dr.GetString("type"),
                    mDate = dr.GetInt32("mDate")
                };
                cars.Add(car);
            }
            conn.Connnection.Close();
            return cars;
        }
    }
}
