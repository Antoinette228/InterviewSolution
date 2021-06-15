using System;
using System.Collections;

namespace interviewTest
{
    public class TestingStack
    {
        static void Main(string[] args)
        {
           
            Stack arr = new Stack();
            TestingStack p = new TestingStack();

            p.Result(arr);

            (new TestingStack()).InputArraySize();
            
        }
        public int  InputArraySize()
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.In.ReadLine());
            return (size);          
        }
        public string PopulateStackValues(int ArraySize, Stack st)
        {
            for (int j = 1; j <= ArraySize; j++)
            {
                Console.Write("Enter values for the array:");
                int val = Convert.ToInt32(Console.In.ReadLine());
                st.Push(val);
            }
            return st.ToString();
        }
        public string Result(Stack st)
        {
            int size = InputArraySize();         

            PopulateStackValues(size, st);  

            while (st.Count > 0)
                Console.WriteLine(st.Pop() + ",");

            Console.WriteLine("Number of elements in stack: {0}", st.Count);
            Console.ReadKey();

            return st.ToString();
        }
    }
}
