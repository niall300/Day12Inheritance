using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given two classes, Person and Student,
//    where Person is the base class and Student is the derived class. 
//Completed code for Person and a declaration for Student are provided for you in the editor.
//    Observe that Student inherits all the properties of Person.

//Complete the Student class by writing the following:

//A Student class constructor, which has  parameters:
//A string, .
//A string, .
//An integer, .
//An integer array(or vector) of test scores, .
//A char calculate() method that calculates a Student 
//    object's average and returns the grade character representative of their calculated average:

namespace Day10Inheritance
{
    class Solution
    {
        static void Main(string[] args)
        {

            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.ReadLine();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;






        public Person()
        {

            //Console.WriteLine("calling constructor in Person");
            


        }
        public Person(string firstName, string lastName, int identification)
        {

            // Console.WriteLine("calling multiple parameter constructor in Person");
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }


    class Student : Person
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here
        public Student()
        {
            Console.WriteLine("calling constructor in Student");
            Console.ReadLine();
        }

        public Student(string firstName, string lastName, int identification, int[] scores) 
            : base(firstName, lastName, identification)
        {
            this.testScores = scores;

        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public char Calculate()
        {

            char result = 'x';

            int total = 0;
            int averageGrade = 0;

            foreach(var v in testScores)
            {
                total = total + v;
            }

            averageGrade = total / testScores.Length;
            //Console.WriteLine("Testscores length is: " + testScores.Length);
            //Console.WriteLine("Average Grade is: " + averageGrade);
            //Console.ReadLine();
            if (averageGrade >= 90 && averageGrade <= 100)
                result = 'O';
            if (averageGrade >= 80 && averageGrade < 90)
                result = 'E';
            if (averageGrade >= 70 && averageGrade < 80)
                result = 'A';
            if (averageGrade >= 55 && averageGrade < 70)
                result = 'P';
            if (averageGrade >= 40 && averageGrade < 55)
                result = 'D';
            if (averageGrade < 40)
                result = 'T';
            else
            {
                Console.WriteLine("We have a problem");
            }



            return result;

        }
    }
}
