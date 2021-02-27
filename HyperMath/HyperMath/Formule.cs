using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMath
{
    class Formule
    {
        public float Permutacije(float n)
        {
            float nRjesenje = 1;
            for (int i = 1; i <= n; i++)
            {
                nRjesenje = nRjesenje * i;
            }
            return nRjesenje;
        }
    }
}
