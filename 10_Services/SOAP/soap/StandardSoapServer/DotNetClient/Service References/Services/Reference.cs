﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetClient.Services {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://db.com/", ConfigurationName="Services.CalculatorServiceSoap")]
    public interface CalculatorServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://db.com/Add", ReplyAction="*")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://db.com/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://db.com/Subtract", ReplyAction="*")]
        int Subtract(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://db.com/Subtract", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubtractAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorServiceSoapChannel : DotNetClient.Services.CalculatorServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceSoapClient : System.ServiceModel.ClientBase<DotNetClient.Services.CalculatorServiceSoap>, DotNetClient.Services.CalculatorServiceSoap {
        
        public CalculatorServiceSoapClient() {
        }
        
        public CalculatorServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int x, int y) {
            return base.Channel.AddAsync(x, y);
        }
        
        public int Subtract(int x, int y) {
            return base.Channel.Subtract(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(int x, int y) {
            return base.Channel.SubtractAsync(x, y);
        }
    }
}
