using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Vehicle : IMoveable
    {
        private int _capacity;
        private int _numPassengers;

        public int NumPassengers
        {
            get { return _numPassengers; }
            set 
            {
                if (value > _capacity) throw new ArgumentException("Passenger count exceeds capacity");
                if (value < 0) throw new ArgumentException("Cannot have negative passengers");
                _numPassengers = value;
            }
        }

        public int Distance { get; set; }

        public int Speed { get; init; }

        public Vehicle()
        {
            Speed = 10;
        }
        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
        }
        public virtual string Move()
        {
            Distance += Speed;
            return "Moving along.";
        }

        public virtual string Move(int times)
        {
            Distance += times * Speed;
            return $"Moving along {times} times.";
        }
        public override string ToString()
        {
            return $"{this.GetType()} Capacity: {_capacity} Passengers: {_numPassengers} Speed: {Speed} Distance: {Distance}";
        }
    }
}