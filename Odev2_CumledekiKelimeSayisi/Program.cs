internal class Program
{
    private static void Main(string[] args)
    {
        //Klavyeden girilen bir cümledeki kelime sayısını bulan console uygulamasını yazınız.(Başlangıçta-sondaki boşluklarave kelimeler arası1’den fazlaolan boşluklara dikkat edilmelidir!

        Console.WriteLine("Cümlenizi giriniz");
        string cumle = Console.ReadLine();
        int kelimeSayisi;
        string[] yeniCumle = cumle.Split(' ');

        for (int i = 0; i < yeniCumle.Length; i++)
        {
            if (yeniCumle[i].Contains(' '))
            {
                yeniCumle[i].Remove(i);
            }
        }

        Console.WriteLine("Cümlenizdeki kelime sayısı: " + yeniCumle.Length);



    }
}