using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(string ID, string name)
        {
            Console.WriteLine(ID + " " + name + " Eklendi");
        }
        public void List(string ID, string name)
        {
            Console.WriteLine(ID + " " + name + " listeye dahil edildi.");
        }
        public void Sil(string ID, string name)
        {
            Console.WriteLine(ID + " " + name +  " silindi");
        }
    }
}
