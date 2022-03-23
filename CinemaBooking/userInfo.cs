using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking
{
    public class userInfo
    {
        private string firstName;
        private string lastName;
        private string fullName;
        private string username;
        private string password;
        private double balance;
        private string greetings, returnGreet;

        //replace the value of your connection string here
        public static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\CinemaBooking\CinemaBooking\Database.mdf;Integrated Security=True";

        //Default Constructor
        public userInfo()
        {
            firstName = "";
            lastName = "";
            fullName = "";
            username = "";
            password = "";
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = capital(value); }
        }
        
        public string LastName
        {
            get{ return lastName;}
            set { lastName = capital(value); }
        }
        public string WholeName
        {
            get { return fullName; }
            set { fullName = capital(value); }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public string Greetings
        {
            get { return greetings; }
            set { greetings = value;
                greet();
            }
        }
        public string ReturnGreet
        {
            get { return returnGreet; }
        }
        public  static string capital(string a)
        {
            return a.ToUpper();
        }
        public void greet()
        {
            returnGreet = "Welcome to Eye-Max Cinema Booking app " + greetings;
        }
        public static string connectionString()
        {
            return connection;   
        }
    }
    class hello: userInfo
    {
        public string greet()
        {
            return "Welcome back Admin!";
        }
    }

}
