using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Example
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        // Get and set method for age.
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        // get and set method of First Name
        public string firstName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }

        // get and set method fro Last Name
        public string lastName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }

        }

        // get and set method for height
        public double personHeight {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
         }
        // get and set method for weight.
        public double personWeight { 
            
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }   
        }
    }
}
