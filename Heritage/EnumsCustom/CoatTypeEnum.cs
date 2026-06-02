using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage.EnumsCustom
{

    [Flags]
    public enum CoatTypeEnum
    {
        Shorthair = 1,
        Longhair = 2,
        Hairless = 4,
        Wooly = 8,
        Spiny = 16,
        Patterned = 32,
        Curly = 64,
        Wavy = 128,
        Corded = 256,

    }
}
