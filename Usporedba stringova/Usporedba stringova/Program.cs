using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Usporedba_stringova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst1 = "Ovo je neki tekst";
            string tekst2 = "Ovo je NEKI tekst";
            string tekst3 = "ovo je neki tekst";
            string tekst4 = "Ovo je neki tekst";
            
            //Korištenje compare metode
                //različiti stringovi
                Console.WriteLine(
                    string.Compare(tekst1, tekst2));
                Console.WriteLine(
                    string.Compare(tekst1, tekst3));
                //isti stringovi
                Console.WriteLine(
                    string.Compare(tekst1, tekst4));

                if (string.Compare(tekst1, tekst2) != 0)
                {
                    Console.WriteLine("Varijable nisu jednake");
                }
                else
                {
                    Console.WriteLine("Varijable su jednake");
                }
                if (string.Compare(tekst1, tekst3) != 0)
                {
                    Console.WriteLine("Varijable nisu jednake");
                }
                else
                {
                    Console.WriteLine("Varijable su jednake");
                }
                if (string.Compare(tekst1, tekst4) != 0)
                {
                    Console.WriteLine("Varijable nisu jednake");
                }
                else
                {
                    Console.WriteLine("Varijable su jednake");
                }

            Console.ReadKey();
        }
    }
}
