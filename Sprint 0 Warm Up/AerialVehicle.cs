using System;

namespace Sprint_0_Warm_Up
{
    public abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }

        Engine Engine { get; set; }

        public bool isFlying { get; set; }

        public int MaxAltitude { get; set; }



        public AerialVehicle()
        {
            Engine engine = new Engine();
            this.Engine = engine;
        }

        public string About()
        {
            string about = this.Engine.About() + " and Current altitude is " + this.CurrentAltitude + " ft";

            return about;

        }

        public string TakeOff()
        {
            string takingoff;
            if (this.Engine.isStarted == true)
            {
                takingoff = "taking off";
                this.isFlying = true;


            }
            else
            {
                takingoff = " You need so start your engine first";
            }

            return takingoff;
        }

        public void StartEngine()
        {
            this.Engine.Start();

        }

        public void StopEngine()
        {
            this.Engine.Stop();
            this.isFlying = false;
        }

        public void FlyDown()
        {
            if (CurrentAltitude == 1000)
            {
                this.StopEngine();
                this.isFlying = false;
            }
            else if (CurrentAltitude < 1000)
            {
                Console.WriteLine("You will crash if you go this low.");
                this.isFlying = false;
            }
        }

        public void FlyDown(int howMuch)
        {
            if (this.CurrentAltitude == howMuch)
            {
                this.StopEngine();
                this.CurrentAltitude = this.CurrentAltitude - howMuch;
                this.isFlying = false;
                System.Console.WriteLine("Successful land");
            }
            else if (this.CurrentAltitude < howMuch)
            {
                Console.WriteLine("You will crash if you go this low.");
                this.isFlying = false;
            }
        }

        internal void FlyUp()
        {
            if (this.CurrentAltitude == this.MaxAltitude)
            {
                Console.WriteLine("You can't go this high");
            }
            else if (this.CurrentAltitude + 1000 > this.MaxAltitude)
            {
                Console.WriteLine("You can't go this high");
            }
            else if (this.CurrentAltitude < this.MaxAltitude)
            {
                this.CurrentAltitude = this.CurrentAltitude + 1000;
            }
        }

        internal void FlyUp(int HowMuch)
        {
            if (this.CurrentAltitude == this.MaxAltitude)
            {
                System.Console.WriteLine("You can't go this high!");
            }
            else if (this.CurrentAltitude + HowMuch > this.MaxAltitude)
            {
                System.Console.WriteLine("You can't go this high!");
            }
            else if (this.CurrentAltitude < this.MaxAltitude)
            {
                this.CurrentAltitude = this.CurrentAltitude + HowMuch;
            }
        }
    }
}