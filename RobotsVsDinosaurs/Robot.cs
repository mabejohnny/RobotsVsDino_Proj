using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{ 
    class Robot
    {    //member variables 
        public string name;
        public int health;
        public int powerLevel;
        public string weaponType;
        public int attackPower;
        public int dinoDeaths;


        //constructor
        public Robot(string name, string weaponType)
        {
            this.name = name;
            this.health = 100;
            this.powerLevel = 100;
            this.weaponType = weaponType;
            this.attackPower = 100;

        }



        //member methods
        public void AttackDinosaur(Dinosaur anyDino)
        {
            for (int i = 0; i < 3; i++)
            {
                anyDino.health = anyDino.health - 25;
                anyDino.attackPower = anyDino.attackPower - 10;
                anyDino.energy = anyDino.energy - 10;

                if (anyDino.health >= 0)
                {
                    Console.WriteLine(anyDino + " down!");
                    dinoDeaths++;
                }
                else
                {
                    Console.WriteLine("No dinosaurs were killed!");

                }
                    

            }
         

        }

    }

}
