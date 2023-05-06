using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bobject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();

            UserObject userObj = new UserObject();//This is for Buisness Object
            userObj.FirstName = "Niraj";
            userObj.LastName = "Tiwari";
            userObj.Gender = "Gender";
            userObj.Country = "India";
            obj.saveUser(userObj);
        }

        public void saveUser(UserObject userObj)
        {
            Console.WriteLine(userObj.FirstName);
            Console.WriteLine(userObj.LastName);
            Console.WriteLine(userObj.Gender);
            Console.WriteLine(userObj.Country);
            Console.ReadLine();
        }
    }

    public class UserObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
    }
}
