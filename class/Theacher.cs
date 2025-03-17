using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyrsovaOOPtask2
{
    public class Theacher:Persone
    {
        private string position { get; set; }
        public Theacher() : base("", "")
        {
            position = "";
        }
        public Theacher(string position, string lastname, string firstname) : base(lastname, firstname)
        {
            this.position = position;
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string ToString()
        {
            return "Посада: " + position +"\n" ;
        }
        public override string Show()
        {
            return this.ToString() + base.ToString();
        }
    }
}
