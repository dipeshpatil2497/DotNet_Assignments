using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig1Soln
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee o1 = new Employee("Dipesh", 72345, 10);
            //o1.Display();
            //Console.WriteLine("NetSal : " + o1.GetNetSalary() + "\n");
            

            //Employee o2 = new Employee("Vipul", 63465);
            //o2.Display();
            //Console.WriteLine("NetSal : "+o2.GetNetSalary()+"\n");

            //Employee o3 = new Employee("Shantanu");
            //o3.Display();
            //Console.WriteLine("\n");


            //Employee o4 = new Employee();
            //o4.Display();
            



            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();

            Console.WriteLine("====Forward====");
            Console.WriteLine("EmpNo : " +o1.EmpNo);
            Console.WriteLine("EmpNo : " +o2.EmpNo);
            Console.WriteLine("EmpNo : " +o3.EmpNo+"\n");

            Console.WriteLine("====Reverse====");
            Console.WriteLine("EmpNo : "+o3.EmpNo);
            Console.WriteLine("EmpNo : "+o2.EmpNo);
            Console.WriteLine("EmpNo : "+o1.EmpNo);

            //o1.Name = "";
            //Console.WriteLine("Name : "+o1.Name);


            Console.ReadLine();
        }
    }

    public class Employee
    {
        private string name;
        private int empNo;
        private decimal basicSalary;
        private short deptNo;
        private static int count;

        public Employee()
        {
            count = count+1;
            empNo = count;
        }

        public Employee(string name="Noname" , decimal basicSalary=10000M, short deptNo=10)
        {
            Name = name;
            BasicSalary = basicSalary;
            DeptNo = deptNo;
            count = count + 1;
            empNo = count;
        }

        //Name Property
        public string Name
        {
            set 
            {
                if (value != "")
                    name = value; 
                else
                    Console.WriteLine("Invalid Name Entry...!!");
            }

            get { return name; }
        }

        //EmpNo Property
        public int EmpNo
        {
            get { return empNo; }
        }

        //BasicSalary Property
        public decimal BasicSalary
        {
            set 
            {
                if (10000 < value || value > 100000)
                    basicSalary = value; 
                else
                    Console.WriteLine("Salary must be Between 10000 to 100000");
            }
        }

        //DeptNo Property
        public short DeptNo
        {
            set 
            {
                if (value > 0)
                    deptNo = value; 
                else
                    Console.WriteLine("DeptNo must be > 0");
            }
        }


        //GetNetSalary Method
        public decimal GetNetSalary()
        {
            decimal NetSal = 0.0M;
            NetSal = basicSalary * 10;
            return NetSal;
        }

        public void Display()
        {
            Console.WriteLine("Object "+empNo+"\nName : "+name+"\nEmpNo : "+empNo+
                "\nBasicSal : "+basicSalary+"\nDeptNo : "+deptNo);
        }
    }
}
