using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace bitmap
{
    public class line:shape
    {   
        public line() { }
        public line(int x, int y, int z, int t) : base(x, y, z, t) { }
        public override int drawNum()
        {
            return 1;
        }

    }
  

}
