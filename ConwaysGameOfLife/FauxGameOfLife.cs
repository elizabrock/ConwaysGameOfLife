using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class FauxGameOfLife : Board
    {
        private List<List<bool>> cells = new List<List<bool>>();

        public FauxGameOfLife()
        {
            cells.Add(new List<bool>(new bool[] { true, true, false }));
            cells.Add(new List<bool>(new bool[] { false, true, false }));
            cells.Add(new List<bool>(new bool[] { true, true, false }));
        }

        public List<List<bool>> ToList()
        {
            return cells;
        }

        public void Tick()
        {
            cells = new List<List<bool>>();
            cells.Add(new List<bool>(new bool[] { true, true, false }));
            cells.Add(new List<bool>(new bool[] { true, true, false }));
            cells.Add(new List<bool>(new bool[] { false, true, false }));
        }
    }
}
