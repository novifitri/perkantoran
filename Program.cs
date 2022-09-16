using System;

namespace TugasDasar
{
    class Program
    {   
       
        //method non-void
        static float HitungGajiPerbulan(int jumlahMasuk, float gaji){       
            int jumlahHariKerja = 20;   
            float hariKerja = (float) jumlahMasuk / jumlahHariKerja;
            float totalGaji = hariKerja * gaji;
            return totalGaji;   
        }
          static float HitungUpahLembur(int jam, float gaji){
            float upahPerjam = gaji * 1/173;
            return upahPerjam * jam;   
        }
        //method void
        static void CetakInfo(string message){
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("====PROGRAM PERHITUNGAN GAJI DAN UPAH SEDERHANA====");    
            Console.WriteLine("MENU");
            Console.WriteLine("1. Hitung Gaji Perbulan");
            Console.WriteLine("2. Hitung Upah Lembur");
            string menu;
            int value;
            //Looping pakai DO-WHILE
            do
            {
                Console.Write("Pilih menu:");
                menu = Console.ReadLine();
                
            } while (int.TryParse(menu, out value) == false);

            //DECISION pakai switch
            switch(value){
                case 1:
                    Console.Write("Masukan Jumlah Hari Masuk: ");
                    int jumlahHariMasuk = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukan Gaji Perbulan: ");
                    float gaji = float.Parse(Console.ReadLine());
                    float totalGaji = HitungGajiPerbulan(jumlahHariMasuk, gaji);
                    CetakInfo($"Total Gaji {totalGaji}");
                    break;
                case 2:
                    Console.Write("Masukan Total Jam Lmebur: ");
                    int jam = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukan Gaji Perbulan: ");
                    float salary = float.Parse(Console.ReadLine());
                    float upah = HitungUpahLembur(jam, salary);
                    CetakInfo($"Total Upah Lembur = {upah}");
                    break;
                default:
                    CetakInfo("Maaf pilihan tidak tersedia");
                    break;
            }
        }
    }
}
