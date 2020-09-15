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



        //constructor
        public Dinosaur(string type)
        {
            this.type = type;
            this.health = 100;
            this.energy = 100;
            this.attackPower = 100;
        }
        //choices:Dino
        //Henry the T-Rex - attack power 95%, health 75%, energy 100%, weapons: 50-Cal rifle
        //if pl1 choice 1 attack power < p2 choice 2 attack power 


        //member methods

        //for loop around damage/attack
        //use dot notation to take away from health, energy and power...Dinosaur.health[i]
        //


        // As a developer, I want a Robot to have the ability to attack a Dinosaur and a Dinosaur to have the ability to attack a Robot on a Battlefield.




        public void AttackRobot(Robot anyRobot)
        {
            anyRobot.health = anyRobot.health - 25;
            anyRobot.powerLevel = anyRobot.powerLevel - 25;

        }
    }

}
