
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mesaj = "Merhaba";
            //double tutar = 10000;
            //int sayi = 100;
            //bool girisYapmisMi=false;

            //string ad = "Fulden";
            //string soyad = "Özsayın";
            //int dogumYili = 2002;
            //long no = 242935356325;

            //Console.WriteLine(tutar * 1.18);
            //Console.ReadLine();

            Vatandas vatandas1 = new Vatandas(); //Bir tane vatandaş oluşturdum, bir tane instance oluşturduk.
            SelamVer("Fulden");
            SelamVer("Ayşe");
            SelamVer();
            Topla(5,10);//Önreğin bir bankacılık uygulamasında misal kredi hesaplarken vs. kullanırız.
            Topla();

            //string ogrenci1 = "Engin";
            //string ogrenci2 = "Fulden";
            //string ogrenci3 = "Ayşe";


            //REFERANS TİPİ YAPILAR (ARRAY, CLASS, ABSTRACT, STRING)
            string[] ogrenciler = new string[3]; //aşağıdaki new i gören Garbage Collector artık bunu tutan yok diyor bunu memoryden atıyor.
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Fulden";
            ogrenciler[2] = "Ayşe";

            ogrenciler=new string[4];//new i gördüğü an heap te yeni bir alan tanımlıyor
            ogrenciler[3] = "İlker";
            for (int i=0;i<ogrenciler.Length;i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            //int, double, bool => değer tipli değişkenlerdir. Heape değerleri atarız
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;//sayi2 yi değiştirmez çünkü referans tipli değiller
 
            foreach(string sehir in sehirler1)//sehir her bir elemanı gezerken ona verdiğimiz takma isim
            {
                Console.WriteLine(sehir);
            }

            //Generic Collection
            List<string> yeniSehirler1=new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            Person person1 = new Person();
            person1.FirstName = "Fulden";
            person1.LastName = "ÖZSAYIN";
            person1.DateOfBirthYear = 2002;
            person1.NationalIdentity = 123;


            Person person2 = new Person();
            person2.FirstName = "Murat";

            PttManager pttManager =new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }

        static void SelamVer(string isim="İsimsiz") //PARAMETRELİ METOT ÖRNEĞİ
        {
            Console.WriteLine("Merhaba " +isim);
        }
        static int Topla(int sayi1=5, int sayi2=5)
        {
            int sonuc= sayi1 + sayi2;
            Console.WriteLine("Toplam: "+sonuc);
            return sonuc;
        }
    }
}

public class Vatandas
{
    /*//değişkenleri başka classlarda da kullanmak istiyorsak başına public yazılır
    public string ad = "Fulden"; //public yazdığımızda değişken isimlerinin baş harfini büyük yazılması gerekir.(pascal case)
    public string soyad = "Özsayın";
    public int dogumYili = 2002;
    public long no = 242935356325;*/

    //prop (özellikleri)
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}