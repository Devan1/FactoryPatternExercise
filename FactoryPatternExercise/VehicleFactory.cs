using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "4":
                    return new Car();                   
                case "2":
                    return new Motorcycle();                    
                default:
                    return new Car();
                    
            }
        }
    }
}
