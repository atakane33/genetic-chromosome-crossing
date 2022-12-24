using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetik_Çaprazlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bulunması gereken geni giriniz : ");

            int gen1 = Int32.Parse(Console.ReadLine());

            int[] anne = new int[4];

            int[] baba = new int[4];

            int[] cocuk = new int[4];

            Random gen = new Random();

            int genler = gen.Next(0, 2);

            int mutasyon;

            mutasyon = gen.Next(0, 4);

            int a;

            a = 0;

            do
            {
                a++;

                Console.WriteLine(" ");

                Console.Write("{0}. İterasyon : ",a);                                                                    
                
                if (gen1 > 9999 || gen1 < 1000)
                {
                    Console.Write("Geçersiz gen girimi !!! ");

                    Console.ReadKey();
                }

                Console.Write("\nAnne : ");

                for (int i = 0; i < anne.Length; i++)
                {
                    anne[i] = gen.Next(0, 2);

                    Console.Write(anne[i]);
                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.Write("Baba : ");

                for (int i = 0; i < baba.Length; i++)
                {
                    baba[i] = gen.Next(0, 2);

                    Console.Write(baba[i]);
                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.Write("Çocuk : ");

                for (int i = 0; i < cocuk.Length; i++)
                {
                    cocuk[0] = anne[0];

                    cocuk[1] = anne[1];

                    cocuk[2] = baba[2];

                    cocuk[3] = baba[3];

                    Console.Write(cocuk[i]);
                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.Write("Mutasyon Hali : ");

                for (int i = 0; i < cocuk.Length; i++)
                {

                    mutasyon = gen.Next(0, 4);

                    if (cocuk[mutasyon] == 0)
                    {
                        cocuk[mutasyon] = 1;
                    }

                    else if (cocuk[mutasyon] == 1)
                    {
                        cocuk[mutasyon] = 0;
                    }

                    Console.Write(cocuk[mutasyon]);
                   
                }

                Console.WriteLine(" ");

                if (gen1 == cocuk[mutasyon])
                {
                    Console.WriteLine("\nGenler Uyuşuyor !! ");

                    Console.ReadKey();

                    break;
                }
               
                else if (gen1 != cocuk[mutasyon])
                {
                    Console.WriteLine("\nGenler Uyuşmadı !! Tekrar Dene !! ");                   
                }

            } while (gen1 != cocuk[mutasyon]);
        }
    }
}
