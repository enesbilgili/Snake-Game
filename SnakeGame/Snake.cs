﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
  public  class Snake : ISnake
    {
        public int Length { get; set; } = 5;
        public Direction Direction { get; set; } = Direction.Right;
        public Coordinate HeadPosition { get; set; } = new Coordinate();
        List<Coordinate> Tail { get; set; } = new List<Coordinate>();
        private bool outOfRange = false;
        public bool GameOver
        {
            get
            {
                return (Tail.Where(c => c.X == HeadPosition.X &&
                c.Y == HeadPosition.Y).ToList().Count > 1);
            }
        }
        public void EatBait()
        {
            Length++;
        }

        public void Move()
        {
            switch (Direction)
            {
                case Direction.Left:
                    HeadPosition.X--;
                    break;
                case Direction.Right:
                    HeadPosition.X++;
                    break;
                case Direction.Up:
                    HeadPosition.Y--;
                    break;
                case Direction.Down:
                    HeadPosition.Y++;
                    break;
            }
            try
            {
                Console.SetCursorPosition(HeadPosition.X, HeadPosition.Y);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("@");
                Tail.Add(new Coordinate(HeadPosition.X, HeadPosition.Y));
                if(Tail.Count > this.Length)
                {
                    var endTail = Tail.First();
                    Console.SetCursorPosition(endTail.X, endTail.Y);
                    Console.Write(" ");
                    Tail.Remove(endTail);
                }

            }
            catch (Exception)
            {

                outOfRange = true;
            }
        }
    }


    public enum Direction { Left, Right, Up, Down }
}