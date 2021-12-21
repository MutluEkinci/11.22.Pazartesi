using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11Pazartesi
{
    class Araba
    {
        public string marka { get; set; }
        public string model { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arabalar = new ArrayList();
            //soru 2: araba sınıfında değer aran bir arraylist koleksiyonu oluşturunuz ve ekranda bilgileri gösteriniz.
           
            for (int i = 0; i < 3; i++)
            {
                Araba araba = new Araba();
                Console.Write("Marka giriniz");
                araba.marka = Console.ReadLine();
                Console.Write("Model giriniz");
                araba.model = Console.ReadLine();
                arabalar.Add(araba);



            }
            foreach (object obj in arabalar) //var ya da object yerine "Araba" yazdığımız zaman tip dönüşümünü otomatik kendi yapıyor.cast operatörü büyük tipten kçük tipe dönüşüm yapılır her zaman.
            {
                Araba a = (Araba)obj;
                Console.WriteLine(a.marka + " " + a.model);
                //bir koleksiyon sizden obje alıyorsa tip dönüşümü ya da cast dönüşümü yapılmalı.ÖNEMLİ
            }
            foreach (Araba a in arabalar) //burada tip otomatik dönüştürüldü
            {
                Console.WriteLine(a.marka+" " + a.model);
            }
        }
    }
}
