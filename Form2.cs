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
    public partial class Form2 : Form
    {
        public delegate void ExamCreatedHandler(Exam exam);
        public event ExamCreatedHandler ExamCreated;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Exam exam = new Exam(
                new Student(Nomer.Text,LastNameStudent.Text,NameStudent.Text)
                ,new Theacher(Position.Text,LastNameTheacher.Text,NameTheacher.Text)
                ,Predmet.Text,Int16.Parse(Hours.Text),Int16.Parse( Rating.Text),DateProv.Value.Date
                );
           ExamCreated?.Invoke(exam);
            this.Close();
             
        }

   
    }
}
