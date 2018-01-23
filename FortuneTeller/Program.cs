using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string roygbiv;
            int siblingsCount;
            string bankMoney;
            string vacationLocation = "Cleveland, OH";
            string transport = "Bad Color Choice";
            int retireAge = 0;


            //User Data Entry

            Console.WriteLine("Enter your first name, please.");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name, please.");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your age, numeric only please.");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birth month, numeric only, please.");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your favorite color, using ROYGBIV letters, please. If you don't know what ROYGBIV means, type \"help\". ");
            roygbiv = Console.ReadLine().ToLower();
            
            //help menu logic

            switch (roygbiv) 
            {
                case "help":
                    Console.WriteLine(" Select a favorite color from the following colors: Red, Orange, Yellow, Green, Blue, Indigo, Violet. Use just the first letter of each color's name.");
                    roygbiv = Console.ReadLine().ToLower();
                    break;

                default:

                    break;
            }

            //Resume data entry....

            Console.WriteLine("Enter the number of siblings you have, living or dead, numeric only, please.");
            siblingsCount = int.Parse(Console.ReadLine());

            //Application Logic starts here
            
            //Retirement Logic

            if (age % 2 == 1)
            {
                retireAge = 67 - age;
            }           
                else
                {
                retireAge = 70 - age;
                }

            //vacation home based on siblings count

            if (siblingsCount < 0)
            {
                vacationLocation = "Newark, NJ";
            }
            else if (siblingsCount == 0)
            {
                vacationLocation = "Aruba, Mexico";
            }
            else if (siblingsCount == 1)
            {
                vacationLocation = "Tampa Bay, FL";
            }
            else if (siblingsCount == 2)
            {
                vacationLocation = "Beaufort, SC";
            }
            else if (siblingsCount == 3)
            {
                vacationLocation = "Tybee Island, GA";
            }
            else if (siblingsCount > 3)
            {
                vacationLocation = "Jacksonville, FL";
            }


            //Color-based transportation...

            switch (roygbiv)
            { 
                case "r":

                transport = "Rocket";
                    break;

                case "o":

                transport = "Dodge Charger";
                    break;

                case "y":

                transport = "VW Beatle";
                    break;

                case "g":

                transport = "Glider";
                    break;

                case "b":

                transport = "Boat";
                    break;

                case "i":

                transport = "Interstellar Gate to jump into";
                    break;

                case "v":

                transport = "Velociraptor to ride";
                    break;

            default:

                break;
            }
            //money in bank based on birth month
            bankMoney = "$0.00";
            if ((birthMonth >= 1) && (birthMonth <= 4))
                        {
                        bankMoney = "$100";
                        }
                else if ((birthMonth >= 5) && (birthMonth <= 8))
                        {
                        bankMoney = "$200";
                        }
                else if ((birthMonth >= 9) && (birthMonth <= 12))
                        {
                        bankMoney = "$300";
                        }
                else if (birthMonth > 12)
                        {
                        bankMoney = "$00.00";
                        }
                    

                //Fortune Presented
                Console.WriteLine(firstName + " " + lastName + " will retire in " + retireAge + " years with " + bankMoney + " in the bank, a vacation home in " + vacationLocation + " and a " + transport + ".");
                
                //END OF LINE, program!
        }
    }
}
