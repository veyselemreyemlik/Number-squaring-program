using System;

namespace SayiKareYazdirma

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Başlangıç Değeri Giriniz :");
            int bassayi = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Bitiş Değerini Giriniz :");
            int sonsayi = Convert.ToInt32(Console.ReadLine());

            int girilensayi = (bassayi - sonsayi);

            
            if (bassayi > sonsayi)
            { 
                while (true) { 
                Console.WriteLine("Başlangıç değerini bitiş değerinden büyük girdiniz.Tekrar Deneyiniz");
                    Console.WriteLine("Başlangıç Değeri Giriniz :");
                    bassayi = Convert.ToInt32((Console.ReadLine()));

                    Console.WriteLine("Bitiş Değerini Giriniz :");
                    sonsayi = Convert.ToInt32((Console.ReadLine()));

                }
            }
            else
            {
                for (int i = bassayi ; i < sonsayi ; i++)
                {

                    Console.Write("Sayıların Kareleri :");
                    int sonuc; 
                  
                    sonuc = (i * i);

                    Console.WriteLine(sonuc);

                 //   int[] dizi = new int[girilensayi];


                   


                }
            }


        }
            


        }

    }
    

