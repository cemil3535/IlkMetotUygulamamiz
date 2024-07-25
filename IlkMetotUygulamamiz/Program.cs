// See https://aka.ms/new-console-template for more information

//Geriye bir deger dondurmeyen metod tanimlanmasi

using System.Collections.Concurrent;
using System.Reflection.Metadata;
//1-Sevdigin sarki sozunun yazilmasi
void SarkiSozu()
{
    Console.WriteLine("Yalan sevinçle oyalandım\nAklın tuzağında dolandım\nKusuruma bakma zil zurna geldim\nSabahın 5’i kapına dayandım\n\nErbabım aşk madem\nMadem yasaklar namahrem\nKafeste sözler susuyor şimdilik\nUçurur zaman hele du’ bakalım\n\nSırtında uzun hırka gibi gece\nYarenlik etmez kaytarır hece\nHatıra oturmuş kalkmaz halden anlamaz\nDerya deniz düşünce\n\nGezdim seni sokak sokak\nValla yok hesap kitap\nİçimde avaz avaz yan yan yan benimle\nUzun yola gider gibi\nBakma öyle yüzüme\nAman cancağazım etme");
}
SarkiSozu();
Console.WriteLine("-----------------------------------------------------------");

//2-Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürulmesi
int KalanSayi()
{
    Random rnd = new Random();
    int randomNumber = rnd.Next();

    int kalanSayi = randomNumber / 2;
    Console.WriteLine(randomNumber + " 2'ye bolumunden kalan: " + kalanSayi);
    return kalanSayi;
}

KalanSayi();
Console.WriteLine("----------------------------------------------------------");

//3-Parametre olarak aldığı iki sayının çarpımını geriye dönduren metod.
int CarpIkiSayi(int sayi1, int sayi2)
{
    int carpimSonuc = sayi1 * sayi2;

    return carpimSonuc;
}

Console.WriteLine("8 ve 3 sayisinin carpimi: " + CarpIkiSayi(8, 3));

Console.WriteLine("-------------------------------------------------");

//4- Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana yazan metod tanimlamasi
Console.Write("Lutfen Isminizi girin: ");
string firstName = Console.ReadLine();

Console.Write("Lutfen soy isminizi girin: ");
string lastName = Console.ReadLine();



void Selamla(string firstName,  string lastName)
{
    
    Console.WriteLine($"Hos Geldiniz {firstName} {lastName}");
    

}
Selamla(firstName, lastName);



