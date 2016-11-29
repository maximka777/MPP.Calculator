using CalculatorWCFService.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        [FaultContract(typeof(ArithmeticFault))]
        double Add(double a, double b);

        [OperationContract]
        [FaultContract(typeof(ArithmeticFault))]
        double Substract(double a, double b);

        [OperationContract]
        [FaultContract(typeof(ArithmeticFault))]
        double Multiply(double a, double b);

        [OperationContract]
        [FaultContract(typeof(ArithmeticFault))]
        double Divide(double a, double b);

        [OperationContract]
        [FaultContract(typeof(ArithmeticFault))]
        double Sqrt(double a);
    }
}
