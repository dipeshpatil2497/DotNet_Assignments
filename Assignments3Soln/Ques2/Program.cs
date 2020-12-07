using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQues2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the no. of branches :");
            int b = Convert.ToInt32(Console.ReadLine()); 
            int[] branchArray = new int[b];

            for (int i = 0; i < branchArray.Length; i++)
            {
                Console.WriteLine("Enter the no. of Stud for {0} batch :",i);
                int noOfStud = Convert.ToInt32(Console.ReadLine());
                int[] studArray = new int[noOfStud];

                for (int j = 0; j < studArray.Length ; j++)
                {
                    int[] subArray = new int[3];
                    for (int k = 0; k < subArray.Length; k++)
                    {
                        Console.WriteLine("Enter the mark of {0} Sub for {1} " +
                            "Stud of {2} batch :", k, j, i);
                        int mark = Convert.ToInt32(Console.ReadLine());
                        subArray[k] = mark;
                    }

                    for (int l = 0; l < subArray.Length; l++)
                    {
                        Console.WriteLine("branch {0} "+
                            "Student {1} "+
                            "Subject {2} ",i,j,subArray[l]);
                    }

                }
            }


        }
    }
}
