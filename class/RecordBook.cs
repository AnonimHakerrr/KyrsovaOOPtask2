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
        Exam[] exam;
        int count;

        public RecordBook(int capacity = 3)
        {
            exam = new Exam[capacity];
            count = 0;
        }

        public void Add(Exam exam)
        {
            try
            {
                if (count < this.exam.Length)
                {
                    this.exam[count] = exam;
                    count++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        public void Delete(int index)
        {
            if (index < count)
            {
                Exam[] tempExams = new Exam[count - 1];
                for (int i = 0; i < count; i++)
                {
                    if (i != index)
                    {
                        tempExams[i] = exam[i];
                    }
                }
            }

            count--;
            }
        public IEnumerator<Exam> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return exam[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
