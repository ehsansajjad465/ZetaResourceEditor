﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.530
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.530.
// 
#pragma warning disable 1591

namespace ZetaResourceEditor.RuntimeBusinessLogic.UpdateChecker {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="UpdateCheckerServiceSoap", Namespace="http://www.zeta-resource-editor.com/")]
    public partial class UpdateCheckerService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback IsUpdateAvailable2OperationCompleted;
        
        private System.Threading.SendOrPostCallback DownloadUpdate2OperationCompleted;
        
        private System.Threading.SendOrPostCallback IsUpdateAvailableOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public UpdateCheckerService() {
            this.Url = "http://www.zeta-resource-editor.com/backend/UpdateCheckerService.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event IsUpdateAvailable2CompletedEventHandler IsUpdateAvailable2Completed;
        
        /// <remarks/>
        public event DownloadUpdate2CompletedEventHandler DownloadUpdate2Completed;
        
        /// <remarks/>
        public event IsUpdateAvailableCompletedEventHandler IsUpdateAvailableCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.zeta-resource-editor.com/IsUpdateAvailable2", RequestNamespace="http://www.zeta-resource-editor.com/", ResponseNamespace="http://www.zeta-resource-editor.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public UpdatePresentResult2 IsUpdateAvailable2(UpdateCheckInfo2 info) {
            object[] results = this.Invoke("IsUpdateAvailable2", new object[] {
                        info});
            return ((UpdatePresentResult2)(results[0]));
        }
        
        /// <remarks/>
        public void IsUpdateAvailable2Async(UpdateCheckInfo2 info) {
            this.IsUpdateAvailable2Async(info, null);
        }
        
        /// <remarks/>
        public void IsUpdateAvailable2Async(UpdateCheckInfo2 info, object userState) {
            if ((this.IsUpdateAvailable2OperationCompleted == null)) {
                this.IsUpdateAvailable2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsUpdateAvailable2OperationCompleted);
            }
            this.InvokeAsync("IsUpdateAvailable2", new object[] {
                        info}, this.IsUpdateAvailable2OperationCompleted, userState);
        }
        
        private void OnIsUpdateAvailable2OperationCompleted(object arg) {
            if ((this.IsUpdateAvailable2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsUpdateAvailable2Completed(this, new IsUpdateAvailable2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.zeta-resource-editor.com/DownloadUpdate2", RequestNamespace="http://www.zeta-resource-editor.com/", ResponseNamespace="http://www.zeta-resource-editor.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public UpdateInformationResult2 DownloadUpdate2(UpdateCheckInfo2 info) {
            object[] results = this.Invoke("DownloadUpdate2", new object[] {
                        info});
            return ((UpdateInformationResult2)(results[0]));
        }
        
        /// <remarks/>
        public void DownloadUpdate2Async(UpdateCheckInfo2 info) {
            this.DownloadUpdate2Async(info, null);
        }
        
        /// <remarks/>
        public void DownloadUpdate2Async(UpdateCheckInfo2 info, object userState) {
            if ((this.DownloadUpdate2OperationCompleted == null)) {
                this.DownloadUpdate2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnDownloadUpdate2OperationCompleted);
            }
            this.InvokeAsync("DownloadUpdate2", new object[] {
                        info}, this.DownloadUpdate2OperationCompleted, userState);
        }
        
        private void OnDownloadUpdate2OperationCompleted(object arg) {
            if ((this.DownloadUpdate2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DownloadUpdate2Completed(this, new DownloadUpdate2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.zeta-resource-editor.com/IsUpdateAvailable", RequestNamespace="http://www.zeta-resource-editor.com/", ResponseNamespace="http://www.zeta-resource-editor.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string IsUpdateAvailable(string assemblyVersion) {
            object[] results = this.Invoke("IsUpdateAvailable", new object[] {
                        assemblyVersion});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void IsUpdateAvailableAsync(string assemblyVersion) {
            this.IsUpdateAvailableAsync(assemblyVersion, null);
        }
        
        /// <remarks/>
        public void IsUpdateAvailableAsync(string assemblyVersion, object userState) {
            if ((this.IsUpdateAvailableOperationCompleted == null)) {
                this.IsUpdateAvailableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsUpdateAvailableOperationCompleted);
            }
            this.InvokeAsync("IsUpdateAvailable", new object[] {
                        assemblyVersion}, this.IsUpdateAvailableOperationCompleted, userState);
        }
        
        private void OnIsUpdateAvailableOperationCompleted(object arg) {
            if ((this.IsUpdateAvailableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsUpdateAvailableCompleted(this, new IsUpdateAvailableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.zeta-resource-editor.com/")]
    public partial class UpdateCheckInfo2 {
        
        private string apiKeyField;
        
        private System.DateTime versionDateField;
        
        private string versionNumberField;
        
        private int cultureField;
        
        /// <remarks/>
        public string ApiKey {
            get {
                return this.apiKeyField;
            }
            set {
                this.apiKeyField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime VersionDate {
            get {
                return this.versionDateField;
            }
            set {
                this.versionDateField = value;
            }
        }
        
        /// <remarks/>
        public string VersionNumber {
            get {
                return this.versionNumberField;
            }
            set {
                this.versionNumberField = value;
            }
        }
        
        /// <remarks/>
        public int Culture {
            get {
                return this.cultureField;
            }
            set {
                this.cultureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.zeta-resource-editor.com/")]
    public partial class UpdateInformationResult2 {
        
        private string apiKeyField;
        
        private bool isPresentField;
        
        private string fileNameField;
        
        private byte[] fileContentField;
        
        private string alternativeFallbackDownloadUrlField;
        
        /// <remarks/>
        public string ApiKey {
            get {
                return this.apiKeyField;
            }
            set {
                this.apiKeyField = value;
            }
        }
        
        /// <remarks/>
        public bool IsPresent {
            get {
                return this.isPresentField;
            }
            set {
                this.isPresentField = value;
            }
        }
        
        /// <remarks/>
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] FileContent {
            get {
                return this.fileContentField;
            }
            set {
                this.fileContentField = value;
            }
        }
        
        /// <remarks/>
        public string AlternativeFallbackDownloadUrl {
            get {
                return this.alternativeFallbackDownloadUrlField;
            }
            set {
                this.alternativeFallbackDownloadUrlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.zeta-resource-editor.com/")]
    public partial class UpdatePresentResult2 {
        
        private bool isPresentField;
        
        private string downloadWebsiteUrlField;
        
        /// <remarks/>
        public bool IsPresent {
            get {
                return this.isPresentField;
            }
            set {
                this.isPresentField = value;
            }
        }
        
        /// <remarks/>
        public string DownloadWebsiteUrl {
            get {
                return this.downloadWebsiteUrlField;
            }
            set {
                this.downloadWebsiteUrlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void IsUpdateAvailable2CompletedEventHandler(object sender, IsUpdateAvailable2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsUpdateAvailable2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsUpdateAvailable2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UpdatePresentResult2 Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UpdatePresentResult2)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void DownloadUpdate2CompletedEventHandler(object sender, DownloadUpdate2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DownloadUpdate2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DownloadUpdate2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UpdateInformationResult2 Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UpdateInformationResult2)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void IsUpdateAvailableCompletedEventHandler(object sender, IsUpdateAvailableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsUpdateAvailableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsUpdateAvailableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591