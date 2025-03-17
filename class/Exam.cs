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
        private Student stud = new Student();
        private Theacher thech = new Theacher();
        public string nameExam { get; private set; }
        public int hours { get; private set; }
        public int rating { get; private set; }
        public DateTime dateTime { get; private set; }
        public Exam(Student stud,Theacher thech, string nameExam, int hours, int rating, DateTime dateTime)
        {
            this.stud =  stud;
            this.thech=thech;
            this.nameExam = nameExam;
            this.hours = hours;
            this.rating = rating;
            this.dateTime = dateTime;
        }
      
        public override string ToString()
        {
            return "\nЕкзамен з "+nameExam + "\nДата проеведення :  " + 
                   dateTime.Date.DayOfWeek.ToString() + "\nВідведення кількість годин: " +
                   hours + "\nОцінка: " +
                   rating +
                   "\n" + thech.Show() +
                   "\n" + stud.Show();
        }
        
         

       
        
    }
}
