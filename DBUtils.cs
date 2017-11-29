using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Utils
{
    public class DBUtils
    {
       
        private  static readonly string DB_CONNECT = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

        //private const string DB_CONNECT="Database=registered_user;Data Source=localhost;User id=root;Password=root";
        private  static MySqlConnection connection=new MySqlConnection(DB_CONNECT);

        protected static MySqlConnection getConnection(){
            return connection;
        }
    }
}
