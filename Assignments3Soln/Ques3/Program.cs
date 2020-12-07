using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQues3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stud = new Student[5];
            
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine("enter details of {0} student : ", i);
                Console.Write("roll number : ");
                int rollNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Marks : ");
                decimal marks = Convert.ToDecimal(Console.ReadLine());
                stud[i] = new Student(rollNo, name, marks);
                Console.WriteLine();
            }

            Console.WriteLine("All Student List : ");
            foreach (Student item in stud)
            {
                Console.WriteLine("Rollno : "+item.RollNo + 
                    " StudName : " + item.Name + 
                    " StudMarks : " + item.Marks);
            }
            Console.ReadLine();
        }
    }

    public struct Student
    {
        private int rollNo;
        public int RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                if (value > 0)
                    rollNo = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value!=null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("enter valid name");
                }
            }
        }
        private decimal marks;
        public decimal Marks { get { return marks; } set { marks = value; } }
        public Student(int rollNo = 0, string name = "noname", decimal marks = 0)
        {
            
            this.name = null;
            this.marks = 0;
            this.rollNo = 0;
            this.RollNo = rollNo;
            this.Name = name;
            this.Marks = marks;
        }
    }
}
