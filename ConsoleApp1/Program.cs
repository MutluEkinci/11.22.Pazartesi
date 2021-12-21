using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //collection
            //5-Sorted List

            SortedList liste = new SortedList();
            liste.Add(34, "Istanbul");
            liste.Add(32, "Isparta");
            liste.Add(06, "Ankara");
            foreach (int s in liste.Keys)//liste.keys keye göre sıralar.liste.values yazarsak eğer string değere yani ada göre sıralar.
            {
                Console.WriteLine(s);
            }

            for (int i=0;i<liste.Count;i++) //listenin içindeki iki değeri birden yazdırmak için.
            {
                Console.WriteLine(liste.GetKey(i)+" "+liste.GetByIndex(i));
            }
        }
    }
}
