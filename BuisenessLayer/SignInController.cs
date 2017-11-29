using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;

namespace BuisenessLayer
{
    class SignInController
    {
        private UserService service = new UserService();
        private User user;


        public User signIn(String login, String password)
        {
            return service.getAll().FirstOrDefault(x=>(x.login.Equals(login)&&x.password.Equals(getHasedPassword(password))));
        }

        private String getHasedPassword(String password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
