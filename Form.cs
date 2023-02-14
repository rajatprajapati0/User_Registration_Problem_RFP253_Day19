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
        
        public static string Email =@"^([a-z.?0-9]{3,}.?[@][a-z0-9]{1,}.(com.au|com.com|in|com|net)| [a-z 0-9]{3,}[@][a-z0-9]{1,}.(com.au|com.com|in|com|net)|[a-z.0-9]{3,}[@][a-z0-9]{1,}.(com.au|com.com|in|com|net)|[a-z0-9]{1,}.?[a-z0-9]{3,}[@][a-z]{3,}.(com|in|net)|[a-z.0-9]{3,}[@][a-z]{3,}.(com.au|com.com))$";


    }
    public class Form
    {
        public void form()
        {
            Regex name = new Regex(Pattern.Name);
            bool check= false;
            Console.WriteLine("\nFirst name starts with Cap and has minimum 3 characters");
            while (!check)
            {
                Console.Write("\nEnter your Name :");
                string userName = Console.ReadLine();
                check = name.IsMatch(userName);

                if (check==false)
                {
                    Console.WriteLine("\nplease follow - First name starts with Cap and has minimum 3 characters ");
                }
                else
                {
                    Console.WriteLine("\ndone"); 
                }

            }
            Regex lastname = new Regex(Pattern.LastName );
            check = false;
            Console.WriteLine("\nLast name starts with Cap and has minimum 3 characters");
            while (!check)
            {
                Console.Write("\nEnter your Last Name :");
                string userLastName = Console.ReadLine();
                check = lastname.IsMatch(userLastName);

                if (check==false)
                {
                    Console.WriteLine("\nplease follow - Last name starts with Cap and has minimum 3 characters ");
                }
                else
                {
                    Console.WriteLine("\ndone\n"); 
                }

            }

            Regex email = new Regex(Pattern.Email);
            bool check1 = false;
            
            while (!check1)
            {
                Console.Write("Enter your email :");
                string userEmail = Console.ReadLine();
                check1 = email.IsMatch(userEmail);

                if (check1 == false)
                {
                    Console.WriteLine("\nplease follow - please enter right email ");
                }
                else
                {
                    Console.WriteLine("done");
                }

            }



        }

    }
}
