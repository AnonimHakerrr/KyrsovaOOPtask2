using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyrsovaOOPtask2
{
    public class Student:Persone
    {
        private string _nomerGrup { get; set; }
        private RecordBook _recordBook =new RecordBook(5);
        public Student() : base("", "")
        {
            _nomerGrup ="";
        }

        public Student(string nomerGrup, string lastname, string firstname) : base(lastname, firstname)
        {
            this._nomerGrup=nomerGrup;   
            
        }
        public string nomerGrup => _nomerGrup;
        public RecordBook GetRecordbook()
        {
            return _recordBook;
        }
        public void AddExam(Exam exam)
        {
            _recordBook.Add(exam);
        }
        public void DeleteExam(Exam exam)
        {
            _recordBook.Delete(1);
        }
        public override string ToString()
        {
            return $"Студент групи :{_nomerGrup} ";
        }

        public override string Show()
        { 
           return  (this.ToString()+base.ToString());
        }
        public override bool Equals(object obj)
        {
            if (obj is Student other)
            {
                return _nomerGrup == other._nomerGrup &&
                       firstName == other.firstName &&
                       lastName == other.lastName;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_nomerGrup, firstName, lastName);
        }
    }
}

