using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class ToDoList
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        //public Dictionary<int, string> Deneme { get; set; }
        public Boyut Boyut { get; set; }
        public ToDoList(string baslik)
        {
            Baslik = baslik;
        }
                    
        internal ToDoList(string baslik, string icerik, string atananKisi, Boyut boyut)
        {
            Baslik = baslik;
            Icerik = icerik;
            AtananKisi = atananKisi;
            Boyut = boyut;
        }
    }

    public enum Boyut
    {
        XS = 0,
        S = 1,
        M = 2,
        L = 3,
        XL = 4
    }

    //internal class TakimArkadaslari
    //{
    //    public static Dictionary<int, string> TakimUyeleri = new Dictionary<int, string>
    //    {
    //        {1, "Ahmet"},
    //        {2, "Mehmet"},
    //        {3, "Ayşe"},
    //        {4, "Fatma"}
    //    };
    //}
}
