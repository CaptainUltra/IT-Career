using System;

namespace IntegerTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte num1 = -100;//signed, 8-bit, [-2^7;2^7-1]
            byte num2 = 128;//unsigned, 8-bit, [0;2^8-1]
            short num3 = -3540;//signed, 16-bit, [-2^15;2^15-1]
            ushort num4 = 64876;//unsigned, 16-bit, [0;2^16-1]
            uint num5 = 2147483648;//unsigned, 32-bit, [0;2^32-1]
            int num6 = -1141583228;//signed, 32-bit, [-2^31;2^31-1]
            long num7 = -1223372036854775808;//signed, 64-bit, [-2^63;2^63-1]
            ulong num8 = 1223372036854775808;//unsigned, 64-bit, [0;2^64-1]
        }
    }
}
