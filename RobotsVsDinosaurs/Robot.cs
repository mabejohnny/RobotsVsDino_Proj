﻿using System;
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


    }

}
