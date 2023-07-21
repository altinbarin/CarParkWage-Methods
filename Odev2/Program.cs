internal class Program
{
    private static void Main(string[] args)
    {
        //Klavyeden girilen bir cümlede bir kelimeyi aratan, bulursa o kelimenin cümlede kaç defa bulunduğunu bulan console uygulamasını yazınız.(Büyük-küçük harf duyarlılığı OLMAMALIDIR)
        Console.WriteLine("Cümle giriniz");
        string cumle = Console.ReadLine().ToLower();
        Console.WriteLine("Aratacağınız kelimeyi giriniz");
        string kelime = Console.ReadLine().ToLower();
        int sayac = 0;
        string[] yeniCumle = cumle.Split(' ');
        for (int i = 0; i < yeniCumle.Length; i++)
        {
            if (yeniCumle[i].Contains(kelime))
            {
                sayac++;
            }
        }

        Console.WriteLine($"Cümleniz {sayac} adet \"{kelime}\" içeriyor");

    }
}