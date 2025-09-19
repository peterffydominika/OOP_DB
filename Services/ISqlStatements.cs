using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DB.Services
{
    internal interface ISqlStatements
    {
        List<object> GetAllData(string dbName);
        object getById(int id);
        object AddNewItem(object newRecod);
        object DeleteItem(int id);
        object UpdateItem(object updateRecord);
    }
}
