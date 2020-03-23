using System;
using System.Linq;
using System.Collections.Generic;



namespace Reversi
{
    public class Game
    {

        private int[,] _board = new int[8,8];

        public Game()
        {
            _board[3, 3] = 1; _board[4, 3] = -1;
            _board[3, 4] = -1; _board[4, 4] = 1;

            //Console.WriteLine($"Nombre Cols : {_board.Rank} ");
            //Console.WriteLine($"Nombre Rows : {_board.GetLength(1)} ");
        }

        public int GetTile(int col, int row)
        {
            return _board[col, row];            
        }

        public int BoardRows => _board.GetLength(0);
        public int BoardCols => _board.GetLength(1);

    }
}
