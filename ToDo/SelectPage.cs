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
                new ToDoList("deneme","denemeiçerik",1,Boyut.XS),
                new ToDoList("deneme2","denemeiçerik2",2, Boyut.S),
            };
        }

        private List<ToDoList> lists2;

        public void InProgressLine()
        {
            lists2 = new List<ToDoList>()
            {
                new ToDoList("deneme3","denemeiçerik",3, Boyut.M),
                new ToDoList("deneme4","denemeiçerik2",4, Boyut.XL),
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
                //int secim = int.Parse(Console.ReadLine());
                string giris = Console.ReadLine();
                if (int.TryParse(giris, out int secim))
                {
                    Console.WriteLine("Seçiminiz: " + secim);
                }
                else
                {
                    Console.WriteLine("Geçersiz değer girdiniz lütfen 0-4 arasında bir değer giriniz.");
                    Console.ReadLine();
                }
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
                        RemoveBoard();
                        break;
                    case 4:
                        MoveBoard();
                        break;
                    default:
                        Console.WriteLine("Geçersiz değer girdiniz lütfen 0-4 arasında bir değer giriniz.");
                        break;
                }
            }
        }

        private void ListBoard()
        {
            Console.WriteLine();
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            foreach (ToDoList todolist in lists)
            {
                Console.WriteLine("Başlık : {0} \nİçerik : {1} \nAtanan Kişi : {2} \nBoyut : {3}", todolist.Baslik, todolist.Icerik, todolist.GetKisiAdi(todolist.AtananKisiId), todolist.Boyut);
                Console.WriteLine("");
            }
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            foreach (ToDoList todolist in lists2)
            {
                Console.WriteLine("Başlık : {0} \nİçerik : {1} \nAtanan Kişi : {2} \nBoyut : {3}", todolist.Baslik, todolist.Icerik, todolist.GetKisiAdi(todolist.AtananKisiId), todolist.Boyut);
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

            Console.WriteLine("Kişinin Id'sini giriniz.");
            int Kisi = int.Parse(Console.ReadLine());

            Console.WriteLine("Boyut giriniz.(XS,S,M,L,XL)");
            string boyut = Console.ReadLine();
            Boyut boyutEnum;
            Enum.TryParse(boyut, out boyutEnum);

            ToDoList addList = new ToDoList(Baslik, Icerik, Kisi, boyutEnum);
            lists.Add(addList);
            Console.WriteLine("Not başarıyla eklendi!");
            Console.WriteLine();
        }
        private void RemoveBoard()
        {
            Console.WriteLine("TODO Listesinden not silmek istiyorsanız (1) \nIN PROGRESS Listesinden not silmek istiyorsanız (2)");
            int listesec = int.Parse(Console.ReadLine());
            switch (listesec)
            {
                case 1:
                    Console.WriteLine("Silmek istediğiniz notun başlığını giriniz");
                    string aranan = Console.ReadLine();
                    ToDoList bulunanNot = lists.FirstOrDefault(ToDoList =>
                    ToDoList.Baslik.Equals(aranan, StringComparison.OrdinalIgnoreCase));
                    if (bulunanNot == null)
                    {
                        Console.WriteLine("Aradığınız başlıkta bir not bulunamadı");
                    }
                    else
                    {
                        Console.WriteLine("{0} başlıklı not silinecek emin misin? (Y/N).", aranan);
                        string onay = Console.ReadLine();
                        switch (onay)
                        {
                            case "y":
                                lists.Remove(bulunanNot);
                                Console.WriteLine("{0} başlıklı not silindi.", aranan);
                                break;
                            case "n":
                                Console.WriteLine("Silme işlemi iptal edildi.");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Silmek istediğiniz notun başlığını giriniz");
                    string aranan2 = Console.ReadLine();
                    ToDoList bulunanNot2 = lists2.FirstOrDefault(ToDoList =>
                    ToDoList.Baslik.Equals(aranan2, StringComparison.OrdinalIgnoreCase));
                    if (bulunanNot2 == null)
                    {
                        Console.WriteLine("Aradığınız başlıkta bir not bulunamadı");
                    }
                    else
                    {
                        Console.WriteLine("{0} başlıklı not silinecek emin misin? (Y/N).", aranan2);
                        string onay2 = Console.ReadLine();
                        switch (onay2)
                        {
                            case "y":
                                lists2.Remove(bulunanNot2);
                                Console.WriteLine("{0} başlıklı not silindi.", aranan2);
                                break;
                            case "n":
                                Console.WriteLine("Silme işlemi iptal edildi.");
                                break;
                        }
                    }
                    break;
            }

        }
        private void MoveBoard()
        {

        }
    }
}
