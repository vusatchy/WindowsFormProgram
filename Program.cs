using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Threading.Tasks;
using Entities;
using Services;
using DAL;
using BuisenessLayer;
using System.Text.RegularExpressions;
using DAL.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DALTask
{
    class Program
    {

        static String menu = "1.Sign in" + "\n" + "2.Registrate user" + "\n" + "3.Reset password" + "\n" + "4.Read feedbacks" + "\n" + "5.Exit";
        static String sessionMenu = "1.Leave feedback" + "\n" + "2.Change password" + "\n" + "3.Read my feedbacks" + "\n" + "4.Read feedbacks" + "\n" + "5.Log out";
        static UserService service = new UserService(); 
       /* static void Main(string[] args)
        {
            bool exit=false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine(menu);
                Console.WriteLine();
                Console.Write("Value:");
                 int number = int.Parse(Console.ReadLine());
                User user;
                switch (number)
                {
                    case (1):
                        Console.Clear();
                        signInAndSession();
                        break;
                    case (2):
                        Console.Clear();
                        registerUser();
                        Console.Clear();
                        Console.WriteLine("Registration completed!");
                        break;
                    case(3):
                        resetPassword();
                        Console.WriteLine("New password was sent on your email");
                        break;
                    case (4):
                        Console.Clear();
                        printFeedbacks();
                        break;
                    case (5):
                        exit = true;
                        break;
                }
               
            }
        }*/
        [STAThread]
        static void Main()
        {  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DAL.Forms.MainMenu());
         
        }


        public static void printFeedbacks()
        {
            NotRegisteredUserController userController = new NotRegisteredUserController();
            Console.WriteLine("Result:");
            foreach (Feedback feedback in userController.getAllFeedbacks())
            {
                Console.WriteLine("User:" + feedback.user.login + "\nProduct:" + feedback.product.name + "\nComment:" + feedback.comment + "\nDate:" + feedback.date+"\n");
            }
        }

        public static void resetPassword()
        {
             PasswordReset reset = new PasswordReset();
             Console.Clear();
             Console.Write("Input your e-mail:");
             String email=Console.ReadLine();
             bool valid=reset.resetPasswordViaEmail(email);
             while (!valid)
             {
                 Console.Clear();
                 Console.WriteLine("Invalid email!");
                 Console.WriteLine("1.Try again" + "\n2.Exit");
                 Console.Write("Value:");
                 int number = int.Parse(Console.ReadLine());
                 if (number == 1)
                 {
                     Console.Clear();
                     Console.Write("Input your e-mail:");
                     email = Console.ReadLine();
                     valid = reset.resetPasswordViaEmail(email);
                 }
                 if (number == 2)
                 {
                     break;
                 }
             }
        }

        public static void registerUser()
        {
            RegistrationController registration = new RegistrationController();
            bool isValid=false;
            User user = new User();
            Console.Write("Input login:");
            String login = Console.ReadLine();
            while(registration.isAlreadyExistLogin(login)){
                    Console.Clear();
                    Console.WriteLine("Login '"+login+"' is already exist");
                    Console.Write("Input login:");
                    login = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Input login:"+login);
            Console.Write("Input gender:");
            string ss = Console.ReadLine();
            Sex sex= (Sex)Enum.Parse(typeof(Sex), ss.ToString().ToUpper());
            Console.Write("Input email:");
            String email = Console.ReadLine();
            while (!registration.isValidEmail(email) && registration.isAlreadyExistEmail(email))
            {
                    Console.Clear();
                    Console.WriteLine("Invalid e-mail or already exist!");
                    Console.WriteLine("Input login:" + login);
                    Console.WriteLine("Input gender:"+sex.ToString().ToLower());
                    Console.Write("Input email:");
                    email = Console.ReadLine();
            }
            Console.Write("Password:");
            String password = hideCharacter();
            while (!registration.isValidPassword(password))
            {
                Console.Clear();
                Console.WriteLine("Invalid password!");
                Console.WriteLine("Input login:" + login);
                Console.WriteLine("Input gender:" + sex.ToString().ToLower());
                Console.WriteLine("Input email:"+email);
                Console.Write("Password:");
                password = hideCharacter();
                Console.WriteLine();
                
            }
            user.login = login;
            user.sex = sex;
            user.password = password;
            user.email = email;
            user.registrationTime = DateTime.Now;
            registration.registerUser(user);

            
        }

        public static void signInAndSession()
        {
            SignInController signIn = new SignInController();
            Console.Write("Input login:");
            String login = Console.ReadLine();
            Console.Write("Input password:");
            String password = hideCharacter();
            User user = signIn.signIn(login, password);
            while (user == null)
            {
                Console.Clear();
                Console.WriteLine("Invalid login or password!");
                Console.WriteLine("1.Try again"+"\n2.Exit");
                Console.Write("Value:");
                int number = int.Parse(Console.ReadLine());
                if (number == 1)
                {
                    Console.Clear();
                    Console.Write("Input login:");
                    login = Console.ReadLine();
                    Console.Write("Input password:");
                    password = hideCharacter();
                    user = signIn.signIn(login, password);
                }
                if (number == 2)
                {
                    break;
                }
            }
            Console.WriteLine();
            Session session = new Session(user);
            bool exit=false;
            Console.Clear();
            while(!exit){
                Console.Write(sessionMenu);
                Console.Write("\nValue:");
                int number=int.Parse(Console.ReadLine());
                switch (number)
                {
                    case(1):
                        Console.Clear();
                        foreach (Product product in session.getAllProducts())
                        {
                            Console.WriteLine("Id:" + product.id + "\nName:" + product.name + "\nPrice:" + product.price+"\n");
                        }
                        Console.Write("Input product id:");
                        int pid=int.Parse(Console.ReadLine());
                        Console.Write("Comment:");
                        String comment = Console.ReadLine();
                        session.leaveFeedback(pid,comment);
                        break;
                    case (2):
                        Console.Clear();
                        Console.Write("Input password:");
                        String pass=hideCharacter();
                        session.changePassword(pass);
                        break;
                    case (3):
                        Console.Clear();
                        foreach (Feedback feedback in session.getMyFeedbacks())
                        {
                            Console.WriteLine("User:" + feedback.user.login + "\nProduct:" + feedback.product.name + "\nComment:" + feedback.comment + "\nDate:" + feedback.date + "\n");
                        }
                        break;
                    case (4):
                        Console.Clear();
                        printFeedbacks();
                        break;
                    case (5):
                        exit = true;
                        break;
                }
            }
         
            

        }

        public static string hideCharacter()
        {
            ConsoleKeyInfo key;
            SecureString pass = new SecureString();
        
            do
            {
                key = Console.ReadKey(true);
                if(!char.IsControl(key.KeyChar))
                {
                    Console.Write("*");
                    pass.AppendChar(key.KeyChar);
                }
                else if(key.Key==ConsoleKey.Backspace &&pass.Length>0)
                {
                    pass.RemoveAt(pass.Length - 1);
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);

            return  new System.Net.NetworkCredential(string.Empty, pass).Password;

        }

    }
}
