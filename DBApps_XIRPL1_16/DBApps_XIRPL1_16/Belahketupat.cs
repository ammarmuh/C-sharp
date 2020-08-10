using System;
using System.Collections.Generic;
using System.Text;

namespace DBApps_XIRPL1_16
{
    class Belahketupat : Bangun_datar
    {
        public float sisi;
        public float d1;
        public float d2;

        public override float luas()
        {
            float luas = 0.5f * d1 * d2;
            Console.WriteLine("Luas belah ketupat : " + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = 4 * sisi;
            Console.WriteLine("Keliling belah ketupat : " + keliling);
            return keliling;
        }
    }
}
