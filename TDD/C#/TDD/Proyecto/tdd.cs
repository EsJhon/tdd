using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class tdd
    {
        public static int MCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int MCD_CuatroNumeros(int a, int b, int c, int d)
        {
            int temp = MCD(a, b);
            temp = MCD(temp, c);
            temp = MCD(temp, d);
            return temp;
        }

    }

}
