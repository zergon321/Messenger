﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessengerClient.MessengerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EnterData", Namespace="http://schemas.datacontract.org/2004/07/MessengerService.Contracts.DataContracts")]
    [System.SerializableAttribute()]
    public partial class EnterData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageToService", Namespace="http://schemas.datacontract.org/2004/07/MessengerService.Contracts.DataContracts")]
    [System.SerializableAttribute()]
    public partial class MessageToService : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SoundToService", Namespace="http://schemas.datacontract.org/2004/07/MessengerService.Contracts.DataContracts")]
    [System.SerializableAttribute()]
    public partial class SoundToService : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] SoundBytesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] SoundBytes {
            get {
                return this.SoundBytesField;
            }
            set {
                if ((object.ReferenceEquals(this.SoundBytesField, value) != true)) {
                    this.SoundBytesField = value;
                    this.RaisePropertyChanged("SoundBytes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageToUser", Namespace="http://schemas.datacontract.org/2004/07/MessengerService.Contracts.DataContracts")]
    [System.SerializableAttribute()]
    public partial class MessageToUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SoundToUser", Namespace="http://schemas.datacontract.org/2004/07/MessengerService.Contracts.DataContracts")]
    [System.SerializableAttribute()]
    public partial class SoundToUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] SoundBytesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] SoundBytes {
            get {
                return this.SoundBytesField;
            }
            set {
                if ((object.ReferenceEquals(this.SoundBytesField, value) != true)) {
                    this.SoundBytesField = value;
                    this.RaisePropertyChanged("SoundBytes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MessengerService.IMessengerService", CallbackContract=typeof(MessengerClient.MessengerService.IMessengerServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IMessengerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessengerService/EnterService", ReplyAction="http://tempuri.org/IMessengerService/EnterServiceResponse")]
        MessengerClient.MessengerService.EnterData EnterService(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessengerService/EnterService", ReplyAction="http://tempuri.org/IMessengerService/EnterServiceResponse")]
        System.Threading.Tasks.Task<MessengerClient.MessengerService.EnterData> EnterServiceAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IMessengerService/LeaveService")]
        void LeaveService(uint id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IMessengerService/LeaveService")]
        System.Threading.Tasks.Task LeaveServiceAsync(uint id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IMessengerService/SendTextMessage")]
        void SendTextMessage(MessengerClient.MessengerService.MessageToService message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IMessengerService/SendTextMessage")]
        System.Threading.Tasks.Task SendTextMessageAsync(MessengerClient.MessengerService.MessageToService message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IMessengerService/SendAudioMessage")]
        void SendAudioMessage(MessengerClient.MessengerService.SoundToService sound);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IMessengerService/SendAudioMessage")]
        System.Threading.Tasks.Task SendAudioMessageAsync(MessengerClient.MessengerService.SoundToService sound);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/IMessengerService/GetUserList", ReplyAction="http://tempuri.org/IMessengerService/GetUserListResponse")]
        string[] GetUserList();
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/IMessengerService/GetUserList", ReplyAction="http://tempuri.org/IMessengerService/GetUserListResponse")]
        System.Threading.Tasks.Task<string[]> GetUserListAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IMessengerService/NotifyClientIsReady")]
        void NotifyClientIsReady(uint id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IMessengerService/NotifyClientIsReady")]
        System.Threading.Tasks.Task NotifyClientIsReadyAsync(uint id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IMessengerService/Pulse")]
        void Pulse(uint id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IMessengerService/Pulse")]
        System.Threading.Tasks.Task PulseAsync(uint id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessengerServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessengerService/ReceiveTextMessage")]
        void ReceiveTextMessage(MessengerClient.MessengerService.MessageToUser message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessengerService/ReceiveAudioMessage")]
        void ReceiveAudioMessage(MessengerClient.MessengerService.SoundToUser soundMessage);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessengerService/NotifyUserConnected")]
        void NotifyUserConnected(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessengerService/NotifyUserDisconnected")]
        void NotifyUserDisconnected(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessengerService/MakePulse")]
        void MakePulse();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessengerServiceChannel : MessengerClient.MessengerService.IMessengerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MessengerServiceClient : System.ServiceModel.DuplexClientBase<MessengerClient.MessengerService.IMessengerService>, MessengerClient.MessengerService.IMessengerService {
        
        public MessengerServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MessengerServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MessengerServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MessengerServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MessengerServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public MessengerClient.MessengerService.EnterData EnterService(string username) {
            return base.Channel.EnterService(username);
        }
        
        public System.Threading.Tasks.Task<MessengerClient.MessengerService.EnterData> EnterServiceAsync(string username) {
            return base.Channel.EnterServiceAsync(username);
        }
        
        public void LeaveService(uint id) {
            base.Channel.LeaveService(id);
        }
        
        public System.Threading.Tasks.Task LeaveServiceAsync(uint id) {
            return base.Channel.LeaveServiceAsync(id);
        }
        
        public void SendTextMessage(MessengerClient.MessengerService.MessageToService message) {
            base.Channel.SendTextMessage(message);
        }
        
        public System.Threading.Tasks.Task SendTextMessageAsync(MessengerClient.MessengerService.MessageToService message) {
            return base.Channel.SendTextMessageAsync(message);
        }
        
        public void SendAudioMessage(MessengerClient.MessengerService.SoundToService sound) {
            base.Channel.SendAudioMessage(sound);
        }
        
        public System.Threading.Tasks.Task SendAudioMessageAsync(MessengerClient.MessengerService.SoundToService sound) {
            return base.Channel.SendAudioMessageAsync(sound);
        }
        
        public string[] GetUserList() {
            return base.Channel.GetUserList();
        }
        
        public System.Threading.Tasks.Task<string[]> GetUserListAsync() {
            return base.Channel.GetUserListAsync();
        }
        
        public void NotifyClientIsReady(uint id) {
            base.Channel.NotifyClientIsReady(id);
        }
        
        public System.Threading.Tasks.Task NotifyClientIsReadyAsync(uint id) {
            return base.Channel.NotifyClientIsReadyAsync(id);
        }
        
        public void Pulse(uint id) {
            base.Channel.Pulse(id);
        }
        
        public System.Threading.Tasks.Task PulseAsync(uint id) {
            return base.Channel.PulseAsync(id);
        }
    }
}
