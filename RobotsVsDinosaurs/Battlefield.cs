using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace RobotsVsDinosaurs
{
    //member variables
    class Battlefield
    {
        Herd herd = new Herd();
        Fleet fleet = new Fleet();

        int robotDeaths;
        int dinoDeaths;

      
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
                    PlayThreeRounds();
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



        public void PlayThreeRounds()
        {
            Console.WriteLine("Let's get ready to rumble!!!" + "\n" + "Press 'enter' to begin");
            Console.ReadLine();
            herd.dinosaurs[0].AttackRobot(fleet.robot[0]);
            fleet.robot[0].AttackDinosaur(herd.dinosaurs[0]);

            if (robotDeaths >= 3)
            {
                Console.WriteLine("The robot fleet is all gone! Thanks for playing");

            }
            if (dinoDeaths >= 3)
            {
                Console.WriteLine("The dinosaur herd is all gone! Thanks for playing");
            }



        }

       
    }

}
