using System;
using System.Collections.Generic;
using System.Text;

namespace BattleMap
{
    public class Board
    {
        //method

        public void MakeBoardTop(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("__");

            }
            Console.WriteLine("_");
        }
        public void MakeBoard(int height, int length)
        {
            MakeBoardTop(length);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {

                    //Console.WriteLine("-");
                    //Console.WriteLine("");

                    Console.Write("|_");
                }
                Console.WriteLine("|");
            }
        }

        public void MakeBoardTakeTwo(int height, int length)
        {
            MakeBoardTop(length);
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < length; k++)
                {

                    Console.Write("| \t");

                }
                Console.WriteLine();
                for (int k = 0; k < length; k++)
                {

                    Console.Write("| \t");

                }
                Console.WriteLine();
                for (int j = 0; j < length; j++)
                {

                    Console.Write("|_______");
                }
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine();
            }
        }
    }
}
