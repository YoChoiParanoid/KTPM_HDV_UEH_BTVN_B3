﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FahrenheitAndCelsiusClient.FAndCServ {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FAndCServ.FahrenheitAndCelsiusSoap")]
    public interface FahrenheitAndCelsiusSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FahrenheitToCelsius", ReplyAction="*")]
        double FahrenheitToCelsius(double fahrenheit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FahrenheitToCelsius", ReplyAction="*")]
        System.Threading.Tasks.Task<double> FahrenheitToCelsiusAsync(double fahrenheit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CelsiusToFahrenheit", ReplyAction="*")]
        double CelsiusToFahrenheit(double celsius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CelsiusToFahrenheit", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CelsiusToFahrenheitAsync(double celsius);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FahrenheitAndCelsiusSoapChannel : FahrenheitAndCelsiusClient.FAndCServ.FahrenheitAndCelsiusSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FahrenheitAndCelsiusSoapClient : System.ServiceModel.ClientBase<FahrenheitAndCelsiusClient.FAndCServ.FahrenheitAndCelsiusSoap>, FahrenheitAndCelsiusClient.FAndCServ.FahrenheitAndCelsiusSoap {
        
        public FahrenheitAndCelsiusSoapClient() {
        }
        
        public FahrenheitAndCelsiusSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FahrenheitAndCelsiusSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FahrenheitAndCelsiusSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FahrenheitAndCelsiusSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double FahrenheitToCelsius(double fahrenheit) {
            return base.Channel.FahrenheitToCelsius(fahrenheit);
        }
        
        public System.Threading.Tasks.Task<double> FahrenheitToCelsiusAsync(double fahrenheit) {
            return base.Channel.FahrenheitToCelsiusAsync(fahrenheit);
        }
        
        public double CelsiusToFahrenheit(double celsius) {
            return base.Channel.CelsiusToFahrenheit(celsius);
        }
        
        public System.Threading.Tasks.Task<double> CelsiusToFahrenheitAsync(double celsius) {
            return base.Channel.CelsiusToFahrenheitAsync(celsius);
        }
    }
}
