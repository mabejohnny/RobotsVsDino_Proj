using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    //member variables
    class Dinosaur
    {
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        public int robotDeaths;



        //constructor
        public Dinosaur(string type)
        {
            this.type = type;
            this.health = 100;
            this.energy = 100;
            this.attackPower = 100;
        }
     


        //member methods

      
        public void AttackRobot(Robot anyRobot)
        {
            for (int i = 0; i <3; i++)
            {
                anyRobot.health = anyRobot.health - 25;
                anyRobot.powerLevel = anyRobot.powerLevel - 10;

                if(anyRobot.health >= 0)
                {
                    Console.WriteLine(anyRobot + " down!");
                    robotDeaths++;
                }

            }
           

        }
    }

}
