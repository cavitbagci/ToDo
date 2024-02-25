using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class ToDoList
    {
        private static Dictionary<int, string> Kullanicilar = new Dictionary<int, string>
        {
            {1, "Cavit"},
            {2, "Ahmet"},
            {3, "Mehmet"},
            {4, "Irmak"},
            {5, "Ayşe"},
            {6, "Fatma"}
        };

        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public int AtananKisiId { get; set; }
        public Boyut Boyut { get; set; }
        public ToDoList(string baslik)
        {
            Baslik = baslik;
        }

        internal ToDoList(string baslik, string icerik, int atananKisiId, Boyut boyut)
        {
            Baslik = baslik;
            Icerik = icerik;
            AtananKisiId = atananKisiId;
            Boyut = boyut;
        }

        public string GetKisiAdi(int id)
        {
            if (Kullanicilar.ContainsKey(id))
            {
                return Kullanicilar[id];
            }
            else
            {
                return "Böyle birisi bulunamadı";
            }
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
}
