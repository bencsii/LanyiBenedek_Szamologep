using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep_beni
{
    internal class Program
    {

        static double osszeadas(double num1, double num2)
        {
            return num1 + num2;
        }

        static double kivonas(double num1, double num2)
        {
            return num1 - num2;
        }


        static double szorzas(double num1, double num2)
        {
            return num1 * num2;
        }

        static double osztas(double num1, double num2)
        {
            return num1 / num2;
        }


        static double szazalek(double num1, double num2)
        {
            return (num1 / num2) * 100;
        }



        static void indit(double num1, double num2)
        {


          
            


            Console.WriteLine("Osszeadas: +");
            Console.WriteLine("Kivonas: -");
            Console.WriteLine("Szorzas: *");
            Console.WriteLine("Osztas: /");
            Console.WriteLine("Szazalek: %"); 



            Console.Write("Adja meg az elvegezendo muvelet jelet: ");
            string muvelet = Console.ReadLine();

            switch (muvelet)
            {
                case "+":
                    Console.WriteLine($"A ket szam osszege: {osszeadas(num1, num2)}"); break;

                case "-":
                    Console.WriteLine($"A ket szam kulonbsege: {kivonas(num1, num2)}"); break;


                case "*":
                    Console.WriteLine($"A ket szam szorzata: {szorzas(num1, num2)}"); break;


                case "/":
                    Console.WriteLine($"Osztas v hogy hivjan nem ertek a matekhoz: {osztas(num1, num2)}"); break;


                case "%":
                    Console.WriteLine($"Szazalek szamitas: {szazalek(num1, num2)}"); break;


            }


        }



        static void Main(string[] args)
        {
            Console.Write("Adja meg az elso szamot: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Adja meg a masodik szamot: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            indit(num1,num2);
        }
    }
}
