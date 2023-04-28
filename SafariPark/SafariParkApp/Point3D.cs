using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public struct Point3D
    {
        public int x; 
        public int y; 
        public int z;

        public Point3D(int x, int y, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
