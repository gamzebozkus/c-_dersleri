// See https://aka.ms/new-console-template for more information
//ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır
Console.Write("Lütfen bir sayı giriniz:");
int sayac=int.Parse(Console.ReadLine());
for (int i = 0; i <= sayac; i++)
{
    if(i%2==1){
        Console.WriteLine(i);
    }
}
//1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır
int tekToplam=0;
int ciftToplam= 0;
for (int i = 0; i <=1000; i++)
{
    if(i%2==1){
        tekToplam=tekToplam+i;

    }
    else{
        ciftToplam+=i; 
    }
 Console.WriteLine("Tek Toplam:"+tekToplam);
 Console.WriteLine("Çift Toplam:"+ciftToplam);

}
