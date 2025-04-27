using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyrsovaOOPtask2
{
    public enum TeacherPosition
    {
        Асистент,
        Викладач,
        СтаршийВиклдач,
        Доцент,
        Професор
    }
    public class Teacher:Persone
    {
        private TeacherPosition position { get; set; }
        public Teacher() : base("", "")
        {
            position = TeacherPosition.Викладач;
        }
        
        public Teacher(TeacherPosition position, string lastname, string firstname) : base(lastname, firstname)
        {
            this.position = position;
        }
        
        public Teacher(Teacher t):base(t.lastName,t.firstName) 
        {
            this.position = t.position;
        }

        public string Position => position.ToString();

        public override string ToString()
        {
            return "Посада: " + position  ;
        }
        
        public override string Show()
        {
            return this.ToString() + base.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Teacher other)
            {
                return position == other.position &&
                       firstName == other.firstName &&
                       lastName == other.lastName;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(position, firstName, lastName);
        }
    }
}
