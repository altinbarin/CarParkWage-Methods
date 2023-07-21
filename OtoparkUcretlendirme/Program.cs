internal class Program
{
    static string aracSecimi;
    static double saatBilgisi, ucret, gunlukUcret;
    private static void Main(string[] args)
    {
        AcilisEkrani();
        UcretHesaplamasi();

    }

    
    /// <summary>
    /// kullanıcıdan saat bilgisi alınıyor
    /// </summary>
    private static void SaatBilgisi()
    {
        Console.WriteLine("Aracını kaç saat boyunca park alanında kaldı?");
        try
        {
            saatBilgisi= Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Geçersiz bir değer girdiniz.Lütfen tekrar deneyiniz");
            SaatBilgisi();
        }
        Math.Ceiling(saatBilgisi);
    }

    /// <summary>
    /// kullanıcıdan arac tipi alınıyor ve secilen araca gore metotlara yonlendirilip ucret hesaplatılıyor
    /// </summary>
    private static void UcretHesaplamasi()
    {
        Console.WriteLine("Lütfen araç tipinizi seçiniz[Otomobil için 1'e, Motosiklet için 2'ye, Minibüs için 3'e, Kamyon ve diğer ticari araçlar için 4'e basınız");
        aracSecimi = Console.ReadLine();
            switch (aracSecimi)
            {
                case "1":
                Otomobil();
                    break;
                case "2":
                Motosiklet();
                    break;
                case "3":
                Minibus();
                    break;
                case "4":
                Kamyon();
                    break;

                default:
                Console.WriteLine("Geçersiz işlem yaptınız. Lütfen tekrar deneyiniz");
                UcretHesaplamasi();
                break;
            }      
    }

    /// <summary>
    /// Aracın tipi kamyon seçildiği durumda, saat bilgisiyle beraber total ücret hesaplanıyor
    /// </summary>
    private static void Kamyon()
    {
        SaatBilgisi();
        if (saatBilgisi > 0 && saatBilgisi <= 2)
        {
            ucret = 15;
        }
        else if (saatBilgisi > 2 && saatBilgisi <= 6)
        {
            ucret = 30;
        }
        else if (saatBilgisi > 6 && saatBilgisi <= 12)
        {
            ucret = 60;
        }
        else if (saatBilgisi > 12 && saatBilgisi <= 24)
        {
            ucret = 100;
        }
        else if (saatBilgisi > 24)
        {
            gunlukUcret = Math.Ceiling((saatBilgisi / 24));
            ucret = 100 + ((gunlukUcret) * 55);
        }
        Console.WriteLine($"Kamyon-Ticari Aracınız için ödenmesi gereken tutar {ucret}TL.");
    }

    /// <summary>
    /// Aracın tipi minibus seçildiği durumda, saat bilgisiyle beraber total ücret hesaplanıyor
    /// </summary>
    private static void Minibus()
    {
        SaatBilgisi();
        if (saatBilgisi > 0 && saatBilgisi <= 2)
        {
            ucret = 8;
        }
        else if (saatBilgisi > 2 && saatBilgisi <= 6)
        {
            ucret = 16;
        }
        else if (saatBilgisi > 6 && saatBilgisi <= 12)
        {
            ucret = 32;
        }
        else if (saatBilgisi > 12 && saatBilgisi <= 24)
        {
            ucret = 45;
        }
        else if (saatBilgisi > 24)
        {
            gunlukUcret = Math.Ceiling((saatBilgisi / 24));
            ucret = 455 + ((gunlukUcret) * 25);
        }
        Console.WriteLine($"Minibüsünüz için ödenmesi gereken tutar {ucret}TL.");
    }


    /// <summary>
    /// Aracın tipi motosiklet seçildiği durumda, saat bilgisiyle beraber total ücret hesaplanıyor
    /// </summary>
    private static void Motosiklet()
    {
        SaatBilgisi();
        if (saatBilgisi > 0 && saatBilgisi <= 2)
        {
            ucret = 0;
        }
        else if (saatBilgisi > 2 && saatBilgisi <= 6)
        {
            ucret = 3;
        }
        else if (saatBilgisi > 6 && saatBilgisi <= 12)
        {
            ucret = 6;
        }
        else if (saatBilgisi > 12 && saatBilgisi <= 24)
        {
            ucret = 12;
        }
        else if (saatBilgisi > 24)
        {
            gunlukUcret = Math.Ceiling((saatBilgisi / 24));
            ucret = 12 + ((gunlukUcret) * 10);
        }
        Console.WriteLine($"Motosikletiniz için ödenmesi gereken tutar {ucret}TL.");
    }


    /// <summary>
    /// Aracın tipi otomobil seçildiği durumda, saat bilgisiyle beraber total ücret hesaplanıyor
    /// </summary>
    private static void Otomobil()
    {
        SaatBilgisi();
        if (saatBilgisi>0 && saatBilgisi<=2)
        {
            ucret = 5;
        }
        else if(saatBilgisi>2 && saatBilgisi<=6)
        {
            ucret = 10;
        }
        else if(saatBilgisi>6 && saatBilgisi<=12)
        {
            ucret = 20;
        }
        else if(saatBilgisi>12 && saatBilgisi<=24)
        {
            ucret = 35;
        }
        else if(saatBilgisi>24)
        {
            gunlukUcret = Math.Ceiling((saatBilgisi / 24));
            ucret = 35 + ((gunlukUcret)*20);
        }
        Console.WriteLine($"Otomobiliniz için ödenmesi gereken tutar {ucret}TL.");
    }

    /// <summary>
    /// açılış mesajı ekrana yazdırılıyor
    /// </summary>
    private static void AcilisEkrani()
    {
        Console.WriteLine("FurkanPark uygulamasın hoşgeldiniz");
    }

}