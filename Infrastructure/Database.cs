using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Infrastructure
{
    internal class Database
    {
        private string connectionString = string.Format("Server=localhost; database=bjjshowcase; UID=root; password=1FontysSQL2!");
        private MySqlConnetion connection = null;
    }
}
