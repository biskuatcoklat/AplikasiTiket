using System;

namespace AplikasiTiket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t\tPT Raja Trans Abadi");
            Console.WriteLine("\tTiket Pembelian Tujuan Bandung - Yogyakarta ");
            Console.WriteLine("\n");

            Penumpang penumpang = new Penumpang.Builder("Kelompok 6", 21113869, "-", "-","-")
            .withPhoneNumber("081234567865")
            .withVaksinNumber("Vaksin 3 (BOOSTER)")
            .withTujuanPerjalanan("Yogyakarta")
            .build();

            penumpang.print();

            Console.WriteLine();

            Alamat alamat = new Alamat.Builder("10", "03", "Maguwoharjo", "Depok", "Kab Sleman", "D.I. Yogyakarta", "0", "0")
            .withStreet("Jalan Menur Sambilegi")
            .withNote("Kost Warna putih")
            .build();
            Console.Write("\tAlamat Penumpang : \n");

            alamat.print();
           
        }
    }
}
