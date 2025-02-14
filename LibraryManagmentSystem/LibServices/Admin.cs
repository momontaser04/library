using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.LibServices
{

    public class Admin : User
    {
        public Admin() : base("", "", "","") // قيم افتراضية فاضية
        {
        }
        public Admin(string Name, string Email, string PhoneNumber,string Password) : base(Name, Email, PhoneNumber, Password)
        {
        }

        public override void Menu()
        {
            Console.WriteLine("1. View Books");
            Console.WriteLine("2. Add Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. View Orders");
            Console.WriteLine("5. Exit");
     
        }
    }
}
