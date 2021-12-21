using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Personel
    {
        public int PerID { get; set; }
        public string PerAD { get; set; }
        public double Maas { get; set; }
        
        public Personel(int id,string ad,double maas) 
        {
            PerID = id;
            PerAD = ad;
            Maas = maas;
        }

    }
    class Mudur:Personel
    {
        public string OdaNo { get; set; }
        
        public Mudur(int id ,string ad,double maas,string odano):base(id,ad,maas) //base=üst sınıfın ctoruna veri göndermek için kullanılır.
        {
            PerID = id;
            PerAD = ad;
            Maas = maas;
            OdaNo = odano;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım ctor kullanımı
            Personel p = new Personel(123,"cevdet",4500);
            Mudur m = new Mudur(145,"Selami",5000,"12");

            
        }
    }
}
