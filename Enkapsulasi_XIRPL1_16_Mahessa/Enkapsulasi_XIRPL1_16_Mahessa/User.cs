using System;
using System.Collections.Generic;
using System.Text;

namespace Enkapsulasi_XIRPL1_16_Mahessa
{
    class User
    {
        public string Nama;
        public int NomorID;
        private int NomorHP;
        protected string RiwayatPasien;
        internal string Bangsa;


        //value default
        public User()
        {
            this.NomorID = 0;
            this.NomorHP = 666;
            this.RiwayatPasien = "sehat";
            this.Bangsa = "Indonesia";
        }

        // Abstraksi
        public int getNumber()
        {
            return NomorHP;
        }
        public int setNumber(int newNumber)
        {
            this.NomorHP = newNumber;
            return NomorHP;
        }


        // Class property
        public int nomorhp
        {
            get { return NomorHP; }
            set { this.NomorHP = value; }
        }

    }
}
