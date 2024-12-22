using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyrsovaOOPtask2
{
    public class Persone
    {
       private string lastname,firstname;
       public Persone(string lastname, string firstname)
       {
           this.lastname = lastname;
           this.firstname = firstname;
       }
       public Persone(Persone p)
       {
           lastname = p.lastname;
           firstname = p.firstname;
       }
        public void  SetPerson(string lastname, string firstname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string GetLast()
        {
            return lastname;
        }

        public string GetFirst()
        {
            return firstname;
        }
        public override string ToString()
        {
            return "Прізвище: " + lastname + ", Ім'я: " + firstname;
        }
      
        public virtual string   Show()
        { 
            return   ToString();
        }
        public void EnterName()
        {
            Console.Write("Введіть ім'я : ");
            firstname = Console.ReadLine();

            Console.Write("Введіть призвіще: ");
            lastname = Console.ReadLine();
        }

      

    }

    
}
