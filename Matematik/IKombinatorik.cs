using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface IKombinatorik
    {
        public ulong BeregnFakultet(ulong n, ulong Result = 1)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return Result;
            }
            else
            {
                return BeregnFakultet(n-1, Result * n);
            }
        }

        public ulong BeregnAntalPermutationer(ulong n, ulong r) //Check if r>n
        {
            return BeregnFakultet(n) / BeregnFakultet(n - r);
        }
        public ulong BeregnAntalKombinationer(ulong n, ulong r) //Check if r>n
        {
            return BeregnFakultet(n) / (BeregnFakultet(r) * BeregnFakultet(n - r));
        }
    }
}   
