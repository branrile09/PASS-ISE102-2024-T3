using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASS_Wk6
{
    abstract class MathLibrary
    {
        static public float addNumber(float x = 0, float y = 0, float z = 0, float w = 0)
        { 
            return x + y + z + w;
        }
    }
}
