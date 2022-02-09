// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.xlocate 
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public interface XLocate {


            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xlocate.searchLocationsResponse searchLocations(com.ptvgroup.xserver.xlocate.searchLocations request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xlocate.searchLocationsInBulkResponse searchLocationsInBulk(com.ptvgroup.xserver.xlocate.searchLocationsInBulk request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xlocate.startSearchLocationsInBulkResponse startSearchLocationsInBulk(com.ptvgroup.xserver.xlocate.startSearchLocationsInBulk request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xlocate.fetchLocationsBulkResponseResponse fetchLocationsBulkResponse(com.ptvgroup.xserver.xlocate.fetchLocationsBulkResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xlocate.watchJobResponse watchJob(com.ptvgroup.xserver.xlocate.watchJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xlocate.stopJobResponse stopJob(com.ptvgroup.xserver.xlocate.stopJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xlocate.deleteJobResponse deleteJob(com.ptvgroup.xserver.xlocate.deleteJob request);
    }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="searchLocations", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class searchLocations {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xlocate.SearchLocationsRequest request;

                public searchLocations() {
                }

                public searchLocations(com.ptvgroup.xserver.xlocate.SearchLocationsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="searchLocationsResponse", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class searchLocationsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xlocate.LocationsResponse @return;

                public searchLocationsResponse() {
                }

                public searchLocationsResponse(com.ptvgroup.xserver.xlocate.LocationsResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="searchLocationsInBulk", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class searchLocationsInBulk {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xlocate.SearchLocationsBulkRequest request;

                public searchLocationsInBulk() {
                }

                public searchLocationsInBulk(com.ptvgroup.xserver.xlocate.SearchLocationsBulkRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="searchLocationsInBulkResponse", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class searchLocationsInBulkResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xlocate.LocationsBulkResponse @return;

                public searchLocationsInBulkResponse() {
                }

                public searchLocationsInBulkResponse(com.ptvgroup.xserver.xlocate.LocationsBulkResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startSearchLocationsInBulk", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startSearchLocationsInBulk {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xlocate.SearchLocationsBulkRequest request;

                public startSearchLocationsInBulk() {
                }

                public startSearchLocationsInBulk(com.ptvgroup.xserver.xlocate.SearchLocationsBulkRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startSearchLocationsInBulkResponse", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startSearchLocationsInBulkResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startSearchLocationsInBulkResponse() {
                }

                public startSearchLocationsInBulkResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchLocationsBulkResponse", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchLocationsBulkResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchLocationsBulkResponse() {
                }

                public fetchLocationsBulkResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchLocationsBulkResponseResponse", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchLocationsBulkResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xlocate.LocationsBulkResponse @return;

                public fetchLocationsBulkResponseResponse() {
                }

                public fetchLocationsBulkResponseResponse(com.ptvgroup.xserver.xlocate.LocationsBulkResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJob", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJobResponse", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJob", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJobResponse", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJob", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJobResponse", WrapperNamespace="http://xlocate.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xlocate.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public deleteJobResponse() {
                }

                public deleteJobResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XLocateChannel : com.ptvgroup.xserver.xlocate.XLocate, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XLocateClient : System.ServiceModel.ClientBase<com.ptvgroup.xserver.xlocate.XLocate>, com.ptvgroup.xserver.xlocate.XLocate {

        public XLocateClient() :
            this("http://localhost:50000/services/ws/XLocate/experimental") {
        }

        public XLocateClient(string baseUri ) :
            this(new System.ServiceModel.BasicHttpBinding { MaxReceivedMessageSize = System.Int32.MaxValue }, new System.ServiceModel.EndpointAddress(baseUri+"/services/ws/XLocate/experimental/")) {
        }

        public XLocateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress) {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xlocate.searchLocationsResponse com.ptvgroup.xserver.xlocate.XLocate.searchLocations(com.ptvgroup.xserver.xlocate.searchLocations request) {
            return base.Channel.searchLocations(request);
        }

        public com.ptvgroup.xserver.xlocate.LocationsResponse searchLocations(com.ptvgroup.xserver.xlocate.SearchLocationsRequest request) {
            com.ptvgroup.xserver.xlocate.searchLocations inValue = new com.ptvgroup.xserver.xlocate.searchLocations();
            inValue.request = request;
            com.ptvgroup.xserver.xlocate.searchLocationsResponse retVal = ((com.ptvgroup.xserver.xlocate.XLocate)(this)).searchLocations(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xlocate.searchLocationsInBulkResponse com.ptvgroup.xserver.xlocate.XLocate.searchLocationsInBulk(com.ptvgroup.xserver.xlocate.searchLocationsInBulk request) {
            return base.Channel.searchLocationsInBulk(request);
        }

        public com.ptvgroup.xserver.xlocate.LocationsBulkResponse searchLocationsInBulk(com.ptvgroup.xserver.xlocate.SearchLocationsBulkRequest request) {
            com.ptvgroup.xserver.xlocate.searchLocationsInBulk inValue = new com.ptvgroup.xserver.xlocate.searchLocationsInBulk();
            inValue.request = request;
            com.ptvgroup.xserver.xlocate.searchLocationsInBulkResponse retVal = ((com.ptvgroup.xserver.xlocate.XLocate)(this)).searchLocationsInBulk(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xlocate.startSearchLocationsInBulkResponse com.ptvgroup.xserver.xlocate.XLocate.startSearchLocationsInBulk(com.ptvgroup.xserver.xlocate.startSearchLocationsInBulk request) {
                return base.Channel.startSearchLocationsInBulk(request);
            }

            public com.ptvgroup.xserver.jobs.Job startSearchLocationsInBulk(com.ptvgroup.xserver.xlocate.SearchLocationsBulkRequest request) {
                com.ptvgroup.xserver.xlocate.startSearchLocationsInBulk inValue = new com.ptvgroup.xserver.xlocate.startSearchLocationsInBulk();
                inValue.request = request;
                com.ptvgroup.xserver.xlocate.startSearchLocationsInBulkResponse retVal = ((com.ptvgroup.xserver.xlocate.XLocate)(this)).startSearchLocationsInBulk(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xlocate.fetchLocationsBulkResponseResponse com.ptvgroup.xserver.xlocate.XLocate.fetchLocationsBulkResponse(com.ptvgroup.xserver.xlocate.fetchLocationsBulkResponse request) {
                return base.Channel.fetchLocationsBulkResponse(request);
            }

            public com.ptvgroup.xserver.xlocate.LocationsBulkResponse fetchLocationsBulkResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xlocate.fetchLocationsBulkResponse inValue = new com.ptvgroup.xserver.xlocate.fetchLocationsBulkResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xlocate.fetchLocationsBulkResponseResponse retVal = ((com.ptvgroup.xserver.xlocate.XLocate)(this)).fetchLocationsBulkResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xlocate.watchJobResponse com.ptvgroup.xserver.xlocate.XLocate.watchJob(com.ptvgroup.xserver.xlocate.watchJob request) {
                return base.Channel.watchJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job watchJob(com.ptvgroup.xserver.jobs.WatchRequest request) {
                com.ptvgroup.xserver.xlocate.watchJob inValue = new com.ptvgroup.xserver.xlocate.watchJob();
                inValue.request = request;
                com.ptvgroup.xserver.xlocate.watchJobResponse retVal = ((com.ptvgroup.xserver.xlocate.XLocate)(this)).watchJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xlocate.stopJobResponse com.ptvgroup.xserver.xlocate.XLocate.stopJob(com.ptvgroup.xserver.xlocate.stopJob request) {
                return base.Channel.stopJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job stopJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xlocate.stopJob inValue = new com.ptvgroup.xserver.xlocate.stopJob();
                inValue.request = request;
                com.ptvgroup.xserver.xlocate.stopJobResponse retVal = ((com.ptvgroup.xserver.xlocate.XLocate)(this)).stopJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xlocate.deleteJobResponse com.ptvgroup.xserver.xlocate.XLocate.deleteJob(com.ptvgroup.xserver.xlocate.deleteJob request) {
                return base.Channel.deleteJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job deleteJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xlocate.deleteJob inValue = new com.ptvgroup.xserver.xlocate.deleteJob();
                inValue.request = request;
                com.ptvgroup.xserver.xlocate.deleteJobResponse retVal = ((com.ptvgroup.xserver.xlocate.XLocate)(this)).deleteJob(inValue);
                return retVal.@return;
            }

   }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class Address : object, System.ComponentModel.INotifyPropertyChanged {

        private string countryField;
        private string stateField;
        private string provinceField;
        private string postalCodeField;
        private string cityField;
        private string districtField;
        private string subdistrictField;
        private string streetField;
        private string houseNumberField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
                this.RaisePropertyChanged("country");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
                this.RaisePropertyChanged("state");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string province {
            get {
                return this.provinceField;
            }
            set {
                this.provinceField = value;
                this.RaisePropertyChanged("province");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
                this.RaisePropertyChanged("postalCode");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("city");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string district {
            get {
                return this.districtField;
            }
            set {
                this.districtField = value;
                this.RaisePropertyChanged("district");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string subdistrict {
            get {
                return this.subdistrictField;
            }
            set {
                this.subdistrictField = value;
                this.RaisePropertyChanged("subdistrict");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
                this.RaisePropertyChanged("street");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string houseNumber {
            get {
                return this.houseNumberField;
            }
            set {
                this.houseNumberField = value;
                this.RaisePropertyChanged("houseNumber");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class AddressScores : object, System.ComponentModel.INotifyPropertyChanged {

        private double countryField;
        private bool countryFieldSpecified;
        private double stateField;
        private bool stateFieldSpecified;
        private double provinceField;
        private bool provinceFieldSpecified;
        private double postalCodeField;
        private bool postalCodeFieldSpecified;
        private double cityField;
        private bool cityFieldSpecified;
        private double districtField;
        private bool districtFieldSpecified;
        private double subdistrictField;
        private bool subdistrictFieldSpecified;
        private double streetField;
        private bool streetFieldSpecified;
        private double houseNumberField;
        private bool houseNumberFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
                this.RaisePropertyChanged("country");
                this.countryFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countrySpecified {
            get {
                return this.countryFieldSpecified;
            }
            set {
                this.countryFieldSpecified = value;
                this.RaisePropertyChanged("countrySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
                this.RaisePropertyChanged("state");
                this.stateFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stateSpecified {
            get {
                return this.stateFieldSpecified;
            }
            set {
                this.stateFieldSpecified = value;
                this.RaisePropertyChanged("stateSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double province {
            get {
                return this.provinceField;
            }
            set {
                this.provinceField = value;
                this.RaisePropertyChanged("province");
                this.provinceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool provinceSpecified {
            get {
                return this.provinceFieldSpecified;
            }
            set {
                this.provinceFieldSpecified = value;
                this.RaisePropertyChanged("provinceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
                this.RaisePropertyChanged("postalCode");
                this.postalCodeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postalCodeSpecified {
            get {
                return this.postalCodeFieldSpecified;
            }
            set {
                this.postalCodeFieldSpecified = value;
                this.RaisePropertyChanged("postalCodeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("city");
                this.cityFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool citySpecified {
            get {
                return this.cityFieldSpecified;
            }
            set {
                this.cityFieldSpecified = value;
                this.RaisePropertyChanged("citySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double district {
            get {
                return this.districtField;
            }
            set {
                this.districtField = value;
                this.RaisePropertyChanged("district");
                this.districtFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool districtSpecified {
            get {
                return this.districtFieldSpecified;
            }
            set {
                this.districtFieldSpecified = value;
                this.RaisePropertyChanged("districtSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double subdistrict {
            get {
                return this.subdistrictField;
            }
            set {
                this.subdistrictField = value;
                this.RaisePropertyChanged("subdistrict");
                this.subdistrictFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subdistrictSpecified {
            get {
                return this.subdistrictFieldSpecified;
            }
            set {
                this.subdistrictFieldSpecified = value;
                this.RaisePropertyChanged("subdistrictSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
                this.RaisePropertyChanged("street");
                this.streetFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool streetSpecified {
            get {
                return this.streetFieldSpecified;
            }
            set {
                this.streetFieldSpecified = value;
                this.RaisePropertyChanged("streetSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double houseNumber {
            get {
                return this.houseNumberField;
            }
            set {
                this.houseNumberField = value;
                this.RaisePropertyChanged("houseNumber");
                this.houseNumberFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool houseNumberSpecified {
            get {
                return this.houseNumberFieldSpecified;
            }
            set {
                this.houseNumberFieldSpecified = value;
                this.RaisePropertyChanged("houseNumberSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class CountryFallbackLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string requestedSubdivisionCodeField;
        private string fallbackCountryCodeField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestedSubdivisionCode {
            get {
                return this.requestedSubdivisionCodeField;
            }
            set {
                this.requestedSubdivisionCodeField = value;
                this.RaisePropertyChanged("requestedSubdivisionCode");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fallbackCountryCode {
            get {
                return this.fallbackCountryCodeField;
            }
            set {
                this.fallbackCountryCodeField = value;
                this.RaisePropertyChanged("fallbackCountryCode");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class Location : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.geometry.Coordinate referenceCoordinateField;
        private com.ptvgroup.xserver.geometry.Coordinate roadAccessCoordinateField;
        private com.ptvgroup.xserver.xlocate.Address addressField;
        private string formattedAddressField;

                    [System.Xml.Serialization.XmlElementAttribute("referenceCoordinate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate referenceCoordinate {
            get {
                return this.referenceCoordinateField;
            }
            set {
                this.referenceCoordinateField = value;
                this.RaisePropertyChanged("referenceCoordinate");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("roadAccessCoordinate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate roadAccessCoordinate {
            get {
                return this.roadAccessCoordinateField;
            }
            set {
                this.roadAccessCoordinateField = value;
                this.RaisePropertyChanged("roadAccessCoordinate");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("address", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xlocate.Address address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("address");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formattedAddress {
            get {
                return this.formattedAddressField;
            }
            set {
                this.formattedAddressField = value;
                this.RaisePropertyChanged("formattedAddress");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class LocationsBulkResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xlocate.LocationsBulkResponseItem[] responseItemsField;

                    [System.Xml.Serialization.XmlElementAttribute("responseItems", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xlocate.LocationsBulkResponseItem[] responseItems {
            get {
                return this.responseItemsField;
            }
            set {
                this.responseItemsField = value;
                this.RaisePropertyChanged("responseItems");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class LocationsBulkResponseItem : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xlocate.SearchLocationsResult[] resultsField;
        private com.ptvgroup.xserver.exceptions.SuppressedXServerException searchExceptionField;

                    [System.Xml.Serialization.XmlElementAttribute("results", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xlocate.SearchLocationsResult[] results {
            get {
                return this.resultsField;
            }
            set {
                this.resultsField = value;
                this.RaisePropertyChanged("results");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("searchException", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.exceptions.SuppressedXServerException searchException {
            get {
                return this.searchExceptionField;
            }
            set {
                this.searchExceptionField = value;
                this.RaisePropertyChanged("searchException");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class LocationsResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xlocate.SearchLocationsResult[] resultsField;

                    [System.Xml.Serialization.XmlElementAttribute("results", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xlocate.SearchLocationsResult[] results {
            get {
                return this.resultsField;
            }
            set {
                this.resultsField = value;
                this.RaisePropertyChanged("results");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class MatchQuality : object, System.ComponentModel.INotifyPropertyChanged {

        private double totalScoreField;
        private bool totalScoreFieldSpecified;
        private com.ptvgroup.xserver.xlocate.AddressScores addressScoresField;
        private double distanceField;
        private bool distanceFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double totalScore {
            get {
                return this.totalScoreField;
            }
            set {
                this.totalScoreField = value;
                this.RaisePropertyChanged("totalScore");
                this.totalScoreFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalScoreSpecified {
            get {
                return this.totalScoreFieldSpecified;
            }
            set {
                this.totalScoreFieldSpecified = value;
                this.RaisePropertyChanged("totalScoreSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("addressScores", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xlocate.AddressScores addressScores {
            get {
                return this.addressScoresField;
            }
            set {
                this.addressScoresField = value;
                this.RaisePropertyChanged("addressScores");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double distance {
            get {
                return this.distanceField;
            }
            set {
                this.distanceField = value;
                this.RaisePropertyChanged("distance");
                this.distanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool distanceSpecified {
            get {
                return this.distanceFieldSpecified;
            }
            set {
                this.distanceFieldSpecified = value;
                this.RaisePropertyChanged("distanceSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class SearchByAddressBulkRequest : com.ptvgroup.xserver.xlocate.SearchLocationsBulkRequest {

        private com.ptvgroup.xserver.xlocate.Address[] addressesField;

                    [System.Xml.Serialization.XmlElementAttribute("addresses", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xlocate.Address[] addresses {
            get {
                return this.addressesField;
            }
            set {
                this.addressesField = value;
                this.RaisePropertyChanged("addresses");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class SearchByAddressRequest : com.ptvgroup.xserver.xlocate.SearchLocationsRequest {

        private com.ptvgroup.xserver.xlocate.Address addressField;

                    [System.Xml.Serialization.XmlElementAttribute("address", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xlocate.Address address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("address");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class SearchByPositionBulkRequest : com.ptvgroup.xserver.xlocate.SearchLocationsBulkRequest {

        private com.ptvgroup.xserver.geometry.Coordinate[] coordinatesField;

                    [System.Xml.Serialization.XmlElementAttribute("coordinates", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate[] coordinates {
            get {
                return this.coordinatesField;
            }
            set {
                this.coordinatesField = value;
                this.RaisePropertyChanged("coordinates");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class SearchByPositionRequest : com.ptvgroup.xserver.xlocate.SearchLocationsRequest {

        private com.ptvgroup.xserver.geometry.Coordinate coordinateField;

                    [System.Xml.Serialization.XmlElementAttribute("coordinate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate coordinate {
            get {
                return this.coordinateField;
            }
            set {
                this.coordinateField = value;
                this.RaisePropertyChanged("coordinate");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class SearchByTextBulkRequest : com.ptvgroup.xserver.xlocate.SearchLocationsBulkRequest {

        private string[] textsField;

                    [System.Xml.Serialization.XmlElementAttribute("texts", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] texts {
            get {
                return this.textsField;
            }
            set {
                this.textsField = value;
                this.RaisePropertyChanged("texts");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class SearchByTextRequest : com.ptvgroup.xserver.xlocate.SearchLocationsRequest {

        private string textField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
                this.RaisePropertyChanged("text");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByAddressBulkRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByPositionBulkRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByTextBulkRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public abstract partial class SearchLocationsBulkRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xlocate.SearchOptions searchOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("searchOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xlocate.SearchOptions searchOptions {
            get {
                return this.searchOptionsField;
            }
            set {
                this.searchOptionsField = value;
                this.RaisePropertyChanged("searchOptions");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByAddressRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByPositionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByTextRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public abstract partial class SearchLocationsRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xlocate.SearchOptions searchOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("searchOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xlocate.SearchOptions searchOptions {
            get {
                return this.searchOptionsField;
            }
            set {
                this.searchOptionsField = value;
                this.RaisePropertyChanged("searchOptions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class SearchLocationsResult : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xlocate.Location locationField;
        private com.ptvgroup.xserver.xlocate.MatchQuality matchQualityField;
        private com.ptvgroup.xserver.xlocate.LocationType typeField;
        private bool typeFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("location", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xlocate.Location location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
                this.RaisePropertyChanged("location");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("matchQuality", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xlocate.MatchQuality matchQuality {
            get {
                return this.matchQualityField;
            }
            set {
                this.matchQualityField = value;
                this.RaisePropertyChanged("matchQuality");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xlocate.LocationType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
                this.typeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
                this.RaisePropertyChanged("typeSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public partial class SearchOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xlocate.CountryType outputCountryTypeField;
        private bool outputCountryTypeFieldSpecified;
        private string[] allowedCountriesField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xlocate.CountryType outputCountryType {
            get {
                return this.outputCountryTypeField;
            }
            set {
                this.outputCountryTypeField = value;
                this.RaisePropertyChanged("outputCountryType");
                this.outputCountryTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool outputCountryTypeSpecified {
            get {
                return this.outputCountryTypeFieldSpecified;
            }
            set {
                this.outputCountryTypeFieldSpecified = value;
                this.RaisePropertyChanged("outputCountryTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("allowedCountries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] allowedCountries {
            get {
                return this.allowedCountriesField;
            }
            set {
                this.allowedCountriesField = value;
                this.RaisePropertyChanged("allowedCountries");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public enum CountryType {
        /**
         * The country will be represented as ISO 3166-1 alpha-2, e.g. DE for Germany.
         */
        ISO_3166_1_ALPHA_2,

        /**
         * The country will be represented as ISO 3166-1 alpha-3, e.g. DEU for Germany.
         */
        ISO_3166_1_ALPHA_3,

        /**
         * The country will be represented by its license plate code, e.g. D for Germany.
         */
        LICENSE_PLATE,

        /**
         * The country will be represented by its name, not abbreviated nor encoded, in the requested language.
         */
        NAME
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xlocate.xserver.ptvgroup.com")]
    public enum LocationType {
        /**
         * Represents a locality (town, city, or place).
         */
        LOCALITY,

        /**
         * Represents a postal code area.
         */
        POSTAL_CODE,

        /**
         * Represents a street, or a section of a street.
         */
        STREET,

        /**
         * An address that is contained exactly in the geocoding data.
         */
        EXACT_ADDRESS,

        /**
         * An address that was interpolated from an address range.
         */
        INTERPOLATED_ADDRESS,

        /**
         * Fallback value to be substituted for enumeration values which were added in an API version that is newer than the request version. When using the current API, this value will never be returned.
         */
        UNSPECIFIED
    }


}
