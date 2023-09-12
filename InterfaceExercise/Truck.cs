using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool HasFlatbed { get; set; } = true;
        public int LiftHeight { get; set; } = 16;
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Ram";
        public int Year { get; set; } = 2005;
        public int WheelNumber { get; set; } = 4;
        public string Logo { get; set; } = "Big D";
        public string CompanyName { get; set; } = "Dodge Trucks";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"Four-Wheel Drive {GetType().Name} is now driving forward.");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is now driving forward in two-wheel drive.");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now reversing.");
            }
            else
            {
                Console.WriteLine($"Cannot reverse until gears are changed.");
            }
        }
        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is now in park.");
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
