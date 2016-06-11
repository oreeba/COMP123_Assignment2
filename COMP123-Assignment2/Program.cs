
using COMP123_Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
*Program Name: The Super Hero Class (Assignment 2)
*Student Name: Oreeba Badar
*Student ID: 300735072
*Last Date Modified: 2016-06-10
*Program Description: Based on the Hero Class, program randomly generates 3 random superpowers from the list
*                     of powers, and outputs it to the user 
*GitHub: https://github.com/oreeba/COMP123_Assignment2.git                     
* 
*/
namespace COMP123_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

       

            //NEW INSTANCE OF SUPER HERO
            SuperHero Oreeba = new SuperHero("Oreeba");
                       
            Oreeba.Show();
            Oreeba.ShowPowers();
            Oreeba.Fight();


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();



        }
    }
}
