using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyrsovaOOPtask2
{
    public class RecordBook : IEnumerable<Exam>
    {
        Exam[] _exam;
        int _count;

        public RecordBook(int capacity = 3)
        {
            _exam = new Exam[capacity];
            _count = 0;
        }

        public Exam[] Exams => _exam;

        public int Count => _count;

        public void Add(Exam exam)
        {
            try
            {
                if (_count < this._exam.Length)
                {
                    this._exam[_count] = exam;
                    _count++;
                }
                else
                {
                    int newSize = this._exam.Length * 2;
                    Exam[] newArray = new Exam[newSize];
                    for (int i = 0; i < this._exam.Length; i++)
                    {
                        newArray[i] = this._exam[i];
                    }
                    this._exam = newArray;
                    this._exam[_count] = exam;
                    _count++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
       
        public void Delete(int index)
        {
            if (index < _count)
            {
                Exam[] tempExams = new Exam[_count - 1];
                int j = 0;
                for (int i = 0; i < _count; i++)
                {
                    if (i != index)
                    {
                        tempExams[j++] = _exam[i];
                    }
                }
                _exam = tempExams;
            }
            _count--;
        }

        public IEnumerator<Exam> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _exam[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
