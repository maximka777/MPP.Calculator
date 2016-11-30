using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CalculatorWCFService.CustomExceptions
{
    [DataContract]
    public class ArithmeticFault
    {
        [DataMember]
        public string Message;

        public ArithmeticFault()
        {
        }

        public ArithmeticFault(string error)
        {
            Message = error;
        }
    }
}