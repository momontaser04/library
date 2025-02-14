using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.LibServices
{
    public class Database
    {
        List<User> Users = new List<User>();
        List<string> UserNames = new List<string>();
        public void AddUser(User user)
        {
            Users.Add(user);
            UserNames.Add(user.GetName());
        }
        public int Login(string Email, string password)
        {
            int n = -1;
            foreach (User user in Users)
            {
                if(user.GetEmail() == Email && user.GetPassword()==password) {


                    n = Users.IndexOf(user); 

                    break;
                
                }
            }
            return n;

        }





        public User GetUser(int id)
        {
            return Users[id];
        }





    }
}
