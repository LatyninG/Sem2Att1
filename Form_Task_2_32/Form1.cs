using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BL;

namespace Form_Task_2_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task2 p = new Task2();
            Recording rec = new Recording(Directory.GetCurrentDirectory() + "/Binary.bin");
            long[] arr_det = rec.Search_quanitity();
            int[] arr_auxiliary = p.Random_Rows_Colums();
            int[,] arr_main = p.Array_Creater(arr_auxiliary[0], arr_auxiliary[1]);
            int[,] h = rec.Read_Bin();
            int m = p.Taker(Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox1.Text), arr_det[2], arr_det[1], h);
            MessageBox.Show(Convert.ToString(m));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Recording rec = new Recording(Directory.GetCurrentDirectory() + "/Binary.bin");
            Task2 cra = new Task2();
            int[] arr_auxiliary = cra.Random_Rows_Colums();
            int[,] arr_main = cra.Array_Creater(arr_auxiliary[0], arr_auxiliary[1]);
            if (System.IO.File.Exists("Binary.bin"))
                rec.Write_Bin(arr_main);
            if (!System.IO.File.Exists("Binary.bin"))
                rec.Create_Bin(); 
            textBox3.Text = Convert.ToString(arr_auxiliary[0]);
            textBox4.Text = Convert.ToString(arr_auxiliary[1]);
        }

        private void Row_Column_Click(object sender, EventArgs e)
        {
            Recording det = new Recording(Directory.GetCurrentDirectory() + "/Binary.bin");
            long[] arr_det = det.Search_quanitity();
            textBox3.Text = Convert.ToString(arr_det[2]);
            textBox4.Text = Convert.ToString(arr_det[1]);
        }
    }
}
