using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface IKombinatorik
    {
        public ulong BeregnFakultet(int n);
        public ulong BeregnAntalPermutationer(int n, int r);
        public ulong BeregnAntalKombinationer(int n, int r);

    }
}
