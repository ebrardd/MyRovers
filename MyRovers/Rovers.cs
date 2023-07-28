using MyRovers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyRover
{
    public class Rover
    {
        private const ulong _height = 9000000000000000000, _length = 9000000000000000000;
        private int _cord_X;
        private int _cord_Y;

        public int Cord_X
        {
            get { return _cord_X; } // x koordinatı okunabilir (get)
            set { _cord_X = value; } // x koordinatı değiştirilebilir (set)
        }
        public int Cord_Y
        {
            get { return _cord_Y; }
            set { _cord_Y = value; }
        }
        public ulong Height
        {
            get { return _height; }
        }

        public ulong Length
        {
            get { return _length; }
        }
       internal  class Coordinate
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Coordinate(int x, int y)
            {
                X = x;
               Y = y;
            }
        }

        static bool CanMove(Coordinate c)
        {
            if (c.X < 0 || c.X >= Console.WindowWidth)
                return false;

            if (c.Y < 0 || c.Y >= Console.WindowHeight)
                return false;

            return true;
        }
    }
}
