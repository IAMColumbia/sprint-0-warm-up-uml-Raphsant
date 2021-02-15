using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;
using System;
using System.Collections.Generic;
using System.Text;  


namespace Sprint_one_test
{
    [TestClass]
    public class ToyPlaneTest
    {
        [TestMethod]
        public void WindUpTest()
        {
            ToyPlane toy = new ToyPlane();
            //isWoundUp = false
            string isWoundUpString = toy.getWindUpString();
            Assert.AreEqual(isWoundUpString, $"{toy} is not wound up.");
            //isWoundUp = true;
            toy.windUp();
            isWoundUpString = toy.getWindUpString();
            Assert.AreEqual(isWoundUpString, $"{toy} is wound up.");
            
        }

        [TestMethod]

        public void UnwindTest()
        {
            ToyPlane toy = new ToyPlane();
            //isWoundUp = true
            toy.windUp();
            string isWoundUpString = toy.getWindUpString();
            Assert.AreEqual(isWoundUpString, $"{toy} is wound up.");
            //isWoundUp = false
            toy.unWind();
            isWoundUpString = toy.getWindUpString();
            Assert.AreEqual(isWoundUpString, $"{toy} is not wound up.");
        }

        [TestMethod]

        public void TakeOffTest()
        {   
            //
            ToyPlane toy = new ToyPlane();
            string TakeOffString = toy.TakeOff();
            Assert.AreEqual(TakeOffString, "You need to start the engine!");  
            //          
            toy.windUp();
            toy.StartEngine();
            toy.TakeOff();
            TakeOffString = toy.TakeOff();
            Assert.AreEqual(TakeOffString, "You are flying");
            //
        }

        [TestMethod]

        public void StartEngineTest()
        {
            //
            ToyPlane toy = new ToyPlane();
            toy.StartEngine();
            Assert.AreEqual(toy.Engine.isStarted, false);
            //
            toy.windUp();
            toy.StartEngine();
            Assert.AreEqual(toy.Engine.isStarted, true);
        }
    }
}
