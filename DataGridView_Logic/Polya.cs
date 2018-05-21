using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_Logic
{
    public class Polya
    {
        private Random rm = new Random();

        public int[,] Arr()
        {
            int[,] arr = new int[4, 7];
            int q = rm.Next(1, 4);
            if(q == 1)
            {
                arr[0, 0] = 0;
                arr[0, 1] = 1;
                arr[0, 2] = 1;
                arr[0, 3] = 1;
                arr[0, 4] = 0;
                arr[0, 5] = 0;
                arr[0, 6] = 0;
                arr[1, 0] = 0;
                arr[1, 1] = 0;
                arr[1, 2] = 0;
                arr[1, 3] = 0;
                arr[1, 4] = 0;
                arr[1, 5] = 1;
                arr[1, 6] = 0;
                arr[2, 0] = 1;
                arr[2, 1] = 1;
                arr[2, 2] = 0;
                arr[2, 3] = 1;
                arr[2, 4] = 0;
                arr[2, 5] = 1;
                arr[2, 6] = 0;
                arr[3, 0] = 1;
                arr[3, 1] = 1;
                arr[3, 2] = 0;
                arr[3, 3] = 1;
                arr[3, 4] = 1;
                arr[3, 5] = 1;
                arr[3, 6] = 0;
            }

            if (q == 2)
            {
                arr[0, 0] = 0;
                arr[0, 1] = 0;
                arr[0, 2] = 0;
                arr[0, 3] = 0;
                arr[0, 4] = 0;
                arr[0, 5] = 0;
                arr[0, 6] = 1;
                arr[1, 0] = 1;
                arr[1, 1] = 0;
                arr[1, 2] = 1;
                arr[1, 3] = 1;
                arr[1, 4] = 1;
                arr[1, 5] = 0;
                arr[1, 6] = 1;
                arr[2, 0] = 1;
                arr[2, 1] = 0;
                arr[2, 2] = 0;
                arr[2, 3] = 0;
                arr[2, 4] = 1;
                arr[2, 5] = 0;
                arr[2, 6] = 1;
                arr[3, 0] = 1;
                arr[3, 1] = 1;
                arr[3, 2] = 1;
                arr[3, 3] = 0;
                arr[3, 4] = 1;
                arr[3, 5] = 0;
                arr[3, 6] = 0;
            }

            if (q == 3)
            {
                arr[0, 0] = 0;
                arr[0, 1] = 1;
                arr[0, 2] = 1;
                arr[0, 3] = 1;
                arr[0, 4] = 1;
                arr[0, 5] = 0;
                arr[0, 6] = 1;
                arr[1, 0] = 0;
                arr[1, 1] = 1;
                arr[1, 2] = 1;
                arr[1, 3] = 1;
                arr[1, 4] = 0;
                arr[1, 5] = 0;
                arr[1, 6] = 0;
                arr[2, 0] = 0;
                arr[2, 1] = 0;
                arr[2, 2] = 1;
                arr[2, 3] = 0;
                arr[2, 4] = 0;
                arr[2, 5] = 1;
                arr[2, 6] = 0;
                arr[3, 0] = 0;
                arr[3, 1] = 0;
                arr[3, 2] = 0;
                arr[3, 3] = 0;
                arr[3, 4] = 1;
                arr[3, 5] = 1;
                arr[3, 6] = 0;
            }
            return arr;
        }
    }
}
