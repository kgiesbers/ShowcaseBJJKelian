using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Infrastructure
{
    public class Database
    {
        public MySqlConnection connectionstring = new MySqlConnection(ConfigurationManager.ConnectionStrings["bjjshowcase"].ConnectionString);
    }
}
