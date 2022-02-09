// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.xmatch 
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public interface XMatch {


            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xmatch.matchTrackResponse matchTrack(com.ptvgroup.xserver.xmatch.matchTrack request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xmatch.startMatchTrackResponse startMatchTrack(com.ptvgroup.xserver.xmatch.startMatchTrack request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xmatch.matchPositionsResponse matchPositions(com.ptvgroup.xserver.xmatch.matchPositions request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xmatch.fetchTrackResponseResponse fetchTrackResponse(com.ptvgroup.xserver.xmatch.fetchTrackResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xmatch.watchJobResponse watchJob(com.ptvgroup.xserver.xmatch.watchJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xmatch.stopJobResponse stopJob(com.ptvgroup.xserver.xmatch.stopJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xmatch.deleteJobResponse deleteJob(com.ptvgroup.xserver.xmatch.deleteJob request);
    }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="matchTrack", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class matchTrack {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xmatch.MatchTrackRequest request;

                public matchTrack() {
                }

                public matchTrack(com.ptvgroup.xserver.xmatch.MatchTrackRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="matchTrackResponse", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class matchTrackResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xmatch.TrackResponse @return;

                public matchTrackResponse() {
                }

                public matchTrackResponse(com.ptvgroup.xserver.xmatch.TrackResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startMatchTrack", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startMatchTrack {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xmatch.MatchTrackRequest request;

                public startMatchTrack() {
                }

                public startMatchTrack(com.ptvgroup.xserver.xmatch.MatchTrackRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startMatchTrackResponse", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startMatchTrackResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startMatchTrackResponse() {
                }

                public startMatchTrackResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="matchPositions", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class matchPositions {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xmatch.MatchPositionsRequest request;

                public matchPositions() {
                }

                public matchPositions(com.ptvgroup.xserver.xmatch.MatchPositionsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="matchPositionsResponse", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class matchPositionsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xmatch.PositionsResponse @return;

                public matchPositionsResponse() {
                }

                public matchPositionsResponse(com.ptvgroup.xserver.xmatch.PositionsResponse @return) {
                    this.@return = @return;
                }
            }


            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchTrackResponse", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchTrackResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchTrackResponse() {
                }

                public fetchTrackResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchTrackResponseResponse", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchTrackResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xmatch.TrackResponse @return;

                public fetchTrackResponseResponse() {
                }

                public fetchTrackResponseResponse(com.ptvgroup.xserver.xmatch.TrackResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJob", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJobResponse", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJob", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJobResponse", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJob", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJobResponse", WrapperNamespace="http://xmatch.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmatch.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public deleteJobResponse() {
                }

                public deleteJobResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XMatchChannel : com.ptvgroup.xserver.xmatch.XMatch, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XMatchClient : System.ServiceModel.ClientBase<com.ptvgroup.xserver.xmatch.XMatch>, com.ptvgroup.xserver.xmatch.XMatch {

        public XMatchClient() :
            this("http://localhost:50000/services/ws/XMatch/experimental") {
        }

        public XMatchClient(string baseUri ) :
            this(new System.ServiceModel.BasicHttpBinding { MaxReceivedMessageSize = System.Int32.MaxValue }, new System.ServiceModel.EndpointAddress(baseUri+"/services/ws/XMatch/experimental/")) {
        }

        public XMatchClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress) {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xmatch.matchTrackResponse com.ptvgroup.xserver.xmatch.XMatch.matchTrack(com.ptvgroup.xserver.xmatch.matchTrack request) {
            return base.Channel.matchTrack(request);
        }

        public com.ptvgroup.xserver.xmatch.TrackResponse matchTrack(com.ptvgroup.xserver.xmatch.MatchTrackRequest request) {
            com.ptvgroup.xserver.xmatch.matchTrack inValue = new com.ptvgroup.xserver.xmatch.matchTrack();
            inValue.request = request;
            com.ptvgroup.xserver.xmatch.matchTrackResponse retVal = ((com.ptvgroup.xserver.xmatch.XMatch)(this)).matchTrack(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xmatch.startMatchTrackResponse com.ptvgroup.xserver.xmatch.XMatch.startMatchTrack(com.ptvgroup.xserver.xmatch.startMatchTrack request) {
                return base.Channel.startMatchTrack(request);
            }

            public com.ptvgroup.xserver.jobs.Job startMatchTrack(com.ptvgroup.xserver.xmatch.MatchTrackRequest request) {
                com.ptvgroup.xserver.xmatch.startMatchTrack inValue = new com.ptvgroup.xserver.xmatch.startMatchTrack();
                inValue.request = request;
                com.ptvgroup.xserver.xmatch.startMatchTrackResponse retVal = ((com.ptvgroup.xserver.xmatch.XMatch)(this)).startMatchTrack(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xmatch.matchPositionsResponse com.ptvgroup.xserver.xmatch.XMatch.matchPositions(com.ptvgroup.xserver.xmatch.matchPositions request) {
            return base.Channel.matchPositions(request);
        }

        public com.ptvgroup.xserver.xmatch.PositionsResponse matchPositions(com.ptvgroup.xserver.xmatch.MatchPositionsRequest request) {
            com.ptvgroup.xserver.xmatch.matchPositions inValue = new com.ptvgroup.xserver.xmatch.matchPositions();
            inValue.request = request;
            com.ptvgroup.xserver.xmatch.matchPositionsResponse retVal = ((com.ptvgroup.xserver.xmatch.XMatch)(this)).matchPositions(inValue);
            return retVal.@return;
        }


            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xmatch.fetchTrackResponseResponse com.ptvgroup.xserver.xmatch.XMatch.fetchTrackResponse(com.ptvgroup.xserver.xmatch.fetchTrackResponse request) {
                return base.Channel.fetchTrackResponse(request);
            }

            public com.ptvgroup.xserver.xmatch.TrackResponse fetchTrackResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xmatch.fetchTrackResponse inValue = new com.ptvgroup.xserver.xmatch.fetchTrackResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xmatch.fetchTrackResponseResponse retVal = ((com.ptvgroup.xserver.xmatch.XMatch)(this)).fetchTrackResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xmatch.watchJobResponse com.ptvgroup.xserver.xmatch.XMatch.watchJob(com.ptvgroup.xserver.xmatch.watchJob request) {
                return base.Channel.watchJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job watchJob(com.ptvgroup.xserver.jobs.WatchRequest request) {
                com.ptvgroup.xserver.xmatch.watchJob inValue = new com.ptvgroup.xserver.xmatch.watchJob();
                inValue.request = request;
                com.ptvgroup.xserver.xmatch.watchJobResponse retVal = ((com.ptvgroup.xserver.xmatch.XMatch)(this)).watchJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xmatch.stopJobResponse com.ptvgroup.xserver.xmatch.XMatch.stopJob(com.ptvgroup.xserver.xmatch.stopJob request) {
                return base.Channel.stopJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job stopJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xmatch.stopJob inValue = new com.ptvgroup.xserver.xmatch.stopJob();
                inValue.request = request;
                com.ptvgroup.xserver.xmatch.stopJobResponse retVal = ((com.ptvgroup.xserver.xmatch.XMatch)(this)).stopJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xmatch.deleteJobResponse com.ptvgroup.xserver.xmatch.XMatch.deleteJob(com.ptvgroup.xserver.xmatch.deleteJob request) {
                return base.Channel.deleteJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job deleteJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xmatch.deleteJob inValue = new com.ptvgroup.xserver.xmatch.deleteJob();
                inValue.request = request;
                com.ptvgroup.xserver.xmatch.deleteJobResponse retVal = ((com.ptvgroup.xserver.xmatch.XMatch)(this)).deleteJob(inValue);
                return retVal.@return;
            }

   }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class MatchPositionsOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xmatch.CalculationMode calculationModeField;
        private bool calculationModeFieldSpecified;
        private string customCalculationModeConfigurationField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xmatch.CalculationMode calculationMode {
            get {
                return this.calculationModeField;
            }
            set {
                this.calculationModeField = value;
                this.RaisePropertyChanged("calculationMode");
                this.calculationModeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool calculationModeSpecified {
            get {
                return this.calculationModeFieldSpecified;
            }
            set {
                this.calculationModeFieldSpecified = value;
                this.RaisePropertyChanged("calculationModeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string customCalculationModeConfiguration {
            get {
                return this.customCalculationModeConfigurationField;
            }
            set {
                this.customCalculationModeConfigurationField = value;
                this.RaisePropertyChanged("customCalculationModeConfiguration");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class MatchPositionsRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xmatch.Position[] positionsField;
        private com.ptvgroup.xserver.xmatch.MatchPositionsResultFields resultFieldsField;
        private com.ptvgroup.xserver.xmatch.MatchPositionsOptions matchPositionsOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("positions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.Position[] positions {
            get {
                return this.positionsField;
            }
            set {
                this.positionsField = value;
                this.RaisePropertyChanged("positions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.MatchPositionsResultFields resultFields {
            get {
                return this.resultFieldsField;
            }
            set {
                this.resultFieldsField = value;
                this.RaisePropertyChanged("resultFields");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("matchPositionsOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.MatchPositionsOptions matchPositionsOptions {
            get {
                return this.matchPositionsOptionsField;
            }
            set {
                this.matchPositionsOptionsField = value;
                this.RaisePropertyChanged("matchPositionsOptions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class MatchPositionsResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool providerIdField;
        private bool providerIdFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool providerId {
            get {
                return this.providerIdField;
            }
            set {
                this.providerIdField = value;
                this.RaisePropertyChanged("providerId");
                this.providerIdFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool providerIdSpecified {
            get {
                return this.providerIdFieldSpecified;
            }
            set {
                this.providerIdFieldSpecified = value;
                this.RaisePropertyChanged("providerIdSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class MatchTrackOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xmatch.CalculationMode calculationModeField;
        private bool calculationModeFieldSpecified;
        private string customCalculationModeConfigurationField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xmatch.CalculationMode calculationMode {
            get {
                return this.calculationModeField;
            }
            set {
                this.calculationModeField = value;
                this.RaisePropertyChanged("calculationMode");
                this.calculationModeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool calculationModeSpecified {
            get {
                return this.calculationModeFieldSpecified;
            }
            set {
                this.calculationModeFieldSpecified = value;
                this.RaisePropertyChanged("calculationModeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string customCalculationModeConfiguration {
            get {
                return this.customCalculationModeConfigurationField;
            }
            set {
                this.customCalculationModeConfigurationField = value;
                this.RaisePropertyChanged("customCalculationModeConfiguration");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class MatchTrackRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xmatch.TrackPosition[] trackPositionsField;
        private com.ptvgroup.xserver.xmatch.MatchTrackResultFields resultFieldsField;
        private com.ptvgroup.xserver.xmatch.MatchTrackOptions matchTrackOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("trackPositions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.TrackPosition[] trackPositions {
            get {
                return this.trackPositionsField;
            }
            set {
                this.trackPositionsField = value;
                this.RaisePropertyChanged("trackPositions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.MatchTrackResultFields resultFields {
            get {
                return this.resultFieldsField;
            }
            set {
                this.resultFieldsField = value;
                this.RaisePropertyChanged("resultFields");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("matchTrackOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.MatchTrackOptions matchTrackOptions {
            get {
                return this.matchTrackOptionsField;
            }
            set {
                this.matchTrackOptionsField = value;
                this.RaisePropertyChanged("matchTrackOptions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class MatchTrackResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool matchedPathsField;
        private bool matchedPathsFieldSpecified;
        private bool geometryField;
        private bool geometryFieldSpecified;
        private bool matchedTrackPositionsField;
        private bool matchedTrackPositionsFieldSpecified;
        private bool encodedPathField;
        private bool encodedPathFieldSpecified;
        private bool providerIdField;
        private bool providerIdFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool matchedPaths {
            get {
                return this.matchedPathsField;
            }
            set {
                this.matchedPathsField = value;
                this.RaisePropertyChanged("matchedPaths");
                this.matchedPathsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool matchedPathsSpecified {
            get {
                return this.matchedPathsFieldSpecified;
            }
            set {
                this.matchedPathsFieldSpecified = value;
                this.RaisePropertyChanged("matchedPathsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool geometry {
            get {
                return this.geometryField;
            }
            set {
                this.geometryField = value;
                this.RaisePropertyChanged("geometry");
                this.geometryFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool geometrySpecified {
            get {
                return this.geometryFieldSpecified;
            }
            set {
                this.geometryFieldSpecified = value;
                this.RaisePropertyChanged("geometrySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool matchedTrackPositions {
            get {
                return this.matchedTrackPositionsField;
            }
            set {
                this.matchedTrackPositionsField = value;
                this.RaisePropertyChanged("matchedTrackPositions");
                this.matchedTrackPositionsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool matchedTrackPositionsSpecified {
            get {
                return this.matchedTrackPositionsFieldSpecified;
            }
            set {
                this.matchedTrackPositionsFieldSpecified = value;
                this.RaisePropertyChanged("matchedTrackPositionsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool encodedPath {
            get {
                return this.encodedPathField;
            }
            set {
                this.encodedPathField = value;
                this.RaisePropertyChanged("encodedPath");
                this.encodedPathFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool encodedPathSpecified {
            get {
                return this.encodedPathFieldSpecified;
            }
            set {
                this.encodedPathFieldSpecified = value;
                this.RaisePropertyChanged("encodedPathSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool providerId {
            get {
                return this.providerIdField;
            }
            set {
                this.providerIdField = value;
                this.RaisePropertyChanged("providerId");
                this.providerIdFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool providerIdSpecified {
            get {
                return this.providerIdFieldSpecified;
            }
            set {
                this.providerIdFieldSpecified = value;
                this.RaisePropertyChanged("providerIdSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class MatchedPath : object, System.ComponentModel.INotifyPropertyChanged {

        private double distanceField;
        private string encodedPathField;
        private int startTrackPositionIndexField;
        private bool startTrackPositionIndexFieldSpecified;
        private int endTrackPositionIndexField;
        private bool endTrackPositionIndexFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double distance {
            get {
                return this.distanceField;
            }
            set {
                this.distanceField = value;
                this.RaisePropertyChanged("distance");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string encodedPath {
            get {
                return this.encodedPathField;
            }
            set {
                this.encodedPathField = value;
                this.RaisePropertyChanged("encodedPath");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int startTrackPositionIndex {
            get {
                return this.startTrackPositionIndexField;
            }
            set {
                this.startTrackPositionIndexField = value;
                this.RaisePropertyChanged("startTrackPositionIndex");
                this.startTrackPositionIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startTrackPositionIndexSpecified {
            get {
                return this.startTrackPositionIndexFieldSpecified;
            }
            set {
                this.startTrackPositionIndexFieldSpecified = value;
                this.RaisePropertyChanged("startTrackPositionIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int endTrackPositionIndex {
            get {
                return this.endTrackPositionIndexField;
            }
            set {
                this.endTrackPositionIndexField = value;
                this.RaisePropertyChanged("endTrackPositionIndex");
                this.endTrackPositionIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endTrackPositionIndexSpecified {
            get {
                return this.endTrackPositionIndexFieldSpecified;
            }
            set {
                this.endTrackPositionIndexFieldSpecified = value;
                this.RaisePropertyChanged("endTrackPositionIndexSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class MatchedPosition : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xmatch.MatchDetail detailField;
        private com.ptvgroup.xserver.xmatch.MatchedSegment matchedSegmentField;
        private com.ptvgroup.xserver.geometry.Coordinate matchedCoordinateField;
        private com.ptvgroup.xserver.xmatch.PositionQuality qualityField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xmatch.MatchDetail detail {
            get {
                return this.detailField;
            }
            set {
                this.detailField = value;
                this.RaisePropertyChanged("detail");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("matchedSegment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.MatchedSegment matchedSegment {
            get {
                return this.matchedSegmentField;
            }
            set {
                this.matchedSegmentField = value;
                this.RaisePropertyChanged("matchedSegment");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("matchedCoordinate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate matchedCoordinate {
            get {
                return this.matchedCoordinateField;
            }
            set {
                this.matchedCoordinateField = value;
                this.RaisePropertyChanged("matchedCoordinate");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("quality", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.PositionQuality quality {
            get {
                return this.qualityField;
            }
            set {
                this.qualityField = value;
                this.RaisePropertyChanged("quality");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class MatchedSegment : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private com.ptvgroup.xserver.geometry.EncodedGeometry polylineField;
        private string providerIdField;

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

                    [System.Xml.Serialization.XmlElementAttribute("polyline", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.EncodedGeometry polyline {
            get {
                return this.polylineField;
            }
            set {
                this.polylineField = value;
                this.RaisePropertyChanged("polyline");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string providerId {
            get {
                return this.providerIdField;
            }
            set {
                this.providerIdField = value;
                this.RaisePropertyChanged("providerId");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class MatchedTrackPosition : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xmatch.MatchDetail detailField;
        private double distanceFromPreviousMatchField;
        private bool distanceFromPreviousMatchFieldSpecified;
        private com.ptvgroup.xserver.xmatch.MatchedSegment matchedSegmentField;
        private com.ptvgroup.xserver.geometry.Coordinate matchedCoordinateField;
        private com.ptvgroup.xserver.xmatch.PositionQuality qualityField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xmatch.MatchDetail detail {
            get {
                return this.detailField;
            }
            set {
                this.detailField = value;
                this.RaisePropertyChanged("detail");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double distanceFromPreviousMatch {
            get {
                return this.distanceFromPreviousMatchField;
            }
            set {
                this.distanceFromPreviousMatchField = value;
                this.RaisePropertyChanged("distanceFromPreviousMatch");
                this.distanceFromPreviousMatchFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool distanceFromPreviousMatchSpecified {
            get {
                return this.distanceFromPreviousMatchFieldSpecified;
            }
            set {
                this.distanceFromPreviousMatchFieldSpecified = value;
                this.RaisePropertyChanged("distanceFromPreviousMatchSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("matchedSegment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.MatchedSegment matchedSegment {
            get {
                return this.matchedSegmentField;
            }
            set {
                this.matchedSegmentField = value;
                this.RaisePropertyChanged("matchedSegment");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("matchedCoordinate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate matchedCoordinate {
            get {
                return this.matchedCoordinateField;
            }
            set {
                this.matchedCoordinateField = value;
                this.RaisePropertyChanged("matchedCoordinate");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("quality", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.PositionQuality quality {
            get {
                return this.qualityField;
            }
            set {
                this.qualityField = value;
                this.RaisePropertyChanged("quality");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xmatch.TrackPosition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class Position : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.geometry.Coordinate coordinateField;
        private double headingField;
        private bool headingFieldSpecified;

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

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double heading {
            get {
                return this.headingField;
            }
            set {
                this.headingField = value;
                this.RaisePropertyChanged("heading");
                this.headingFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool headingSpecified {
            get {
                return this.headingFieldSpecified;
            }
            set {
                this.headingFieldSpecified = value;
                this.RaisePropertyChanged("headingSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class PositionQuality : object, System.ComponentModel.INotifyPropertyChanged {

        private double matchDistanceField;
        private double angleDifferenceField;
        private bool angleDifferenceFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double matchDistance {
            get {
                return this.matchDistanceField;
            }
            set {
                this.matchDistanceField = value;
                this.RaisePropertyChanged("matchDistance");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double angleDifference {
            get {
                return this.angleDifferenceField;
            }
            set {
                this.angleDifferenceField = value;
                this.RaisePropertyChanged("angleDifference");
                this.angleDifferenceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool angleDifferenceSpecified {
            get {
                return this.angleDifferenceFieldSpecified;
            }
            set {
                this.angleDifferenceFieldSpecified = value;
                this.RaisePropertyChanged("angleDifferenceSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class PositionsResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xmatch.MatchedPosition[] matchedPositionsField;

                    [System.Xml.Serialization.XmlElementAttribute("matchedPositions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.MatchedPosition[] matchedPositions {
            get {
                return this.matchedPositionsField;
            }
            set {
                this.matchedPositionsField = value;
                this.RaisePropertyChanged("matchedPositions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class TrackPosition : com.ptvgroup.xserver.xmatch.Position {

        private double distanceFromPreviousPositionField;
        private bool distanceFromPreviousPositionFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double distanceFromPreviousPosition {
            get {
                return this.distanceFromPreviousPositionField;
            }
            set {
                this.distanceFromPreviousPositionField = value;
                this.RaisePropertyChanged("distanceFromPreviousPosition");
                this.distanceFromPreviousPositionFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool distanceFromPreviousPositionSpecified {
            get {
                return this.distanceFromPreviousPositionFieldSpecified;
            }
            set {
                this.distanceFromPreviousPositionFieldSpecified = value;
                this.RaisePropertyChanged("distanceFromPreviousPositionSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public partial class TrackResponse : com.ptvgroup.xserver.service.ResponseBase {

        private double distanceField;
        private com.ptvgroup.xserver.xmatch.MatchedPath[] matchedPathsField;
        private com.ptvgroup.xserver.geometry.EncodedGeometry geometryField;
        private com.ptvgroup.xserver.xmatch.MatchedTrackPosition[] matchedTrackPositionsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double distance {
            get {
                return this.distanceField;
            }
            set {
                this.distanceField = value;
                this.RaisePropertyChanged("distance");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("matchedPaths", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.MatchedPath[] matchedPaths {
            get {
                return this.matchedPathsField;
            }
            set {
                this.matchedPathsField = value;
                this.RaisePropertyChanged("matchedPaths");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("geometry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.EncodedGeometry geometry {
            get {
                return this.geometryField;
            }
            set {
                this.geometryField = value;
                this.RaisePropertyChanged("geometry");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("matchedTrackPositions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmatch.MatchedTrackPosition[] matchedTrackPositions {
            get {
                return this.matchedTrackPositionsField;
            }
            set {
                this.matchedTrackPositionsField = value;
                this.RaisePropertyChanged("matchedTrackPositions");
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public enum CalculationMode {
        /**
         * The algorithm's focus is on performance.
* This means to take into account a higher count of failed matches and in the case of track matching
* that the matched track may be split into several paths.
         */
        PERFORMANCE,

        /**
         * The algorithm chooses a standard trade-off between quality and performance.
         */
        STANDARD,

        /**
         * The algorithm's focus is on high solution quality.
* This means that as much as possible of the input positions are matched and taken into account.
* Though the processing time of the request can be high.
         */
        QUALITY,

        /**
         * The algorithm's focus is adapted to the customer's needs.
* It is necessary to define the <a href="xmatch.html#com.ptvgroup.xserver.xmatch.MatchTrackOptions.customCalculationModeConfiguration">MatchTrackOptions.customCalculationModeConfiguration</a> or <a href="xmatch.html#com.ptvgroup.xserver.xmatch.MatchPositionsOptions.customCalculationModeConfiguration">MatchPositionsOptions.customCalculationModeConfiguration</a> accordingly.
         */
        CUSTOM
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmatch.xserver.ptvgroup.com")]
    public enum MatchDetail {
        /**
         * The position was matched successfully.
         */
        MATCH_SUCCESSFUL,

        /**
         * The position could not be matched.
         */
        MATCH_FAILED,

        /**
         * The position was not considered.
* This can only occur for track matching and not for position matching.
         */
        NOT_CONSIDERED,

        /**
         * Fallback value to be substituted for enumeration values which were added in an API version that is newer than the request version. When using the current API, this value will never be returned.
         */
        UNSPECIFIED
    }


}
