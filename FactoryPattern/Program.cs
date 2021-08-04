using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get info from user to determine the car build.
            Console.WriteLine("How many wheels? 4 = Car 8 = BigRig.");
            var wheelCount = Convert.ToInt32(Console.ReadLine());


            //Creating the vehicle based off users input
            IVehicle vehicle = VehicleFactory.GetVehicle(wheelCount);


            //display type of vehicle created by user
            vehicle.Drive();
            
        }
    } 
}
