using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
             DiamondDisplay(MenuDisplay());

                Console.WriteLine("Você deseja continuar? [Y/N]");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "Y")
                {
                    break;
                }

            }
                Console.ReadLine();    

        }

        public static int MenuDisplay()
        {
            Console.Clear();
            Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
            Console.WriteLine("                                     DIAMANTE DE X");
            Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
            Console.WriteLine();

            Console.WriteLine("Por favor, digite um número ímpar entre 3 e 11: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            return userNumber;
        }

        public static void DiamondDisplay(int userNumber)
        {

            string x1 = "x";
            string x3 = "xxx";
            string x5 = "xxxxx";
            string x7 = "xxxxxxx";
            string x9 = "xxxxxxxxx";
            string x11 = "xxxxxxxxxxx";

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Número inválido. Por favor, insira apenas números ímpares.");
            }

            else if (userNumber < 1 && userNumber > 11)
            {

                Console.WriteLine("Número inválido. Digite apenas números ímpares entre 1 e 11.");
            }

            else
            {
                if (userNumber == 3)
                {
                    Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                    Console.WriteLine();
                    Console.WriteLine(" " + x1);
                    Console.WriteLine(x3);
                    Console.WriteLine(" " + x1);
                    Console.WriteLine();
                    Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                }

                else if (userNumber == 5)
                {
                    Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                    Console.WriteLine();
                    Console.WriteLine("  " + x1);
                    Console.WriteLine(" " + x3);
                    Console.WriteLine(x5);
                    Console.WriteLine(" " + x3);
                    Console.WriteLine("  " + x1);
                    Console.WriteLine();
                    Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                }

                else if (userNumber == 7)
                {
                    Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                    Console.WriteLine();
                    Console.WriteLine("   " + x1);
                    Console.WriteLine("  " + x3);
                    Console.WriteLine(" " + x5);
                    Console.WriteLine(x7);
                    Console.WriteLine(" " + x5);
                    Console.WriteLine("  " + x3);
                    Console.WriteLine("   " + x1);
                    Console.WriteLine();
                    Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                }

                else if (userNumber == 9)
                {

                    Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                    Console.WriteLine();
                    Console.WriteLine("    " + x1);
                    Console.WriteLine("   " + x3);
                    Console.WriteLine("  " + x5);
                    Console.WriteLine(" " + x7);
                    Console.WriteLine(x9);
                    Console.WriteLine(" " + x7);
                    Console.WriteLine("  " + x5);
                    Console.WriteLine("   " + x3);
                    Console.WriteLine("    " + x1);
                    Console.WriteLine();
                    Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                }


                else if (userNumber == 11)
                {
                    Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                    Console.WriteLine();
                    Console.WriteLine("     " + x1);
                    Console.WriteLine("    " + x3);
                    Console.WriteLine("   " + x5);
                    Console.WriteLine("  " + x7);
                    Console.WriteLine(" " + x9);
                    Console.WriteLine(x11);
                    Console.WriteLine(" " + x9);
                    Console.WriteLine("  " + x7);
                    Console.WriteLine("   " + x5);
                    Console.WriteLine("    " + x3);
                    Console.WriteLine("     " + x1);
                    Console.WriteLine();
                    Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                }
            }



        }
    }
}



