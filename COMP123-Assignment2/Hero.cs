using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Program Name: The Hero Class (Assignment 1)
 *Student Name: Oreeba Badar
 *Student ID: 300735072
 *Last Date Modified: 2016-06-03
 *Program Description: Create a Hero class with the private instance variables: strength, speed, health and name. The program assign's a random 
 *                     number between 1 and 100 to the abilities (strength, speed, health). Depending on the hero's attempt to hit, the program
 *                     will display the hero's damage caused. The program will then display the hero's ability scroes to the console.
 *                     determine the damage if hero hits the target and display appropriate messages to the 
 *                     console.
 *GitHub: https://github.com/oreeba/COMP123-Assignment1.git                                          
 */


namespace COMP123_Assignment1
{
    class Hero
    {
        //PRIVATE INSTANCE VARIABLES ***************************************************

        private int _strength;
        private int _speed;
        private int _health;
        private string _name;
        private int _rdnum;

        //PUBLIC PROPERTIES ***********************************************************

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }

        }


        //CONSTRUCTOR METHOD************************************************************

        public Hero(string name)
        {
            this.Name = _name;  // Pass the this.Name value to the private _name variable
            _generateAbilities();
        }

        //PRIVATE METHODS*****************************************************************

        private void _generateAbilities()
        {
            //This Generates random numbers of strength, speed & health between 1 to 100

            Random rnum = new Random();
            this._strength = rnum.Next(1, 100);


            Random speed = new Random();
            this._speed = rnum.Next(1, 100);


            Random health = new Random();
            this._health = rnum.Next(1, 100);
        
        }


        private bool _hitAttempt()
        {
            Random rdnum = new Random();


            this._rdnum = rdnum.Next(1, 100);


            if (this._rdnum >= 1 && this._rdnum <= 20) //Method randomly determines if the hero hits, only 20% of the time
            {
                Console.WriteLine("Hero hit! :D ");
                return true;
            }
            else // if not, will return false.
            {
                Console.WriteLine("Hero did not hit! ");
                
                return false;
            }
        }


        private int _hitDamage()
        {

            Random rdnum = new Random();

            this._rdnum = rdnum.Next(1, 6);
            int damage = this._strength * this._rdnum; // multiply the strength by a number between 1-6 to calculate Hero's Damage
            
            return damage;

        }


        //PUBLIC METHODS********************************************************************

        public void Fight()
        {
            if (_hitAttempt()==true) // If _hitAttempt() returns true, then it will call the _hitDamage() method
            {
                int damage = _hitDamage();
                Console.WriteLine("--------The damage caused is: {0}--------", damage);// damage will be displayed in the console
            }
        }


        public void Show() //	display	the	Hero’s ability scores
        {
            Console.WriteLine("\n^^^^^^^^^Hero's Ability Scores^^^^^^^^\n");
            Console.WriteLine("************************************");
            Console.WriteLine("*--------Strength: {0}--------------*", this._strength);
            Console.WriteLine("*--------Speed: {0}-----------------*", this._speed);
            Console.WriteLine("*--------Health: {0}----------------*", this._health);
            Console.WriteLine("************************************");
        }

    }
}