using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{


    class Student
    {
        private int rollno;
        private string name;
        private string stclass;
        private string sem;
        private string branch;
        private int[] marks = new int[5];

        public Student(int rollno, string name, string stclass, string sem, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.sem = sem;
            this.stclass = stclass;
            this.branch = branch;


        }
        public void GetMarks()
        {
            Console.WriteLine($" enter the marks of all 5 subjects");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public void DisplayResult()
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
                if (mark < 35)
                {
                    Console.WriteLine("result marks in one sub less than 35 : Failed ");
                    return;
                }
                
            }
           int avg = sum / (int)marks.Length;
                if (avg < 50)
                {
                    Console.WriteLine("Result:Failed(avg less than 50)");
                }
                else
                {
                    Console.WriteLine("Result:=========Passed==========");
                }
        }
        public void DisplayData()
        {
            //Console.WriteLine( "================marks==============");
            Console.WriteLine($"{rollno}, {name}, {stclass}, {sem} ,{branch} ");

            for (int i=0; i<marks.Length;i++)
            {
                Console.WriteLine($"sub{i + 1}: { marks[i]}");

            }
        }
    }
}