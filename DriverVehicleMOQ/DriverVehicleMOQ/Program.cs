using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverVehicleMOQ
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class Driver
    {
        private IVehicle vehicleToDrive;

        public Driver(IVehicle vehicleToDrive)
        {
            this.vehicleToDrive = vehicleToDrive;
        }

        public bool EvasiveManeuvers(bool alertOffendingDriver)
        {
            bool success = false;
            if (alertOffendingDriver)
                success = this.vehicleToDrive.ApplyBrakes() && this.vehicleToDrive.HonkHorn();
            else
                success = this.vehicleToDrive.ApplyBrakes();

            return success;
        }
    }

    public interface IVehicle
    {
        ///<summary>
        ///Honks the vehicle's horn.
        ///</summary>
        ///<returns>
        ///True if the action was successful.
        ///</returns>
        bool HonkHorn();

        ///<summary>
        ///Applies the vehicle's brakes.
        ///</summary>
        ///<returns>
        ///True if the action was successful.
        ///</returns>
        bool ApplyBrakes();
    }

    public class FakeVehicle : IVehicle
    {
        public int CalledHonkHorn = 0;
        public int CalledApplyBrakes = 0;

        public bool HonkHorn()
        {
            this.CalledHonkHorn++;
            return true;
        }

        public bool ApplyBrakes()
        {
            this.CalledApplyBrakes++;
            return true;
        }
    }
}
