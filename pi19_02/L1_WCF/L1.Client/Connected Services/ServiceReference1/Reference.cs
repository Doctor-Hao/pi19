﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EncyclopediaType", Namespace="http://schemas.datacontract.org/2004/07/L1.WcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class EncyclopediaType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FolderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsApp1.ServiceReference1.EncyclopediaPartType[] PartListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PublisherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Folder {
            get {
                return this.FolderField;
            }
            set {
                if ((object.ReferenceEquals(this.FolderField, value) != true)) {
                    this.FolderField = value;
                    this.RaisePropertyChanged("Folder");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsApp1.ServiceReference1.EncyclopediaPartType[] PartList {
            get {
                return this.PartListField;
            }
            set {
                if ((object.ReferenceEquals(this.PartListField, value) != true)) {
                    this.PartListField = value;
                    this.RaisePropertyChanged("PartList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Publisher {
            get {
                return this.PublisherField;
            }
            set {
                if ((object.ReferenceEquals(this.PublisherField, value) != true)) {
                    this.PublisherField = value;
                    this.RaisePropertyChanged("Publisher");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EncyclopediaPartType", Namespace="http://schemas.datacontract.org/2004/07/L1.WcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class EncyclopediaPartType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsApp1.ServiceReference1.EncyclopediaArticleInfoType[] ArticleInfoListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FolderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameEncyclopediaPartTypeField;
        
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
        public WindowsFormsApp1.ServiceReference1.EncyclopediaArticleInfoType[] ArticleInfoList {
            get {
                return this.ArticleInfoListField;
            }
            set {
                if ((object.ReferenceEquals(this.ArticleInfoListField, value) != true)) {
                    this.ArticleInfoListField = value;
                    this.RaisePropertyChanged("ArticleInfoList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Folder {
            get {
                return this.FolderField;
            }
            set {
                if ((object.ReferenceEquals(this.FolderField, value) != true)) {
                    this.FolderField = value;
                    this.RaisePropertyChanged("Folder");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameEncyclopediaPartType {
            get {
                return this.NameEncyclopediaPartTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.NameEncyclopediaPartTypeField, value) != true)) {
                    this.NameEncyclopediaPartTypeField = value;
                    this.RaisePropertyChanged("NameEncyclopediaPartType");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EncyclopediaArticleInfoType", Namespace="http://schemas.datacontract.org/2004/07/L1.WcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class EncyclopediaArticleInfoType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameFileFullArticleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameShortArticleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NotesField;
        
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
        public double Mark {
            get {
                return this.MarkField;
            }
            set {
                if ((this.MarkField.Equals(value) != true)) {
                    this.MarkField = value;
                    this.RaisePropertyChanged("Mark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameFileFullArticle {
            get {
                return this.NameFileFullArticleField;
            }
            set {
                if ((object.ReferenceEquals(this.NameFileFullArticleField, value) != true)) {
                    this.NameFileFullArticleField = value;
                    this.RaisePropertyChanged("NameFileFullArticle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameShortArticle {
            get {
                return this.NameShortArticleField;
            }
            set {
                if ((object.ReferenceEquals(this.NameShortArticleField, value) != true)) {
                    this.NameShortArticleField = value;
                    this.RaisePropertyChanged("NameShortArticle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Notes {
            get {
                return this.NotesField;
            }
            set {
                if ((object.ReferenceEquals(this.NotesField, value) != true)) {
                    this.NotesField = value;
                    this.RaisePropertyChanged("Notes");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EncyclopediaArticleType", Namespace="http://schemas.datacontract.org/2004/07/L1.WcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class EncyclopediaArticleType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] BooksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MainArticleTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameArticleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameFileWithArticleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] NameFileWithImgField;
        
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
        public string[] Books {
            get {
                return this.BooksField;
            }
            set {
                if ((object.ReferenceEquals(this.BooksField, value) != true)) {
                    this.BooksField = value;
                    this.RaisePropertyChanged("Books");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MainArticleText {
            get {
                return this.MainArticleTextField;
            }
            set {
                if ((object.ReferenceEquals(this.MainArticleTextField, value) != true)) {
                    this.MainArticleTextField = value;
                    this.RaisePropertyChanged("MainArticleText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameArticle {
            get {
                return this.NameArticleField;
            }
            set {
                if ((object.ReferenceEquals(this.NameArticleField, value) != true)) {
                    this.NameArticleField = value;
                    this.RaisePropertyChanged("NameArticle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameFileWithArticle {
            get {
                return this.NameFileWithArticleField;
            }
            set {
                if ((object.ReferenceEquals(this.NameFileWithArticleField, value) != true)) {
                    this.NameFileWithArticleField = value;
                    this.RaisePropertyChanged("NameFileWithArticle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] NameFileWithImg {
            get {
                return this.NameFileWithImgField;
            }
            set {
                if ((object.ReferenceEquals(this.NameFileWithImgField, value) != true)) {
                    this.NameFileWithImgField = value;
                    this.RaisePropertyChanged("NameFileWithImg");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IEncyclopediaService")]
    public interface IEncyclopediaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/GetInfo", ReplyAction="http://tempuri.org/IEncyclopediaService/GetInfoResponse")]
        WindowsFormsApp1.ServiceReference1.EncyclopediaType GetInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/GetInfo", ReplyAction="http://tempuri.org/IEncyclopediaService/GetInfoResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.EncyclopediaType> GetInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/GetPart", ReplyAction="http://tempuri.org/IEncyclopediaService/GetPartResponse")]
        WindowsFormsApp1.ServiceReference1.EncyclopediaPartType GetPart(string sDirectoryCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/GetPart", ReplyAction="http://tempuri.org/IEncyclopediaService/GetPartResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.EncyclopediaPartType> GetPartAsync(string sDirectoryCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/GetArticle", ReplyAction="http://tempuri.org/IEncyclopediaService/GetArticleResponse")]
        WindowsFormsApp1.ServiceReference1.EncyclopediaArticleType GetArticle(string sDirectoryCode, string sFileNameCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/GetArticle", ReplyAction="http://tempuri.org/IEncyclopediaService/GetArticleResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.EncyclopediaArticleType> GetArticleAsync(string sDirectoryCode, string sFileNameCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/GetImages", ReplyAction="http://tempuri.org/IEncyclopediaService/GetImagesResponse")]
        byte[] GetImages(string sDirectoryCode, string sImgNameCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/GetImages", ReplyAction="http://tempuri.org/IEncyclopediaService/GetImagesResponse")]
        System.Threading.Tasks.Task<byte[]> GetImagesAsync(string sDirectoryCode, string sImgNameCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/CreateFullArticle", ReplyAction="http://tempuri.org/IEncyclopediaService/CreateFullArticleResponse")]
        void CreateFullArticle(string sDirectoryCode, string sNameFullAtricle, string sText, string[] sBooks, byte[][] sPictures);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/CreateFullArticle", ReplyAction="http://tempuri.org/IEncyclopediaService/CreateFullArticleResponse")]
        System.Threading.Tasks.Task CreateFullArticleAsync(string sDirectoryCode, string sNameFullAtricle, string sText, string[] sBooks, byte[][] sPictures);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/TestCreateWithoutMassiveOnlyMemory", ReplyAction="http://tempuri.org/IEncyclopediaService/TestCreateWithoutMassiveOnlyMemoryRespons" +
            "e")]
        void TestCreateWithoutMassiveOnlyMemory(string sDirectoryCode, string sNameFullAtricle, string sText, System.IO.MemoryStream sPictures);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/TestCreateWithoutMassiveOnlyMemory", ReplyAction="http://tempuri.org/IEncyclopediaService/TestCreateWithoutMassiveOnlyMemoryRespons" +
            "e")]
        System.Threading.Tasks.Task TestCreateWithoutMassiveOnlyMemoryAsync(string sDirectoryCode, string sNameFullAtricle, string sText, System.IO.MemoryStream sPictures);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/EditFullArticle", ReplyAction="http://tempuri.org/IEncyclopediaService/EditFullArticleResponse")]
        void EditFullArticle(string sDirectoryCode, WindowsFormsApp1.ServiceReference1.EncyclopediaArticleType createdChangedEncyclopedia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/EditFullArticle", ReplyAction="http://tempuri.org/IEncyclopediaService/EditFullArticleResponse")]
        System.Threading.Tasks.Task EditFullArticleAsync(string sDirectoryCode, WindowsFormsApp1.ServiceReference1.EncyclopediaArticleType createdChangedEncyclopedia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/AddPictureToServer", ReplyAction="http://tempuri.org/IEncyclopediaService/AddPictureToServerResponse")]
        void AddPictureToServer(string sDirectoryCode, System.IO.MemoryStream sPicture);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEncyclopediaService/AddPictureToServer", ReplyAction="http://tempuri.org/IEncyclopediaService/AddPictureToServerResponse")]
        System.Threading.Tasks.Task AddPictureToServerAsync(string sDirectoryCode, System.IO.MemoryStream sPicture);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEncyclopediaServiceChannel : WindowsFormsApp1.ServiceReference1.IEncyclopediaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EncyclopediaServiceClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.IEncyclopediaService>, WindowsFormsApp1.ServiceReference1.IEncyclopediaService {
        
        public EncyclopediaServiceClient() {
        }
        
        public EncyclopediaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EncyclopediaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EncyclopediaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EncyclopediaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsApp1.ServiceReference1.EncyclopediaType GetInfo() {
            return base.Channel.GetInfo();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.EncyclopediaType> GetInfoAsync() {
            return base.Channel.GetInfoAsync();
        }
        
        public WindowsFormsApp1.ServiceReference1.EncyclopediaPartType GetPart(string sDirectoryCode) {
            return base.Channel.GetPart(sDirectoryCode);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.EncyclopediaPartType> GetPartAsync(string sDirectoryCode) {
            return base.Channel.GetPartAsync(sDirectoryCode);
        }
        
        public WindowsFormsApp1.ServiceReference1.EncyclopediaArticleType GetArticle(string sDirectoryCode, string sFileNameCode) {
            return base.Channel.GetArticle(sDirectoryCode, sFileNameCode);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.EncyclopediaArticleType> GetArticleAsync(string sDirectoryCode, string sFileNameCode) {
            return base.Channel.GetArticleAsync(sDirectoryCode, sFileNameCode);
        }
        
        public byte[] GetImages(string sDirectoryCode, string sImgNameCode) {
            return base.Channel.GetImages(sDirectoryCode, sImgNameCode);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetImagesAsync(string sDirectoryCode, string sImgNameCode) {
            return base.Channel.GetImagesAsync(sDirectoryCode, sImgNameCode);
        }
        
        public void CreateFullArticle(string sDirectoryCode, string sNameFullAtricle, string sText, string[] sBooks, byte[][] sPictures) {
            base.Channel.CreateFullArticle(sDirectoryCode, sNameFullAtricle, sText, sBooks, sPictures);
        }
        
        public System.Threading.Tasks.Task CreateFullArticleAsync(string sDirectoryCode, string sNameFullAtricle, string sText, string[] sBooks, byte[][] sPictures) {
            return base.Channel.CreateFullArticleAsync(sDirectoryCode, sNameFullAtricle, sText, sBooks, sPictures);
        }
        
        public void TestCreateWithoutMassiveOnlyMemory(string sDirectoryCode, string sNameFullAtricle, string sText, System.IO.MemoryStream sPictures) {
            base.Channel.TestCreateWithoutMassiveOnlyMemory(sDirectoryCode, sNameFullAtricle, sText, sPictures);
        }
        
        public System.Threading.Tasks.Task TestCreateWithoutMassiveOnlyMemoryAsync(string sDirectoryCode, string sNameFullAtricle, string sText, System.IO.MemoryStream sPictures) {
            return base.Channel.TestCreateWithoutMassiveOnlyMemoryAsync(sDirectoryCode, sNameFullAtricle, sText, sPictures);
        }
        
        public void EditFullArticle(string sDirectoryCode, WindowsFormsApp1.ServiceReference1.EncyclopediaArticleType createdChangedEncyclopedia) {
            base.Channel.EditFullArticle(sDirectoryCode, createdChangedEncyclopedia);
        }
        
        public System.Threading.Tasks.Task EditFullArticleAsync(string sDirectoryCode, WindowsFormsApp1.ServiceReference1.EncyclopediaArticleType createdChangedEncyclopedia) {
            return base.Channel.EditFullArticleAsync(sDirectoryCode, createdChangedEncyclopedia);
        }
        
        public void AddPictureToServer(string sDirectoryCode, System.IO.MemoryStream sPicture) {
            base.Channel.AddPictureToServer(sDirectoryCode, sPicture);
        }
        
        public System.Threading.Tasks.Task AddPictureToServerAsync(string sDirectoryCode, System.IO.MemoryStream sPicture) {
            return base.Channel.AddPictureToServerAsync(sDirectoryCode, sPicture);
        }
    }
}
