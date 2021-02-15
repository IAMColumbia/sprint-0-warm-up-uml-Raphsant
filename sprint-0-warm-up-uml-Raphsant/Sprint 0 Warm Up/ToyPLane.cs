using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class ToyPlane : Airplane
    {
        public bool isWoundUp;

        public ToyPlane()
        {
            MaxAltitude = 50;
        }



        public string getWindUpString()
        {
            if (this.isWoundUp == true)
            {
                return $"{this} is wound up.";
            }
            else
            {
                return $"{this} is not wound up.";
            }
        }

        public void StartEngine()
        {
            if (this.isWoundUp == true) this.Engine.Start();
            else Console.WriteLine("You need to wind up the engine!");

        }

        public string TakeOff()
        {
            if (this.Engine.isStarted == true)
            {
                this.FlyUp(50);
                this.isFlying = true;
                return "You are flying";
            }
            else return "You need to start the engine!";
        }

        public void unWind()
        {
            this.isWoundUp = false;
        }

        public void windUp()
        {
            this.isWoundUp = true;
        }
    }
}
