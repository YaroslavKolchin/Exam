﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project
{
    public class User
    {
        public User() { }
        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
