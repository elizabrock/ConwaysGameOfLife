using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class UnboundedWorld : Board
    {
        private List<Cell> cells;

        public UnboundedWorld()
        {
            cells = new List<Cell>();
        }

        public void Tick()
        {
            throw new NotImplementedException();
        }

        public List<List<bool>> ToList()
        {
            throw new NotImplementedException();
        }

        public int CellCount()
        {
            return cells.Count;
        }

        public void AddCell(int x, int y)
        {
            cells.Add(new Cell { X = x, Y = y });
        }

        public int AliveNeighborCount(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private bool IsAlive(Cell c)
        {
            bool result = false;
            foreach (var cell in cells)
            {
                if (c.X == cell.X && c.Y == cell.Y)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public List<Cell> AliveNeighbors(int x, int y)
        {
            List<Cell> neighbors = new List<Cell>();
            Cell above = null;
            Cell below = null;

            below = new Cell { X = x, Y = y - 1 };
            above = new Cell { X = x, Y = y + 1 };

            if (cells.Exists(c => c.X==above.X && c.Y == above.Y))
            {
                neighbors.Add(above);
            }

            if (cells.Exists(c => c.X == below.X && c.Y == below.Y))
            {
                neighbors.Add(below);
            }

            return neighbors;
        }
    }
}
