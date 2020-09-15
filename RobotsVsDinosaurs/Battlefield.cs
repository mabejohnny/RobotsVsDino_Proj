using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace RobotsVsDinosaurs
{
    //member variables
    class Battlefield
    {


        //constructor
        public Battlefield()
        {

        }





        //member methods 
        public void MainMenu()
        {
            Console.WriteLine("Welcome To Dinosaur's Vs. Robot's!");
            Console.WriteLine("Please enter your name");
            string playersName = Console.ReadLine();
            Console.WriteLine("Hello " + playersName + "\n" + "Enter: '1', for rules" + "\n" + "Enter: 2, to play" + "\n" + "Enter: 3, to quit" );
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    ReadTheRules();
                    break;

                case "2":
                    PlayTheGame();
                    break;

                case "3":
                    MainMenu();
                    break;

                default:
                    break;
            }
        }

        public void ReadTheRules()
        {

        }



        public void PlayTheGame()
        {

        }
    }

}
