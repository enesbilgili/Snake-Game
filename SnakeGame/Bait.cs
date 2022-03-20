using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Bait
    {
        public Bait()
        {
            Random rnd = new Random();
            var x = rnd.Next(1, 20);
            var y = rnd.Next(1, 20);
            CurrentTarget = new Coordinate(x, y);
            Draw();
        }
        public Coordinate CurrentTarget { get; set; }
        void Draw()
        {
            Console.SetCursorPosition(CurrentTarget.X, CurrentTarget.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*");
        }
    }
}
