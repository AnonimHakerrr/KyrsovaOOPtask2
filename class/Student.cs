using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyrsovaOOPtask2
{
    public class Student:Persone
    {
        private string nomerGrup { get; set; }
        public Student() : base("", "")
        {
            nomerGrup ="";
        }

        public Student(string nomerGrup, string lastname, string firstname) : base(lastname, firstname)
        {
            this.nomerGrup=nomerGrup;   
            
        }
        public string NomerGrup
        {
            get { return nomerGrup; }
            set { nomerGrup = value; }
        }
        public override string ToString()
        {
            return $"Студент групи :{nomerGrup} \n";
        }

        public override string Show()
        { 
           return  this.ToString()+base.Show();
        }
    }
}
