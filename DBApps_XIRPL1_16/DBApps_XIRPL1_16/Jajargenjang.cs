using System;
using System.Collections.Generic;
using System.Text;

namespace DBApps_XIRPL1_16
{
    class Jajargenjang : Bangun_datar {
        public float sisi_miring;
        public float alas;
        public float tinggi;

        public override float luas()
        {
            float luas = alas*tinggi;
            Console.WriteLine("Luas Jajargenjang : " + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = 2 * (alas + sisi_miring);
            Console.WriteLine("Keliling Jajrgenjang " + keliling);
            return keliling;
        }
    }
}
