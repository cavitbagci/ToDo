using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class SelectPage
    {
        private List<ToDoList> lists;

        public void Liste()
        {
            lists = new List<ToDoList>()
            {
                new ToDoList("deneme","denemeiçerik","a"),
                new ToDoList("deneme2","denemeiçerik2","b"),
            };
        }

        private List<ToDoList> lists2;

        public void InProgressLine()
        {
            lists2 = new List<ToDoList>()
            {
                new ToDoList("deneme3","denemeiçerik","a"),
                new ToDoList("deneme4","denemeiçerik2","b"),
            };
        }

        private List<ToDoList> lists3;

        public void DoneLine()
        {
            lists3 = new List<ToDoList>()
            {
               new ToDoList("Başlık")
            };
        }

        public void Main()
        {
            Liste();
            InProgressLine();
            DoneLine();
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("Hangi işlemi yapmak istediğinizi seçiniz.");
                Console.WriteLine("(1) Board Listelemek \n(2) Board'a Kart Eklemek \n(3) Board'dan Kart Silmek \n(4) Kart Taşımak \n(0) Uygulamadan Çıkmak");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 0:
                        Continue = false;
                        break;
                    case 1:
                        ListBoard();
                        break;
                    case 2:
                        AddBoard();
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
        }

        private void ListBoard()
        {

            Dictionary<int, string> kisiler = new Dictionary<int, string>();
            kisiler.Add(1, "Administrator");
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            foreach (ToDoList todolist in lists)
            {
                Console.WriteLine("Başlık : {0} \nİçerik : {1} \nAtanan Kişi : {2}", todolist.Baslik, todolist.Icerik, todolist.AtananKisi);
                Console.WriteLine("");
            }
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            foreach (ToDoList todolist in lists2)
            {
                Console.WriteLine("Başlık : {0} \nİçerik : {1} \nAtanan Kişi : {2}", todolist.Baslik, todolist.Icerik, todolist.AtananKisi);
                Console.WriteLine("");
            }
            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            foreach (ToDoList todolist in lists3)
            {
                Console.WriteLine(todolist.Baslik);
            }
            Console.WriteLine();
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
        private void AddBoard()
        {
            Console.WriteLine("Başlık giriniz.");
            string Baslik = Console.ReadLine();
            Console.WriteLine("İçerik giriniz.");
            string Icerik = Console.ReadLine();
            Console.WriteLine("Kişi seçiniz");
            string Kisi = Console.ReadLine();
            ToDoList addList = new ToDoList(Baslik,Icerik,Kisi);
            lists.Add(addList);
            Console.WriteLine("Not başarıyla eklendi!");
            Console.WriteLine();
        }
    }
}
