// See https://aka.ms/new-console-template for more information
using System;
// try
// {
//     Console.WriteLine("Bir sayı giriniz:");
// int sayi=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("girmiş oldugunuz sayı:"+sayi);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("hata:" +ex.Message.ToString());
    
// }
// finally
// {
// Console.WriteLine("İşlem Tamamlandı.");
// }
try
{
    //int a=int.Parse(null);
   // int a =int.Parse("test");
    int a=int.Parse("-12345678910");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("BOŞ DEĞER GİRDİNİZ");
    Console.WriteLine(ex);

}
catch(FormatException ex){
     Console.WriteLine("veri tipi uygun değil");
    Console.WriteLine(ex);
}
catch (OverflowException ex)
{
    Console.WriteLine("ÇOK KÜÇÜK YA DA ÇOK BÜYÜK BİR DEĞER GİRNİZ");
    Console.WriteLine(ex); 

}
finally{
   
    Console.WriteLine("işlem başarıyla tamamlandı");
   
   


}