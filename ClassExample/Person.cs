using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
    class Person
    {
        // Member Variables
        // method s

        private  string name { get;  set; }
        private int age { get; set; }

        // Methods

        public void SetMember (string setName, int setAge)
        {
            name = setName;
            age = setAge;
        }

        public void GetMember(out string getName, out int getAge)
        {
            getName =name;
            getAge = age;
        }


    }

    
}
