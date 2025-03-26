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
                string x11 = "xxxxxxxxxx";



                Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                Console.WriteLine("                                     DIAMANTE DE X");
                Console.WriteLine("x---------------------------x--------------------------------x----------------------------x");
                Console.WriteLine();

                Console.WriteLine("Por favor, digite um número ímpar entre 3 e 11: ");
                int userNumber = 0;


                if (userNumber % 2 == 0)
                {
                    Console.WriteLine("Número inválido. Por favor, insira apenas números pares.");
                }

                else {
                    if (userNumber == 3)
                    {
                        Console.WriteLine();
                    }

                }


                    Console.ReadLine();


            }

        }
              
    }
}
