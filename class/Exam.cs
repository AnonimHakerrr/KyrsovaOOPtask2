using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyrsovaOOPtask2
{
    public class Exam
    {
        private Teacher _teacher;
        
        private string _nameExam { get; set; }
        
        private int _hours { get; set; }
        
        private int _rating { get; set; }
        
        private DateTime _dateTime { get; set; }
        
        public Exam( Teacher tech, string nameExam, int hours, int rating, DateTime dateTime)
        {
            _teacher = tech;
            _nameExam = nameExam;
            _hours = hours;
            _rating = rating;
            _dateTime = dateTime;
        }
        
        public int rating {
            get => _rating; 
            set => _rating = value;
        }

        public int hours => _hours;
        
        public DateTime dateTime => _dateTime;
        
        public string nameExam => _nameExam;
        
        public Teacher teacher => _teacher;
        
        public override bool Equals(object obj)
        {
            if (obj is Exam other)
            {
                return _nameExam == other._nameExam &&
                       _hours == other._hours &&
                       _rating == other._rating &&
                       _dateTime.Date == other._dateTime.Date &&
                       _teacher.Equals(other._teacher);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_nameExam, _hours, _rating, _dateTime.Date, _teacher);
        }

        public override string ToString()
        {
            return  $"\nЕкзамен з {_nameExam} " +
                $"\nДата проеведення : {_dateTime.Date.ToString()}" +
                $"\nВідведення кількість годин: {_hours} " +
                $"\nОцінка: {_rating}" +
                $"\n{_teacher.Show()}";
        }
    }
}
