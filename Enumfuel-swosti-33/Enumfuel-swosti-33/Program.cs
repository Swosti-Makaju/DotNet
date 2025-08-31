using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumfuel_swosti_33
{
    // Define an enumeration for different vehicle types
    enum VehicleType
    {
        Car,
        Bike,
        Bus,
        Truck,
        Scooter
    }

    class Program
    {
        // Function to get the fuel type based on vehicle type
        static string GetFuelType(VehicleType vehicle)
        {
            switch (vehicle)
            {
                case VehicleType.Car:
                case VehicleType.Bike:
                case VehicleType.Scooter:
                    return "Petrol";

                case VehicleType.Bus:
                case VehicleType.Truck:
                    return "Diesel";

                default:
                    return "Unknown";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vehicle Types and Their Fuel Types:");

            // Iterate through all values in the VehicleType enum
            foreach (VehicleType vehicle in Enum.GetValues(typeof(VehicleType)))
            {
                string fuelType = GetFuelType(vehicle);
                Console.WriteLine($"- {vehicle} = {fuelType}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}