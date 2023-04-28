using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter { get; set; }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            this.Shooter = shooter;
        }
        public string Shoot()
        {
            return $"{GetFullName()} has taken a shot with their {Shooter.Shoot()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Shooter: {Shooter}";
        }
    }
}
