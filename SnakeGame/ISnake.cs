using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
   public interface ISnake
    {

        void Move();
        void EatBait();
    }
}
