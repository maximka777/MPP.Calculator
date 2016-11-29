using CalculatorWCFService.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculator.svc or Calculator.svc.cs at the Solution Explorer and start debugging.
    public class Calculator : ICalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            if(b == 0)
            {
                throw new FaultException<ArithmeticFault>(new ArithmeticFault("Dividing by zero."));
            }
            return a / b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }
    }
}
