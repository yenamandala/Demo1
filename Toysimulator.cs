using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    public class Toysimulator
    {
        private int x;
        private int y;
        private Direction facing;

     
        public void Place(int x, int y, Direction facing)
        {
            this.x = x;
            this.y = y;
            this.facing = facing;
        }

        public void Move()
        {
            switch (facing)
            {
                case Direction.NORTH:
                    if (y < 4) y++;
                    break;
                case Direction.SOUTH:
                    if (y > 0) y--;
                    break;
                case Direction.EAST:
                    if (x < 4) x++;
                    break;
                case Direction.WEST:
                    if (x > 0) x--;
                    break;
            }
        }

        public void Left()
        {
            facing = (Direction)(((int)facing + 3) % 4);
        }

        public void Right()
        {
            facing = (Direction)(((int)facing + 1) % 4);
        }

        public void Report()
        {
            Console.WriteLine($"{x},{y},{facing}");
        }
    }

    public enum Direction
    {
        NORTH,
        EAST,
        SOUTH,
        WEST
    }

}
