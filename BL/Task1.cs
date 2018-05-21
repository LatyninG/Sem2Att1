using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BL
{
    public class Task1
    {
        public static string[] Kek(double a, double b, int n, bool rab1, bool rab2, bool rab3)
        {
            string probel_max = "                                                                                                               ";
            string probel = " ";
            string probel_10 = "        ";
            string[] k = new string[n + 1];
            double step, x = a, f = 1;
            step = (b - a) / n;
            for (int i = 0; i <= n; i++)
            {
                if (rab1)
                    f = Math.Sin(x);
                else if (rab2)
                    f = Math.Cos(x);
                else if (rab3)
                    f = Math.Exp(x);
                x = Math.Round(x, 3);
                f = Math.Round(f, 8);
                if (f >= 0)
                    k[i] = System.String.Format("{0}{1} {2} {3}{4}",probel_max, x, probel, probel_10, f);
                else
                    k[i] = System.String.Format("{0}{1} {2} {3}",probel_max, x, probel_10, f);
                x += step;
            }
            return k;
        }
    }
}
