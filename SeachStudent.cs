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
    public partial class SeachStudent : Form
    {
        public delegate void SeachStudentHandler(string studentInfo);
        
        public event SeachStudentHandler SeachStudents;
        
        public SeachStudent()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                string studentInfo = textBox1.Text;
                SeachStudents?.Invoke(studentInfo);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введіть інформацію студента для пошуку.");
            }

        }
    }
}
