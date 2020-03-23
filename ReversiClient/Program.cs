using Colorful;
using Reversi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Console = Colorful.Console;

namespace ReversiClient
{
    class Program
    {
        //private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        

        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.Unicode;

            Formatter[] Tokens = new Formatter[]
            {
                new Formatter(" ", Color.White),
                new Formatter("■", Color.MediumAquamarine),
                new Formatter("■", Color.HotPink)
            };

            Game newGame = new Game();

            static void WriteALine()
            {
                string Line = "";
                for (int j = 0; j < 8; j++) // >> methode
                {
                    Line += "+---";
                }
                Line += "+";
                Console.WriteLine(Line);
            }

            #region : Affichage du jeu

            Console.Write("   ");
            for (int i = 0; i < newGame.BoardCols; i++)
            {
                Console.Write($"  {(char)('A' + i)} ");
            }

            Console.WriteLine();

            for (int i = 0; i < newGame.BoardRows; i++)
            {
                Console.Write($"   ");
                WriteALine();

                Console.Write($" {i + 1} ");
                for (int j = 0; j < newGame.BoardCols; j++)
                {
                    var token = 0;
                    if (newGame.GetTile(i, j) == 1)
                    {
                        token = 1;
                    }
                    else if (newGame.GetTile(i, j) == -1)
                    {
                        token = 2;
                    }
                    Console.WriteFormatted($"| {{{token}}} ", Color.White, Tokens);

                }
                Console.WriteLine("|");

            }
            Console.Write($"   ");
            WriteALine();

            #endregion

            Console.WriteLine("Joueur 1 : Veuillez choisir une case");
            var TileSelected = Console.ReadLine();

            var coord = TileSelected.Split("");
            if(coord.Length > 2)
            {
                Console.WriteLine("erreur");
            }

        }
    }
}
