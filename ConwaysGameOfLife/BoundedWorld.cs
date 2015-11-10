using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class BoundedWorld : Board
    {
        private Cell[,] cells;
        public int Height { get; set; }
        public int Width { get; set; }

        public BoundedWorld()
        {
        }

        public BoundedWorld(int width, int height)
        {
            cells = new Cell[height, width];
            Width = width;
            Height = height;
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    cells[row, col] = new Cell();
                }
            }
        }

        public void Tick()
        {
            
        }

        public List<List<bool>> ToList()
        {
            throw new NotImplementedException();
        }

        public int DeadCellCount()
        {
            int result = 0;

            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    if (!cells[row,col].IsAlive)
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        public int AliveCellCount()
        {
            return (Width * Height) - DeadCellCount();
        }
    }
}
