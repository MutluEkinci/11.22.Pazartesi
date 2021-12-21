using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Daire
    {
        public Daire(double yarıcap)
        {
            r = yarıcap;
            Console.WriteLine(AlanHesapla());
        }
        public double r { get; set; }
        public double AlanHesapla()
        {
            return Math.PI * r * r;
        }
    }
    class Silindir : Daire
    {
        public Silindir(double yarıcap,double yukseklik): base(yarıcap)
        {
            h = yukseklik;
            Console.WriteLine(AlanHesapla()*h);
        }
        public double h { get; set; }
        public double SilindirHacim()
        {
            return AlanHesapla() * h;
        }
    }
    class Koni : Silindir
    {
        public Koni(double yarıcap,double yukseklik):base(yarıcap,yukseklik)
        {
            Console.WriteLine(SilindirHacim()/3);
        }
        public double konihacim()
        {
            return SilindirHacim() / 3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Daire,silindir ve koni nesneleri oluşturunuz ve bunların alan/hacim hesaplarını yapınız.
            Daire d = new Daire(3);
            //d.r = 3;
            //Console.WriteLine(d.AlanHesapla());

            Silindir s = new Silindir(3,5);
            //s.r = 3;
            //s.h = 10;
            //Console.WriteLine(s.SilindirHacim());

            Koni k = new Koni(3,5);
            //k.r = 3;
            //k.h = 10;
            //Console.WriteLine(k.konihacim());

        }
    }
}
