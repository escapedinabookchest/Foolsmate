using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foolsmate.Model
{
    internal struct Piece
    {
        private readonly Rank rank;
        private readonly Color color;
        private readonly bool isSet;

        public Piece(Rank rank, Color color)
        {
            this.rank = rank;
            this.color = color;
            this.isSet = true;
        }

        public Rank Rank
        {
            get { return this.rank; }
        }

        public Color Color
        {
            get { return this.color; }
        }

        public bool IsSet
        {
            get { return this.isSet; }
        }
    }
}