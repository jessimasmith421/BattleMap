using System;

namespace BattleMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE THUNDERDOME");
            Console.Write("How long do you want your map to be? ");
            string length = Console.ReadLine();
            int lengthInt = int.Parse(length);
            Console.Write("How tall homie? ");
            string height = Console.ReadLine();
            int heightInt = int.Parse(height);

            Board board = new Board();
            board.MakeBoard(heightInt, lengthInt);

        }
    }
}
