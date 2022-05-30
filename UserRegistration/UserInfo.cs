﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserInfo
    {
        public const string fname = "^[A-Z]{1}[A-Za-z]{2,}$";
        public void FirstName()
        {
            Regex reg = new Regex(fname);
            Console.WriteLine("Enter the first name:");
            string input = Console.ReadLine();
            if(reg.IsMatch(input))
            {
                Console.WriteLine("First Name is Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
        }
    }
}