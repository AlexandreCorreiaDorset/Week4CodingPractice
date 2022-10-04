using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4CodingPractice
{
    class Person
    {
        private string name;
        
        public string Name
        {
            get { return (this.name); }
            set { this.name = value; }
        }

        public Person(string name)
        {
            this.name = name;
        }

        ~Person()
        {
            this.name = String.Empty;
        }
    }
}
