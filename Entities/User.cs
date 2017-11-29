using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum Sex
    {
        MALE,FEMALE
    }

    public class User
    {
        public int id { get;set;}
        public String login { get; set; }
        public String password { get; set; }
        public Sex sex { get; set; }
        public DateTime registrationTime { get; set; }
        public String email { get; set; }

        public override String ToString()
        {
            return "id= " + id + " name=" + login.ToString() +" password="+password + " sex=" + sex.ToString().ToLower() + "  data=" + registrationTime.ToString()+" email="+email;
        }
    }
}
