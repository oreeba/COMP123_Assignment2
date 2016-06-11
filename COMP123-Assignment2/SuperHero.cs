
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
    public class SuperHero : Hero
    {
        //PRIVATE INSTANCE VARIABLES ******************************************************
        List<string> _superPowers = new List<string>();
        

        //PUBLIC PROPERTIES****************************************************************
        public List<string> SuperPowers
        {
            get { return this._superPowers; }
            set { this._superPowers = value; }
        }

        //CONSTRUCTOR **********************************************************************

        public SuperHero(string _name)
            : base(_name)
        {
            this.Name = _name;
            this._generateRandomPowers();
        }

        //PRIVATE METHODS*********************************************************************
        private void _generateRandomPowers()

        {
            Random RandomNum = new Random();
            SuperPowers.Add("Super Speed");
            SuperPowers.Add("Super Strength");
            SuperPowers.Add("Body Armour");
            SuperPowers.Add("Flight");
            SuperPowers.Add("Fire Generation");
            SuperPowers.Add("Weather Control");
          
        }

        //PUBLIC METHOD**************************************************************************

        public void ShowPowers()
        {
            Console.WriteLine("{0}", _superPowers);
        }
    }
}
    




    

