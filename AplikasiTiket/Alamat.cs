using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiTiket
{
    class Alamat
    {
        private string rt;
        private string rw;
        private string kelurahan;
        private string kecamatan;
        private string kabupaten;
        private string provinsi;
        private string catatan;
        private string jalan;

        public Alamat(string rt, string rw, string kelurahan, string kecamatan, string kabupaten, string provinsi, string catatan, string jalan)
        {
            this.rt = rt;
            this.rw = rw;
            this.kelurahan = kelurahan;
            this.kecamatan = kecamatan;
            this.kabupaten = kabupaten;
            this.provinsi = provinsi;
            this.catatan = catatan;
            this.jalan = jalan;
        }

        public string getRt()
        {
            return this.rt;
        }

        public string getRw()
        {
            return this.rw;
        }

        public string getKelurahan()
        {
            return this.kelurahan;
        }

        public string getKecamatan()
        {
            return this.kecamatan;
        }

        public string getKabupaten()
        {
            return this.kabupaten;
        }

        public string getProvinsi()
        {
            return this.provinsi;
        }

        public string getJalan()
        {
            return (this.jalan == null) ? "-" : this.jalan;
        }

        public string getCatatan()
        {
            return (this.catatan == null) ? "-" : this.catatan;
        }

        public void print()
        {
            Console.WriteLine($"\tRT. {this.getRt()}");
            Console.WriteLine($"\tRW. {this.getRw()}");
            Console.WriteLine($"\tKEL. {this.getKelurahan()}");
            Console.WriteLine($"\tKEC. {this.getKecamatan()}");
            Console.WriteLine($"\tKAB. {this.getKabupaten()}");
            Console.WriteLine($"\tPROV. {this.getProvinsi()}");
            Console.WriteLine($"\tJLN. {this.getJalan()}");
            Console.WriteLine($"\tCatatan: {this.getCatatan()}");
        }

        public class Builder
        {
            public Alamat alamat;

            public Builder(string rt, string rw, string kelurahan, string kecamatan, string kabupaten, string provinsi, string catatan, string jalan)
            {
                this.alamat = new Alamat(rt, rw, kelurahan, kecamatan, kabupaten, provinsi, jalan, catatan);
            }

            public Builder withStreet(string jalan)
            {
                this.alamat.jalan = jalan;
                return this;
            }

            public Builder withNote(string catatan)
            {
                this.alamat.catatan = catatan;
                return this;
            }


            public Alamat build()
            {
                return alamat;
            }
        }
    }
}

