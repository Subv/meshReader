using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SlimDX;

namespace meshReader.Helper
{
    public static class Extensions
    {
        public static Vector3 ToVector3(this Vector4 val)
        {
            return new Vector3(val.X, val.Y, val.Z);
        }
    }
}
