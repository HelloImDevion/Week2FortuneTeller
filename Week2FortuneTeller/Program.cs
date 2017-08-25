using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //Asking Question to collect information.
                Console.WriteLine("Please Enter Your First Name: ");
                string userFirstName = Console.ReadLine();
                Console.WriteLine("Please Enter Your Last name: ");
                string userLastName = Console.ReadLine();
                Console.WriteLine("Please Enter Your Age: ");
                int userAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter Your Birth Month As A Number: ");
                int userBirthMonth = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter A ROYGBIV color: (Enter Help If You Dont Know What ROYGBIV Is)");
                string userFavoriteColor = Console.ReadLine();

                // Making help no case sensitive.
                string needHelp = "Help";
                string theHelp = "Help".ToUpper();
                string wordHelp = "Help".ToLower();

                // Making help usable if typed in.
                if (userFavoriteColor == theHelp || userFavoriteColor == wordHelp || userFavoriteColor == needHelp)
                {
                    Console.WriteLine("Red");
                    Console.WriteLine("Orange");
                    Console.WriteLine("Yellow");
                    Console.WriteLine("Green");
                    Console.WriteLine("Blue");
                    Console.WriteLine("Indigo");
                    Console.WriteLine("Violet");

                    Console.WriteLine("Please Enter A ROYGBIV color: ");
                    userFavoriteColor = Console.ReadLine();
                }

                Console.WriteLine("Please Enter How Many Siblings You Have: ");
                int userNumberOfSiblings = int.Parse(Console.ReadLine());

                // The start of the ending sentence.
                Console.Write(userFirstName + " " + userLastName);

                //The next part of the ending sentence also the work for even or odd.
                if (userAge % 2 == 0)
                {
                    Console.Write(" will retire in 18 years with ");
                }
                else
                {
                    Console.Write(" will retire in 60 years with ");
                }

                // The next part of the ending sentence also the work for the diffrent birth months.
                if (userBirthMonth >= 1 && userBirthMonth <= 4)
                {
                    Console.Write("$300 in the bank, ");
                }
                else if (userBirthMonth >= 5 && userBirthMonth <= 8)
                {
                    Console.Write("$45,000 in the bank, ");
                }
                else if (userBirthMonth >= 9 && userBirthMonth <= 12)
                {
                    Console.Write("$10,000,000 in the bank, ");
                }
                else
                {
                    Console.Write("$0.00 in the bank, ");
                }

                // The next part in the final sentence also work for the different amount of siblings.
                if (userNumberOfSiblings < 0)
                {
                    Console.Write("a vacation home in the Trash Dump ");
                }
                else if (userNumberOfSiblings == 0)
                {
                    Console.Write("a vacation home in Australia ");
                }
                else if (userNumberOfSiblings == 1)
                {
                    Console.Write("a vacation home in China ");
                }
                else if (userNumberOfSiblings == 2)
                {
                    Console.Write("a vaction home in California ");
                }
                else if (userNumberOfSiblings == 3)
                {
                    Console.Write("a vacation home in Miami ");
                }
                else
                {
                    Console.Write("a vacation home in Mexico ");
                }

                // The Final part of the sentence also making the colors not case sensitive.
                if (userFavoriteColor == "Red".ToLower() || userFavoriteColor == "Red".ToUpper() || userFavoriteColor == "Red")
                {
                    Console.Write("and a Car.");
                }
                else if (userFavoriteColor == "Orange".ToLower() || userFavoriteColor == "Orange".ToUpper() || userFavoriteColor == "Orange")
                {
                    Console.Write("and a Bike.");
                }
                else if (userFavoriteColor == "Yellow".ToLower() || userFavoriteColor == "Yellow".ToUpper() || userFavoriteColor == "Yellow")
                {
                    Console.Write("and will Walk.");
                }
                else if (userFavoriteColor == "Green".ToLower() || userFavoriteColor == "Green".ToUpper() || userFavoriteColor == "Green")
                {
                    Console.Write("and a Jet.");
                }
                else if (userFavoriteColor == "Blue".ToLower() || userFavoriteColor == "Blue".ToUpper() || userFavoriteColor == "Blue")
                {
                    Console.Write("and a Boat.");
                }
                else if (userFavoriteColor == "Indigo".ToLower() || userFavoriteColor == "Indigo".ToUpper() || userFavoriteColor == "Indigo")
                {
                    Console.Write("and a Helicopter.");
                }
                else if (userFavoriteColor == "Violet".ToLower() || userFavoriteColor == "Violet".ToUpper() || userFavoriteColor == "Violet")
                {
                    Console.Write("and will fly with Super Powers.");
                }
            

             

            

            



        }
    }
}
