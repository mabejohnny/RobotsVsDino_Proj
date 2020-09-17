using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{

    //member variables
    class Fleet
    {
        public List<Robot> robot;

        //public List<Weapon> weapons;


        //constructor
        public Fleet()
        {
            robot = new List<Robot>();
            robot.Add(new Robot("Joe", "AT-4 Rocket Launcher"));
            robot.Add(new Robot("Rob", "Fixed blade"));
            robot.Add(new Robot("Jen", "9MM Luger"));

            //weapons = new List<Weapon>();
            //weapons.Add(new Weapon("Beretta 9MM"));
            //weapons.Add(new Weapon("S&W AR-15"));
            //weapons.Add(new Weapon("AT-4 rocket"));
            //weapons.Add(new Weapon("M240-G"));

        }







        //member methods
        //public void ChooseWeaponType()
        //{
           
        //}



    }


}
