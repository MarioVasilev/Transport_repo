using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Model
{
    class Transport
    {
        private int kilometers;
        private string dayState;
        public int Kilometers
        {
            get { return this.kilometers; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("The kilometers cannot be under 1.");
                }
                else if (value > 5000)
                {
                    throw new Exception("The kilometers cannot be more than 5000.");
                }
                else
                {
                    this.kilometers = value;
                }
            }
        }
        public string DayState
        {
            get { return this.DayState; }
            set
            {
                if (value.ToLower() == "day")
                {
                    this.dayState = value.ToLower();
                }
                else if (value == "night")
                {
                    this.dayState = value;
                }
                else
                {
                    throw new Exception("You must enter either 'day' or 'night'");
                }

            }
        }
        public Transport(int kilometers, string dayState)
        {
            Kilometers = kilometers;
            DayState = dayState;
        }
        public Transport() : this(0, "") { }

        public Vehicle GetCheapestTransport()
        {
            Vehicle taxi = CalculateTaxiTrip();
            Vehicle bus = CalculateBusTrip();
            Vehicle train = CalculateTrainTrip();

            if (taxi.totalPrice < bus.totalPrice && taxi.totalPrice < train.totalPrice)
            {
                return taxi;
            }
            else if (bus.totalPrice < taxi.totalPrice && bus.totalPrice < train.totalPrice)
            {
                return bus;
            }
            else
            {
                return train;
            }
        }

        public Vehicle CalculateTaxiTrip()
        {
            double price = 0.7;
            if (dayState == "day")
            {
                price = price + (kilometers * 0.79);
            }
            else
            {
                price = price + (kilometers * 0.90);
            }
            return new Vehicle("Taxi", price);
        }
        public Vehicle CalculateBusTrip()
        {
            double price = kilometers * 0.09;
            if (kilometers >= 20)
            {
                return new Vehicle("Bus", price);
            }
            else
            {
                return new Vehicle("Bus", double.PositiveInfinity);
            }

        }
        public Vehicle CalculateTrainTrip()
        {
            double price = kilometers * 0.06;
            if (kilometers >= 100)
            {
                return new Vehicle("Train", price);
            }
            else
            {
                return new Vehicle("Train", double.PositiveInfinity);
            }
        }

    }
}

class Vehicle
{
    public string vehicle;
    public double totalPrice;
    public Vehicle(string vehicle, double totalPrice)
    {
        this.vehicle = vehicle;
        this.totalPrice = totalPrice;
    }
}