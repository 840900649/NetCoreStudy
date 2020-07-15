using MLTest.BinaryClassification;
using System;
using System.IO;

namespace MLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest test = new Test.BinaryClassificationTest();


            test.Test(); 
            Console.ReadLine();
        }

       
        
    }
}
