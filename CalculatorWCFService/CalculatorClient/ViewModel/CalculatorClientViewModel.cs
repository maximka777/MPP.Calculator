using CalculatorWCFService.CustomExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClient.ViewModel
{
    class CalculatorClientViewModel : INotifyPropertyChanged
    {
        private readonly CalculatorWCFClient calculator = new CalculatorWCFClient();

        public event PropertyChangedEventHandler PropertyChanged;

        private double a;
        private double b;
        private double result;
        private string errorText;

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
                RaisePropertyChangedEvent(nameof(A));
            }

        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
                RaisePropertyChangedEvent(nameof(B));
            }

        }

        public double Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                RaisePropertyChangedEvent(nameof(Result));
            }
        }

        public string ErrorText
        {
            get
            {
                return errorText;
            }
            set
            {
                if(errorText == null)
                {
                    errorText = string.Empty;
                }
                errorText += value + "\n";
                RaisePropertyChangedEvent(nameof(ErrorText));
            }
        }

        public Command AddCommand
        {
            get
            {
                return new Command(Add);
            }
        }

        public Command SubtractCommand
        {
            get
            {
                return new Command(Subtract);
            }
        }

        public Command MultiplyCommand
        {
            get
            {
                return new Command(Multiply);
            }
        }

        public Command DivideCommand
        {
            get
            {
                return new Command(Divide);
            }
        }

        public Command SqrtCommand
        {
            get
            {
                return new Command(Sqrt);
            }
        }

        private void Add()
        {
            try
            {
                Result = calculator.Add(a, b);
            }
            catch(OverflowException exc)
            {
                ErrorText = exc.Message;
            }
        }

        private void Subtract()
        {
            try
            {
                Result = calculator.Substract(a, b);
            }
            catch (OverflowException exc)
            {
                ErrorText = exc.Message;
            }
}

        private void Multiply()
        {
            try
            {
                Result = calculator.Multiply(a, b);
            }
            catch (OverflowException exc)
            {
                ErrorText = exc.Message;
            }
        }

        private void Divide()
        {
            try
            {
                Result = calculator.Divide(a, b);
            }
            catch (FaultException<ArithmeticFault> exc)
            {
                ErrorText = exc.Message;
            }
        }

        private void Sqrt()
        {
            try
            {
                Result = calculator.Sqrt(a);
            }
            catch (ArithmeticException exc)
            {
                ErrorText = exc.Message;
            }
        }

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
