internal class Program
{
    private static void Main(string[] args)
    {
        //Math.Pow() metodunu herhangi bir hazır metod KULLANMADAN yazınız.Math.Pow()gibi içerisine iki parametre almalı ve sonucu DÖNDÜRMELİDİR.(Metodu SADECE pozitif tamsayılar için yazmanız yeterlidir
        Console.WriteLine("Sayı giriniz");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sayının kaçıncı kuvveti alınsın");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{num1} üssü {num2}= "+SayininKuvveti(num1,num2));

    }

    private static int SayininKuvveti(int sayi1, int sayi2)
        {
        int kuvvet = 1;
        for (int i = 1; i <= sayi2; i++)
           {           
            kuvvet = sayi1 * kuvvet;
           }
        return kuvvet;
        }
    

}