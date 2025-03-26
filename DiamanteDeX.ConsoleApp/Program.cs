using System.ComponentModel.Design;

namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {

                string x1 = "x";
                string x2 = "xx";
                string x3 = "xxx";
                string x4 = "xxxx";
                string x5 = "xxxxx";
                string x6 = "xxxxxx";
                string x7 = "xxxxxxx";
                string x8 = "xxxxxxxx";
                string x9 = "xxxxxxxxx";
                string x10 = "xxxxxxxxx";
                string x11 = "xxxxxxxxxxx";



                Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                Console.WriteLine("                                     DIAMANTE DE X");
                Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                Console.WriteLine();

                Console.WriteLine("Por favor, digite um número ímpar entre 3 e 11: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());


                if (userNumber % 2 == 0)
                {
                    Console.WriteLine("Número inválido. Por favor, insira apenas números ímpares.");
                }

                else {
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

                    else if (userNumber < 1 && userNumber > 11)
                    {

                      Console.WriteLine("Número inválido. Digite apenas números ímpares entre 1 e 11.");

                    }                 
                        
                
                }
                Console.ReadLine();
            }

        }

    }
}
              
    

