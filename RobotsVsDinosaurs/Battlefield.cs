using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace RobotsVsDinosaurs
{
    //member variables
    class Battlefield
    {
        Herd herd = new Herd();
        Fleet fleet = new Fleet();
        public int dinoDeaths;
        public int robotDeaths;
       


       

      
        //constructor
        public Battlefield()
        {
            this.dinoDeaths = 0;
            this.robotDeaths = 0;

        }


        //member methods 
        public void MainMenu()
        {
          
            Console.WriteLine("Welcome To Dinosaur's Vs. Robot's!");
            Console.WriteLine("Please enter your name");
            string playersName = Console.ReadLine();
            Console.WriteLine("Hello " + playersName + "\n" + "Enter: '1', for rules" + "\n" + "Enter: '2', to play" + "\n" + "Enter: '3', to quit" );
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
                    break;
                default:
                    Console.WriteLine("Error! Please try again");
                    MainMenu();
                    break;
            }
        }

        public void ReadTheRules()
        {
            Console.WriteLine("This is war! There are no rules!");
            MainMenu();

        }



        public void PlayThreeRounds()
        {
            Console.WriteLine("Let's get ready to rumble!!!" + "\n" + "Press 'enter' to begin");
            Console.ReadLine();

            while (fleet.robot.Count > 0 || herd.dinosaurs.Count > 0)
            {
                herd.dinosaurs[0].AttackRobot(fleet.robot[0]);
                fleet.robot[0].AttackDinosaur(herd.dinosaurs[0]);
               

                if (herd.dinosaurs[0].health <= 0)
                {
                    herd.dinosaurs.Remove(herd.dinosaurs[0]);
                    dinoDeaths++;
                   

                }
                else if (fleet.robot[0].health <= 0)
                {
                    fleet.robot.Remove(fleet.robot[0]);
                    robotDeaths++;
                }
                if(dinoDeaths == 3)
                {
                    Console.WriteLine("The entire herd of dinosaurs are extinct!");
                    Console.WriteLine("Game Over!");
                    break;
                }
                if(robotDeaths == 3)
                {
                    Console.WriteLine("I guess robots are not the future!");
                    Console.WriteLine("Game Over!");
                    break;
                }

            }
        }

       
            
        
    }

}
