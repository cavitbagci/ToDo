using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class SelectPage
    {
        private List<List> lists;
        public void Liste()
        {
            lists = new List<List>()
            {
                new List("deneme","denemeiçerik","a"),
                new List("deneme2","denemeiçerik2","b")
            };
        }

        private List<List> lists2;
        private void InProgressLine()
        {
            lists2 = new List<List>()
            {
                new List("deneme3","denemeiçerik","a"),
                new List("deneme4","denemeiçerik2","b")
            };
        }

        private List<List> lists3;
        private void DoneLine()
        {
            lists3 = new List<List>()
            {
               new List("Başlık")
            };
        }
        internal void Main()
        {
            Console.WriteLine("Hangi işlemi yapmak istediğinizi seçiniz.");
            Console.WriteLine("(1) Board Listelemek \n(2) Board'a Kart Eklemek \n(3) Board'dan Kart Silmek \n(4) Kart Taşımak");

            int secim = int.Parse(Console.ReadLine());
            Liste();
            InProgressLine();
            DoneLine();
            switch (secim)
            {
                case 1:
                    ListBoard();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Geçersiz değer girdiniz lütfen 1-4 arasında bir değer giriniz.");
                    break;
            }
        }

        private void ListBoard()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            foreach (List list in lists)
            {
                Console.WriteLine("Başlık : {0} \nİçerik : {1} \nAtanan Kişi : {2}", list.Baslik, list.Icerik, list.AtananKisi);
                Console.WriteLine("");
            }
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            foreach (List list in lists2)
            {
                Console.WriteLine("Başlık : {0} \nİçerik : {1} \nAtanan Kişi : {2}", list.Baslik, list.Icerik, list.AtananKisi);
                Console.WriteLine("");
            }
            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            foreach(List list in lists3)
            {
                Console.WriteLine(list.Baslik);
            }
            /*TODO Line
            ************************
            Başlık      :
            İçerik      :
            Atanan Kişi :
            Büyüklük    :
 
            IN PROGRESS Line
            ************************
            Başlık      :
            İçerik      :
            Atanan Kişi :
            Büyüklük    :

            DONE Line
            ************************
            ~ BOŞ ~
            */
        }
    }


}
