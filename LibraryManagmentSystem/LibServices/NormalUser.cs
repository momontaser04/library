using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.LibServices
{
    public class NormalUser : User
    {
        public NormalUser() : base("", "", "","") // قيم افتراضية فاضية
        {
        }
        public NormalUser(string Name, string Email, string PhoneNumber,string Password) : base(Name, Email, PhoneNumber,Password)
        {
        }

        public override void Menu()
        {
            Console.WriteLine("1. View Books");
            Console.WriteLine("2. Place Order");
            Console.WriteLine("3. Calculate Fine");
            Console.WriteLine("4. Exit");


        }
    }
}
