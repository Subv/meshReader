using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace meshReader.Helper
{
    public static class MathHelper
    {
        public static float Pi = (float)Math.PI;
        
        public static float ToRadians(float value)
        {
            return value * Pi / 180;
        }

        public static float Distance(float start, float end)
        {
            return (float)Math.Sqrt(start * start + end * end);
        }
    }
}
