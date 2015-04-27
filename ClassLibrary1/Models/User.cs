using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public Role Role { get; set; }
       // public string Locale { get; set; }
       // public TimeSpan TimeZone { get; set; }

        public User(int userId, string login, string password, string firstName,
            string lastName, DateTimeOffset registrationDate/*, Role role, string locale, TimeSpan timeZone*/)
        {
            this.UserId = userId;
            this.Login = login;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.RegistrationDate = registrationDate;
            //this.Role = role;
            //this.Locale = locale;
           // this.TimeZone = timeZone;
        }


    }
}
