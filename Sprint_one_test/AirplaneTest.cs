using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;
using System;
using System.Collections.Generic;
using System.Text;  

namespace Sprint_one_test
{
    [TestClass]
    public class AirplaneTest   
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Set-up
            Airplane plane = new Airplane();

            // Test about method, Plane is in the ground.
            Assert.AreEqual(plane.About(), plane.Engine.About() + " and Current altitude is " + plane.CurrentAltitude + " ft");
            
            
        }

        [TestMethod]
        public void TakeOffTest()
        {
            Airplane plane = new Airplane();

            //no Engine started 

            Assert.AreEqual(plane.TakeOff(), " You need so start your engine first");

            // Start engine and test

            plane.StartEngine();
            Assert.AreEqual(plane.TakeOff(), "taking off");
        }

        [TestMethod]

        public void FlyingUpTest()
        {
            Airplane plane = new Airplane();
            //initial flyUp when currentAltitude is 0
            plane.CurrentAltitude = 0;
            plane.FlyUp();
            Assert.AreEqual(plane.CurrentAltitude, 1000);
            //FlyUp when the plane can't go higher, currentAltitude shouldn't change.
            plane.CurrentAltitude = plane.MaxAltitude;
            plane.FlyUp();
            Assert.AreEqual(plane.CurrentAltitude, plane.MaxAltitude);


        }

        [TestMethod]
        public void FlyingDownTest()
        {
            Airplane plane = new Airplane();
            plane.StartEngine();
            plane.TakeOff();
            plane.FlyUp(5000);
            plane.FlyDown(1);            
            Assert.AreEqual(plane.CurrentAltitude, 4999);
            plane.FlyDown(6000);
            Assert.AreEqual(plane.CurrentAltitude, 4999);
            plane.FlyDown(4999);
            Assert.AreEqual(plane.isFlying, false);

        }

        [TestMethod]

        public void StopEngineTest()
        {
            Airplane plane = new Airplane();
            Assert.AreEqual(plane.Engine.isStarted, false);
            plane.StartEngine();
            Assert.AreEqual(plane.Engine.isStarted, true);

        }
    }
}
