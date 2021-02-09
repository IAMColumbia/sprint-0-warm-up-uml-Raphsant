using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class ToyPlane : Airplane
    {
        public bool isWoundUp;

        public ToyPlane()
        {
            MaxAltitude = 50;
        }


        public string About()
        {
            return $"{this}";
        }

        public string getWindUpString()
        {
            return "wind up";
        }

        public void StartEngine()
        {
            if (this.isWoundUp == true) this.StartEngine();
            else Console.WriteLine("You need to wind up the engine!");

        }

        public string TakeOff()
        {
            if (this.Engine.isStarted == true)
            {
                this.FlyUp(50);
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
            this.isFlying = true;
        }
    }
}
