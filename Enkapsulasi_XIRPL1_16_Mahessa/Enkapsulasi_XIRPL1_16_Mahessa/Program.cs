using System;

namespace Enkapsulasi_XIRPL1_16_Mahessa
{
    class Program
    {
        static void Main(string[] args)
        {
            //cara access public
            User user = new User();
            user.Nama = "Jono";
            Console.WriteLine("Nama : " + user.Nama);
            user.NomorID = 1;
            Console.WriteLine("Nomor ID : " + user.NomorID);

            //cara access abstraksi
            int newNumber = 9876;
            User user1 = new User();
            Console.WriteLine("Nomor awal : " + user1.getNumber());
            Console.WriteLine("Nomor baru : " + user1.setNumber(newNumber));

            //cara access Properti
            int nomorBaru = 8765;
            User user2 = new User();
            Console.WriteLine("Nomor awal : " + user2.nomorhp);
            user2.nomorhp = nomorBaru;
            Console.WriteLine("Nomor awal : " + user2.nomorhp);

            //cara access Protected
            Dokter dokter = new Dokter();
            Console.WriteLine(dokter.biodataDokter());

            //cara acces internal
            User user3 = new User();
            user3.Bangsa = "Singapura";
            Console.WriteLine(user3.Bangsa);
        }
    }
}
