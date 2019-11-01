using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Example
{
    class PersonHandler
    {
    
        public void SetAge(Person pers,int age)
        {
            pers.Age = age;

        }
     
        public Person CreatePerson(int age,string fname,string lname,double height,double weight)
        {
           Person newPerson = new Person();
       
            newPerson.Age = age;
            newPerson.firstName = fname;
            newPerson.lastName = lname;
            newPerson.personHeight = height;
            newPerson.personWeight = weight;

            return newPerson;

        }

        public void printPerson(Person newPerson)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"First Name is: {newPerson.firstName}");
            Console.WriteLine($"Last Name is: {newPerson.lastName}");
            Console.WriteLine($"Age : {newPerson.Age}");
            Console.WriteLine($"Height: {newPerson.personHeight}");
            Console.WriteLine($"Weight: {newPerson.personWeight}");
        }

    }
}
