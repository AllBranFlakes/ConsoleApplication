using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] studentRec = new string[5, 2] { { "adam", "111" }, { "beatrice", "222" }, { "campbell", "333" }, { "delila", "444" }, { "eric", "555" } };
            int x = studentRec.GetLength(0);

            Console.WriteLine("Student Matriculation System: \r\n");
            Console.WriteLine("\r\n");
            Console.WriteLine("Enter Student Name");
            string tmpName = Console.ReadLine();
            Console.WriteLine("Enter Matriculation Number:");
            string tmpNum = Console.ReadLine();

            string[,] newArray = new string[(x+1), 2];
            Array.Copy(studentRec, newArray, studentRec.Length);
            studentRec = newArray;
            studentRec[x, 0] = tmpName;
            studentRec[x, 1] = tmpNum;

            for (int p = 0; p < studentRec.GetLength(0); p += 1)
            {
                for (int y = 0; y < studentRec.GetLength(1); y += 1)
                {
                    Console.Write(studentRec[p, y]);
                }
                Console.Write("\n");
            }
            Console.Read();
        }

        
    }
}
