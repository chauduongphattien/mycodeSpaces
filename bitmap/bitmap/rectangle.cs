using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitmap
{
    public class rectangle:shape
    {
        public rectangle() { }
        public rectangle(int x, int y, int z, int t) : base(x, y, z, t) { }
        public override int drawNum()
        {
            return 3;
        }
    }
}
