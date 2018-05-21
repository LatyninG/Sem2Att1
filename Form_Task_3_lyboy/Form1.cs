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
using DataGridView_Logic;

namespace Form_Task_3_lyboy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randomizer ran = new Randomizer();
            Binary_Recording br = new Binary_Recording(Directory.GetCurrentDirectory() + "/Students.bin");
            List<BL_Student> student = ran.Rand();
            br.Write(student);
        }

        private void DGV_Click(object sender, EventArgs e)
        {
            Binary_Recording br = new Binary_Recording(Directory.GetCurrentDirectory() + "/Students.bin");
            List<BL_Student> student = br.Read();
            FillDgv<BL_Student>(student, dataGridView1);
        }

        private void Reshenie_Click(object sender, EventArgs e)
        {
            Binary_Recording br = new Binary_Recording(Directory.GetCurrentDirectory() + "/Students.bin");
            List<BL_Student> student = br.Read();
            Task3 task3 = new Task3();
            int top = task3.Best_group(student);
            List<BL_Student> up_student = task3.BGL(student, top);
            FillDgv<BL_Student>(up_student, dataGridView1);
        }

        public static void FillDgv<T>(List<BL_Student> data, DataGridView dgv)
        {
            var bindingList = new BindingList<BL_Student>(data);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;
        }
    }
}
