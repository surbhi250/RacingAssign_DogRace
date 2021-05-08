using Microsoft.VisualStudio.TestTools.UnitTesting;
using RacingAssign_DogRace;
using System;

namespace RacingAssign_DogRaceTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RunningGround rg = new RunningGround();
            if (rg.stp == 800)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }


        [TestMethod]
        public void TestMethod2()
        {
            RunningGround rg = new RunningGround();
            rg.step();
            if (rg.jump> 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
