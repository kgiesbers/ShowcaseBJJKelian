using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class StudentRepository
    {
        public MySqlConnection connectionstring = new MySqlConnection(ConfigurationManager.ConnectionStrings["bjjshowcase"].ConnectionString);
        public Beltlevel ConvertToEnum(string beltlevel)
        {
            return (Beltlevel) Enum.Parse(typeof(Beltlevel), beltlevel, true);
        }
        /*
        public List<Student> GetStudents()
        {
            List<Student> result = new List<Student>();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM students", connectionstring);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                Student student = new Student(
                    Convert.ToInt32(mySqlDataReader["id"]),
                    Convert.ToString(mySqlDataReader["first_name"]),
                    Convert.ToString(mySqlDataReader["last_name"]),
                    ConvertToEnum(mySqlDataReader["belt_level"]));


            }

        }*/
    }
}
