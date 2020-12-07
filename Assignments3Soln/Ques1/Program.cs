using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQues1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee obj1 = new Employee("Dipesh",2000,12);
            //obj1.Display();

            Employee[] empArray = new Employee[2];

            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine("Enter Employee {0} Name :", i);
                string empName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Employee {0} Basic :", i);
                decimal basic = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Employee {0} DeptNo :", i);
                short deptNo = Convert.ToInt16(Console.ReadLine());

                Employee obj = new Employee(empName, basic, deptNo);
                empArray[i] = obj;
                Console.WriteLine();
            }

            //Find Employee in Array From EmpNo
            //Console.Write("\n\nEnter empNo : ");
            //int empNo = Convert.ToInt32(Console.ReadLine());
            //FindEmp(empArray, empNo);


            Console.Write("\n\nHighest Sal Employee : ");
            HighSalEmp(empArray);

            //for (int i = 0; i < empArray.Length; i++)
            //{
            //    empArray[i].Display();
            //}

            Console.ReadLine();
        }

        public static void FindEmp(Employee[] empArr, int empNo)
        {
            for (int i = 0; i < empArr.Length; i++)
            {
                if ((empArr[i].EmpNo) == empNo)
                {
                    Console.WriteLine("Hightest Basic ");
                    empArr[i].Display();
                }

            }
        }


        public static void HighSalEmp(Employee[] empArr)
        {
            decimal highest = 0;
            int empNo = 1;
            highest = empArr[0].Basic;
            for (int i = 1; i < empArr.Length; i++)
            {
                if(empArr[i].Basic > highest)
                {
                    empNo = empArr[i].EmpNo;
                    highest = empArr[i].Basic;
                }
                else
                {

                }

            }
            //Console.WriteLine(empNo+"  "+highest);
            FindEmp(empArr, empNo);
        }
       
    }

    public class Employee
    {
        private int empNo;
        private string empName;
        private decimal basic;
        private short deptNo;
        private static int empCount = 0;

        public Employee()
        {
            this.empNo = ++empCount;
        }

        public Employee(string name = "Noname", decimal basic=1000, short deptno = 10)
        {
            Basic = basic;
            DeptNo = deptno;
            EmpName = name;
            this.empNo = ++empCount;
        }

        public int EmpNo
        {
            get { return empNo; }
        }

        public string EmpName
        {
            set { empName = value; }
            get { return empName; }
        }

        public decimal Basic
        {
            set { basic = value; }
            get { return basic; }
        }

        public short DeptNo
        {
            set { deptNo = value; }
            get { return deptNo; }
        }

        public void Display()
        {
            Console.WriteLine(
            "\nEmployee :\n"
            + "\nempNo : " + EmpNo
            + "\nempName : " + EmpName
            + "\ndept no : " + DeptNo
            + "\nbasic : " + Basic);
        }

    }
}
