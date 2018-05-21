using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BL
{
    public class Recording
    {
        public string Path { get; private set; }
        public Recording(string path)
        {
            this.Path = path;
        }

        public void Write_Bin(int[,] mas)
        {
            FileStream bin = new FileStream(Path, FileMode.Truncate, FileAccess.Write);
            BinaryWriter f = new BinaryWriter(bin);
            int n = mas.Length;
            int l = mas[0, 0];
            int k = n / l;
            /*for (int i = 0; i < n; i++)
            {
                f.Write(mas[i]);
            }*/

            for (int i = 0; i < k; i ++)
            {
                for (int j = 0; j < l; j++)
                {
                    f.Write(mas[i, j]);
                }
            }
            f.Close();
            bin.Close();
        }

        public int[,] Read_Bin()
        {
            FileStream bin = new FileStream(Path, FileMode.Open, FileAccess.Read);
            BinaryReader f = new BinaryReader(bin);
            long n = bin.Length / sizeof(int);
            int l = f.ReadInt32();
            long k = n / l;
            int[,] arr_w = new int[k,l];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (i == 0 && j == 0)
                        arr_w[i, j] = l;
                    else
                    {
                      arr_w[i, j] = f.ReadInt32();
                    }
                }
            }
            /*while (f.PeekChar() > -1)
            {
                arr_w[i] = f.ReadInt32();
                i++;
            }*/
            bin.Close();
            f.Close();
            return arr_w;
        }

        public long[] Search_quanitity()
        {
            FileStream bin = new FileStream(Path, FileMode.Open, FileAccess.Read);
            BinaryReader f = new BinaryReader(bin);
            long[] arr_q = new long[3];
            arr_q[0] = bin.Length / sizeof(int); // кол-во элементов
            arr_q[1] = f.ReadInt32(); // столбцы
            arr_q[2] = arr_q[0] / arr_q[1]; // строки
            bin.Close();
            f.Close();
            return arr_q;
        }

        public void Create_Bin()
        {
            FileStream bin = new FileStream(Path, FileMode.Create, FileAccess.Write);
            bin.Close();
        }
    }
}
