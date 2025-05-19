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
        private TeacherPosition _position;
        
        public Teacher() : base("", "")
        {
            _position = TeacherPosition.Викладач;
        }
        
        public Teacher(TeacherPosition position, string lastname, string firstname) : base(lastname, firstname)
        {
            _position = position;
        }
        
        public Teacher(Teacher teacher):base(teacher.lastName, teacher.firstName) 
        {
            _position = teacher._position;
        }

        public string Position => _position.ToString();
        
        public override bool Equals(object obj)
        {
            if (obj is Teacher other)
            {
                return _position == other._position &&
                       firstName == other.firstName &&
                       lastName == other.lastName;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_position, firstName, lastName);
        }

        public override string ToString()
        {
            return "Посада: " + _position  ;
        }
        
        public override string Show()
        {
            return this.ToString() + base.ToString();
        }
    }
}
