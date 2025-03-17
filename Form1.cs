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
            listBox1.Items.Clear(); 
            foreach (Exam exam in exams)
            {
                listBox1.Items.Add(exam.ToString());  
            }
        }



        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;

            string text = listBox1.Items[e.Index].ToString();
            e.ItemHeight = (text.Split('\n').Length) * 15; 
        }
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
                e.Font, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }
    }
}
