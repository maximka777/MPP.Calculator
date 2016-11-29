﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICalculator")]
public interface ICalculator
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
    double Add(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
    System.Threading.Tasks.Task<double> AddAsync(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Substract", ReplyAction="http://tempuri.org/ICalculator/SubstractResponse")]
    double Substract(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Substract", ReplyAction="http://tempuri.org/ICalculator/SubstractResponse")]
    System.Threading.Tasks.Task<double> SubstractAsync(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
    double Multiply(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
    System.Threading.Tasks.Task<double> MultiplyAsync(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Divide", ReplyAction="http://tempuri.org/ICalculator/DivideResponse")]
    double Divide(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Divide", ReplyAction="http://tempuri.org/ICalculator/DivideResponse")]
    System.Threading.Tasks.Task<double> DivideAsync(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Sqrt", ReplyAction="http://tempuri.org/ICalculator/SqrtResponse")]
    double Sqrt(double a);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Sqrt", ReplyAction="http://tempuri.org/ICalculator/SqrtResponse")]
    System.Threading.Tasks.Task<double> SqrtAsync(double a);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalculatorChannel : ICalculator, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalculatorWCFClient : System.ServiceModel.ClientBase<ICalculator>, ICalculator
{
    
    public CalculatorWCFClient()
    {
    }
    
    public CalculatorWCFClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalculatorWCFClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double Add(double a, double b)
    {
        return base.Channel.Add(a, b);
    }
    
    public System.Threading.Tasks.Task<double> AddAsync(double a, double b)
    {
        return base.Channel.AddAsync(a, b);
    }
    
    public double Substract(double a, double b)
    {
        return base.Channel.Substract(a, b);
    }
    
    public System.Threading.Tasks.Task<double> SubstractAsync(double a, double b)
    {
        return base.Channel.SubstractAsync(a, b);
    }
    
    public double Multiply(double a, double b)
    {
        return base.Channel.Multiply(a, b);
    }
    
    public System.Threading.Tasks.Task<double> MultiplyAsync(double a, double b)
    {
        return base.Channel.MultiplyAsync(a, b);
    }
    
    public double Divide(double a, double b)
    {
        return base.Channel.Divide(a, b);
    }
    
    public System.Threading.Tasks.Task<double> DivideAsync(double a, double b)
    {
        return base.Channel.DivideAsync(a, b);
    }
    
    public double Sqrt(double a)
    {
        return base.Channel.Sqrt(a);
    }
    
    public System.Threading.Tasks.Task<double> SqrtAsync(double a)
    {
        return base.Channel.SqrtAsync(a);
    }
}