using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyrsovaOOPtask2
{
    public class Persone
    {
       private string _lastname,_firstname;
       public Persone(string lastname, string firstname)
       {
           _lastname = lastname;
           _firstname = firstname;
       }
       public Persone(Persone p)
       {
           _lastname = p._lastname;
           _firstname = p._firstname;
       }
        public void  SetPerson(string lastname, string firstname)
        {
            this._firstname = firstname;
            this._lastname = lastname;
        }
        public string lastName => _lastname;
        public string firstName => _firstname;
        public override string ToString()
        {
            return $"\nПрізвище: { _lastname} , Ім'я: { _firstname}\n";
        }
      
        public virtual string   Show()
        { 
            return ToString();
        }
    }

    
}
