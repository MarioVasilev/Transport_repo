using _12.Model;
using _12.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Controllers
{
    class TransportCalculatorController
    {
        private Transport transport;
        private Display display;

        public TransportCalculatorController()
        { // Hardcoded = когато напишеш ръчно String
            // type(class) = тип ; tip = бакшиш
            display = new Display();

            transport = new Transport(display.Kilometers, display.DayState);

            display.Vehicle = transport.GetCheapestTransport();
            display.ShowCheapestTransport();
        }
   
    }
}
