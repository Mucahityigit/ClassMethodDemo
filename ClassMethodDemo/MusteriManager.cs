using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class MusteriManager
    {
        public void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listesi");
            Console.WriteLine("-----------------------------");  
            foreach(Musteri m in musteriler)
            {
                Console.Write(m.MusteriAdSoyad + " " + m.MusteriYas);
                Console.WriteLine();
            }
        }
    }
}
