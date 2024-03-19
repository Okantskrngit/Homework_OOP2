using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation
{

    public class Student
    {
        private string name;
        private int age;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public int Age
        {
            get
            {
                return age;
            }
            set
            {

                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Please enter a positive number");
                }
            }
        }



        public void StudentInfo()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Age : " + age);
        }
    }
}

