using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labb1_whitebox;

namespace Labb1_whiteboxTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] input = new double[3];

            //Skickar 3 värden av typen double till konstruktorn, får då objektet för att testa med.
            Triangle testObj = new Triangle(input[0], input[1], input[2]);
        }
    }
}
