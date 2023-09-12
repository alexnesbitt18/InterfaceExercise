using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool IsCool { get; set; } = false;
        public bool IsDesired { get; set; } = true;
        public string Make { get; set; } = "Tesla";
        public string Model { get; set; } = "Speedrunner";
        public int Year { get; set; } = 2022;
        public int WheelNumber { get; set; } = 4;
        public string Logo { get; set; } = "Weird T";
        public string CompanyName { get; set; } = "Tesla Motors";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving forward.");
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
