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
    public partial class AddStud : Form
    {
        public delegate void StudCreatedHandler(Student exam);
       
        public event StudCreatedHandler StudCreated;
        
        public AddStud(List<Student> listStudents)
        {
            InitializeComponent(); 
            listGroup.Items.AddRange(listStudents.Select(s => s.nomerGrup).Distinct().ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                StudCreated?.Invoke(new Student(listGroup.Text, LastNameStudent.Text, NameStudent.Text));
                this.Close();
            }
        }
        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(listGroup.Text) || string.IsNullOrWhiteSpace(LastNameStudent.Text) || string.IsNullOrWhiteSpace(NameStudent.Text))
            {
                MessageBox.Show("Всі поля повинні бути заповнені.");
                return false;
            }
            return true;
        }

        private void Click_KeyDown(object sender, KeyEventArgs e)
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

       
    }
}
