using System;

namespace challange
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new int[] { 10 , 11 , 12 , 13 , 14 , 15};
            Console.WriteLine(student[3]);



            var studentGradus = new int[10];
            studentGradus[0] = 80;
            studentGradus[1] = 90;
            studentGradus[2] = 100;
            studentGradus[9] = 900;

            foreach (var studentGrad in studentGradus)
            {
            Console.WriteLine(studentGrad);
            }
        }
        }
        }
