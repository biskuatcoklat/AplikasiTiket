using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiTiket
{
    class Penumpang
    {
        public string nama;
        public long nik;
        public string nomorHp;
        public string noVaksin;
        public string tujuanPerjalanan;

        public Penumpang(string nama, long nik, string nomorHp, string noVaksin, string tujuanPerjalanan)
        {
            this.nama = nama;
            this.nik = nik;
            this.nomorHp = nomorHp;
            this.noVaksin = noVaksin;
            this.tujuanPerjalanan = tujuanPerjalanan;
            
        }

        public string getNama()
        {
            return this.nama;
        }

        public long getNik()
        {
            return this.nik;
        }

        public string getNomorHp()
        {
            return (this.nomorHp == null) ? "-" : this.nomorHp;
        }

        public string getNoVaksin()
        {
            return (this.noVaksin == null) ? "-" : this.noVaksin;
        }

        public string getTujuanPerjalanan()
        {
            return (this.tujuanPerjalanan == null) ? "-" : this.tujuanPerjalanan;
        }

        public void print()
        {
            Console.WriteLine($"\tNama : {this.getNama()}");
            Console.WriteLine($"\tNIK : {this.getNik()}");
            Console.WriteLine($"\tNomor HP: {this.getNomorHp()}");
            Console.WriteLine($"\tNo Vaksin :{this.getNoVaksin()}");
            Console.WriteLine($"\tKota Tujuan :{this.getTujuanPerjalanan()}");
        }

        public class Builder
        {
            public Penumpang penumpang;

            public Builder(string nama, long nik, string nomorHp, string NoVaksin, string tujuanPerjalanan)
            {
                this.penumpang = new Penumpang(nama, nik, nomorHp, NoVaksin, tujuanPerjalanan);
            }


            public Builder withPhoneNumber(string nomorHp)
            {
                this.penumpang.nomorHp = nomorHp;
                return this;
            }

            public Builder withVaksinNumber(string NoVaksin)
            {
                this.penumpang.noVaksin = NoVaksin;
                return this;
            }

            public Builder withTujuanPerjalanan(string tujuanPerjalanan)
            {
                this.penumpang.tujuanPerjalanan = tujuanPerjalanan;
                return this;
            }

            public Penumpang build()
            {
                return penumpang;
            }
        }
    }
}
