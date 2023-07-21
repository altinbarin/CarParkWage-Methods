internal class Program
{
    private static void Main(string[] args)
    {
        //Klavyeden girilen bir kelimenin sesli harf içerip içermediğini bulan console uygulamasını yazınız.

        Console.WriteLine("Kelime giriniz");
        string kelime = Console.ReadLine().ToLower();
        string sesliHarf = "aeiouı";

        for (int i = 0; i < kelime.Length; i++)
        {
            if (kelime.Contains(sesliHarf[i]))
            {
                Console.WriteLine("Kelimeniz sesli harf içerir");
                break;
            }
            else
            {
                Console.WriteLine("kelimenizde hiç sesli harf bulunmamaktadır");
                break;
            }
        }
       

    }
}