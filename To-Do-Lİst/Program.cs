namespace To_Do_Lİst
{
    internal class Program
    {
        static List<string> gorevler = new List<string>();
        static void Main(string[] args)
        {
            int secim = -1;

            while (secim != 0)
            {
                Console.Clear();
                Console.WriteLine("----TO-DO-LİST UYGULAMASI----");
                Console.WriteLine("1- Görev Ekle,");
                Console.WriteLine("2- Görevleri Listele,");
                Console.WriteLine("3- Görev Sil,");
                Console.WriteLine("0- Çıkış");
                Console.WriteLine("Seçiminiz; ");
                int.TryParse(Console.ReadLine(), out secim);

                switch (secim)
                {
                    case 1: gorevEkle();
                        break;
                    case 2: gorevleriListele();
                        break;
                    case 3: gorevSil();
                        break;
                    case 0: Console.WriteLine("Çıkış Yapılıyor.");
                        break;
                    default: Console.WriteLine("Geçersiz Seçim");
                        break;
                }
                Console.WriteLine("Devam Etmek İçin Bir Tuşa Basın");
                Console.ReadKey();

            }

            static void gorevEkle()
            {
                Console.WriteLine("Yeni Görev Giriniz: ");
                string yeniGorev = Console.ReadLine();
                gorevler.Add(yeniGorev);
                Console.WriteLine("Görev Eklendi.");
            }

            static void gorevleriListele()
            {
                if (gorevler.Count == 0)
                {
                    Console.WriteLine("Görev Bulunamadı");
                    return;
                }

                for(int i=0; i<gorevler.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {gorevler[i]}");
                }
            }
            static void gorevSil()
            {
                gorevleriListele();
                Console.WriteLine("Silmek İstediğiniz Görevin Numarasını Giriniz:");
                int index;
                int.TryParse(Console.ReadLine(), out index);
                index -= 1;

                if(index>=0&& index < gorevler.Count)
                {
                    Console.WriteLine($"'{gorevler[index]}' silindi.");
                    gorevler.RemoveAt(index);
                }

                else
                {
                    Console.WriteLine("Geçersiz Görev Numarası Girdiniz.");
                }
            }
        }
    }
}
