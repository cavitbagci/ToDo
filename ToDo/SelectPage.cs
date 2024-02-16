using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class SelectPage
    {
        internal void Main()
        {
            Console.WriteLine("Hangi işlemi yapmak istediğinizi seçiniz.");
            Console.WriteLine("(1) Board Listelemek \n(2) Board'a Kart Eklemek \n(3) Board'dan Kart Silmek \n(4) Kart Taşımak");
            
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine();
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
    }


}
