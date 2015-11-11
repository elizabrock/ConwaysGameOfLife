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
    }
}
