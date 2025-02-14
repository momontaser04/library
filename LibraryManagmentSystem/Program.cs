using LibraryManagmentSystem.LibServices;
using System.Threading.Channels;

namespace LibraryManagmentSystem
{
    internal class Program
    {
        public static Database database;
        static void Main(string[] args)
        {
            database = new Database();
            int n;
            Console.WriteLine("Welcome To Library Managment System ");

            do {

                Console.WriteLine("0.Exit\n1.Login\n2.NewUser");

                int ChoiceNum = int.Parse(Console.ReadLine());
                n= ChoiceNum;
                switch (n)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        NewUser();
                        break;
                    default: throw new Exception("Invalid choice. Please enter a valid number.");
                }
            }
            while (n != 0) ;





          




        }
        private static void Login()
        {

            Console.WriteLine("Enter Your Email ");
            string UserEmail = Console.ReadLine();
            Console.WriteLine("Enter Your Password");
            string Password = Console.ReadLine();
            int n=database.Login(UserEmail, Password);
            if (n != -1)
            {
                User user=database.GetUser(n);
                Console.WriteLine("Welcome "+user.GetName());
                user.Menu();
            }
            else
            {
                 Console.WriteLine("User doesn't Exist!"); ;
            }

        }

        private static void NewUser()
        {

            Console.WriteLine("Enter Your Email ");
            string UserEmail = Console.ReadLine();
            Console.WriteLine("Enter Your Name ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter Your Phone ");
            string UserPhone = Console.ReadLine();
            Console.WriteLine("Enter Your Password");
            string Password = Console.ReadLine();

            Console.WriteLine("1.Admin \n2.NormalUser");
            int UserIdentityt = int.Parse(Console.ReadLine());
            User user;
            if (UserIdentityt == 1)
            {
                user = new Admin { 
                
                Email=UserEmail,
                    Password=Password,
                    Name=UserName,
                    PhoneNumber=UserPhone
                
                };
                database.AddUser(user);

            }
            else
            {
                user = new NormalUser
                {
                    Email = UserEmail,
                    Password = Password,
                    Name = UserName,
                    PhoneNumber = UserPhone,

                };
                database.AddUser(user);
            }
            user.Menu();

            

        }
    } }
    

