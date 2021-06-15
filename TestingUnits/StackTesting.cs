using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections;
using interviewTest;

namespace TestingUnits
{
    [TestClass]
    public class StackTesting
    {
        [TestMethod]
        public void Testing_InputArraySize()
        {           
            TestingStack p = new TestingStack();

            //Given
            StringReader input = new StringReader("3");
            Console.SetIn(input);

            //When
            int size = p.InputArraySize();

            //Then
            Assert.AreEqual(3, size, "Size should be 3"); 
        }


        [TestMethod]
        public void Testing_PopulateStackValues()
        {
            TestingStack p = new TestingStack();            

            //Given
            StringReader input = new StringReader("95\n6\n7");
            Console.SetIn(input);

            //When 
            Stack st = new Stack();
            p.PopulateStackValues(3, st);

            //Then
            Assert.AreEqual(3, st.Count);  // .AreEqual(3, size, "Size should be 3");
        }

        [TestMethod]
        public void Testing_Result()
        {
           /* TestingStack p = new TestingStack();

            //Given
            StringWriter output = new StringWriter();
            Console.SetOut(output);

            Stack input = new Stack();
            input.Push(6);
            input.Push(7);
            input.Push(8);

            //When            
            p.Result(input);

            //Then
            Assert.AreEqual("6\n7\n8", output.ToString());  */
        }
    }
}
