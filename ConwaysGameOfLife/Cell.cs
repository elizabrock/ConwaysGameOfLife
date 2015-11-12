using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class Cell : IComparable, IEquatable<Cell>
    {
        public bool IsAlive { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Cell other)
        {
            return this.Y == other.Y && this.X == other.X;
        }
    }
}
