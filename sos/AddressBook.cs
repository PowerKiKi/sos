using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SOS
{
   class AddressBook
   {
      List<Person> persons = new List<Person>();

      public List<Person> List
      {
         get { return this.persons; }
      }

      public AddressBook(System.Collections.Specialized.StringCollection data)
      {
         foreach (String s in data)
            persons.Add(new Person(s));
      }
   }
}
