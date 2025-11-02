namespace Hafta6_ödev
{
    internal class Program
    {
        static void Main(string[] args)
        /* Kaan Bakış  */
        {
            Console.WriteLine("Bir N değeri giriniz");
            int N = int.Parse(Console.ReadLine());
            int[,] matris = new int[N, N];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matris[i, j] = rnd.Next(-9, 10);
                }
            }
            Console.WriteLine("Oluşturulan Matris:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matris[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matris oluşturuldu.");
            // Asal köşegen üzerindeki sayıların toplamını bulun.
            int asalKosegenToplam = 0;
            for (int i = 0; i < N; i++)
            {
                asalKosegenToplam += matris[i, i];
            }
            Console.WriteLine("Asal köşegen üzerindeki sayıların toplamı: " + asalKosegenToplam);
            // Yardımcı köşegen üzerindeki sayıların çarpımını bulun.
            int yardimciKosegenCarpim = 1;
            for (int i = 0; i < N; i++)
            {
                yardimciKosegenCarpim *= matris[i, N - 1 - i];
            }
            Console.WriteLine("Yardımcı köşegen üzerindeki sayıların çarpımı: " + yardimciKosegenCarpim);
            // Matrisin içinde kaç adet negatif sayı olduğunu sayın.
            int negatifSayiAdedi = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matris[i, j] < 0)
                    {
                        negatifSayiAdedi++;
                    }
                }
            }
            Console.WriteLine("Matrisin içinde kaç adet negatif sayı olduğu: " + negatifSayiAdedi);
            // Matrisin içinde en sık tekrar eden sayıyı bulun.
            int enSikTekrarEdenSayi = matris[0, 0];
            int enSikTekrarEdenSayiAdedi = 1;
            for (int i = -9; i <= 9; i++)
            {
                int sayac = 0;
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        if (matris[j, k] == i)
                        {
                            sayac++;
                        }
                    }
                }
                if (sayac > enSikTekrarEdenSayiAdedi || (sayac == enSikTekrarEdenSayiAdedi && i < enSikTekrarEdenSayi))
                {
                    enSikTekrarEdenSayiAdedi = sayac;
                    enSikTekrarEdenSayi = i;
                }
            }
            Console.WriteLine("Matrisin içinde en sık tekrar eden sayı: " + enSikTekrarEdenSayi);
            // Matris içindeki asal sayıların ortalamasını hesaplayın.
            int asalSayiToplami = 0;
            int asalSayiAdedi = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int sayi = matris[i, j];
                    if (sayi > 1)
                    {
                        bool asalMi = true;
                        for (int k = 2; k <= Math.Sqrt(sayi); k++)
                        {
                            if (sayi % k == 0)
                            {
                                asalMi = false;
                                break;
                            }
                        }
                        if (asalMi)
                        {
                            asalSayiToplami += sayi;
                            asalSayiAdedi++;
                        }
                    }
                }
            }
            if (asalSayiAdedi > 0)
            {
                double asalSayiOrtalamasi = (double)asalSayiToplami / asalSayiAdedi;
                Console.WriteLine("Matris içindeki asal sayıların ortalaması: " + asalSayiOrtalamasi);
            }
            else
            {
                Console.WriteLine("Asal sayı yok.");
            }
            // Son olarak matrisi saat yönünde 90 derece döndürün ve yeni halini ekrana yazdırın.
            int[,] donmusMatris = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    donmusMatris[j, N - 1 - i] = matris[i, j];
                }
            }
            Console.WriteLine("Matrisi saat yönünde 90 derece döndürülmüş hali:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(donmusMatris[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}