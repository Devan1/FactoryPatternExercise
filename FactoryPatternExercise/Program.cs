using System;

namespace FactoryPatternExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have? ");
            string userInput = Console.ReadLine(); 

            VehicleFactory vehicleFactory = new VehicleFactory();
            IVehicle firstCar = vehicleFactory.GetVehicle(userInput);
            firstCar.Drive();

            Console.WriteLine("How many tires does your vehicle have? ");
            userInput = Console.ReadLine();
            IVehicle firstMotorcycle = vehicleFactory.GetVehicle(userInput);
            firstMotorcycle.Drive();


        }
    }
}
