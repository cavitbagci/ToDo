using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class List
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        //public Dictionary<int, string> TakimUyeleri { get; set; }
        public List(string baslik)
        {
            Baslik = baslik;
        }
        public List(string baslik, string icerik, string atananKisi)
        {
            //Console.Write("Başlık : ");
            Baslik = baslik;
            //Console.WriteLine();
            //Console.Write("İçerik : ");
            Icerik = icerik;
            //Console.WriteLine();
            //Console.Write("Atanan Kişi : ");
            AtananKisi = atananKisi;
            //TakimUyeleri = TakimArkadaslari.TakimUyeleri;

        }
    }

    internal enum Boyut
    {
        xs = 0,
        s = 1,
        m = 2,
        l = 3,
        xl = 4
    }

    internal class TakimArkadaslari
    {
        public static Dictionary<int, string> TakimUyeleri = new Dictionary<int, string>
        {
            {1, "Ahmet"},
            {2, "Mehmet"},
            {3, "Ayşe"},
            {4, "Fatma"}
        };
    }
}
