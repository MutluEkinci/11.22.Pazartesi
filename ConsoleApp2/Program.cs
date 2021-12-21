using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class A
    {
        public void MetodA()
        {
            Console.WriteLine("AAA");
        }
        protected void Test()//dışarıya kapalın sadece türeyen sınıflara açık.metod gibi şeylerin içinde çalışır.class içine kod yazılmaz.
        {
            Console.WriteLine("protected...");
        }
        private void Deneme()//sadece yazıldığı class'a özel.inheritance olsa bile çalışmaz.Sadece A class'ında çalışır.
        {
            Console.WriteLine("protected...");
        }
    }
    class B:A
    {
        public void MetodB()
        {
            Console.WriteLine("BBB");
            Test();
        }
    }
    // Class C:A,B (mutliple inheritence olamaz).
    class C:B
    {
        public void MetodC()
        {
            Console.WriteLine("CCC");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //2-)Inheritance(Kalıtım,türetme,miras)
            //Çoklu kalıtım c#'ta yoktur(C++'ta vardır).A ve B nin birleşiminden kalıtım yoktur yani.
            //A(base class)->B(Derived Class-"base for C")->C(derived class)
            //Hiyerarşik bir düzen kuruyoruz kalıtımla.
            //Sembolu ":"dür.
            A a = new A();
            a.MetodA();
            B b = new B();
            b.MetodB();
            b.MetodA();
            C c = new C();
            c.MetodC();
            c.MetodB();
            c.MetodA();

        }
    }
}
