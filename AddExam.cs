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
    public partial class AddExam : Form
    {
        public delegate void ExamCreatedHandler(Exam exam);
        public event ExamCreatedHandler ExamCreated;
        public AddExam()
        {
            InitializeComponent();
            Position.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return; 
            }
            if (!Enum.TryParse(Position.SelectedItem.ToString(), out TeacherPosition position))
            {
                MessageBox.Show("Невірна посада викладача.");
                return;
            }
            Exam exam = new Exam(
                new Teacher(position, LastNameTheacher.Text, NameTheacher.Text),
                Predmet.Text, Convert.ToInt32(Hours.Value), Convert.ToInt32(Rating.Value), DateProv.Value.Date
            );
            ExamCreated?.Invoke(exam);
            this.Close();

        }
        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(Predmet.Text) ||
                (int)Hours.Value  == 0  ||
                (int)Rating.Value < -1 ||
                string.IsNullOrWhiteSpace(Position.SelectedItem.ToString()) ||
                string.IsNullOrWhiteSpace(NameTheacher.Text) ||
                string.IsNullOrWhiteSpace(LastNameTheacher.Text))
            {
                MessageBox.Show("Усі поля повинні бути заповнені.");
                return false;
            }
            return true;
        }


    }
}
