using System;
namespace uppgift2
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Vilket årtal är du född");
            string födelsedagtext = Console.ReadLine();
            int födelsedag = int.Parse(födelsedagtext);
            int gammal = 2023-födelsedag;
            Console.WriteLine("du är född år " + födelsedag + " du är eller kommer att bli " + gammal + " i år"); 

        }
    }
}