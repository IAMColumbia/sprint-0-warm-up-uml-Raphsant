using Sprint_0_Warm_Up;
using System;
using System.Collections.Generic;
using System.Text;  
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sprint_one_test
{
    [TestClass]
    public class EngineTest
    {
        [TestMethod]
        public void EngineAbout()
        {
            //
            Engine testEngine = new Engine();
            string about = testEngine.About();
            Assert.AreEqual(about, testEngine + " engine is not started");
            //
            testEngine.Start();
            about = testEngine.About();
            Assert.AreEqual(about, testEngine + " engine is started");
            //

        }

        [TestMethod]

        public void EngineConstructorAbout()
        {
            Engine testEngine = new Engine(about: "testing parameter");
            Assert.AreEqual(testEngine.about, "testing parameter");
        }

        [TestMethod]

        public void EngineStart()
        {
            Engine testEngine = new Engine();
            Assert.AreEqual(testEngine.isStarted, false);
            //
            testEngine.Start();
             Assert.AreEqual(testEngine.isStarted, true);
            //
        
        }

        [TestMethod]

        public void EngineStop()
        {
            Engine testEngine = new Engine();
            Assert.AreEqual(testEngine.isStarted, false);
            //
            testEngine.Start();
             Assert.AreEqual(testEngine.isStarted, true);
            //
            testEngine.Stop();
            Assert.AreEqual(testEngine.isStarted, false);
            //  
        
        }
    }
}
