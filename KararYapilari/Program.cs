using System;

namespace KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            //Karar Yapilari : if=> programin akisini duruma gore degistirmeye yarar
            //            //3 adet karar yapisi vardir.
            //            //1- if-else
            //            //2-switch-case
            //            //3-ternary-if
            //            /*
            //                 Karşılaştırma operatörleri
            //            1)  == karsilikli iki değişkeni birbiriyle esit olması durumu 
            //            2) !=   karsilikli iki değişkeni birbiriyle esit olmaması durumu 
            //             3)  <  soldaki degerin sagdaki değerden kucuk olma durumu
            //            4)   >  soldaki değerin sağdaki değerden buyuk olma durumu
            //            5)  <=  ve >=  ifadeleri ise soldaki değerin sağdaki değerle buyuk esit durumu kıyaslar
            //            */

            //            #region If-Else
            //            //iki durum için kıyaslama örenği
            //            //Console.Write("kullici kodu giriniz:");
            //            //string username = Console.ReadLine();
            //            //if (username == "admin") 
            //            //{
            //            //    Console.WriteLine("hoşgeldiniz sayin admin...");
            //            //}
            //            //else
            //            //{
            //            //    Console.WriteLine("tanıyamadık sizi...");
            //            //}

            //            //birden fazla durum için 
            //            //Console.Write("haftanın kaçıncı gunu olduğunu giriniz:");
            //            //string haftagunu = Console.ReadLine();

            //            //if (haftagunu == "1")
            //            //{
            //            //    Console.WriteLine("pazartesi");
            //            //}
            //            //else if (haftagunu == "2") { Console.WriteLine("sali"); }
            //            //else if (haftagunu == "3") { Console.WriteLine("çarşamba"); }
            //            //else if (haftagunu == "4") { Console.WriteLine("perşembe"); }
            //            //else if (haftagunu == "5") { Console.WriteLine("cuma"); }
            //            //else if (haftagunu == "6") { Console.WriteLine("cumartesi"); }
            //            //else if (haftagunu == "27") { Console.WriteLine("pazar"); }
            //            //else { (Console.WriteLine("1-7 arasında bir değer giriniz."); }
            //            #endregion


            //            #region sorULAR
            //            //kullanıcıdan alınan sayinin tek mi çift mi

            //            Console.Write("bir sayi giriniz:");
            //            int sayi = Convert.ToInt32(Console.ReadLine());
            //            if (sayi % 2 == 0)
            //            {
            //                Console.WriteLine("girdiğiniz sayi çift");
            //            }
            //            else
            //            {
            //                Console.WriteLine("girdiğiniz sayi tek");
            //            }

            //            //EKRANDAN ALINAN SUYUN CICAKLIĞI İLE KATI SIVI GAZ
            //            Console.Write("sıcaklık değerini giriniz:");
            //            int derece = Convert.ToInt32(Console.ReadLine());

            //            if (derece <= 0)
            //            {
            //                Console.WriteLine("katı");
            //            }
            //            else if (derece > 100)
            //            {
            //                Console.WriteLine("sıvı");
            //            }
            //            else
            //            {
            //                Console.WriteLine("gaz");
            //            }
            //            #endregion

            //            #region mantıksal operatörler
            //            /*
            //             birden fazla durumun aynı anda kontrol edilmesi senaryosunda kullanılan operatörlerdir.
            //              && (ve) 
            //               || (veya)

            //                Console.Write("sıcaklık değerini giriniz:");
            //            int derece= Convert.ToInt32(Console.ReadLine());

            //            if (derece <= 0)
            //                {
            //                Console.WriteLine("katı");
            //            }
            //            else if ( derece >=0 && derce <100)
            //            {
            //                Console.WriteLine("sıvı");
            //            }
            //            else if( derece >=100)
            //                    {
            //                Console.WriteLine("gaz");
            //            }
            //             */
            //            #endregion

            //            #region soru2
            //            // kullanıcı adı ve şifre istenecek kullanıcı adı admi
            //            //şifre 123 ikisi birden doğru girildiyse hoşgeldiniz 
            //            // diğer durumda hataları ekrana bastırınız
            //            string kullaniciadi = "admin";
            //            Console.WriteLine("kullanıcı adınızı giriniz:");
            //            string ad = Console.ReadLine();

            //            int sifre = 123;
            //            Console.WriteLine("şifreyi giriniz:");
            //            int passworrd = Convert.ToInt32(Console.ReadLine());

            //            if (ad == kullaniciadi && passworrd == sifre)
            //            {
            //                Console.WriteLine(" hoşgeldiniz");
            //            }
            //            else
            //            {
            //                Console.WriteLine("hatalı giriş");
            //            }
            //            #endregion

            //            #region soru3

            //            //girilen not 0-30 arasında ise ff
            //            //30-50 arasında dd
            //            //    50-70 arasında bb
            //            //    70-100 arasında aa
            //            //    olacak şekilde  kullanıcıyı bilgilendir


            //            Console.WriteLine("sınav notunuzu giriniz");
            //            int not = Convert.ToInt32(Console.ReadLine());
            //            if (not >= 0 && not <= 30)
            //            {
            //                Console.WriteLine("FF");
            //            }

            //            else if (not >= 30 && not <= 50)
            //            {
            //                Console.WriteLine("DD");
            //            }

            //            else if (not >= 70 && not <= 100)
            //            {
            //                Console.WriteLine("AA");
            //            }

            //            #endregion

            //            #region SORU4
            //            //DIŞARIDAN URUN ADI GİRİLECEK
            //            //PROGRAM URUNUN HANGİ REYONDA OLDUĞUNU SÖYLEYECEK 
            //            // DOMATES, BİBER,PATLICAN İÇİN SEBZE REYONU
            //            //DİŞ MACUNU , PARFUM , KREM İÇİN KOZMETİK REYONU
            //            //TELEFON, BİLGİSAYAR,SES SİSTEMLERİ İÇİN TEKNOLOJİ REYONU
            //            //BUNLARDAN FARKLI URUN GİRER İSE "BU URUN BİZDE YOK " UYARISI VERECEK

            //            string sebze;
            //            string kozmetik;
            //            string teknoloji;
            //            Console.WriteLine("ürün  ismi giriniz:");
            //            sebze = Console.ReadLine();
            //            kozmetik = Console.ReadLine();
            //            teknoloji = Console.ReadLine();
            //            if (sebze == "domates")
            //            { Console.WriteLine(sebze + "girdiğiniz ürün sebze"); }

            //            else if (sebze == "patlıcan")
            //            { Console.WriteLine(sebze + "girdiğiniz ürün sebze"); }

            //            else if (sebze == "biber")
            //            { Console.WriteLine(sebze + "girdiğiniz ürün sebze"); }

            //            else if (kozmetik == "diş macunu")
            //            { Console.WriteLine(kozmetik + "girdiğiniz ürün kozmetik"); }

            //            else if (kozmetik == "parfüm")
            //            { Console.WriteLine(kozmetik + "girdiğiniz ürün kozmetik"); }

            //            else if (kozmetik == "krem")
            //            { Console.WriteLine(kozmetik + "girdiğiniz ürün kozmetik"); }

            //            else if (teknoloji == "bilgisayar")
            //            { Console.WriteLine(kozmetik + "girdiğiniz ürün kozmetik"); }

            //            else if (teknoloji == "ses sistemleri")
            //            { Console.WriteLine(kozmetik + "girdiğiniz ürün kozmetik"); }

            //            else if (teknoloji == "telefon")
            //            { Console.WriteLine(kozmetik + "girdiğiniz ürün kozmetik"); }

            //            else
            //            {
            //                Console.WriteLine("BU URUN BİZDE YOK");

            //            }
            //            #endregion


            //            #region soru5
            //            int fiyat = 5, siparişAdet;
            //            float indirimlitutar, toplamtutar, odenecektutar;

            //            Console.WriteLine("siparis sayısını giriniz:");
            //            siparişAdet = Convert.ToInt32(Console.ReadLine());
            //            if (siparişAdet < 20)
            //            {
            //                indirimlitutar = siparişAdet * 0.05f * fiyat;
            //                toplamtutar = siparişAdet * fiyat;
            //                odenecektutar = toplamtutar - indirimlitutar;
            //                Console.WriteLine("siparis sayisi:" + siparişAdet);
            //                Console.WriteLine("ürün fiyati:" + fiyat);
            //                Console.WriteLine("toplam tutar:" + toplamtutar);
            //                Console.WriteLine("indirim oranı:0.05");
            //                Console.WriteLine("indirim tutarı:" + indirimlitutar);
            //                Console.WriteLine("ödenecek tutar:" + odenecektutar);

            //            }
            //            else if (siparişAdet >= 20 && siparişAdet < 50)
            //            {
            //                indirimlitutar = siparişAdet * 0.1f * fiyat;
            //                toplamtutar = siparişAdet * fiyat;
            //                odenecektutar = toplamtutar - indirimlitutar;
            //                Console.WriteLine("siparis sayisi:" + siparişAdet);
            //                Console.WriteLine("ürün fiyati:" + fiyat);
            //                Console.WriteLine("toplam tutar:" + toplamtutar);
            //                Console.WriteLine("indirim oranı:0.10");
            //                Console.WriteLine("indirim tutarı:" + indirimlitutar);
            //                Console.WriteLine("ödenecek tutar:" + odenecektutar);
            //            }
            //            else if (siparişAdet >= 50 && siparişAdet < 100)
            //            {
            //                indirimlitutar = siparişAdet * 0.15f * fiyat;
            //                toplamtutar = siparişAdet * fiyat;
            //                odenecektutar = toplamtutar - indirimlitutar;
            //                Console.WriteLine("siparis sayisi:" + siparişAdet);
            //                Console.WriteLine("ürün fiyati:" + fiyat);
            //                Console.WriteLine("toplam tutar:" + toplamtutar);
            //                Console.WriteLine("indirim oranı:0.15");
            //                Console.WriteLine("indirim tutarı:" + indirimlitutar);
            //                Console.WriteLine("ödenecek tutar:" + odenecektutar);
            //            }
            //            else
            //            {
            //                indirimlitutar = siparişAdet * 0.2f * fiyat;
            //                toplamtutar = siparişAdet * fiyat;
            //                odenecektutar = toplamtutar - indirimlitutar;
            //                Console.WriteLine("siparis sayisi:" + siparişAdet);
            //                Console.WriteLine("ürün fiyati:" + fiyat);
            //                Console.WriteLine("toplam tutar:" + toplamtutar);
            //                Console.WriteLine("indirim oranı:0.20");
            //                Console.WriteLine("indirim tutarı:" + indirimlitutar);
            //                Console.WriteLine("ödenecek tutar:" + odenecektutar);
            //            }
            //            #endregion

            //            #region Ternary If
            //            //eğer tek satırda ufak bir karar mekanızması ile yolumuza devam etmek istersek 
            //            //soru işareti operatoru size bu konuda yardımcı olucaktır
            //            //  sonuc>10 ? "true olduğunda calısacak kod":"false olduğunda çalısacak kod:"

            //            int x = 10, y = 100;
            //            int? yas= null;

            //            var result = x > y ? "x büyüktür y" : "x küçüktür y";
            //            var sonuc = yas == null ? 0 : yas;
            //            Console.WriteLine(result);

            //           #endregion

            //          #region Switch Case
            ////            /* is-else mantığı ilw çalışır.aradaki fark 
            ////             if -else büyüklük küçüklük gibi durumları kontrol ederken
            ////            switch case  yalnızca eşitlik durumlarını kontrol eder.
            ////            kendisine ait bir indexleme mekanizması vardır.
            ////            sıraya koyar otomatik olarak yüzlerce koşulumuz olsa biile herbirine bakmadan
            ////            hangisine eşit ise oraya konumlanır.

            ////            switch içerisindeki veri tipiniz ne ise casede de ayni veri tipi olmalıdır.
            ////            

            //           Console.WriteLine("mevsim giriniz:");
            //            string mevsim = Console.ReadLine();

            //       switch (mevsim)
            //         {
            //                case "KIŞ":
            //                    mesaj="ARALIK,OCAK,ŞUBAT";
            //                break;
            //                         case "İLKBAHAR":
            //                   mesaj = "MART,NİSAN,MAYIS";
            //                   break;
            //               case "YAZ":
            //                 mesaj = "HAZİRAN,TEMMUZ,AĞUSTOS";
            //                   break;
            //             case "SONBAHAR":
            //                   mesaj = "EYLÜL,EKİM,KASIM";
            //                   break;
            //               default://ÖNGÖRÜLEN BİR DURUM HARİCİ DEĞERLE KARŞILAŞIRSAK,
            //                  //VARSAYILAN OLARAK BURAYA GİRER.KULLANMASANIZDA OLUR.
            //                    break;
            //     }
            //            Console.WriteLine(mesaj);

            //          #endregion

            #region switch case soru:
            //ekrandan rol okutalım:
            // eğer admin girilirse ekrana "admin sayfasına yönlendiriliyorsunuz"mesajı versin
            // eğer satiş derse "satış sayfa"sına yönlendiriliyorusnuz
            //eğer uye giriş yaparsa "uye sayfasına yönlendiriliyorsunuz" diye mesaj verin

            Console.WriteLine("rol giriniz:");
            string rol = Console.ReadLine();
            switch(rol)
            {
                case "modetayor":
                case "CEO":
                case "Admin":
                    Console.WriteLine("admin sayfasına yönlendiriliyorsunuz...");
                    break;
                case "Satis":
                    Console.WriteLine("satiş sayfasına yönlendiriliyorsunuz...");
                    break;
                case "uye":
                    Console.WriteLine("üye sayfasına yönlendiriliyorsunuz...");
                    break;
                default:
                    break;
            }
            #endregion


            #region soru2
            /*
             *ekrandan ay okutun 1 girilirse Ocak 2girilirse Şubat....  girilirse Aralık yazsın
             */

            Console.WriteLine("bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch(sayi)
            {
                case 1:Console.WriteLine("ocak"); 
                    break;
                case 2: Console.WriteLine("şubat");
                    break;
                case 3:
                    Console.WriteLine("mart");
                    break;
                case 4:
                    Console.WriteLine("nisan");
                    break;
                case 5:
                    Console.WriteLine("mayıs");
                    break;
                case 6:
                    Console.WriteLine("haziran");
                    break;
                case 7:
                    Console.WriteLine("temmuz");
                    break;
                case 8:
                    Console.WriteLine("ağustos");
                    break;
                case 9:
                    Console.WriteLine("eylül");
                    break;
                case 10:
                    Console.WriteLine("ekim");
                    break;
                    case 11:Console.WriteLine("kasım"); 
                    break;
                case 12: Console.WriteLine("aralık");
                    break;
                default:
                    break;
            }

            #endregion
            #region SORU3 İÇ İÇE SWİTCH
            //KULLANICI ADI VE ŞİFRE
            //EĞER KULLANICI ADI VE ŞİFRE DOĞRU İSE "TEBRİKLER HEM KULLANICI ADI VE ŞİFRE DOĞRU"
            //KULLANIIC ADI DOĞRU ŞİFRE YANLIŞ İSE "KULLANICI ADI DOĞRU ŞİFRE YANLIŞ"
            //KULLANICI ADI YANLIŞ ŞİFRE DOĞRU İSE "KULLANICI ADINIZ YANLIŞ ANCAK ŞİFRE DOĞRU"
            //MESAJINI VERİNİZ..

            Console.WriteLine("user name");
            string? username = Console.ReadLine();

            Console.WriteLine("password");
            string? password = Console.ReadLine();

            switch(username)
            {
                case "admin":
                    switch(password)
                    {
                        case "123":
                            Console.WriteLine("tebrikler kullanıcı adı ve şifre doğru");
                            break;
                        default:
                            Console.WriteLine("kullaıcı adı doğru ancak şifre yanlış");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("kullanıcı adınız yanlış");
                    break;
            }
            #endregion
        }
    }
}
