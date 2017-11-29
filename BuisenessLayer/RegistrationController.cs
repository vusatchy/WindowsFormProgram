using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;
using System.Text.RegularExpressions;

namespace BuisenessLayer
{
    class RegistrationController
    {
        private UserService service = new UserService();
        private const String emailPattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
        private const String passwordPattern =@"^(?=(.*\d){2})(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z\d]).{8,}$";

        public void registerUser(User user){

            

            user.password = getHasedPassword(user.password);
            service.add(user);

           
        }

        public bool isValidEmail(String email)
        {
            return Regex.IsMatch(email,emailPattern);
        }

          public bool isValidPassword(String password)
        {
            Regex len = new Regex("^.{8,}$");
            Regex num = new Regex("\\d");
            Regex alpha = new Regex("\\D");
            if (len.IsMatch(password) && num.IsMatch(password) && alpha.IsMatch(password))
            {
                return true;
            }
            return false;
        }

        public bool isAlreadyExistLogin(String login){
            return service.getAll().Exists(x=>x.login.Equals(login));
        }
        public bool isAlreadyExistEmail(String email)
        {
            return service.getAll().Exists(x => x.email.Equals(email));
        }

        private String getHasedPassword(String password){
             var bytes = new UTF8Encoding().GetBytes(password);
             var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
             return Convert.ToBase64String(hashBytes);
        }

    }
}
