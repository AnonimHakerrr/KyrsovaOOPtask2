using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyrsovaOOPtask2
{
    public partial class Form1 : Form
    {
        RecordBook exams;
        public Form1()
        {
            exams = new RecordBook();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ExamCreated += Form2_ExamCreated;
            f.ShowDialog();
        }

        private void Form2_ExamCreated( Exam exam)
        {
            exams.Add(exam);
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
