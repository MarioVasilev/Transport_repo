using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Views
{
    class Display
    {
        //public - accessor, т.е. това казва дали променливата/функцията може да се извика извън scope-а на класа
        //double, int, decimal, float - това са типове за числа, като само int е тип за цяло число, а останалите са със плаваща запетая
        //get - това е getter, т.е. това е функция която дава достъп до променливата, която по подразбиране е празна и дава само стойността
        //set - това е setter, т.е.
        public int Kilometers { get; set; }
        public string DayState { get; set; }
        public Vehicle Vehicle { get; set; }
        public Display() //Конструктор, който материализира класа
        {
            Kilometers = 0;
            DayState = "";
            GetValues();
        }
        private void GetValues()
        {
            Console.WriteLine("Enter the distance in KM (between 1 and 5000):");
            Kilometers = int.Parse(Console.ReadLine()); // => ReadLine ни връща винаги string
            Console.WriteLine("Enter day state. Can be only 'day' or 'night': ");
            DayState = Console.ReadLine();
        }
        public void ShowCheapestTransport()
        {
            Console.WriteLine("The cheapest transport is: {0}", Vehicle.vehicle);
            Console.WriteLine("The total cost with the cheapest vehicle is {0:C}", Vehicle.totalPrice);
        }

    }
}