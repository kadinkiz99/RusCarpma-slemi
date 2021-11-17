using System;

namespace roma_carpma
{
    class Program
    {
        static void Main(string[] args)
        {
// Roma sayı sisteminde çarpma işlemi
            Console.WriteLine("Birinci sayıyı giriniz:");//:arpma için kullanılacak ilk sayı alındı
            int sayi1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");// çarpma işleminde kullanılacak olan ikinci  sayı kullanıcıdan alındı
            int sayi2= Convert.ToInt32(Console.ReadLine());
           
             int toplam=0;// işlemin cevabı 

             while(sayi1!=0)
             {
              
                if(sayi1 % 2 != 0 )
                {
                 toplam += sayi2;
                 Console.WriteLine("sayi1 : " + sayi1);
                 Console.WriteLine("sayi2 : " + sayi2);
                 Console.WriteLine("toplam : " + toplam);
                 Console.WriteLine("");
                }
                else 
                {
                  Console.WriteLine("sayi1 : " + sayi1);
                  Console.WriteLine("sayi2 : " + sayi2);
                  Console.WriteLine("toplam : " + toplam);
                  Console.WriteLine("");
                }
              sayi2=sayi2*2;
              sayi1=sayi1/2;  
            
        }

         Console.WriteLine("Roma Sayı Çarpım Sonucu : " + toplam);

    }
}
}
