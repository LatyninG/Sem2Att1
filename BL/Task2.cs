using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Task2
    {
        public int Taker(int i, int j, long k, long l, int[,] arr)
          {
            int vivod;
            long n;
            if ((i > k) || (j > l) || (i < 1) || (j < 1))
                vivod = 0;
            else
            {
                vivod = arr[i,j];
            }
            return vivod;
          }
        public int[] Random_Rows_Colums()
        {
            Random rand = new Random();
            int[] arr = new int[3];
            arr[0] = rand.Next(3, 9); //строки
            arr[1] = rand.Next(3, 9); //столбцы
            arr[2] = arr[0] * arr[1]; //общее кол-во элементов
            return arr;
        }

        public int[,] Array_Creater(int k, int l)
        {
            int[,] mas = new int[k, l];
            Random rand = new Random();
            /*mas[0] = k;
            for (int i = 1; i < n; i++)
            {
                mas[i] = rand.Next(1, 9);
            }*/
            for (int i = 0; i < k; i++) // заполнение файла рандомными значениями (от 1 до 9)
            {
                for (int j = 0; j < l; j++)
                {
                    mas[i, j] = rand.Next(1, 9);
                }
            }
            mas[0, 0] = l;
            return mas;
        }
    }
}
