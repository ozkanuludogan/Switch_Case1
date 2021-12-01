using System;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1=1 , s2,s3, toplam = 0;
            double ortalama = 0.0;
            int soruno = 0;
            double yukseklik, taban, alan;
            int vize, final;
            double yaricap = 0,  cevre = 0;
            const double pi = 3.14; 
            int adet = 0;
            double sayac = 0;
            int cift = 0;
            double kilo, boy, bki = 0;
            double calis, ucret, Ucret;
            int faktoriyel;

            int adet1 = 0;
             int x, y, z;
            Console.WriteLine("Soru Numarası Giriniz..");
            soruno = Convert.ToSByte(Console.ReadLine());
            switch (soruno)
            {
                case 1:
                    
                    Console.WriteLine("1. Sayı Giriniz: ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. Sayıyı Giriniz: ");
                    s2 = Convert.ToInt32(Console.ReadLine());
                    toplam = s1 + s2;
                    ortalama = toplam / 2;
                    Console.WriteLine("ortalama" +ortalama);
                    break;
                case 2:

                    Console.Write("Sayı Giriniz: ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    if (s1 < 0)
                    {
                        Console.Write("Girilen Sayı Negatif.");
                    }
                     else if (s1 > 0)
                    {
                        Console.Write("Girilen Sayı Pozitif.");
                    }
                    else
                    {
                        Console.Write("0 Nötr Bir Sayıdır..");
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    
                    Console.Write("Yüksekliği Giriniz: ");
                    yukseklik = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Kenar Uzunluğunu Giriniz: ");
                    taban = Convert.ToDouble(Console.ReadLine());
                    alan = (taban * yukseklik) / 2;
                    Console.Write("alan:"+alan);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Write("1. Sayıyı Giriniz: ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Sayıyı Giriniz: ");
                    s2 = Convert.ToInt32(Console.ReadLine());
                    if (s1 < s2)
                    {
                        Console.WriteLine("1. Sayı Küçük..");
                    }
                    else
                    {
                        Console.WriteLine("2. Sayı Küçük..");
                    }
                    Console.ReadKey();


                    break;
                case 5:
                    
                    Console.Write("vize : ");
                    vize = Convert.ToInt32(Console.ReadLine());
                    Console.Write("final : ");
                    final = Convert.ToInt32(Console.ReadLine());
                    ortalama = Convert.ToInt32(vize * 0.3 + final * 0.7);

                    Console.WriteLine("ortalamanız: " + ortalama);
                    if (ortalama < 60)
                    {
                        Console.WriteLine("kaldınız");
                    }
                    else
                    {
                        Console.WriteLine("geçtiniz");
                    }
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Write("Dairenin yarıçapını giriniz:");
                    yaricap = Convert.ToInt32(Console.ReadLine());
                    alan = pi * yaricap * yaricap;
                    cevre = 2 * pi * yaricap;
                    Console.WriteLine("Çevre= {0} alan= {1}", cevre, alan);
                    Console.ReadKey();
                    break;
                case 7:
                    
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write(i + ".sayıyı Girin : ");
                        s1 = Convert.ToInt32(Console.ReadLine());
                        if (s1 > 50)
                        {
                            adet++;
                        }
                    }
                    Console.WriteLine("50 den büyük girilen sayı adeti : " + adet);
                    Console.ReadKey();
                    break;
                case 8:
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("{0} Sayı Giriniz: ", (i + 1));
                        s1 = Convert.ToInt32(Console.ReadLine());
                        if (s1 > 100)
                        {
                            sayac++;
                        }
                    }
                    Console.WriteLine("100'den buyuk {0} tane sayı girdiniz", sayac);
                    Console.ReadKey();
                    break;
                case 9:
                    
                    while (s1 != 0)
                    {
                        Console.WriteLine("sayı gir");
                        s1 = Convert.ToInt32(Console.ReadLine());
                        toplam = toplam + s1;
                        adet1 ++;
                    }
                    ortalama = toplam / (adet1 - 1);
                    Console.WriteLine("toplama" + toplam + "ortalama" + ortalama);
                    Console.ReadKey();
                    break;
                case 10:
                   
                    Console.Write("1. Notu Giriniz: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Notu Giriniz: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("3. Notu Giriniz: ");
                    z = Convert.ToInt32(Console.ReadLine());
                    toplam = x + y + z;
                    ortalama = toplam / 3;
                    Console.WriteLine("Toplam :" + toplam);
                    Console.WriteLine("Ortalama :" + ortalama);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Yanlış Soru Numarası Girdiniz..!");
                    break;
                case 11:
                    for (int i = 1; i <= 1000; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadKey();
                    break;
                case 12:
                    Console.Write("Sayı Giriniz: ");
                    s1 = Convert.ToInt32(Console.Read()) ;
                    if (s1 % 3 >= 0 && s1 <= 100)
                    {
                        Console.WriteLine("Girdiğiniz Sayı Geçerli..!");
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz Sayı Geçersiz..!");
                    }
                    Console.ReadKey();
                    break;
                case 13:
                    Console.WriteLine("1'den Kaça Kadar olan sayıları toplamak istiyorsunuz");
                    s1 = int.Parse(Console.ReadLine());
                    s2 = s1;
                    while (s1 >0)
                    {
                        toplam += s1;
                        s1--;
                    }
                    Console.WriteLine("1-{0} arası tamsayılar toplamı{1}", s2, toplam);
                    Console.ReadKey();
                    break;
                case 14:
                    Console.WriteLine("1.Notu Girin");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2.Notu Girin");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("3.Notu Girin");
                    z = Convert.ToInt32(Console.ReadLine());
                    toplam = x + y + z;
                    ortalama = toplam / 3;
                    Console.WriteLine("Toplam :" + toplam);
                    Console.WriteLine("Ortalama :" + ortalama);
                    Console.ReadKey();
                    break;
                case 15:
                    Console.WriteLine("Açıyı giriniz = ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    s2 = Convert.ToInt32(s1 * pi / 180);
                    s3 = s1 * 200 / 180;
                    Console.WriteLine("Radyan = " + s2);
                    Console.WriteLine("Grad = " + s3);
                    Console.ReadKey();
                    break;
                case 16:
                    
                    Console.Write("Bir sayı giriniz: ");
                    s1 = Convert.ToInt16(Console.ReadLine());

                    if (s1 % 2 == 0) 
                    {
                        Console.Write(s1 + " sayisi çift sayıdır.");
                    }
                    else  
                    {
                        Console.Write(s1 + " sayisi tek sayıdır.");
                    }
                    Console.ReadKey(); 
                    break;
                case 17:
                    Console.Write("Sayı giriniz ---> ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    int mutlakDeger = Math.Abs(s1);
                    Console.WriteLine("Girilen sayının mutlak değeri: " + mutlakDeger);
                    break;
                case 18:
                    Console.Write("Lütfen 1. Sayıyı Giriniz = ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Lütfen 2. Sayıyı Giriniz = ");
                    s2 = Convert.ToInt32(Console.ReadLine());
                    if (s1 > s2)
                    {
                        if (s1 % s2 == 0)
                        {
                            Console.Write(s1 + " Sayısı " + s2 + " Sayısına Tam Bölünüyor");
                        }
                        else
                        {
                            Console.Write("Bu Sayılar Birbirine Tam Bölünmez");
                        }
                    }
                    else
                    {
                        if (s2 % s1 == 0)
                        {
                            Console.Write(s2 + " Sayısı " + s1 + " Sayısına Tam Bölünüyor.");
                        }
                        else
                        {
                            Console.Write("Bu Sayılar Birbirine Tam Bölünmez");
                        }
                    }
                    Console.ReadKey();
                    break;
                case 19:
                    Console.Write("Bir sayı giriniz: ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < s1; i++)
                    {
                        if (i % 2 == 0)
                        {
                            cift += i;
                        }

                    }
                    Console.WriteLine(s1 + " Sayısına Kadar Çift Sayıların Toplamı: " + cift);
                    Console.ReadKey();
                    break;
                case 20:
                    Console.Write("A Değerini Giriniz = ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("B Değerini Giriniz = ");
                    s2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("C Değerini Giriniz = ");
                    s3 = Convert.ToInt32(Console.ReadLine());
                    double d = (s2 * s2) - (4 * s1 * s3);
                    if (d == 0)
                    {
                        double yukseklık = -s2 / (2 * s1);
                        Console.WriteLine("Denklemin Bir Kökü Vardır = ");
                        Console.WriteLine("x =" + yukseklık);
                    }
                    else
                    {
                        Console.Write("Sanal Kök Vardır");
                    }
                    Console.ReadKey();
                    break;
                case 21:

                    break;
                case 22:
                    Console.Write("Kilonuzu Giriniz: ");
                    kilo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Boyunuzu Giriniz: ");
                    boy = Convert.ToDouble(Console.ReadLine());
                    bki = kilo / (boy * boy);
                    Console.WriteLine("Vücut Kitle İndexiniz : {0}", bki);
                    if (bki < 18)
                    {
                        Console.Write("Zayıf");
                    }
                    else if (bki >= 18.5 && bki < 24.9)
                    {
                        Console.Write("Normal");
                    }
                    else if (bki >= 24.9 && bki < 34.9)
                    {
                        Console.Write("fazla kilolu");
                    }
                    else if (bki >= 24.9 && bki < 39.9)
                    {
                        Console.Write("1.derece obez");
                    }
                    else if (bki >= 39.9 && bki < 40)
                    {
                        Console.Write("2.derece obez");
                    }
                    else if (bki >= 40 && bki < 45)
                    {
                        Console.Write("3.derece obez");
                    }
                    break;
                case 23:
                    
                    Console.Write("Kaç Saat Çalıştığınızı Yazınız:  ");
                    calis = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Saat Ücreti Giriniz: ");
                    ucret = Convert.ToDouble(Console.ReadLine());
                    if (calis < 40)
                    {
                        Ucret = calis * ucret;
                    }
                    else
                    {
                        Ucret = (calis * 2) * ucret;
                    }
                    Console.Write("Alacağınız Ücret : " + Ucret + " TL ");
                    Console.ReadLine();
                    break;
                case 24:
                    Console.Write("Sayı giriniz: ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Girdiğiniz Sayının Tam Bölenleri: ");
                    for (int i = 1; i <= s1; i++)
                    {
                        if (s1 % i == 0)
                            Console.Write(i + " - ");
                    }
                    break;
                case 25:
                    Console.Write("Faktröriyeli Bulunması İstenen Sayıyı Giriniz: ");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    faktoriyel = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= s1; i++)
                    {
                        faktoriyel = faktoriyel * i;
                    }
                    Console.WriteLine(s1 + "! = " + faktoriyel);
                    break;
            }
            Console.ReadLine();
        }
    }
}
