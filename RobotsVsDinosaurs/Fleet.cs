using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{

    //member variables
    class Fleet
    {
        public List<Robot> robot;
       

        //constructor
        public Fleet()
        {
            robot = new List<Robot>();
            robot.Add(new Robot("Joe", "Lazer Gun"));
            robot.Add(new Robot("Rob", "Knife"));
            robot.Add(new Robot("Jen", "Grenade"));

        }







        //member methods




    }


}
