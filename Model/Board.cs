using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foolsmate.Model
{
    /*
     * This class is responsible for keeping track of the pieces on the board.
     */
    internal class Board
    {
        public const int number_of_ranks = 8;
        public const int number_of_files = 8;

        private Piece[,] grid;

        public Board()
        {
            grid = new Piece[number_of_ranks, number_of_files];
        }

        public Piece this[int x, int y]
        {
            get { return Grid[x, y]; }
        }

        public Piece[,] Grid
        {
            get { return this.grid; }
            private set { this.grid = value; }
        }

        public void AddPiece(int x, int y, Piece piece)
        {
            Grid[x, y] = piece;
        }

        public void RemovePiece(int x, int y)
        {
            Grid[x, y] = new Piece();
        }

        //REFACTOR: Move to another class responsible for moving a piece?
        public void MovePiece(int x1, int y1, int x2, int y2)
        {
            AddPiece(x2, y2, new Piece(this[x1, y1].Rank, this[x1, y1].Color));
            RemovePiece(x1, y1);
        }
    }
}