using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    static class VehicleFactory
    {

      public static IVehicle GetVehicle(int wheelCount)
        {
          
            if(wheelCount == 4)
            {
                return new Car();
            }
            return new BigRig();
           
           
        }

    }
}
