﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapHandler
{
    [Serializable]
    public class Position
    {
        public int X;
        public int Y;

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
    }

}
