// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.xload 
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public interface XLoad {


            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xload.packBinsResponse packBins(com.ptvgroup.xserver.xload.packBins request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xload.startPackBinsResponse startPackBins(com.ptvgroup.xserver.xload.startPackBins request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xload.fetchPackedBinsResponseResponse fetchPackedBinsResponse(com.ptvgroup.xserver.xload.fetchPackedBinsResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xload.watchJobResponse watchJob(com.ptvgroup.xserver.xload.watchJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xload.stopJobResponse stopJob(com.ptvgroup.xserver.xload.stopJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xload.deleteJobResponse deleteJob(com.ptvgroup.xserver.xload.deleteJob request);
    }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="packBins", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class packBins {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xload.PackBinsRequest request;

                public packBins() {
                }

                public packBins(com.ptvgroup.xserver.xload.PackBinsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="packBinsResponse", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class packBinsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xload.PackedBinsResponse @return;

                public packBinsResponse() {
                }

                public packBinsResponse(com.ptvgroup.xserver.xload.PackedBinsResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startPackBins", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startPackBins {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xload.PackBinsRequest request;

                public startPackBins() {
                }

                public startPackBins(com.ptvgroup.xserver.xload.PackBinsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startPackBinsResponse", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startPackBinsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startPackBinsResponse() {
                }

                public startPackBinsResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchPackedBinsResponse", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchPackedBinsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchPackedBinsResponse() {
                }

                public fetchPackedBinsResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchPackedBinsResponseResponse", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchPackedBinsResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xload.PackedBinsResponse @return;

                public fetchPackedBinsResponseResponse() {
                }

                public fetchPackedBinsResponseResponse(com.ptvgroup.xserver.xload.PackedBinsResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJob", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.WatchRequest request;

                public watchJob() {
                }

                public watchJob(com.ptvgroup.xserver.jobs.WatchRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJobResponse", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public watchJobResponse() {
                }

                public watchJobResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJob", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public stopJob() {
                }

                public stopJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJobResponse", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public stopJobResponse() {
                }

                public stopJobResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJob", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public deleteJob() {
                }

                public deleteJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJobResponse", WrapperNamespace="http://xload.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xload.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public deleteJobResponse() {
                }

                public deleteJobResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XLoadChannel : com.ptvgroup.xserver.xload.XLoad, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XLoadClient : System.ServiceModel.ClientBase<com.ptvgroup.xserver.xload.XLoad>, com.ptvgroup.xserver.xload.XLoad {

        public XLoadClient() :
            this("http://localhost:50000/services/ws/XLoad") {
        }

        public XLoadClient(string baseUri , string version="") :
            this(new System.ServiceModel.BasicHttpBinding { MaxReceivedMessageSize = System.Int32.MaxValue }, new System.ServiceModel.EndpointAddress(baseUri+"/services/ws/XLoad/"+version)) {
        }

        public XLoadClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress) {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xload.packBinsResponse com.ptvgroup.xserver.xload.XLoad.packBins(com.ptvgroup.xserver.xload.packBins request) {
            return base.Channel.packBins(request);
        }

        public com.ptvgroup.xserver.xload.PackedBinsResponse packBins(com.ptvgroup.xserver.xload.PackBinsRequest request) {
            com.ptvgroup.xserver.xload.packBins inValue = new com.ptvgroup.xserver.xload.packBins();
            inValue.request = request;
            com.ptvgroup.xserver.xload.packBinsResponse retVal = ((com.ptvgroup.xserver.xload.XLoad)(this)).packBins(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xload.startPackBinsResponse com.ptvgroup.xserver.xload.XLoad.startPackBins(com.ptvgroup.xserver.xload.startPackBins request) {
                return base.Channel.startPackBins(request);
            }

            public com.ptvgroup.xserver.jobs.Job startPackBins(com.ptvgroup.xserver.xload.PackBinsRequest request) {
                com.ptvgroup.xserver.xload.startPackBins inValue = new com.ptvgroup.xserver.xload.startPackBins();
                inValue.request = request;
                com.ptvgroup.xserver.xload.startPackBinsResponse retVal = ((com.ptvgroup.xserver.xload.XLoad)(this)).startPackBins(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xload.fetchPackedBinsResponseResponse com.ptvgroup.xserver.xload.XLoad.fetchPackedBinsResponse(com.ptvgroup.xserver.xload.fetchPackedBinsResponse request) {
                return base.Channel.fetchPackedBinsResponse(request);
            }

            public com.ptvgroup.xserver.xload.PackedBinsResponse fetchPackedBinsResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xload.fetchPackedBinsResponse inValue = new com.ptvgroup.xserver.xload.fetchPackedBinsResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xload.fetchPackedBinsResponseResponse retVal = ((com.ptvgroup.xserver.xload.XLoad)(this)).fetchPackedBinsResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xload.watchJobResponse com.ptvgroup.xserver.xload.XLoad.watchJob(com.ptvgroup.xserver.xload.watchJob request) {
                return base.Channel.watchJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job watchJob(com.ptvgroup.xserver.jobs.WatchRequest request) {
                com.ptvgroup.xserver.xload.watchJob inValue = new com.ptvgroup.xserver.xload.watchJob();
                inValue.request = request;
                com.ptvgroup.xserver.xload.watchJobResponse retVal = ((com.ptvgroup.xserver.xload.XLoad)(this)).watchJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xload.stopJobResponse com.ptvgroup.xserver.xload.XLoad.stopJob(com.ptvgroup.xserver.xload.stopJob request) {
                return base.Channel.stopJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job stopJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xload.stopJob inValue = new com.ptvgroup.xserver.xload.stopJob();
                inValue.request = request;
                com.ptvgroup.xserver.xload.stopJobResponse retVal = ((com.ptvgroup.xserver.xload.XLoad)(this)).stopJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xload.deleteJobResponse com.ptvgroup.xserver.xload.XLoad.deleteJob(com.ptvgroup.xserver.xload.deleteJob request) {
                return base.Channel.deleteJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job deleteJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xload.deleteJob inValue = new com.ptvgroup.xserver.xload.deleteJob();
                inValue.request = request;
                com.ptvgroup.xserver.xload.deleteJobResponse retVal = ((com.ptvgroup.xserver.xload.XLoad)(this)).deleteJob(inValue);
                return retVal.@return;
            }

   }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class AllowedItemOrientations : object, System.ComponentModel.INotifyPropertyChanged {

        private bool originalField;
        private bool originalFieldSpecified;
        private bool xField;
        private bool xFieldSpecified;
        private bool yField;
        private bool yFieldSpecified;
        private bool zField;
        private bool zFieldSpecified;
        private bool xzField;
        private bool xzFieldSpecified;
        private bool yzField;
        private bool yzFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool original {
            get {
                return this.originalField;
            }
            set {
                this.originalField = value;
                this.RaisePropertyChanged("original");
                this.originalFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool originalSpecified {
            get {
                return this.originalFieldSpecified;
            }
            set {
                this.originalFieldSpecified = value;
                this.RaisePropertyChanged("originalSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("x");
                this.xFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xSpecified {
            get {
                return this.xFieldSpecified;
            }
            set {
                this.xFieldSpecified = value;
                this.RaisePropertyChanged("xSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("y");
                this.yFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ySpecified {
            get {
                return this.yFieldSpecified;
            }
            set {
                this.yFieldSpecified = value;
                this.RaisePropertyChanged("ySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
                this.RaisePropertyChanged("z");
                this.zFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool zSpecified {
            get {
                return this.zFieldSpecified;
            }
            set {
                this.zFieldSpecified = value;
                this.RaisePropertyChanged("zSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool xz {
            get {
                return this.xzField;
            }
            set {
                this.xzField = value;
                this.RaisePropertyChanged("xz");
                this.xzFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xzSpecified {
            get {
                return this.xzFieldSpecified;
            }
            set {
                this.xzFieldSpecified = value;
                this.RaisePropertyChanged("xzSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool yz {
            get {
                return this.yzField;
            }
            set {
                this.yzField = value;
                this.RaisePropertyChanged("yz");
                this.yzFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yzSpecified {
            get {
                return this.yzFieldSpecified;
            }
            set {
                this.yzFieldSpecified = value;
                this.RaisePropertyChanged("yzSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class BinType : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private int numberOfBinsField;
        private bool numberOfBinsFieldSpecified;
        private com.ptvgroup.xserver.xload.BoxDimensions dimensionsField;
        private double maximumVolumeCapacityField;
        private bool maximumVolumeCapacityFieldSpecified;
        private double maximumWeightCapacityField;
        private bool maximumWeightCapacityFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfBins {
            get {
                return this.numberOfBinsField;
            }
            set {
                this.numberOfBinsField = value;
                this.RaisePropertyChanged("numberOfBins");
                this.numberOfBinsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfBinsSpecified {
            get {
                return this.numberOfBinsFieldSpecified;
            }
            set {
                this.numberOfBinsFieldSpecified = value;
                this.RaisePropertyChanged("numberOfBinsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("dimensions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.BoxDimensions dimensions {
            get {
                return this.dimensionsField;
            }
            set {
                this.dimensionsField = value;
                this.RaisePropertyChanged("dimensions");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumVolumeCapacity {
            get {
                return this.maximumVolumeCapacityField;
            }
            set {
                this.maximumVolumeCapacityField = value;
                this.RaisePropertyChanged("maximumVolumeCapacity");
                this.maximumVolumeCapacityFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumVolumeCapacitySpecified {
            get {
                return this.maximumVolumeCapacityFieldSpecified;
            }
            set {
                this.maximumVolumeCapacityFieldSpecified = value;
                this.RaisePropertyChanged("maximumVolumeCapacitySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumWeightCapacity {
            get {
                return this.maximumWeightCapacityField;
            }
            set {
                this.maximumWeightCapacityField = value;
                this.RaisePropertyChanged("maximumWeightCapacity");
                this.maximumWeightCapacityFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumWeightCapacitySpecified {
            get {
                return this.maximumWeightCapacityFieldSpecified;
            }
            set {
                this.maximumWeightCapacityFieldSpecified = value;
                this.RaisePropertyChanged("maximumWeightCapacitySpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class BoxDimensions : object, System.ComponentModel.INotifyPropertyChanged {

        private double xField;
        private double yField;
        private double zField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("x");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("y");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
                this.RaisePropertyChanged("z");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class ItemPosition : object, System.ComponentModel.INotifyPropertyChanged {

        private double xField;
        private double yField;
        private double zField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("x");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("y");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
                this.RaisePropertyChanged("z");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class ItemSurfaceLoads : object, System.ComponentModel.INotifyPropertyChanged {

        private double xField;
        private bool xFieldSpecified;
        private double yField;
        private bool yFieldSpecified;
        private double zField;
        private bool zFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("x");
                this.xFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xSpecified {
            get {
                return this.xFieldSpecified;
            }
            set {
                this.xFieldSpecified = value;
                this.RaisePropertyChanged("xSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("y");
                this.yFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ySpecified {
            get {
                return this.yFieldSpecified;
            }
            set {
                this.yFieldSpecified = value;
                this.RaisePropertyChanged("ySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
                this.RaisePropertyChanged("z");
                this.zFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool zSpecified {
            get {
                return this.zFieldSpecified;
            }
            set {
                this.zFieldSpecified = value;
                this.RaisePropertyChanged("zSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class ItemType : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private com.ptvgroup.xserver.xload.BoxDimensions dimensionsField;
        private double weightField;
        private com.ptvgroup.xserver.xload.ItemSurfaceLoads maximumSurfaceLoadsField;
        private com.ptvgroup.xserver.xload.AllowedItemOrientations allowedOrientationsField;
        private int numberOfItemsField;
        private bool numberOfItemsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("dimensions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.BoxDimensions dimensions {
            get {
                return this.dimensionsField;
            }
            set {
                this.dimensionsField = value;
                this.RaisePropertyChanged("dimensions");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
                this.RaisePropertyChanged("weight");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("maximumSurfaceLoads", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.ItemSurfaceLoads maximumSurfaceLoads {
            get {
                return this.maximumSurfaceLoadsField;
            }
            set {
                this.maximumSurfaceLoadsField = value;
                this.RaisePropertyChanged("maximumSurfaceLoads");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("allowedOrientations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.AllowedItemOrientations allowedOrientations {
            get {
                return this.allowedOrientationsField;
            }
            set {
                this.allowedOrientationsField = value;
                this.RaisePropertyChanged("allowedOrientations");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfItems {
            get {
                return this.numberOfItemsField;
            }
            set {
                this.numberOfItemsField = value;
                this.RaisePropertyChanged("numberOfItems");
                this.numberOfItemsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfItemsSpecified {
            get {
                return this.numberOfItemsFieldSpecified;
            }
            set {
                this.numberOfItemsFieldSpecified = value;
                this.RaisePropertyChanged("numberOfItemsSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class ItemsToUnload : object, System.ComponentModel.INotifyPropertyChanged {

        private string itemTypeIdField;
        private int numberOfItemsField;
        private bool numberOfItemsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string itemTypeId {
            get {
                return this.itemTypeIdField;
            }
            set {
                this.itemTypeIdField = value;
                this.RaisePropertyChanged("itemTypeId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfItems {
            get {
                return this.numberOfItemsField;
            }
            set {
                this.numberOfItemsField = value;
                this.RaisePropertyChanged("numberOfItems");
                this.numberOfItemsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfItemsSpecified {
            get {
                return this.numberOfItemsFieldSpecified;
            }
            set {
                this.numberOfItemsFieldSpecified = value;
                this.RaisePropertyChanged("numberOfItemsSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class PackBinsOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xload.PackBinsFocus focusField;
        private bool focusFieldSpecified;
        private com.ptvgroup.xserver.xload.Stop[] unloadingSequenceField;
        private com.ptvgroup.xserver.xload.StackingOptions stackingOptionsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xload.PackBinsFocus focus {
            get {
                return this.focusField;
            }
            set {
                this.focusField = value;
                this.RaisePropertyChanged("focus");
                this.focusFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool focusSpecified {
            get {
                return this.focusFieldSpecified;
            }
            set {
                this.focusFieldSpecified = value;
                this.RaisePropertyChanged("focusSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("unloadingSequence", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.Stop[] unloadingSequence {
            get {
                return this.unloadingSequenceField;
            }
            set {
                this.unloadingSequenceField = value;
                this.RaisePropertyChanged("unloadingSequence");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("stackingOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.StackingOptions stackingOptions {
            get {
                return this.stackingOptionsField;
            }
            set {
                this.stackingOptionsField = value;
                this.RaisePropertyChanged("stackingOptions");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class PackBinsRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xload.ItemType[] itemsField;
        private com.ptvgroup.xserver.xload.BinType[] binsField;
        private com.ptvgroup.xserver.xload.PackBinsOptions optionsField;

                    [System.Xml.Serialization.XmlElementAttribute("items", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.ItemType[] items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("items");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("bins", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.BinType[] bins {
            get {
                return this.binsField;
            }
            set {
                this.binsField = value;
                this.RaisePropertyChanged("bins");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("options", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.PackBinsOptions options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
                this.RaisePropertyChanged("options");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class PackedBin : object, System.ComponentModel.INotifyPropertyChanged {

        private string binTypeIdField;
        private com.ptvgroup.xserver.xload.PackedItem[] packedItemsField;
        private double totalItemsVolumeField;
        private double totalItemsWeightField;
        private double usedWeightCapacityField;
        private bool usedWeightCapacityFieldSpecified;
        private double usedVolumeCapacityField;
        private double loadingMetersField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string binTypeId {
            get {
                return this.binTypeIdField;
            }
            set {
                this.binTypeIdField = value;
                this.RaisePropertyChanged("binTypeId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("packedItems", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.PackedItem[] packedItems {
            get {
                return this.packedItemsField;
            }
            set {
                this.packedItemsField = value;
                this.RaisePropertyChanged("packedItems");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double totalItemsVolume {
            get {
                return this.totalItemsVolumeField;
            }
            set {
                this.totalItemsVolumeField = value;
                this.RaisePropertyChanged("totalItemsVolume");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double totalItemsWeight {
            get {
                return this.totalItemsWeightField;
            }
            set {
                this.totalItemsWeightField = value;
                this.RaisePropertyChanged("totalItemsWeight");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double usedWeightCapacity {
            get {
                return this.usedWeightCapacityField;
            }
            set {
                this.usedWeightCapacityField = value;
                this.RaisePropertyChanged("usedWeightCapacity");
                this.usedWeightCapacityFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usedWeightCapacitySpecified {
            get {
                return this.usedWeightCapacityFieldSpecified;
            }
            set {
                this.usedWeightCapacityFieldSpecified = value;
                this.RaisePropertyChanged("usedWeightCapacitySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double usedVolumeCapacity {
            get {
                return this.usedVolumeCapacityField;
            }
            set {
                this.usedVolumeCapacityField = value;
                this.RaisePropertyChanged("usedVolumeCapacity");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double loadingMeters {
            get {
                return this.loadingMetersField;
            }
            set {
                this.loadingMetersField = value;
                this.RaisePropertyChanged("loadingMeters");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class PackedBinsResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xload.PackedBin[] packedBinsField;
        private com.ptvgroup.xserver.xload.ItemType[] itemsNotPackedField;

                    [System.Xml.Serialization.XmlElementAttribute("packedBins", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.PackedBin[] packedBins {
            get {
                return this.packedBinsField;
            }
            set {
                this.packedBinsField = value;
                this.RaisePropertyChanged("packedBins");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("itemsNotPacked", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.ItemType[] itemsNotPacked {
            get {
                return this.itemsNotPackedField;
            }
            set {
                this.itemsNotPackedField = value;
                this.RaisePropertyChanged("itemsNotPacked");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class PackedItem : object, System.ComponentModel.INotifyPropertyChanged {

        private string itemTypeIdField;
        private com.ptvgroup.xserver.xload.ItemPosition positionField;
        private com.ptvgroup.xserver.xload.BoxDimensions dimensionsField;
        private com.ptvgroup.xserver.xload.ItemOrientation orientationField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string itemTypeId {
            get {
                return this.itemTypeIdField;
            }
            set {
                this.itemTypeIdField = value;
                this.RaisePropertyChanged("itemTypeId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("position", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.ItemPosition position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
                this.RaisePropertyChanged("position");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("dimensions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.BoxDimensions dimensions {
            get {
                return this.dimensionsField;
            }
            set {
                this.dimensionsField = value;
                this.RaisePropertyChanged("dimensions");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xload.ItemOrientation orientation {
            get {
                return this.orientationField;
            }
            set {
                this.orientationField = value;
                this.RaisePropertyChanged("orientation");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class StackingOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xload.StackingRestrictions[] stackingRestrictionsField;

                    [System.Xml.Serialization.XmlElementAttribute("stackingRestrictions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.StackingRestrictions[] stackingRestrictions {
            get {
                return this.stackingRestrictionsField;
            }
            set {
                this.stackingRestrictionsField = value;
                this.RaisePropertyChanged("stackingRestrictions");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class StackingRestrictions : object, System.ComponentModel.INotifyPropertyChanged {

        private string itemTypeIdField;
        private com.ptvgroup.xserver.xload.StackingRestrictionType restrictionTypeField;
        private bool restrictionTypeFieldSpecified;
        private string[] itemTypeIdsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string itemTypeId {
            get {
                return this.itemTypeIdField;
            }
            set {
                this.itemTypeIdField = value;
                this.RaisePropertyChanged("itemTypeId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xload.StackingRestrictionType restrictionType {
            get {
                return this.restrictionTypeField;
            }
            set {
                this.restrictionTypeField = value;
                this.RaisePropertyChanged("restrictionType");
                this.restrictionTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restrictionTypeSpecified {
            get {
                return this.restrictionTypeFieldSpecified;
            }
            set {
                this.restrictionTypeFieldSpecified = value;
                this.RaisePropertyChanged("restrictionTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("itemTypeIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] itemTypeIds {
            get {
                return this.itemTypeIdsField;
            }
            set {
                this.itemTypeIdsField = value;
                this.RaisePropertyChanged("itemTypeIds");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public partial class Stop : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xload.ItemsToUnload[] itemsToUnloadField;

                    [System.Xml.Serialization.XmlElementAttribute("itemsToUnload", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xload.ItemsToUnload[] itemsToUnload {
            get {
                return this.itemsToUnloadField;
            }
            set {
                this.itemsToUnloadField = value;
                this.RaisePropertyChanged("itemsToUnload");
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public enum ItemOrientation {
        /**
         * Items is not re-oriented. Dimensions stay (x,y,z).
         */
        ORIGINAL,

        /**
         * Item is rotated around x-axis (widthwise) by +/-90 degrees compared to the original orientation. Dimensions are (x,z,y).
         */
        X,

        /**
         * Item is rotated around y-axis (heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,y,x).
         */
        Y,

        /**
         * Item is rotated around z-axis (lengthwise) by +/-90 degrees compared to the original orientation. Dimensions are (y,x,z).
         */
        Z,

        /**
         * Item is rotated around x- then z-axis (width- then heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,x,y).
         */
        XZ,

        /**
         * Item is rotated around its y- then z-axis (length- then heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (y,z,x).
         */
        YZ
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public enum PackBinsFocus {
        /**
         * Focus on building horizontal layers of similar items. This will freely
* use available floor space with no special regard to loading meters.
         */
        BUILD_LAYERS,

        /**
         * Focus on reducing loading meters. This might result in less efficient
* use of overall volume.
         */
        REDUCE_LOADING_METERS
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xload.xserver.ptvgroup.com")]
    public enum StackingRestrictionType {
        /**
         * All <a href="xload.html#com.ptvgroup.xserver.xload.ItemType">ItemType</a> can be stacked on top of the current one. Moreover, every items of the same <a href="xload.html#com.ptvgroup.xserver.xload.ItemType">ItemType</a> can be stacked on top of the current one.
         */
        ALL_ALLOWED,

        /**
         * All <a href="xload.html#com.ptvgroup.xserver.xload.ItemType">ItemType</a> can not be stacked on top of the current one. Moreover, even items of the same <a href="xload.html#com.ptvgroup.xserver.xload.ItemType">ItemType</a> can not be stacked on top of the current one.
         */
        ALL_PROHIBITED,

        /**
         * Every listed <a href="xload.html#com.ptvgroup.xserver.xload.ItemType">ItemType</a> can be stacked on top of the current one.
         */
        ALLOWED,

        /**
         * Every listed <a href="xload.html#com.ptvgroup.xserver.xload.ItemType">ItemType</a> can not be stacked on top of the current one.
         */
        PROHIBITED
    }


}
