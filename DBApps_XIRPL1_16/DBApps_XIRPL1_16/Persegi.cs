using System;
using System.Collections.Generic;
using System.Text;

namespace DBApps_XIRPL1_16
{
    class Persegi : Bangun_datar
    {
        public float sisi;

        public override float luas()
        {
            float luas = sisi * sisi;
            Console.WriteLine("Luas persegi : " + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = sisi * 4;
            Console.WriteLine("Keliling Persegi : " + keliling);
            return keliling;
        }
    }
}
