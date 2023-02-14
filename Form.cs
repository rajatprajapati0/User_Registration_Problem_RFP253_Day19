using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Pattern 
    {
        public static string Name = "^[A-Z][a-z]{2,}$";
        public static string LastName = "^[A-Z][a-z]{2,}$";
    }
    public class Form
    {
        public void form()
        {
            Regex name = new Regex(Pattern.Name);
            bool check= false;
            Console.WriteLine("First name starts with Cap and has minimum 3 characters");
            while (!check)
            {
                Console.Write("Enter your Name :");
                string userName = Console.ReadLine();
                check = name.IsMatch(userName);

                if (check==false)
                {
                    Console.WriteLine("\nplease follow - First name starts with Cap and has minimum 3 characters ");
                }
                else
                {
                    Console.WriteLine("done"); 
                }

            }
            Regex lastname = new Regex(Pattern.Name);
            check = false;
            Console.WriteLine("Last name starts with Cap and has minimum 3 characters");
            while (!check)
            {
                Console.Write("Enter your Last Name :");
                string userLastName = Console.ReadLine();
                check = lastname.IsMatch(userLastName);

                if (check==false)
                {
                    Console.WriteLine("\nplease follow - Last name starts with Cap and has minimum 3 characters ");
                }
                else
                {
                    Console.WriteLine("done"); 
                }

            }                        



        }

    }
}
