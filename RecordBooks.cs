using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace KyrsovaOOPtask2
{
    public partial class RecordBooks : Form
    {
        private List<Student> students = new List<Student>();
        private bool isFilterActive = false;
        private bool isFileReader = false;
        private bool isfilterExamAtive = false;
        public RecordBooks()
        {
            InitializeComponent();
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

        private void ShowStudentList()
        {
            listBox1.Items.Clear();
            if (students.Count == 0)
            {
                MessageBox.Show("Студентів не знайдено");
                return;
            }
            foreach (Student st in students)
            {
                listBox1.Items.Add(st.Show());
            }
            isFilterActive = true;
            isfilterExamAtive = false;
        }
        private void ShowStudentExamsList(int index)
        {
            if (students[index].GetRecordbook().Count == 0)
            {
                MessageBox.Show("Екзаменів не знайдено");
                ShowStudentList();
                return;
            }
            listBox1.Items.Clear();
            listBox1.Items.Add(students[index].Show());
            foreach (Exam exam in students[index].GetRecordbook())
            {
                listBox1.Items.Add(exam.ToString());
            }
            isFilterActive = false;
            isfilterExamAtive = true;
        }

        private void середнійБалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0 || !isFilterActive)
            {
                MessageBox.Show("Виберіть студента ( Виберіть  Фільтр -> Вивід студентів )");
                return;
            }
            if (students[index].GetRecordbook().Count == 0)
            {
                MessageBox.Show("Екзаменів не знайдено");
                return;
            }
            double average = 0;
            foreach (Exam exam in students[index].GetRecordbook())
            {
                average += exam.rating;
            }
            average /= students[index].GetRecordbook().Count;
            MessageBox.Show($"Середній бал студента \n{students[index].Show()} \n-> {average}");
        }

        private void додаванняСтрудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStud f = new AddStud();
            f.StudCreated += Form2_StudentCreated;
            f.ShowDialog();
            ShowStudentList();
        }
        private void Form2_StudentCreated(Student stud)
        {
            if (!isValidStud(stud))
            {
                MessageBox.Show("Студент вже існує");
                return;
            }
            students.Add(stud);
            MessageBox.Show("Студента додано");

        }

        private void додаванняЕкзаменуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                if ((index <= 0 && !isFilterActive) || listBox1.Items[index].ToString() == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                AddExam f = new AddExam();
                f.ExamCreated += AddExam_ExamCreated;
                f.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Виберіть студента ( Виберіть  Фільтр -> Вивід студентів )");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Невідома помилка: {ex.Message}");
            }
        }
        private void AddExam_ExamCreated(Exam exam)
        {
            if (!isValidStudExam(students[listBox1.SelectedIndex], exam))
            {
                MessageBox.Show("Екзамен вже існує");
                return;
            }
            students[listBox1.SelectedIndex].AddExam(exam);
            MessageBox.Show("Екзамен додано");
        }

        private void вивідЕкзаменівСтрудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                if (index < 0 || !isFilterActive )
                {
                    MessageBox.Show("Виберіть студента ( Виберіть  Фільтр -> Вивід студентів )");
                    return;
                }
                listBox1.Items.Clear();
                ShowStudentExamsList(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Невідома помилка: {ex.Message}");
            }
        }

        private void DeleteCтудента(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                if (index <= 0 && listBox1.Items[index].ToString() == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цього студента?", "Підтвердження", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes) return;
                students.RemoveAt(index);
                MessageBox.Show("Студента видалено");
                ShowStudentList();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Виберіть студента");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Невідома помилка: {ex.Message}");
            }
        }

        private void вивідСтруденівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentList();
        }

        private void екзаменуСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0 && !isFilterActive)
            {
                MessageBox.Show("Екзамена не знайдено ( виберіть Екзамен ," +
                    " якщо ви не бачите екзаменів зайдіть в фільтр і виберіть пункт меню" +
                    " під назвою Вивід екзаменів студента )");
                return;
            }
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цього студента?", "Підтвердження", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            int indexStudent = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Show() == listBox1.Items[0].ToString())
                {
                    indexStudent = i;
                    break;
                }
            }
            students[indexStudent].GetRecordbook().Delete(index - 1);
            MessageBox.Show("Екзамен видалено");
            ShowStudentExamsList(indexStudent);
        }

        private void середнійБалПоЕкзаменуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("Список студентів порожній.");
                return;
            }
            bool hasAnyExams = students.Any(st => st.GetRecordbook().Count > 0);
            if (!hasAnyExams)
            {
                MessageBox.Show("У жодного студента немає екзаменів.");
                return;
            }
            var sortedStudents = students.OrderByDescending(st =>
            st.GetRecordbook().Count > 0 ? st.GetRecordbook().Average(exam => exam.rating) : 0).ToList();
            listBox1.Items.Clear();
            foreach (var student in sortedStudents)
            {
                var rating = student.GetRecordbook().Count > 0 ? student.GetRecordbook().Average(exam => exam.rating) : 0;
                listBox1.Items.Add($"{student.Show()} Середній бал - {rating} ");
            }
            isFilterActive = false;
            isfilterExamAtive = false;
        }

        private void сортуванняСтудентівПоОцінціЕкзаменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFilterActive)
            {
                MessageBox.Show("Виберіть студента ( Виберіть  Фільтр -> Вивід студентів )");
                return;
            }
            SeachExam f = new SeachExam();
            f.SeachExams += SeachExam_SeachExamRating;
            f.ShowDialog();

        }
        private void SeachExam_SeachExamRating(string examName)
        {
            var filteredStudents = students
      .Where(st => st.GetRecordbook().Any(ex => ex.nameExam.ToLower() == examName.ToLower()))
      .OrderByDescending(st =>
          st.GetRecordbook()
            .First(ex => ex.nameExam.ToLower() == examName.ToLower()).rating).ToList();
            if (filteredStudents.Count == 0)
            {
                MessageBox.Show("Немає жодного студента з екзаменом \"" + examName + "\".");
                return;
            }
            listBox1.Items.Clear();
            foreach (var student in filteredStudents)
            {
                var exam = student.GetRecordbook()
                    .First(ex => ex.nameExam.Equals(examName, StringComparison.OrdinalIgnoreCase));

                listBox1.Items.Add($"{student.Show()} Оцінка - {exam.rating}");
            }
            isFilterActive = false;
            isfilterExamAtive = false;
        }

        private void вивідСтудентівПоЕкзаменуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFilterActive)
            {
                MessageBox.Show("Виберіть студента ( Виберіть  Фільтр -> Вивід студентів )");
                return;
            }
            SeachExam f = new SeachExam();
            f.SeachExams += SeachExamName;
            f.ShowDialog();
        }
        private void SeachExamName(string examName)
        {
            var filteredStudents = students.Where(st => st.GetRecordbook().Any(ex => ex.nameExam.ToLower() == examName.ToLower())).ToList();
            if (filteredStudents.Count == 0)
            {
                MessageBox.Show("Немає жодного студента з екзаменом \"" + examName + "\".");
                return;
            }
            listBox1.Items.Clear();
            foreach (var student in filteredStudents)
            {
                listBox1.Items.Add(student.Show());
            }
            isFilterActive = false;
              isfilterExamAtive = false;
        }

        private void читанняЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(
            "C:\\Users\\oleks\\source\\repos\\KyrsovaOOPtask2\\ListStudentAndExam.txt",
            Encoding.GetEncoding(1251)
            );
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                Student student = new Student(parts[0], parts[1], parts[2]);
                if (!isValidStud(student))
                {
                    if (parts.Length > 3)
                    {
                        var existingStudent = students.FirstOrDefault(s => s.Equals(student));
                        for (int i = 3; i + 6 < parts.Length; i += 7)
                        {
                            Enum.TryParse(parts[i + 4], out TeacherPosition position);
                            Teacher tech = new Teacher(position, parts[i + 5], parts[i + 6]);
                            Exam exam = new Exam(tech, parts[i], int.Parse(parts[i + 2]), int.Parse(parts[i + 3]), DateTime.Parse(parts[i + 1]));
                            if (!isValidStudExam(existingStudent, exam))
                            {
                                existingStudent.AddExam(exam);
                            }
                        }
                    }
                    continue;
                }
                if (parts.Length < 7)
                {
                    students.Add(student);
                    continue;
                }
                for (int i = 3; i + 6 < parts.Length; i += 7)
                {
                    Enum.TryParse(parts[i + 4], out TeacherPosition position);
                    Teacher tech = new Teacher(position, parts[i + 5], parts[i + 6]);
                    Exam exam = new Exam(tech, parts[i], int.Parse(parts[i + 2]), int.Parse(parts[i + 3]), DateTime.Parse(parts[i + 1]));
                    student.AddExam(exam);
                }
                students.Add(student);
            }
            ShowStudentList();
            MessageBox.Show("Імпорт завершено!");
            isFileReader = true;
        }

        private bool isValidStud(Student st)
        {
            var existingStudent = students.FirstOrDefault(s => s.Equals(st));
            return existingStudent == null;
        }
        private bool isValidStudExam(Student st, Exam exam)
        {
            var recordbook = st.GetRecordbook();
            var existingExam = recordbook.FirstOrDefault(e => e.Equals(exam));
            return existingExam == null;
        }

        private void записВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFileReader)
            {
                MessageBox.Show("Сопчатку оновіть список, зчитуваням з файлу");
                return;
            }
            List<string> lines = new List<string>();
            foreach (var student in students)
            {
                var studentLine = $"{student.nomerGrup},{student.lastName},{student.firstName}";
                foreach (var exam in student.GetRecordbook())
                {
                    studentLine += $",{exam.nameExam},{exam.dateTime},{exam.hours},{exam.rating},{exam.teacher.Position.ToString()}," +
                        $"{exam.teacher.firstName},{exam.teacher.lastName}";
                }
                lines.Add(studentLine);
            }
            File.WriteAllLines("C:\\Users\\oleks\\source\\repos\\KyrsovaOOPtask2\\ListStudentAndExam.txt", lines, Encoding.GetEncoding(1251));
            MessageBox.Show("Експорт завершено!");
        }

        private void пошукСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeachStudent f = new SeachStudent();
            f.SeachStudents += SeachInfoStudent;
            f.ShowDialog();
        }
        private void SeachInfoStudent(string studentInfo)
        {
            var searchWords = studentInfo.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            var filteredStudents = students.Where(student =>
            {
                var studentData = $"{student.firstName} {student.lastName} {student.nomerGrup}".ToLower();

                return searchWords.All(word => studentData.Contains(word.ToLower()));
            }).ToList();
            listBox1.Items.Clear();
            foreach (var student in filteredStudents)
            {
                listBox1.Items.Add(student.Show());
            }
            isFileReader = false;
            isfilterExamAtive = false;
        }

        private void редагуваннняОцінкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0 && !isFilterActive)
            {
                MessageBox.Show("Екзамена не знайдено ( виберіть Екзамен ," +
                    " якщо ви не бачите екзаменів зайдіть в фільтр і виберіть пункт меню" +
                    " під назвою Вивід екзаменів студента )");
                return;
            }
            int indexStudent = students.FindIndex(student => student.Show() == listBox1.Items[0].ToString());
            int examIndex = index - 1;
            var recordbook = students[indexStudent].GetRecordbook();
            var currentRating = recordbook.Exams[examIndex].rating;
            string newRatingString = Microsoft.VisualBasic.Interaction.InputBox(
                $"Введіть нову оцінку для екзамену: {recordbook.Exams[examIndex].nameExam}",
                "Редагування оцінки", currentRating.ToString());

            if (string.IsNullOrWhiteSpace(newRatingString))
            {
                MessageBox.Show("Оцінка не була змінена.");
                return;
            }
            int newRating;
            if (!int.TryParse(newRatingString, out newRating) || newRating < 0 || newRating > 100)
            {
                MessageBox.Show("Невірна оцінка! Введіть число від 0 до 100.");
                return;
            }
            recordbook.Exams[examIndex].rating = newRating;
            MessageBox.Show("Оцінку змінено");
            ShowStudentExamsList(indexStudent);
        }

    }

}

