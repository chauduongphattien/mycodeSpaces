using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitmap
{
    public class eclipeClass:shape
    {
         public eclipeClass() { }
        public eclipeClass(int x, int y, int z,int t):base(x,y,z,t) { }
        public override int drawNum()
        {
            return 2;
        }
    }
}
