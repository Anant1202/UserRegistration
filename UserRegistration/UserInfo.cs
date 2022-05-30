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
        public const string lname = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string email = @"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$";
        public void FirstName()
        {
            Regex reg = new Regex(fname);
            Console.WriteLine("Enter the first name:");
            string input = Console.ReadLine();
            if (reg.IsMatch(input))
            {
                Console.WriteLine("First Name is Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
        }
        public void LastName()
        {
            Regex reg = new Regex(lname);
            Console.WriteLine("\nEnter the Last name:");
            string last = Console.ReadLine();
            if (reg.IsMatch(last))
            {
                Console.WriteLine("Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
        }
        public void EmailID()
        {
            Regex reg = new Regex(email);
            Console.WriteLine("\nEnter the Email Id:");
            string eId = Console.ReadLine();
            if (reg.IsMatch(eId))
            {
                Console.WriteLine("Email id is Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
        }
    }
}
