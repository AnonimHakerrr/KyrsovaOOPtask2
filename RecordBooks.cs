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
        private List<Student> _students = new List<Student>();
        private bool _isFilterActive = false;
        private bool _isFileReader = false;
        private bool _isFilterExamAtive = false;
        public RecordBooks()
        {
            InitializeComponent();
        }
        public List<Student> students => _students;
        private void NotVisiableMenuItem()
        {
            DeleteMenuItem.Visible = false;
            DeleteStudentMenuItem.Visible = false;
            DeleteExamMenuItem.Visible = false;
            UpdateRatingMenuItem.Visible = false;
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
        // вивід студентів
        private void ShowStudentList()
        {
            listBox1.Items.Clear();
            NotVisiableMenuItem();
            if (students.Count == 0)
            {
                MessageBox.Show("Студентів не знайдено");
                return;
            }
            foreach (Student st in students)
            {
                listBox1.Items.Add(st.Show());
            }
            _isFilterActive = true;
            _isFilterExamAtive = false;
            DeleteMenuItem.Visible = true;
            DeleteStudentMenuItem.Visible = true;
        }
        // вивід екзаменів студента
        private void ShowStudentExamsList(int index)
        {
            NotVisiableMenuItem();
            if (students[index].recordBook.Count == 0)
            {
                MessageBox.Show("Екзаменів не знайдено");
                ShowStudentList();
                return;
            }
            listBox1.Items.Clear();
            listBox1.Items.Add(students[index].Show());
            foreach (Exam exam in students[index].recordBook)
            {
                listBox1.Items.Add(exam.ToString());
            }
            _isFilterActive = false;
            _isFilterExamAtive = true;
            DeleteMenuItem.Visible = true;
            DeleteExamMenuItem.Visible = true;
            UpdateRatingMenuItem.Visible = true;
        }

        // додавання студентів
        private void AddStudent(object sender, EventArgs e)
        {
            AddStud _addStudentForm = new AddStud(students);
            _addStudentForm.StudCreated += StudentCreated;
            _addStudentForm.ShowDialog();
            ShowStudentList();
        }
        private void StudentCreated(Student stud)
        {
            if (!isValidStud(stud))
            {
                MessageBox.Show("Студент вже існує");
                return;
            }
            students.Add(stud);
        }

        // додавання студентів  екзаменів
        private void AddExamToStudent(object sender, EventArgs e)
        {

            int _indexStudent = listBox1.SelectedIndex;
            if (_indexStudent < 0)
            {
                MessageBox.Show("Виберіть студента");
                return;
            }
            _indexStudent = students.FindIndex(student => student.Show() == listBox1.Items[_indexStudent].ToString());
            AddExam _addExamForm = new AddExam();
            _addExamForm.ExamCreated += ExamCreated;
            _addExamForm.ShowDialog();
        }
        private void ExamCreated(Exam exam)
        {
            if (!isValidStudExam(students[listBox1.SelectedIndex], exam))
            {
                MessageBox.Show("Екзамен вже існує");
                return;
            }
            students[listBox1.SelectedIndex].AddExam(exam);
        }

        // видалення студента
        private void DeleteStudent(object sender, EventArgs e)
        {
            int _indexStudent = listBox1.SelectedIndex;
            if (_indexStudent < 0)
            {
                MessageBox.Show("Виберіть студента");
                return;
            }
            _indexStudent = students.FindIndex(student => student.Show() == listBox1.Items[_indexStudent].ToString());
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цього студента?", "Підтвердження", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            students.RemoveAt(_indexStudent);
            ShowStudentList();
        }

        // видалення екзамену
        private void DeleteExamToStudent(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index <= 0 || !_isFilterExamAtive)
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
            students[indexStudent].recordBook.Delete(index - 1);
            ShowStudentExamsList(indexStudent);
        }

        // вивідд студентів використовуючи метод 
        private void ViewListStudent(object sender, EventArgs e)
        {
            ShowStudentList();
        }

        //вивід екзаменів студента
        private void ViewExamsToStudent(object sender, EventArgs e)
        {
            int _indexStudent = listBox1.SelectedIndex;
            if (_indexStudent < 0)
            {
                _indexStudent = students.FindIndex(student => student.Show() == listBox1.Items[_indexStudent].ToString());
                if (_indexStudent < 0)
                {
                    ShowStudentList();
                    MessageBox.Show("Виберіть студента");
                    return;
                }
            }
            listBox1.Items.Clear();
            ShowStudentExamsList(_indexStudent);
        }

        //сортуання студентів по середньому балу
        private void AverageScoreToStudent(object sender, EventArgs e)
        {

            int index = listBox1.SelectedIndex;
            if (index < 0 || !_isFilterActive)
            {
                ShowStudentList();
                MessageBox.Show("Виберіть студента");
                return;
            }
            if (students[index].recordBook.Count == 0)
            {
                MessageBox.Show("Екзаменів не знайдено");
                return;
            }
            double average = 0;
            foreach (Exam exam in students[index].recordBook)
            {
                average += exam.rating;
            }
            average /= students[index].recordBook.Count;
            MessageBox.Show($"Середній бал студента \n{students[index].Show()} \n-> {average}");
        }

        // сортування студентів по  середньому балу 
        private void SortStudentsAverage(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("Список студентів порожній.");
                return;
            }
            bool hasAnyExams = students.Any(st => st.recordBook.Count > 0);
            if (!hasAnyExams)
            {
                MessageBox.Show("У жодного студента немає екзаменів.");
                return;
            }
            NotVisiableMenuItem();
            var sortedStudents = students.OrderByDescending(st =>
            st.recordBook.Count > 0 ? st.recordBook.Average(exam => exam.rating) : 0).ToList();
            listBox1.Items.Clear();
            foreach (var student in sortedStudents)
            {
                var rating = student.recordBook.Count > 0 ? student.recordBook.Average(exam => exam.rating) : 0;
                listBox1.Items.Add($"{student.Show()} Середній бал - {rating} ");
            }
            _isFilterActive = false;
            _isFilterExamAtive = false;
        }

        // сортування студентів по оцінці екзамену
        private void SortStudentsRatingExam(object sender, EventArgs e)
        {
            SeachExam SeachExamForm = new SeachExam();
            SeachExamForm.SeachExams += SeachExam;
            SeachExamForm.ShowDialog();
        }
        private void SeachExam(string examName)
        {
            var filteredStudents = students
             .Where(st => st.recordBook.Any(ex => ex.nameExam.ToLower() == examName.ToLower()))
              .OrderByDescending(st =>st.recordBook
               .First(ex => ex.nameExam.ToLower() == examName.ToLower()).rating).ToList();
            if (filteredStudents.Count == 0)
            {
                MessageBox.Show("Немає жодного студента з екзаменом \"" + examName + "\".");
                return;
            }
            listBox1.Items.Clear();
            NotVisiableMenuItem();
            foreach (var student in filteredStudents)
            {
                var exam = student.recordBook
                    .First(ex => ex.nameExam.Equals(examName, StringComparison.OrdinalIgnoreCase));

                listBox1.Items.Add($"{student.Show()} Оцінка - {exam.rating}");
            }
            _isFilterActive = false;
            _isFilterExamAtive = false;
        }

        // вивід студентів по екзамену
        private void ViewStudentsOnExam(object sender, EventArgs e)
        {
            SeachExam _seachExamForm = new SeachExam();
            _seachExamForm.SeachExams += SeachExamName;
            _seachExamForm.ShowDialog();
        }
        private void SeachExamName(string examName)
        {
            var filteredStudents = students.Where(st => st.recordBook.Any(ex => ex.nameExam.ToLower() == examName.ToLower())).ToList();
            if (filteredStudents.Count == 0)
            {
                MessageBox.Show("Немає жодного студента з екзаменом \"" + examName + "\".");
                return;
            }
            listBox1.Items.Clear();
            NotVisiableMenuItem();
            foreach (var student in filteredStudents)
            {
                listBox1.Items.Add(student.Show());
            }
            _isFilterActive = false;
            _isFilterExamAtive = false;
        }

        // читання з файлу
        private void ReadFile(object sender, EventArgs e)
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
                            if (isValidStudExam(existingStudent, exam))
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
            _isFileReader = true;
        }

        // валідаці порівняння студентів
        private bool isValidStud(Student st)
        {
            var existingStudent = students.FirstOrDefault(s => s.Equals(st));
            return existingStudent == null;
        }

        // валідація порівняння екзаменів 
        private bool isValidStudExam(Student st, Exam exam)
        {
            var recordbook = st.recordBook;
            var existingExam = recordbook.FirstOrDefault(e => e.Equals(exam));
            return existingExam == null;
        }

        // запис в файл
        private void WriteFile(object sender, EventArgs e)
        {
            if (!_isFileReader)
            {
                MessageBox.Show("Сопчатку оновіть список, зчитуваням з файлу");
                return;
            }
            List<string> lines = new List<string>();
            foreach (var student in students)
            {
                var studentLine = $"{student.nomerGrup},{student.lastName},{student.firstName}";
                foreach (var exam in student.recordBook)
                {
                    studentLine += $",{exam.nameExam},{exam.dateTime},{exam.hours},{exam.rating},{exam.teacher.Position.ToString()}," +
                        $"{exam.teacher.firstName},{exam.teacher.lastName}";
                }
                lines.Add(studentLine);
            }
            File.WriteAllLines("C:\\Users\\oleks\\source\\repos\\KyrsovaOOPtask2\\ListStudentAndExam.txt", lines, Encoding.GetEncoding(1251));
            MessageBox.Show("Експорт завершено!");
        }

        //пошук студента
        private void SeachStudent(object sender, EventArgs e)
        {
            SeachStudent _seachExamForm = new SeachStudent();
            _seachExamForm.SeachStudents += SeachInfoStudent;
            _seachExamForm.ShowDialog();
        }
        private void SeachInfoStudent(string studentInfo)
        {
            var searchWords = studentInfo.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            var filteredStudents = students.Where(student =>
            {
                var studentData = $"{student.firstName} {student.lastName} {student.nomerGrup}".ToLower();
                return searchWords.All(word => studentData.Contains(word.ToLower()));
            }).ToList();
            if (filteredStudents.Count==0) {
                MessageBox.Show("Студентів не знайдено");
                return;
            } 
            listBox1.Items.Clear();
            foreach (var student in filteredStudents)
            {
                listBox1.Items.Add(student.Show());
            }
            _isFileReader = false;
            _isFilterExamAtive = false;
            DeleteExamMenuItem.Visible = true;
            DeleteStudentMenuItem.Visible = true;
            DeleteExamMenuItem.Visible = false;
            UpdateRatingMenuItem.Visible = false;

        }

        // редагування оцінки за екзамен який вибраний 
        private void UpdateRatingExam(object sender, EventArgs e)
        { 
            int index = listBox1.SelectedIndex;
            if (index <= 0 || !_isFilterExamAtive)
            {
                MessageBox.Show("Виберіть екзамен");
                return;
            }
            int indexStudent = students.FindIndex(student => student.Show() == listBox1.Items[0].ToString());
            int examIndex = index - 1;
            var recordbook = students[indexStudent].recordBook;
            var currentRating = recordbook.Exams[examIndex].rating;
            string newRatingString = Microsoft.VisualBasic.Interaction.InputBox(
                $"Введіть нову оцінку для екзамену: {recordbook.Exams[examIndex].nameExam}",
                "Редагування оцінки", currentRating.ToString());

            if (string.IsNullOrWhiteSpace(newRatingString))
            {
                return;
            }
            int newRating;
            if (!int.TryParse(newRatingString, out newRating) || newRating < 0 || newRating > 100)
            {
                MessageBox.Show("Невірна оцінка! Введіть число від 0 до 100.");
                return;
            }
            recordbook.Exams[examIndex].rating = newRating;
            ShowStudentExamsList(indexStudent);
        }


    }

}

