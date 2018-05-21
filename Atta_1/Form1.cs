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

namespace Atta_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int n = Convert.ToInt32(textBox3.Text);
            // Task1 p = new Task1();
            string[] k = Task1.Kek(a, b, n, But1.Checked, But2.Checked, But3.Checked);
            textBox4.Lines = k;
           // textBox4.TextAlign = HorizontalAlignment.Right;
        }

        private void save_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox3.Text);
            string[] k = new string[n + 1];
            TextFile_Recording g = new TextFile_Recording(Directory.GetCurrentDirectory() + "/Text_Test.txt");
            for (int i = 0; i <= n; i++)
            {
                k[i] = textBox4.Lines[i];
            }
            g.Lel(n, k);
        }
    }
}
