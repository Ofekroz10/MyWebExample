using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Test
    {
        static void Main(string[] args)
        {
            int grade = 0;

            for(int i=0; i<10;i++)
            {
                int temp = i + i;
                if (temp == Program.Add(i, i))
                    grade += 10;
            }

            Console.WriteLine("Your grade is: "+grade);
        }
    }
}
