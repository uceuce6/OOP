using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootchamp24
{
    abstract class BangunDatar
    {
        public abstract double hitungKeliling();
    }

    // class segitiga
    class segitiga : BangunDatar
    {
        double sisi1;
        double sisi2;
        double sisi3;
        public segitiga(double a, double b, double c)
        {
            sisi1 = a;
            sisi2 = b;
            sisi3 = c;
        }
        public override double hitungKeliling()
        {
            return (sisi1 + sisi2 + sisi3);
        }
    }

    // class lingkaran
    class lingkaran : BangunDatar
    {
        double diameter;
        public lingkaran(double d)
        {
            diameter = d;
        }
        public override double hitungKeliling()
        {
            return ((Convert.ToDouble(3.14)) * diameter);
        }
    }
    // class persegi panjang
    class persegiPanjang : BangunDatar
    {
        double panjang;
        double lebar;
        public persegiPanjang(double e, double f)
        {
            panjang = e;
            lebar = f;
        }
        public override double hitungKeliling()
        {
            return (2 * (panjang + lebar));
        }

    }
    // class Trapesium
    class trapesium : BangunDatar
    {
        double sisi1;
        double sisi2;
        double sisi3;
        double sisi4;
        public trapesium(double g, double h, double i, double j)
        {
            sisi1 = g;
            sisi2 = h;
            sisi3 = i;
            sisi4 = j;
        }
        public override double hitungKeliling()
        {
            return (sisi1 + sisi2 + sisi3 + sisi4);
        }

    }
    class perhitungan
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("   PERHITUNGAN KELILING");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Segitiga");
            Console.WriteLine("2. Lingkaran");
            Console.WriteLine("3. Persegi Panjang");
            Console.WriteLine("4. Trapesium");
            Console.WriteLine("-------------------------");
            Console.Write("pilihan menu : ");

            double nomor = Convert.ToInt16(Console.ReadLine());

            if (nomor == 1)
            {
                Console.WriteLine();
                Console.Write("masukan sisi 1 :");
                Double s1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("masukan sisi 2 :");
                Double s2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("masukan sisi 3 :");
                Double s3 = Convert.ToDouble(Console.ReadLine());
                BangunDatar k = new segitiga(s1, s2, s3);
                double l = k.hitungKeliling();
                Console.WriteLine("keliling Segitiga  : " + l);
                Console.Read();
            }
            else if (nomor == 2)
            {
                Console.WriteLine();
                Console.Write("masukan diameter :");
                Double s4 = Convert.ToDouble(Console.ReadLine());
                BangunDatar m = new lingkaran(s4);
                double n = m.hitungKeliling();
                Console.WriteLine("keliling Ligkaran  : " + n);
                Console.Read();
            }
            else if (nomor == 3)
            {
                Console.WriteLine();
                Console.Write("masukan Panjang :");
                Double s5 = Convert.ToDouble(Console.ReadLine());
                Console.Write("masukan Lebar :");
                Double s6 = Convert.ToDouble(Console.ReadLine());
                BangunDatar o = new persegiPanjang(s5, s6);
                double p = o.hitungKeliling();
                Console.WriteLine("keliling Persegi Panjang  : " + p);
                Console.Read();
            }
            else
            {
                Console.WriteLine();
                Console.Write("masukan sisi 1 :");
                Double s7 = Convert.ToDouble(Console.ReadLine());
                Console.Write("masukan sisi 2 :");
                Double s8 = Convert.ToDouble(Console.ReadLine());
                Console.Write("masukan sisi 3 :");
                Double s9 = Convert.ToDouble(Console.ReadLine());
                Console.Write("masukan sisi 4 :");
                Double s10 = Convert.ToDouble(Console.ReadLine());
                BangunDatar q = new trapesium(s7, s8, s9, s10);
                double r = q.hitungKeliling();
                Console.WriteLine("keliling Trapesium  : " + r);
                Console.Read();
            }
            Console.Read();
        }
    }
}
