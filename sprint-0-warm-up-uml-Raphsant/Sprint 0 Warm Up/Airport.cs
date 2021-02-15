using System;
using System.Collections.Generic;

namespace Sprint_0_Warm_Up
{

    public class Airport
    {

        public int MaxVehicles;
        public List<AerialVehicle> Vehicles;

        public string AirportCode { get; set; }

        public Airport(string Code)
        {
            this.AirportCode = Code;


        }

        public Airport(string Code, int MaxVehicles)
        {
            this.AirportCode = Code;
            this.MaxVehicles = MaxVehicles;
        }

        public string AllTakeOff()
        {
            foreach (AerialVehicle a in Vehicles)
            {
                TakeOff(a);
            }
            return "All planes took off";

        }

        public string Land(AerialVehicle a)
        {
            a.FlyDown(a.CurrentAltitude);
            a.StopEngine();
            string land = $"{a} has just landed";
            return land;
        }

        public string Land(List<AerialVehicle> landing)
        {
            string returnString = "";

            foreach (AerialVehicle b in landing)
            {
                Land(b);
                returnString += $"{b} has landed \n ";
            }

            return "Landing Successful";




        }

        public string TakeOff(AerialVehicle a)
        {
            a.StartEngine();
            a.TakeOff();

            return $"{a} is taking off";
        }





    }









}
