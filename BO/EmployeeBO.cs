﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPE;

namespace BO
{
    public class EmployeeBO:IEmployeeBO
    {
        private string username;
        private string password;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return username;
            }
            set
            {
                password = value;
            }
        }
        public EmployeeBO (string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
