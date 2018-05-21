using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DataGridView_Logic;


namespace Form_Task_4_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Zapolnenie_Click(object sender, EventArgs e)
        {
            Polya pol = new Polya();
            int[,] arr = pol.Arr();
            Zap_dgv(arr);
        }

        private void Reshenie_Click(object sender, EventArgs e)
        {
            int[,] arr = Arr();
            Task4 task4 = new Task4();          
            int ret = task4.Prohod(0, 0, arr, arr.GetLength(0), arr.GetLength(1));
            Zap_dgv(arr);
            if (ret == 10)
            {
                MessageBox.Show("Bingo");
            }
            else if (ret == 11)
            {
                MessageBox.Show("Fail");
            }
        }

        public void Zap_dgv(int[,]arr)
        {
            dataGridView1.RowCount = arr.GetUpperBound(0) + 1;
            dataGridView1.ColumnCount = arr.Length / dataGridView1.RowCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j, i].Value = arr[i, j];
                    if (arr[i, j] == 0)
                    {
                        dataGridView1[j, i].Style.BackColor = Color.White;
                    }
                    else if (arr[i, j] == 1)
                    {
                        dataGridView1[j, i].Style.BackColor = Color.Black;
                    }
                    else if(arr[i,j] == 2)
                    {
                        dataGridView1[j, i].Style.BackColor = Color.Brown;
                    }
                    else if(arr[i,j] == 3)
                    {
                        dataGridView1[j, i].Style.BackColor = Color.DarkBlue;
                    }
                }
            }
        }

        public int[,] Arr()
        {
            int[,] arr = new int[dataGridView1.RowCount,dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for(int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    arr[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                }
            }
            return arr;
        }
    }
}
