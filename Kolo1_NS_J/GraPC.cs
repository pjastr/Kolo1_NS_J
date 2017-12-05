using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_J
{
    class GraPC:Gra
    {
        private int pegi;

        public GraPC(string p1, double p2, int p3)
            : base(p1, p2)
        {
            this.pegi = p3;
        }

        public bool Multiplayer()
        {
            if (pegi > 13) return true;
            else return false;
        }
    }
}
