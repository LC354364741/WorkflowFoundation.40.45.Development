﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVM.Packpub.Northwind.Application.CustomerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/MVVM.Packpub.Northwind.Service")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVVM.Packpub.Northwind.Application.CustomerService.Order[] OrdersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegionField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactName {
            get {
                return this.ContactNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNameField, value) != true)) {
                    this.ContactNameField = value;
                    this.RaisePropertyChanged("ContactName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerIDField, value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MVVM.Packpub.Northwind.Application.CustomerService.Order[] Orders {
            get {
                return this.OrdersField;
            }
            set {
                if ((object.ReferenceEquals(this.OrdersField, value) != true)) {
                    this.OrdersField = value;
                    this.RaisePropertyChanged("Orders");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalCode {
            get {
                return this.PostalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostalCodeField, value) != true)) {
                    this.PostalCodeField = value;
                    this.RaisePropertyChanged("PostalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Region {
            get {
                return this.RegionField;
            }
            set {
                if ((object.ReferenceEquals(this.RegionField, value) != true)) {
                    this.RegionField = value;
                    this.RaisePropertyChanged("Region");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/MVVM.Packpub.Northwind.Service")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> FreightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> OrderDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVVM.Packpub.Northwind.Application.CustomerService.OrderDetails[] OrderDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ShippedDateField;
        
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
        public System.Nullable<decimal> Freight {
            get {
                return this.FreightField;
            }
            set {
                if ((this.FreightField.Equals(value) != true)) {
                    this.FreightField = value;
                    this.RaisePropertyChanged("Freight");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> OrderDate {
            get {
                return this.OrderDateField;
            }
            set {
                if ((this.OrderDateField.Equals(value) != true)) {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MVVM.Packpub.Northwind.Application.CustomerService.OrderDetails[] OrderDetails {
            get {
                return this.OrderDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderDetailsField, value) != true)) {
                    this.OrderDetailsField = value;
                    this.RaisePropertyChanged("OrderDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderID {
            get {
                return this.OrderIDField;
            }
            set {
                if ((this.OrderIDField.Equals(value) != true)) {
                    this.OrderIDField = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ShippedDate {
            get {
                return this.ShippedDateField;
            }
            set {
                if ((this.ShippedDateField.Equals(value) != true)) {
                    this.ShippedDateField = value;
                    this.RaisePropertyChanged("ShippedDate");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderDetails", Namespace="http://schemas.datacontract.org/2004/07/MVVM.Packpub.Northwind.Service")]
    [System.SerializableAttribute()]
    public partial class OrderDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVVM.Packpub.Northwind.Application.CustomerService.Product ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal UnitPriceField;
        
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
        public MVVM.Packpub.Northwind.Application.CustomerService.Product Product {
            get {
                return this.ProductField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductField, value) != true)) {
                    this.ProductField = value;
                    this.RaisePropertyChanged("Product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/MVVM.Packpub.Northwind.Service")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
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
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerService.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomers", ReplyAction="http://tempuri.org/ICustomerService/GetCustomersResponse")]
        MVVM.Packpub.Northwind.Application.CustomerService.Customer[] GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomers", ReplyAction="http://tempuri.org/ICustomerService/GetCustomersResponse")]
        System.Threading.Tasks.Task<MVVM.Packpub.Northwind.Application.CustomerService.Customer[]> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomer", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerResponse")]
        MVVM.Packpub.Northwind.Application.CustomerService.Customer GetCustomer(string customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomer", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerResponse")]
        System.Threading.Tasks.Task<MVVM.Packpub.Northwind.Application.CustomerService.Customer> GetCustomerAsync(string customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/Update", ReplyAction="http://tempuri.org/ICustomerService/UpdateResponse")]
        void Update(MVVM.Packpub.Northwind.Application.CustomerService.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/Update", ReplyAction="http://tempuri.org/ICustomerService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(MVVM.Packpub.Northwind.Application.CustomerService.Customer customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : MVVM.Packpub.Northwind.Application.CustomerService.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<MVVM.Packpub.Northwind.Application.CustomerService.ICustomerService>, MVVM.Packpub.Northwind.Application.CustomerService.ICustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MVVM.Packpub.Northwind.Application.CustomerService.Customer[] GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<MVVM.Packpub.Northwind.Application.CustomerService.Customer[]> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public MVVM.Packpub.Northwind.Application.CustomerService.Customer GetCustomer(string customerID) {
            return base.Channel.GetCustomer(customerID);
        }
        
        public System.Threading.Tasks.Task<MVVM.Packpub.Northwind.Application.CustomerService.Customer> GetCustomerAsync(string customerID) {
            return base.Channel.GetCustomerAsync(customerID);
        }
        
        public void Update(MVVM.Packpub.Northwind.Application.CustomerService.Customer customer) {
            base.Channel.Update(customer);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(MVVM.Packpub.Northwind.Application.CustomerService.Customer customer) {
            return base.Channel.UpdateAsync(customer);
        }
    }
}
