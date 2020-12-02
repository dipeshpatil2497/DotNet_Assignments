using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Soln
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ep = new Manager();
            ep.Display();

            Manager ep1 = new Manager("Dipesh", 10, 50000, "Kharghar");
            ep1.Display();

            GeneralManager ep2 = new GeneralManager("Vipul", 12, 45000, "Chinchwad");
            ep2.Display();

            CEO ep3 = new CEO("DipeshP", 15, 100000);
            ep3.Display();
            Console.WriteLine("CEO NetSal : "+ep3.CalNetSal()); 

            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        private string name;
        private int empNo;
        private short deptNo;
        private static int empCount = 0;
        public decimal basic;

        public Employee()
        {
            this.empNo = ++empCount;
            Console.WriteLine("Employee paramless constr");
        }

        public Employee(string name="Noname" ,short deptno=10 )
        {
            DeptNo = deptno;
            Name = name;
            this.empNo = ++empCount; 
        }

        public string Name
        {
            set 
            {
                if (value != "")
                    name = value;
                else
                    Console.WriteLine("Name Can't be Blank...!!");
                            
            }
            get { return name; }
        } 

        public int EmpNo
        {
            get { return empNo; }
        }

        public short DeptNo
        {
            set 
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Deptno should be > 0");
            }
            get
            {
                return deptNo;
            }
        }

        public abstract decimal Basic { set; get; }
        public abstract decimal CalNetSal();

        public void Display()
        {
            Console.WriteLine(
            "\nEmployee :\n"
            +"\nempNo : " + EmpNo
            +"\nempName : " + Name
            +"\ndept no : " + DeptNo
            +"\nbasic : " + Basic);
        }
    }

    public class Manager : Employee
    {
        private string destination;

        public Manager()
        {
            Console.WriteLine("no para Manager construct......");
        }
        public Manager(string name, short deptno,decimal basic=15000, string destination="none") : base(name,deptno)
        {
            Basic = basic;
            Destination = destination ;
        }
        public string Destination
        {
            set 
            {
                if (value != "")
                    destination = value;
                else
                    Console.WriteLine("Destination can't be blank");
            }
            get { return destination; }
        }

        public override decimal Basic
        {
            set 
            {
                if (value > 10000 || value < 100000)
                    basic = value;
                else
                    Console.WriteLine("Basic of manager should between 10000 to 100000");

            }
            get { return basic; }
        }

        public override decimal CalNetSal()
        {
            decimal salary = 0;
            salary = basic * 10;
            return salary;
        }

        public new void Display()
        {
            Console.WriteLine(
            "\nManager :\n"
            + "\nempNo : " + EmpNo
            + "\nempName : " + Name
            + "\ndept no : " + DeptNo
            + "\nbasic : " + Basic
            +"\nDestination : "+ Destination);
        }
    }

    public class GeneralManager : Manager
    {
        private string perks;
        public GeneralManager(string name, short deptno,decimal basic, string destination,string perks="none"):base(name,deptno,basic,destination)
        {
            Perks = perks;
        }
         
        public string Perks { set; get; }

        public new void Display()
        {
            Console.WriteLine(
            "\nGeneral Manager :\n"
            + "\nempNo : " + EmpNo
            + "\nempName : " + Name
            + "\ndept no : " + DeptNo
            + "\nbasic : " + Basic
            + "\nDestination : " + Destination
            + "\nPerks : "+ Perks);
        }


    }

    public class CEO : Employee
    {
        public CEO(string name, short deptno,decimal basic=60000):base(name,deptno)
        {
            Basic = basic;
            Console.WriteLine("CEO param constr");
        }

        public override decimal Basic
        {
            set
            {
                if (value > 50000 || value < 200000)
                    basic = value;
                else
                    Console.WriteLine("Basic of manager should between 50000 to 200000");

            }
            get { return basic; }
        }

        public sealed override decimal CalNetSal()
        {
            decimal sal=0;
            sal = basic * 10;
            return sal;
        }

        public new void Display()
        {
            Console.WriteLine(
            "\nCEO :\n"
            + "\nempNo : " + EmpNo
            + "\nempName : " + Name
            + "\ndept no : " + DeptNo
            + "\nbasic : " + Basic);
        }

    }
}
