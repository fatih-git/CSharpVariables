using System;

namespace DEgiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEğişkenelr boş bırakılamaz. Boş bırakmak için null atanmalıdır
            string deger=null;  //Sınırsız uzunlukta yer kaplar
            string deger2 = string.Empty; //null
            //Bunun dışında string birleştirm filan diğer dillerle aynı

            //sayısal değerler null atanamaz
            int sayi = 15;
            Console.WriteLine(deger + sayi);

            byte b = 5;     //0||255
            sbyte a = -5;   //-128||127

            Int16 i16 = 2;  //2byte
            int i = 3;
            Int32 i32 = 4;  //4byte
            Int64 i64 = 5;  //8byte
            long l = 7;
            
            float f = 7.5F;     //Float kullanırken virgüllü sayı kullnaılacaksa sonunsa girilen değerin sonuna F eklnemleidir.
            Console.WriteLine(f);
            //Yani aslında float e sayısı pi sayısı vb sayılar için kullanmak verimlidir yoksa double kullan
            //4 byte

            double d = 7.5;     //double böyle bir gereksinim duymaz
            Console.WriteLine(d);
            //8 byte
            //Aradaki byte farkından dolayı 8byte ihtiyacın yoksa RAM'i yormamak için double yarine float kullanmak da mantıklıdır.

            decimal dec = 21.1M;    //float gibi decimale'de M koymak gerekir ondalıklı sayılar için
            Console.WriteLine(dec);
            //16 byte

            char harf = 'c';

            DateTime dt = DateTime.Now; //Bu DAteTime kütüphanesinden alınan bir değişkendir.
            Console.WriteLine(dt);
            //Yanına yazdığım .Now uygulama çalıştırıldığı andaki tarihi verecektir. Saniyesine kadar değer üretir

            //Objeler aklına gelebilecek her şeyi tutar
            object o1 = "fatih";
            object o2 = 'f';
            object o3 = 7;
            object o4 = 7.5;
            object o5 = DateTime.Now;
            Console.WriteLine(o1 + " " + o2 + " " + o3 + " " + o4 + " " + o5);

            bool z = true;  //mantıksal

            //Değişken Dönüşümleri

            string str20 = "20";
            int int20 = 22;

            string yeni= str20 + int20.ToString();
            Console.WriteLine(yeni);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            //Convert.To... ile farklı farklı dönüşümler yapılabilir.

            int int22 = int20 + int.Parse(str20);   //42
            //Parse string'den dönüşüm için kullanılır.

            string tarih = DateTime.Now.ToString("dd.MM.yyyy"); //M=month; m=minute
            Console.WriteLine(tarih);
            //Bu şekilde datetime'ı string'e çaviririm
            //Parantez içinde belirttiğim ile zaman verilmez "." gösterim ile sadece tarih verilecektir.

            //saat
            string saat = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(saat);
        }
    }
}
