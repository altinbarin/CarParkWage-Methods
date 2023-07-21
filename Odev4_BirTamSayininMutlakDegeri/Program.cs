using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        // Math.Abs()gibi hazır bir metod KULLANMADANbir tamsayının mutlak değerini DÖNDÜREN bir metod yazınız. (Mutlak değeri alınacak sayı metoda parametre olarak verilmelidir.)
        Console.WriteLine("Bir sayı giriniz");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mutlak değeri: " + MutlakDeger(num1));

    }


    /// <summary>
    /// sayi1 negatif ise  -1 ile çarpan, pozitif ise aynı değerini döndüren metot
    /// </summary>
    /// <param name="sayi1">mutlak değeri alınacak sayi</param>
    /// <returns></returns>
    static int MutlakDeger(int sayi1)
    {
        sayi1 = sayi1 < 0 ? sayi1 * -1 : sayi1;
        return sayi1;
    }

}