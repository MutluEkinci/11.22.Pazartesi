using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Personel
    {

    }
    class Hizmetli:Personel
    {

    }
    class Asci:Hizmetli
    {

    }
    class Temizlikgorevlisi:Hizmetli
    {

    }
    class ofis : Personel
    {

    }
    class yönetici : Personel
    {

    }
    class sekreter : ofis
    {

    }
    class memur:ofis
    {

    }
    class mudur : yönetici
    {

    }
    class muduryardımcısı : mudur
    {

    }
    class genelmudur : mudur
    {

    }
    class uretim : mudur
    {

    }
    class imalat : mudur
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            //soru:Bir personel bilgi takip sistemi için program yazmanız isteniyor.Bu sistemin analizini yaparak gerekli sınıfları oluşturunuz.
        }
    }
}
