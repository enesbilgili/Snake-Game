﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Coordinate
    {
        public Coordinate()
            {
            X=0;
            Y = 0;
            }


        public Coordinate( int x, int y)
        {
            X = x;
            Y = y;
        }
    public int X { get; set; }
    public int Y { get; set; }
}
}

