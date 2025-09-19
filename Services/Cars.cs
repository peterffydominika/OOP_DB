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
        public object getById(int id)
        {
            throw new NotImplementedException();
        }

        public object UpdateItem(object updateRecord)
        {
            throw new NotImplementedException();
        }
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
                    id = dr.GetBodyDefinition(dr.GetName(0)),
                    brand = dr.GetBodyDefinition(dr.GetName(1)),
                    type = dr.GetBodyDefinition(dr.GetName(2)),
                    mDate = dr.GetBodyDefinition(dr.GetName(3))
                };
                cars.Add(car);
            }
            conn.Connnection.Close();
            return cars;
        }
    }
}
