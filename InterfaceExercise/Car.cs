using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; } = true;
        public bool HasSunRoof { get; set; } = false;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Corolla";
        public int Year { get; set; } = 2011;
        public int WheelNumber { get; set; } = 4;
        public string Logo { get; set; } = "Big T";
        public string CompanyName { get; set; } = "Toyota Cars"; 
        public bool HasChangedGears { get; set; } 

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving forward.");
        }
        public void Reverse()
        {
            if(HasChangedGears == true )
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
