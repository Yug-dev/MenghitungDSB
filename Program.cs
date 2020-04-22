using System;

namespace KecepatanRataRata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menghitung GLB");
            Console.WriteLine("========================");
            Console.WriteLine("1. Menghitung Kecepatan");
            Console.WriteLine("2. Menghitung Jarak Tempuh");
            Console.WriteLine("3. Menghitung Waktu Tempuh");
            Console.WriteLine("=========================");
            Console.WriteLine("Pilih : ");

            int pil = int.Parse(Console.ReadLine());

            if (pil == 1)
            {
                Console.WriteLine("=====================");
                Console.Write("Masukan Jarak Tempuh :");
                double Jarak = double.Parse(Console.ReadLine());
                Console.Write("Masukan Waktu Tempuh :");
                double Waktu = double.Parse(Console.ReadLine());
                Kecepatan kec = new Kecepatan();
                double result = ( Jarak / Waktu);
                Console.Write("Kecepatannya adalah: ");
                Console.Write(result);
            }
            else if (pil == 2)
            {
                    Console.WriteLine("=================");
                    Console.Write("Masukan Waktu Tempuh :");
                    double Waktu = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Kecepatan Tempuh :");
                    double Kecepatan = double.Parse(Console.ReadLine());
                    Jarak jrk = new Jarak();
                    double result = (Waktu * Kecepatan);
                    Console.Write("Jaraknya adalah :");
                    Console.Write(result);
            }
            else if(pil == 3)
            {
                        Console.WriteLine("==================");
                    Console.Write("Masukan Jarak Tempuh : ");
                    double Jarak = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Kecepatan Tempuh :");
                    double Kecepatan = double.Parse(Console.ReadLine());
                    Waktu wkt = new Waktu();
                    double result = (Jarak / Kecepatan);
                    Console.Write("Waktunya adalah :");
                    Console.Write(result);

            }
        }
    }   
}
