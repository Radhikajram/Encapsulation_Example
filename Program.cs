using System;

namespace Encapsulation_Example
{
    class Program
    {
        static void Main(string[] args)
        {


            Person person = new Person();

           /* the person object can access the age,fname,lname,height,weight details through its correpesonding set and get method as the fields in the Person class are declared as private.
           When i try to access the field after person. only the method Names are listed and not the field names.So if i want to access the variable i need to access through its get and set methods which are declared as public. */

           // set the person details through set method.
           
            person.firstName = "Shreya";
            person.Age = 3;
            person.lastName = "Jayakrishnan";
            person.personHeight = 90;
            person.personWeight = 13;

            // get the preson details through get method and print.

            printPerson();


            // Instantiate PersonHandler class.

            PersonHandler perhand = new PersonHandler();

            // Set the Age using SetAge method of PersonHandler class.

            perhand.SetAge(person, 5);

            //print the  Updated detalis.

            printPerson();

            // Create Person1

            Person createNewPerson1 = perhand.CreatePerson(7, "Sahana", "Jayakrishnan", 105.2, 17.5);

            perhand.printPerson(createNewPerson1);

            // Create Person2

            Person createNewPerson2 = perhand.CreatePerson(7, "Jayaraman", "Viswanathan", 160.9, 45.5);

            perhand.printPerson(createNewPerson2                        );



            void printPerson()
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"First Name is: {person.firstName}");
                Console.WriteLine($"Last Name is: {person.lastName}");
                Console.WriteLine($"Age : {person.Age}");
                Console.WriteLine($"Height: {person.personHeight}");
                Console.WriteLine($"Weight: {person.personWeight}");
            }
        }
    }
}
