using System;
using System.IO;

namespace BestPractices
{
    class Program
    {

        public const int ConstantNumber = 100;
        public static readonly int ReadOnlyNumber = 0;

        static Program()
        {
            ReadOnlyNumber = 5;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConstantNumber);
            Console.WriteLine(ReadOnlyNumber);

            ///This will cause an excpetion
            //Agency agency = null;
            //Console.WriteLine(agency.Name);

            ///this will cause a validation, to check if agency is null
            //Agency agency = null;
            //Console.WriteLine(agency?.Name);


            //this will cause problem, cause, when the fs2 calls, the fs1 still holds the file
            //FileStream fs1 = new FileStream(@"", FileMode.Open);
            //FileStream fs2 = new FileStream(@"", FileMode.Open);


            //here, we won't have a problem, cause the USING clause create a scope
            //and dispose the resource when it understants that the work is done, inside the scope
            //using (FileStream fs1 = new FileStream(@"", FileMode.Open))
            //{

            //}

            //using (FileStream fs2 = new FileStream(@"", FileMode.Open))
            //{

            //}

        }
    }
}
