using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_6
{
    internal class Program
    {
        private static object lastname;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter order:");
            int order = int.Parse(Console.ReadLine());

            string suffix;
            if (order % 100 >= 11 && order % 100 <= 13)
            {
                suffix = "th";
            }
            else
            {
                switch (order % 10)
                {
                    case 1:
                        suffix = "st";
                        break;
                    case 2:
                        suffix = "nd";
                        break;
                    case 3:
                        suffix = "rd";
                        break;
                    default:
                        suffix = "th";
                        break;
                }
            }

            
            string completeName = $"{name} {lastName} the {order}{suffix}";
            // While concating the first name and lastname I had just seperated the values of name and lastname by space.

            Console.WriteLine("The name without adding last name is : "+name);
            Console.WriteLine("The name after adding last name is : " + completeName);

            Console.WriteLine(completeName);
            Console.ReadLine();
        }
    }
}
