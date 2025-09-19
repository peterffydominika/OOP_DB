using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DB.Services
{
    internal interface ILibrary
    {
        List<object> GetAllData(string dbName);
    }
}
