﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login_Nhom20.SV_Login {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KiemTra", Namespace="http://schemas.datacontract.org/2004/07/FaultContract")]
    [System.SerializableAttribute()]
    public partial class KiemTra : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SV_Login.ILoginService")]
    public interface ILoginService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/KiemTraTaiKhoan", ReplyAction="http://tempuri.org/ILoginService/KiemTraTaiKhoanResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Login_Nhom20.SV_Login.KiemTra), Action="http://tempuri.org/ILoginService/KiemTraTaiKhoanKiemTraFault", Name="KiemTra", Namespace="http://schemas.datacontract.org/2004/07/FaultContract")]
        bool KiemTraTaiKhoan(string tk, string mk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/DangKy", ReplyAction="http://tempuri.org/ILoginService/DangKyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Login_Nhom20.SV_Login.KiemTra), Action="http://tempuri.org/ILoginService/DangKyKiemTraFault", Name="KiemTra", Namespace="http://schemas.datacontract.org/2004/07/FaultContract")]
        void DangKy(string tk, string mk1, string mk2, string ht, string em, string pn);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginServiceChannel : Login_Nhom20.SV_Login.ILoginService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginServiceClient : System.ServiceModel.ClientBase<Login_Nhom20.SV_Login.ILoginService>, Login_Nhom20.SV_Login.ILoginService {
        
        public LoginServiceClient() {
        }
        
        public LoginServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool KiemTraTaiKhoan(string tk, string mk) {
            return base.Channel.KiemTraTaiKhoan(tk, mk);
        }
        
        public void DangKy(string tk, string mk1, string mk2, string ht, string em, string pn) {
            base.Channel.DangKy(tk, mk1, mk2, ht, em, pn);
        }
    }
}
