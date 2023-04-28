﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Airplane : Vehicle
    {
        private string _airline;
        public int Altitude { get; private set; }
        public Airplane(int capacity) : base(capacity)
        {
            
        }
        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            this._airline = airline;
        }

        public void Ascend(int distance)
        {
            Altitude += distance;
        }

        public void Descend(int distance)
        {
            Altitude -= distance;
        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {Altitude} metres.";
        }

        public override string Move(int times)
        { 
            return $"{base.Move(times)} at an altitude of {Altitude} metres.";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} altitude: {Altitude}";
        }
    }
}
