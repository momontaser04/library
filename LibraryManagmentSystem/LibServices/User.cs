using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.LibServices
{
    public abstract class User
    {
        public string Name {  get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Name,string Email,string PhoneNumber,string Password)
        {
            this.Name = Name;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Password = Password;

        }
        public string GetName() { return Name; }
        public string GetEmail() { return Email; }
        public string GetPhoneNumber() { return PhoneNumber; }
        public string GetPassword() { return Password; }

        abstract public void Menu();


    }
}
