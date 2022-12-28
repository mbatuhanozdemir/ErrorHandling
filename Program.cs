/* try
{
    Console.WriteLine("Lütfen bir sayı giriniz ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("girmiş olduğunuz sayı : " + sayi);
}
catch(Exception ex)
{
    Console.WriteLine("Hata : " + ex.Message.ToString());
}
finally
{
    Console.WriteLine("Islem Tamamlandı");

}    */


try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a = int.Parse("-200000000000");
}
catch (ArgumentNullException ex)
{
   Console.WriteLine("Boş bir değer girdiniz");
   Console.WriteLine(ex); 
   
}
catch(FormatException ex)
{
   Console.WriteLine("veri tipi uygun değil");
   Console.WriteLine(ex); 
}
catch(OverflowException ex)
{
    Console.WriteLine("Çok büyük ya da çok küçük bir değer girdiniz");
    Console.WriteLine(ex); 

}
finally
{

    Console.WriteLine("İşlem başarıyla tamamlandı");
}



