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
            Connect conn = new Connect("library");

            conn.Connnection.Open();

            string sql = "SELECT `id`, `brand`, `type`, `mDate` FROM `cars` WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connnection);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            var record = new
            {
                id = dr.GetBodyDefinition(dr.GetName(0)),
                brand = dr.GetBodyDefinition(dr.GetName(1)),
                type = dr.GetBodyDefinition(dr.GetName(2)),
                mDate = dr.GetBodyDefinition(dr.GetName(3))
            };

            conn.Connnection.Close();

            return record;
        }
        public object UpdateItem(int id, object updateRecord)
        {
            Connect conn = new Connect("library");
            conn.Connnection.Open();

            string sql = "UPDATE `cars` SET `brand`='@brand',`type`='@type',`mDate`='@mdate' WHERE `id`=@id";
            var record = updateRecord.GetType().GetProperties();
            MySqlCommand cmd = new MySqlCommand(sql, conn.Connnection);

            cmd.Parameters.AddWithValue("@brand", record[0].GetValue(updateRecord));
            cmd.Parameters.AddWithValue("@type", record[1].GetValue(updateRecord));
            cmd.Parameters.AddWithValue("@mdate", record[2].GetValue(updateRecord));
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conn.Connnection.Close();
            return new { message = "Sikeres módosítás." };
        }
        public object AddNewItem(object newRecord)
        {
            Connect conn = new Connect("library");
            conn.Connnection.Open();
            string sql = "INSERT INTO `cars`(`brand`, `type`, `mDate`) VALUES (@brand, @type, @mDate)";
            MySqlCommand cmd = new MySqlCommand(sql, conn.Connnection);

            var car= newRecord.GetType().GetProperties();
            cmd.Parameters.AddWithValue("@brand", car[0].GetValue(newRecord));
            cmd.Parameters.AddWithValue("@type", car[1].GetValue(newRecord));
            cmd.Parameters.AddWithValue("@mDate", car[2].GetValue(newRecord));
            cmd.ExecuteNonQuery();

            conn.Connnection.Close();
            var result = new
            {
                message = "Sikeres felvétel.",
                result = newRecord
            };
            return result;
        }

        public object DeleteItem(int id)
        {
            Connect conn = new Connect("library");

            conn.Connnection.Open();

            string sql = "DELETE FROM `cars` WHERE id = @id";

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
