﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
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
        public string Locale { get; set; }
        public TimeSpan TimeZone { get; set; }



    }
}
