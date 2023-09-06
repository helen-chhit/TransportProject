using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Project.Class
{
    internal class addConnection
    {
        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        }
    }
}
