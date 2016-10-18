using System;
using System.Linq;
using System.Collections.Generic;

namespace MakeJumps
{
    public class Program
    {
        public const string quitSymbol = "Q";
        public static void Main(string[] args)
        {
            string[] RANDOMS = {"a", "b", "c"};
            string[] A_BLOCKS = {"2", "4"};
            Category category;
            string categoryInput = "AAA";
            categoryInput = askForCategory();
            switch (categoryInput.ToUpper())
            {
                case "R":
                    category = new Rookie();
                    break;
                case "A":
                    category = new Intermediate();
                    break;
                case "AA":
                    category = new DoubleA();
                    break;
                case "AAA":
                    category = new Open();
                    break;
                default:
                    return;
            }

            Console.WriteLine("Category: " + category.getName());
            category.getFormations().ForEach(delegate(string form)
            {
                Console.Write(form);
            });
            Console.WriteLine("");
            Console.WriteLine("Draw:");
            category.getDraw().ForEach(delegate(Jump jump)
            {
                Console.WriteLine("New jump:");
                Console.Write(jump.printJump());
                Console.WriteLine("");
            });
        }

        private static string askForCategory()
        {
            Console.WriteLine("Please give category");
            Console.WriteLine("R/A/AA/AAA/Q=quit");
            string category = Console.ReadLine();
            //string category = "R";
            switch (category.ToUpper())
            {
                case "R":
                case "A":
                case "AA":
                case "AAA":
                    Console.WriteLine("Thank you!");
                    return category.ToUpper();
                case "Q":
                    Console.WriteLine("Quitting");
                    return quitSymbol;
                default:
                    Console.WriteLine("incorrect category");
                    return quitSymbol;
            }
        }
    }
}
