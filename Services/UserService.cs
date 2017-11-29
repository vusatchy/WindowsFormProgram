using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using DAL;
using Entities;
using MySql.Data.MySqlClient;

namespace Services
{
    public class UserService  : DBUtils,ITemplateDAL<User>
    {
        public  User getById(int id)
        {     
            User user = new User();
            using(MySqlConnection connection = getConnection())
            {
               
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM user WHERE user.id=@id";
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                user.id = Int32.Parse(dataReader["id"].ToString());
                user.login = dataReader["login"].ToString();
                user.password = dataReader["password"].ToString();
                user.sex = (Sex)Enum.Parse(typeof(Sex), dataReader["sex"].ToString().ToUpper());
                user.registrationTime = DateTime.Parse(dataReader["registration_time"].ToString());
                user.email = dataReader["email"].ToString();
                dataReader.Close();
            }
            return user;
        }

        public  void add(User obj)
        {
            using(MySqlConnection connection = getConnection())
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO user (login,password,sex,registration_time,email) VALUES(@login,@password,@sex,@registration_time,@email)";
                //command.Parameters.AddWithValue("@id",obj.id);
                command.Parameters.AddWithValue("@login", obj.login);
                command.Parameters.AddWithValue("@password", obj.password);
                command.Parameters.AddWithValue("@sex", obj.sex.ToString().ToLower());
                command.Parameters.AddWithValue("@registration_time", obj.registrationTime);
                command.Parameters.AddWithValue("@email", obj.email);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public  void update(User obj)
        {
            using (MySqlConnection connection = getConnection())
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE user SET login=@login,password=@password,sex=@sex,registration_time=@registration_time,email=@email WHERE id=@id";
                command.Parameters.AddWithValue("@id", obj.id);
                command.Parameters.AddWithValue("@login", obj.login);
                command.Parameters.AddWithValue("@password", obj.password);
                command.Parameters.AddWithValue("@sex", obj.sex.ToString().ToLower());
                command.Parameters.AddWithValue("@registration_time", obj.registrationTime);
                command.Parameters.AddWithValue("@email", obj.email);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public  void delete(User obj)
        {
            using (MySqlConnection connection = getConnection())
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM user WHERE id = @id";
                command.Parameters.AddWithValue("@id", obj.id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public  List<User> getAll()
        {
            List<User> users = new List<User>();
            User user = null;
            using (MySqlConnection connection = getConnection())
            {

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM user";
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    user = new User();
                    user.id = Int32.Parse(dataReader["id"].ToString());
                    user.login = dataReader["login"].ToString();
                    user.password = dataReader["password"].ToString();
                    user.sex = (Sex)Enum.Parse(typeof(Sex), dataReader["sex"].ToString().ToUpper());
                    user.registrationTime = DateTime.Parse(dataReader["registration_time"].ToString());
                    user.email = dataReader["email"].ToString();
                    users.Add(user);
                }
                dataReader.Close();
            }
            return users;
        }
    }
}
