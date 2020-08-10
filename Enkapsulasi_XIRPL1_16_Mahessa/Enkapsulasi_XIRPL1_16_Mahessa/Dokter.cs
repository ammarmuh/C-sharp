using System;
using System.Collections.Generic;
using System.Text;

namespace Enkapsulasi_XIRPL1_16_Mahessa
{
    class Dokter : User
    {
        public string biodataDokter()
        {
            base.RiwayatPasien = "Magh";
            return RiwayatPasien;
        }
    }
}
