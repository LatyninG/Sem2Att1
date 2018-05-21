using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Task4
    {
        public int Prohod(int q, int n, int[,] arr, int rows, int columns)
        {
            if (q == (rows - 1) && n == (columns - 1))
            {
                return 10;
            }
            else if ((q < (rows-1) && n <= (columns-1)) && (arr[q + 1, n] == 0))
            {
                arr[q, n] = 2;
                return Prohod(q + 1, n, arr, rows, columns);
            }
            else if ((q <= (rows-1) && n < (columns-1)) && arr[q, n + 1] == 0)
            {
                arr[q, n] = 2;
                return Prohod(q, n + 1, arr, rows, columns);
            }
            else if ((q <= (rows-1) && n <= (columns-1)) && arr[q - 1, n] == 0)
            {
                arr[q, n] = 2;
                return Prohod(q - 1, n, arr, rows, columns);
            }
            else if ((q <= (rows-1) && n <= (columns-1)) && arr[q, n - 1] == 0)
            {
                arr[q, n] = 2;
                return Prohod(q, n - 1, arr, rows, columns);
            }
            else if ((q < (rows-1) && n <= (columns-1)) && arr[q + 1, n] == 2)
            {
                arr[q, n] = 3;
                return Prohod(q + 1, n, arr, rows, columns);
            }
            else if ((q <= (rows-1) && n < (columns-1)) && arr[q, n + 1] == 2)
            {
                arr[q, n] = 3;
                return Prohod(q, n + 1, arr, rows, columns);
            }
            else if ((q <= (rows-1) && n <= (columns-1)) && arr[q - 1, n] == 2)
            {
                arr[q, n] = 3;
                return Prohod(q - 1, n, arr, rows, columns);
            }
            else if ((q <= (rows-1) && n <= (columns-1)) && arr[q, n - 1] == 2)
            {
                arr[q, n] = 3;
                return Prohod(q, n - 1, arr, rows, columns);
            }
            else
            {
                return 11;
            }
        }
    }
}
