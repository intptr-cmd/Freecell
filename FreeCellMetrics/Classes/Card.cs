using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeCellMetrics.Classes
{
    public class Card
    {
        public Card() 
        { 
            this.Position = new Tuple(); 
        }

        public int Value;
        public string Color; //S,C,H,D
        public bool isRed; //TODO   

        public Tuple Position;
        public bool isTop;
        public bool isTopMinusOne;

        public class Tuple
        {
            public int row = 1;
            public int col = 1;
        }
    }
}
