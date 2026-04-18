using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Students
    {
        // Properties
        public string name;
        public int age;
        public string studentId;
        public double score;

        // display student info
        public void displayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Student ID: " + studentId);
        }

        // fail/pass status
        public void checkStatus()
        {
            if(score >= 75)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
