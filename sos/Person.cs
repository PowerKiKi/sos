using System;
using System.Collections.Generic;
using System.Text;

namespace SOS
{
    class Person
    {
        const char separator = '|';

        string name = "<unknown name>";
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        string number = "<unknown number>";
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public Person(string data)
        {
            string[] tmp = data.Split(separator);
            if (tmp.Length == 2)
            {
                this.number = tmp[0];
                this.name = tmp[1];
            }
        }

        public override string ToString()
        {
            return this.number + separator + this.name;
        }

    }
}
