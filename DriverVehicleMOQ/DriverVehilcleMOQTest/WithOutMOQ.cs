using System;
using DriverVehicleMOQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DriverVehilcleMOQTest
{
    [TestClass]
    public class WithOutMOQ
    {
        [TestMethod]
        public void Can_Evade_Trouble()
        {
            // Arrange (set up a scenario)
            FakeVehicle fakeVehicle = new FakeVehicle();
            Driver target = new Driver(fakeVehicle);

            // Act (attempt the operation)
            bool success = target.EvasiveManeuvers(false);

            // Assert (verify the result)
            Assert.IsTrue(success);
            Assert.IsTrue(fakeVehicle.CalledHonkHorn == 0);
            Assert.IsTrue(fakeVehicle.CalledApplyBrakes == 1);
        }

        [TestMethod]
        public void Can_Evade_Trouble_And_Alert_Offending_Driver()
        {
            // Arrange (set up a scenario)
            FakeVehicle fakeVehicle = new FakeVehicle();
            Driver target = new Driver(fakeVehicle);

            // Act (attempt the operation)
            bool success = target.EvasiveManeuvers(true);

            // Assert (verify the result)
            Assert.IsTrue(success);
            Assert.IsTrue(fakeVehicle.CalledHonkHorn == 1);
            Assert.IsTrue(fakeVehicle.CalledApplyBrakes == 1);
        }
    }
}
