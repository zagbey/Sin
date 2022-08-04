// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//bu kadar duygusuz anlatan hoca görmedim evet bilnçsiz dönüşüm 

byte a = 5 ;
sbyte b = 30 ;
short c = 10 ;

int d = a+b+c ;
Console.WriteLine("d"+d);

long h = d ;
Console.WriteLine("h"+h);

float i = h ;
Console.WriteLine("i"+i);

// ne varsa bunla bilreştir ekrana yazdır 
object g = h+i+d;

//Explicit yani bilinçi kullanıcı dönüşümü sadece akıllı insanlar yapabilir evet doğru bildin sen yapamassın 

Console.WriteLine("******* expiilicit konverseyşın*****") ;

int x = 4;
byte y = (byte)x ;
Console.WriteLine("y"+y);

int z = 100 ;
byte t = (byte)z;
Console.WriteLine("t"+t);

// ToString 

string zz = 12.5f.ToString();
Console.WriteLine("zz"+zz);

//System.Convert 

Console.WriteLine("sitemli bişey");

string s1 = "10" , s2 = "20";
int sayi1,sayi2 ;
int Toplam ;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);

Toplam = sayi1+sayi2;
Console.WriteLine(Toplam);

//parse
 Console.WriteLine(Toplam);
 ParseMethod();

public static void ParseMethod()
{
    string metin = "20";
    string metin2 = "10.25";
    int rakam1;
    double double1; 
    
    rakam1 = Int32.Parse(metin);

}




