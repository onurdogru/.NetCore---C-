using System;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/// <summary>
/// ///////////
/// </summary>
/// 
/// 1- DEĞİŞKENLER ///
//int sayi1 = 10;
//int sayi2 = 12;
//Console.WriteLine(sayi1 + sayi2);

//string name = "Onur";
//string surname = "Dogru";
//Console.WriteLine(name + surname);
///////////////////////////
//Bir ürünün satışda olup olmadığının bilgisini tutacak değişken
//bool satistami = true;
//bool _satistami = false;
/////////////////////////////////////
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 2 - VERİ TİPİ DÖNÜŞÜM
/// 
// Console.Write("1.sayi: ");
// int sayi3 = int.Parse(Console.ReadLine());

// Console.Write("2.sayi: ");
// int sayi4 = int.Parse(Console.ReadLine());

// int toplam = sayi3 + sayi4;
// Console.WriteLine($"girilen toplam değer: {toplam}");

// double g = 10.6;
// float h = (float)g;

//Kısa ve Uzun kenarı girilen dikdörtgenin alan ve çevresini hesap et.

// Console.Write("kısa kenar: ");
// int kisa = int.Parse(Console.ReadLine());

// Console.Write("uzun kenar: ");

// int alan = kisa*uzun;
// int cevre = (kisa+uzun)*2;
// Console.WriteLine("alan : "+ alan + " "+ "çevre :" + cevre);




// 3 - STRING VERI TIPI
// string name ="Onur";
// string surname ="True";
// int age = 36;
// Console.Write("Şehir Yazınız : ");
// string sehir = Console.ReadLine();

// Console.WriteLine(name + age + surname + sehir);
//3A- DİZİ METOTOLARI
//karakter uzunluk ölçme.
// string mesaj = "Hello My Name is Onur";
// Console.WriteLine(mesaj.Length);

//4 - DİZİLER/ARRAYLER
// string mesaj = "Hello My Name is Onur";
// Console.WriteLine(mesaj.Length);
// Console.WriteLine(mesaj[4]);

// string[] isimler = new string[2]; //toplam girilen array sayısı
// isimler[0] = "Onur";
// isimler[1]=  "Duygu";

// Console.WriteLine(isimler[1]); //yazdırmak istediğin array 

//5-DİZİLER METOTOLARI
//6- DATETIME İLE ÇALIŞMA

// DateTime simdi = DateTime.Now;
// Console.WriteLine(simdi);

///OPERATÖRLER//
//Aritmatik Operatörler///

// int a = 10;
// int b = 20;
// int value = a+b;
// Console.WriteLine(value);

//Atama Opöratörleri Soruları
//int x=2, y=5, z=10;
//a) Kullanıcıdan aldığınız 2 sayının çarpımı ile xyz toplamının farkı nedir
//b) Kullanıcıdan alınan bir sayının tek çift kontrolünü yapınız.


//a)
// Console.Write("1.sayi: ");
// int sayi1 = int.Parse(Console.ReadLine());

// Console.Write("2.sayi: ");
// int sayi2 = int.Parse(Console.ReadLine());

// int sonuc =(sayi1 * sayi2) - (x+y+z);
// Console.WriteLine("sonuc :" + sonuc);

//b)
// Console.Write("sayi: ");
// int sayi = int.Parse(Console.ReadLine());

// bool sonuc = (sayi % 2) ==0?true:false;
// Console.WriteLine($"girilen sayı çiftmi : {sonuc}");

// KARŞILAŞTIRMA OPERATÖRLERİ
//MANTIKSAL OPERATÖRLER
//ÖRNEKLER
//SORU1 :Girilen 2 sayıdan hangisi büyüktür?
// Console.WriteLine("sayı 1: ");
// int sayi1 = int.Parse(Console.ReadLine());

// Console.WriteLine("sayı 2: ");
// int sayi2 = int.Parse(Console.ReadLine());

// var result = (sayi1>sayi2);
// Console.WriteLine(result);

//KONU : IF - ELSE - ELSE IF

// string username = "onur";


// if (username == "onurr")
// {
    
//     Console.WriteLine("Welcome to Mars! Mr. GroovyPrimat");
// }
// else
// {
// Console.WriteLine("Yanlış");
// }

// int x=10;
// int y=10;

// if(x>y)
// Console.WriteLine("x yden büyük");
// else if (x==y)
// Console.WriteLine("x ve y eşit");
// else
// Console.WriteLine("y xden büyük");

//IF ELSE SORUSU : Kullanıcıdan İsim ve yaş bilgisi isteyip, ehliyet durumunu kontrol ediniz. ################

// Console.Write("Ad :");
// string Ad = Console.ReadLine(); //Girilen Satırı okuma için

// Console.Write("Yaş :");
// int yas = int.Parse(Console.ReadLine()); //Girilen satırı okuma için


// if(yas>18)
// {
// Console.WriteLine("Ehliyet Alabilirsiniz :)");
// }
// else
// {
// Console.WriteLine("İşlem İptal Edildi");
// }

//SWİTCH KONUSU


// int ay = 5;

// switch (ay)
// {
//     case 10:
//     Console.WriteLine("Kış Mevsimi");
//     break;
//     case 5:
//     Console.WriteLine("Yaz Mevsimi");
//     break;

//     default:
//     break;
// }





//KONU : DÖNGÜLER

//FOR DÖNGÜSÜ
//NOT : for yazıp loop tıkladığın zaman aşağıdaki kod dizini otomatik olarak yükler.
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine(i);
// }

//SORU :Kullanıcıdan başlangıç, bitiş ve artış miktarı alınarak aralıktaki tüm sayıları ekrana yazdırınız.

// Console.Write("Başlangıç: ");
// int baslangic = int.Parse(Console.ReadLine());

// Console.Write("Bitiş: ");
// int bitis = int.Parse(Console.ReadLine());

// int sayac=0;
// int toplam=0;
// for (int i = baslangic; i <= bitis; i++)
// {
//     sayac++;
//     toplam+=i;
//     Console.WriteLine($"{sayac}.sayi : {i}");
// }
// Console.WriteLine("toplam :" +toplam);



//WHILE DÖNGÜSÜ
// int i=0;
// while (i<10)
// {
//     Console.WriteLine(i);
// ????????????????????
// }



//Continue & Break
//?????????????????????????

//ASAL SAYI UYGULAMASI
//Girilen sayının asal olup olmadığını kontrol ediniz

// bool asalmi = true;
// Console.Write("sayi :");
// int sayi = int.Parse(Console.ReadLine());

// if(sayi==1)
// asalmi = false;

// for (int i = 2; i < sayi; i++)
// {
//     if(sayi%i==0)
//     {
//     asalmi = false;
//     break;
//     }
// }

// if (asalmi)
// Console.WriteLine("sayı asaldır");
// else{
//     Console.WriteLine("asal değildir");
// }