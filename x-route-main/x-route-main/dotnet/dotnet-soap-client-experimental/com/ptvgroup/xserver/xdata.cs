// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.xdata 
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public interface XData {


            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.getSegmentsResponse getSegments(com.ptvgroup.xserver.xdata.getSegments request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.getTimeZoneResponse getTimeZone(com.ptvgroup.xserver.xdata.getTimeZone request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.createContentSnapshotResponse createContentSnapshot(com.ptvgroup.xserver.xdata.createContentSnapshot request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.deleteContentSnapshotResponse deleteContentSnapshot(com.ptvgroup.xserver.xdata.deleteContentSnapshot request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.listContentSnapshotsResponse listContentSnapshots(com.ptvgroup.xserver.xdata.listContentSnapshots request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.startCreateHighPerformanceRoutingNetworkResponse startCreateHighPerformanceRoutingNetwork(com.ptvgroup.xserver.xdata.startCreateHighPerformanceRoutingNetwork request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.deleteHighPerformanceRoutingNetworkResponse deleteHighPerformanceRoutingNetwork(com.ptvgroup.xserver.xdata.deleteHighPerformanceRoutingNetwork request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.listHighPerformanceRoutingNetworksResponse listHighPerformanceRoutingNetworks(com.ptvgroup.xserver.xdata.listHighPerformanceRoutingNetworks request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.createFeatureLayerResponse createFeatureLayer(com.ptvgroup.xserver.xdata.createFeatureLayer request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.startCreateFeatureLayerResponse startCreateFeatureLayer(com.ptvgroup.xserver.xdata.startCreateFeatureLayer request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.deleteFeatureLayerResponse deleteFeatureLayer(com.ptvgroup.xserver.xdata.deleteFeatureLayer request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.listFeatureLayersResponse listFeatureLayers(com.ptvgroup.xserver.xdata.listFeatureLayers request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.fetchFeatureLayerResponseResponse fetchFeatureLayerResponse(com.ptvgroup.xserver.xdata.fetchFeatureLayerResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.fetchHighPerformanceRoutingNetworkResponseResponse fetchHighPerformanceRoutingNetworkResponse(com.ptvgroup.xserver.xdata.fetchHighPerformanceRoutingNetworkResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.watchJobResponse watchJob(com.ptvgroup.xserver.xdata.watchJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.stopJobResponse stopJob(com.ptvgroup.xserver.xdata.stopJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdata.deleteJobResponse deleteJob(com.ptvgroup.xserver.xdata.deleteJob request);
    }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getSegments", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getSegments {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.SegmentsRequest request;

                public getSegments() {
                }

                public getSegments(com.ptvgroup.xserver.xdata.SegmentsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getSegmentsResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getSegmentsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.SegmentsResponse @return;

                public getSegmentsResponse() {
                }

                public getSegmentsResponse(com.ptvgroup.xserver.xdata.SegmentsResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getTimeZone", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getTimeZone {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.TimeZoneRequest request;

                public getTimeZone() {
                }

                public getTimeZone(com.ptvgroup.xserver.xdata.TimeZoneRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getTimeZoneResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getTimeZoneResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.TimeZoneResponse @return;

                public getTimeZoneResponse() {
                }

                public getTimeZoneResponse(com.ptvgroup.xserver.xdata.TimeZoneResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="createContentSnapshot", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class createContentSnapshot {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.CreateContentSnapshotRequest request;

                public createContentSnapshot() {
                }

                public createContentSnapshot(com.ptvgroup.xserver.xdata.CreateContentSnapshotRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="createContentSnapshotResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class createContentSnapshotResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.ContentSnapshotResponse @return;

                public createContentSnapshotResponse() {
                }

                public createContentSnapshotResponse(com.ptvgroup.xserver.xdata.ContentSnapshotResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteContentSnapshot", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteContentSnapshot {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.DeleteContentSnapshotRequest request;

                public deleteContentSnapshot() {
                }

                public deleteContentSnapshot(com.ptvgroup.xserver.xdata.DeleteContentSnapshotRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteContentSnapshotResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteContentSnapshotResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.service.VoidResponse @return;

                public deleteContentSnapshotResponse() {
                }

                public deleteContentSnapshotResponse(com.ptvgroup.xserver.service.VoidResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="listContentSnapshots", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class listContentSnapshots {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.ListContentSnapshotsRequest request;

                public listContentSnapshots() {
                }

                public listContentSnapshots(com.ptvgroup.xserver.xdata.ListContentSnapshotsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="listContentSnapshotsResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class listContentSnapshotsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.ContentSnapshotsListResponse @return;

                public listContentSnapshotsResponse() {
                }

                public listContentSnapshotsResponse(com.ptvgroup.xserver.xdata.ContentSnapshotsListResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCreateHighPerformanceRoutingNetwork", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCreateHighPerformanceRoutingNetwork {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.CreateHighPerformanceRoutingNetworkRequest request;

                public startCreateHighPerformanceRoutingNetwork() {
                }

                public startCreateHighPerformanceRoutingNetwork(com.ptvgroup.xserver.xdata.CreateHighPerformanceRoutingNetworkRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCreateHighPerformanceRoutingNetworkResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCreateHighPerformanceRoutingNetworkResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startCreateHighPerformanceRoutingNetworkResponse() {
                }

                public startCreateHighPerformanceRoutingNetworkResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteHighPerformanceRoutingNetwork", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteHighPerformanceRoutingNetwork {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.DeleteHighPerformanceRoutingNetworkRequest request;

                public deleteHighPerformanceRoutingNetwork() {
                }

                public deleteHighPerformanceRoutingNetwork(com.ptvgroup.xserver.xdata.DeleteHighPerformanceRoutingNetworkRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteHighPerformanceRoutingNetworkResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteHighPerformanceRoutingNetworkResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.service.VoidResponse @return;

                public deleteHighPerformanceRoutingNetworkResponse() {
                }

                public deleteHighPerformanceRoutingNetworkResponse(com.ptvgroup.xserver.service.VoidResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="listHighPerformanceRoutingNetworks", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class listHighPerformanceRoutingNetworks {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.ListHighPerformanceRoutingNetworksRequest request;

                public listHighPerformanceRoutingNetworks() {
                }

                public listHighPerformanceRoutingNetworks(com.ptvgroup.xserver.xdata.ListHighPerformanceRoutingNetworksRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="listHighPerformanceRoutingNetworksResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class listHighPerformanceRoutingNetworksResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworksListResponse @return;

                public listHighPerformanceRoutingNetworksResponse() {
                }

                public listHighPerformanceRoutingNetworksResponse(com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworksListResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="createFeatureLayer", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class createFeatureLayer {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.CreateFeatureLayerRequest request;

                public createFeatureLayer() {
                }

                public createFeatureLayer(com.ptvgroup.xserver.xdata.CreateFeatureLayerRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="createFeatureLayerResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class createFeatureLayerResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.FeatureLayerResponse @return;

                public createFeatureLayerResponse() {
                }

                public createFeatureLayerResponse(com.ptvgroup.xserver.xdata.FeatureLayerResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCreateFeatureLayer", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCreateFeatureLayer {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.CreateFeatureLayerRequest request;

                public startCreateFeatureLayer() {
                }

                public startCreateFeatureLayer(com.ptvgroup.xserver.xdata.CreateFeatureLayerRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCreateFeatureLayerResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCreateFeatureLayerResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startCreateFeatureLayerResponse() {
                }

                public startCreateFeatureLayerResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteFeatureLayer", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteFeatureLayer {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.DeleteFeatureLayerRequest request;

                public deleteFeatureLayer() {
                }

                public deleteFeatureLayer(com.ptvgroup.xserver.xdata.DeleteFeatureLayerRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteFeatureLayerResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteFeatureLayerResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.service.VoidResponse @return;

                public deleteFeatureLayerResponse() {
                }

                public deleteFeatureLayerResponse(com.ptvgroup.xserver.service.VoidResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="listFeatureLayers", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class listFeatureLayers {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.ListFeatureLayersRequest request;

                public listFeatureLayers() {
                }

                public listFeatureLayers(com.ptvgroup.xserver.xdata.ListFeatureLayersRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="listFeatureLayersResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class listFeatureLayersResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.FeatureLayersListResponse @return;

                public listFeatureLayersResponse() {
                }

                public listFeatureLayersResponse(com.ptvgroup.xserver.xdata.FeatureLayersListResponse @return) {
                    this.@return = @return;
                }
            }


            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchFeatureLayerResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchFeatureLayerResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchFeatureLayerResponse() {
                }

                public fetchFeatureLayerResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchFeatureLayerResponseResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchFeatureLayerResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.FeatureLayerResponse @return;

                public fetchFeatureLayerResponseResponse() {
                }

                public fetchFeatureLayerResponseResponse(com.ptvgroup.xserver.xdata.FeatureLayerResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchHighPerformanceRoutingNetworkResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchHighPerformanceRoutingNetworkResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchHighPerformanceRoutingNetworkResponse() {
                }

                public fetchHighPerformanceRoutingNetworkResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchHighPerformanceRoutingNetworkResponseResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchHighPerformanceRoutingNetworkResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkResponse @return;

                public fetchHighPerformanceRoutingNetworkResponseResponse() {
                }

                public fetchHighPerformanceRoutingNetworkResponseResponse(com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJob", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJobResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJob", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJobResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJob", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJobResponse", WrapperNamespace="http://xdata.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdata.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public deleteJobResponse() {
                }

                public deleteJobResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XDataChannel : com.ptvgroup.xserver.xdata.XData, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XDataClient : System.ServiceModel.ClientBase<com.ptvgroup.xserver.xdata.XData>, com.ptvgroup.xserver.xdata.XData {

        public XDataClient() :
            this("http://localhost:50000/services/ws/XData/experimental") {
        }

        public XDataClient(string baseUri ) :
            this(new System.ServiceModel.BasicHttpBinding { MaxReceivedMessageSize = System.Int32.MaxValue }, new System.ServiceModel.EndpointAddress(baseUri+"/services/ws/XData/experimental/")) {
        }

        public XDataClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress) {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdata.getSegmentsResponse com.ptvgroup.xserver.xdata.XData.getSegments(com.ptvgroup.xserver.xdata.getSegments request) {
            return base.Channel.getSegments(request);
        }

        public com.ptvgroup.xserver.xdata.SegmentsResponse getSegments(com.ptvgroup.xserver.xdata.SegmentsRequest request) {
            com.ptvgroup.xserver.xdata.getSegments inValue = new com.ptvgroup.xserver.xdata.getSegments();
            inValue.request = request;
            com.ptvgroup.xserver.xdata.getSegmentsResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).getSegments(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdata.getTimeZoneResponse com.ptvgroup.xserver.xdata.XData.getTimeZone(com.ptvgroup.xserver.xdata.getTimeZone request) {
            return base.Channel.getTimeZone(request);
        }

        public com.ptvgroup.xserver.xdata.TimeZoneResponse getTimeZone(com.ptvgroup.xserver.xdata.TimeZoneRequest request) {
            com.ptvgroup.xserver.xdata.getTimeZone inValue = new com.ptvgroup.xserver.xdata.getTimeZone();
            inValue.request = request;
            com.ptvgroup.xserver.xdata.getTimeZoneResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).getTimeZone(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdata.createContentSnapshotResponse com.ptvgroup.xserver.xdata.XData.createContentSnapshot(com.ptvgroup.xserver.xdata.createContentSnapshot request) {
            return base.Channel.createContentSnapshot(request);
        }

        public com.ptvgroup.xserver.xdata.ContentSnapshotResponse createContentSnapshot(com.ptvgroup.xserver.xdata.CreateContentSnapshotRequest request) {
            com.ptvgroup.xserver.xdata.createContentSnapshot inValue = new com.ptvgroup.xserver.xdata.createContentSnapshot();
            inValue.request = request;
            com.ptvgroup.xserver.xdata.createContentSnapshotResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).createContentSnapshot(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdata.deleteContentSnapshotResponse com.ptvgroup.xserver.xdata.XData.deleteContentSnapshot(com.ptvgroup.xserver.xdata.deleteContentSnapshot request) {
            return base.Channel.deleteContentSnapshot(request);
        }

        public com.ptvgroup.xserver.service.VoidResponse deleteContentSnapshot(com.ptvgroup.xserver.xdata.DeleteContentSnapshotRequest request) {
            com.ptvgroup.xserver.xdata.deleteContentSnapshot inValue = new com.ptvgroup.xserver.xdata.deleteContentSnapshot();
            inValue.request = request;
            com.ptvgroup.xserver.xdata.deleteContentSnapshotResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).deleteContentSnapshot(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdata.listContentSnapshotsResponse com.ptvgroup.xserver.xdata.XData.listContentSnapshots(com.ptvgroup.xserver.xdata.listContentSnapshots request) {
            return base.Channel.listContentSnapshots(request);
        }

        public com.ptvgroup.xserver.xdata.ContentSnapshotsListResponse listContentSnapshots(com.ptvgroup.xserver.xdata.ListContentSnapshotsRequest request) {
            com.ptvgroup.xserver.xdata.listContentSnapshots inValue = new com.ptvgroup.xserver.xdata.listContentSnapshots();
            inValue.request = request;
            com.ptvgroup.xserver.xdata.listContentSnapshotsResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).listContentSnapshots(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdata.startCreateHighPerformanceRoutingNetworkResponse com.ptvgroup.xserver.xdata.XData.startCreateHighPerformanceRoutingNetwork(com.ptvgroup.xserver.xdata.startCreateHighPerformanceRoutingNetwork request) {
                return base.Channel.startCreateHighPerformanceRoutingNetwork(request);
            }

            public com.ptvgroup.xserver.jobs.Job startCreateHighPerformanceRoutingNetwork(com.ptvgroup.xserver.xdata.CreateHighPerformanceRoutingNetworkRequest request) {
                com.ptvgroup.xserver.xdata.startCreateHighPerformanceRoutingNetwork inValue = new com.ptvgroup.xserver.xdata.startCreateHighPerformanceRoutingNetwork();
                inValue.request = request;
                com.ptvgroup.xserver.xdata.startCreateHighPerformanceRoutingNetworkResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).startCreateHighPerformanceRoutingNetwork(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdata.deleteHighPerformanceRoutingNetworkResponse com.ptvgroup.xserver.xdata.XData.deleteHighPerformanceRoutingNetwork(com.ptvgroup.xserver.xdata.deleteHighPerformanceRoutingNetwork request) {
            return base.Channel.deleteHighPerformanceRoutingNetwork(request);
        }

        public com.ptvgroup.xserver.service.VoidResponse deleteHighPerformanceRoutingNetwork(com.ptvgroup.xserver.xdata.DeleteHighPerformanceRoutingNetworkRequest request) {
            com.ptvgroup.xserver.xdata.deleteHighPerformanceRoutingNetwork inValue = new com.ptvgroup.xserver.xdata.deleteHighPerformanceRoutingNetwork();
            inValue.request = request;
            com.ptvgroup.xserver.xdata.deleteHighPerformanceRoutingNetworkResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).deleteHighPerformanceRoutingNetwork(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdata.listHighPerformanceRoutingNetworksResponse com.ptvgroup.xserver.xdata.XData.listHighPerformanceRoutingNetworks(com.ptvgroup.xserver.xdata.listHighPerformanceRoutingNetworks request) {
            return base.Channel.listHighPerformanceRoutingNetworks(request);
        }

        public com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworksListResponse listHighPerformanceRoutingNetworks(com.ptvgroup.xserver.xdata.ListHighPerformanceRoutingNetworksRequest request) {
            com.ptvgroup.xserver.xdata.listHighPerformanceRoutingNetworks inValue = new com.ptvgroup.xserver.xdata.listHighPerformanceRoutingNetworks();
            inValue.request = request;
            com.ptvgroup.xserver.xdata.listHighPerformanceRoutingNetworksResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).listHighPerformanceRoutingNetworks(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdata.createFeatureLayerResponse com.ptvgroup.xserver.xdata.XData.createFeatureLayer(com.ptvgroup.xserver.xdata.createFeatureLayer request) {
            return base.Channel.createFeatureLayer(request);
        }

        public com.ptvgroup.xserver.xdata.FeatureLayerResponse createFeatureLayer(com.ptvgroup.xserver.xdata.CreateFeatureLayerRequest request) {
            com.ptvgroup.xserver.xdata.createFeatureLayer inValue = new com.ptvgroup.xserver.xdata.createFeatureLayer();
            inValue.request = request;
            com.ptvgroup.xserver.xdata.createFeatureLayerResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).createFeatureLayer(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdata.startCreateFeatureLayerResponse com.ptvgroup.xserver.xdata.XData.startCreateFeatureLayer(com.ptvgroup.xserver.xdata.startCreateFeatureLayer request) {
                return base.Channel.startCreateFeatureLayer(request);
            }

            public com.ptvgroup.xserver.jobs.Job startCreateFeatureLayer(com.ptvgroup.xserver.xdata.CreateFeatureLayerRequest request) {
                com.ptvgroup.xserver.xdata.startCreateFeatureLayer inValue = new com.ptvgroup.xserver.xdata.startCreateFeatureLayer();
                inValue.request = request;
                com.ptvgroup.xserver.xdata.startCreateFeatureLayerResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).startCreateFeatureLayer(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdata.deleteFeatureLayerResponse com.ptvgroup.xserver.xdata.XData.deleteFeatureLayer(com.ptvgroup.xserver.xdata.deleteFeatureLayer request) {
            return base.Channel.deleteFeatureLayer(request);
        }

        public com.ptvgroup.xserver.service.VoidResponse deleteFeatureLayer(com.ptvgroup.xserver.xdata.DeleteFeatureLayerRequest request) {
            com.ptvgroup.xserver.xdata.deleteFeatureLayer inValue = new com.ptvgroup.xserver.xdata.deleteFeatureLayer();
            inValue.request = request;
            com.ptvgroup.xserver.xdata.deleteFeatureLayerResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).deleteFeatureLayer(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdata.listFeatureLayersResponse com.ptvgroup.xserver.xdata.XData.listFeatureLayers(com.ptvgroup.xserver.xdata.listFeatureLayers request) {
            return base.Channel.listFeatureLayers(request);
        }

        public com.ptvgroup.xserver.xdata.FeatureLayersListResponse listFeatureLayers(com.ptvgroup.xserver.xdata.ListFeatureLayersRequest request) {
            com.ptvgroup.xserver.xdata.listFeatureLayers inValue = new com.ptvgroup.xserver.xdata.listFeatureLayers();
            inValue.request = request;
            com.ptvgroup.xserver.xdata.listFeatureLayersResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).listFeatureLayers(inValue);
            return retVal.@return;
        }


            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdata.fetchFeatureLayerResponseResponse com.ptvgroup.xserver.xdata.XData.fetchFeatureLayerResponse(com.ptvgroup.xserver.xdata.fetchFeatureLayerResponse request) {
                return base.Channel.fetchFeatureLayerResponse(request);
            }

            public com.ptvgroup.xserver.xdata.FeatureLayerResponse fetchFeatureLayerResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xdata.fetchFeatureLayerResponse inValue = new com.ptvgroup.xserver.xdata.fetchFeatureLayerResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xdata.fetchFeatureLayerResponseResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).fetchFeatureLayerResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdata.fetchHighPerformanceRoutingNetworkResponseResponse com.ptvgroup.xserver.xdata.XData.fetchHighPerformanceRoutingNetworkResponse(com.ptvgroup.xserver.xdata.fetchHighPerformanceRoutingNetworkResponse request) {
                return base.Channel.fetchHighPerformanceRoutingNetworkResponse(request);
            }

            public com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkResponse fetchHighPerformanceRoutingNetworkResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xdata.fetchHighPerformanceRoutingNetworkResponse inValue = new com.ptvgroup.xserver.xdata.fetchHighPerformanceRoutingNetworkResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xdata.fetchHighPerformanceRoutingNetworkResponseResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).fetchHighPerformanceRoutingNetworkResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdata.watchJobResponse com.ptvgroup.xserver.xdata.XData.watchJob(com.ptvgroup.xserver.xdata.watchJob request) {
                return base.Channel.watchJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job watchJob(com.ptvgroup.xserver.jobs.WatchRequest request) {
                com.ptvgroup.xserver.xdata.watchJob inValue = new com.ptvgroup.xserver.xdata.watchJob();
                inValue.request = request;
                com.ptvgroup.xserver.xdata.watchJobResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).watchJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdata.stopJobResponse com.ptvgroup.xserver.xdata.XData.stopJob(com.ptvgroup.xserver.xdata.stopJob request) {
                return base.Channel.stopJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job stopJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xdata.stopJob inValue = new com.ptvgroup.xserver.xdata.stopJob();
                inValue.request = request;
                com.ptvgroup.xserver.xdata.stopJobResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).stopJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdata.deleteJobResponse com.ptvgroup.xserver.xdata.XData.deleteJob(com.ptvgroup.xserver.xdata.deleteJob request) {
                return base.Channel.deleteJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job deleteJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xdata.deleteJob inValue = new com.ptvgroup.xserver.xdata.deleteJob();
                inValue.request = request;
                com.ptvgroup.xserver.xdata.deleteJobResponse retVal = ((com.ptvgroup.xserver.xdata.XData)(this)).deleteJob(inValue);
                return retVal.@return;
            }

   }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class ContentSnapshotDescription : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private string labelField;
        private string tenantField;
        private string scopeField;
        private System.DateTime createdAtField;
        private bool createdAtFieldSpecified;
        private System.DateTime lastUsedAtField;
        private bool lastUsedAtFieldSpecified;
        private long sizeField;
        private bool sizeFieldSpecified;

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
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
                this.RaisePropertyChanged("label");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tenant {
            get {
                return this.tenantField;
            }
            set {
                this.tenantField = value;
                this.RaisePropertyChanged("tenant");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
                this.RaisePropertyChanged("scope");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime createdAt {
            get {
                return this.createdAtField;
            }
            set {
                this.createdAtField = value;
                this.RaisePropertyChanged("createdAt");
                this.createdAtFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdAtSpecified {
            get {
                return this.createdAtFieldSpecified;
            }
            set {
                this.createdAtFieldSpecified = value;
                this.RaisePropertyChanged("createdAtSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime lastUsedAt {
            get {
                return this.lastUsedAtField;
            }
            set {
                this.lastUsedAtField = value;
                this.RaisePropertyChanged("lastUsedAt");
                this.lastUsedAtFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastUsedAtSpecified {
            get {
                return this.lastUsedAtFieldSpecified;
            }
            set {
                this.lastUsedAtFieldSpecified = value;
                this.RaisePropertyChanged("lastUsedAtSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
                this.RaisePropertyChanged("size");
                this.sizeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeSpecified {
            get {
                return this.sizeFieldSpecified;
            }
            set {
                this.sizeFieldSpecified = value;
                this.RaisePropertyChanged("sizeSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class ContentSnapshotInformation : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xdata.ContentSnapshotDescription contentSnapshotDescriptionField;
        private com.ptvgroup.xserver.exceptions.SuppressedXServerException listExceptionField;

                    [System.Xml.Serialization.XmlElementAttribute("contentSnapshotDescription", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.ContentSnapshotDescription contentSnapshotDescription {
            get {
                return this.contentSnapshotDescriptionField;
            }
            set {
                this.contentSnapshotDescriptionField = value;
                this.RaisePropertyChanged("contentSnapshotDescription");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("listException", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.exceptions.SuppressedXServerException listException {
            get {
                return this.listExceptionField;
            }
            set {
                this.listExceptionField = value;
                this.RaisePropertyChanged("listException");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class ContentSnapshotResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xdata.ContentSnapshotDescription contentSnapshotDescriptionField;

                    [System.Xml.Serialization.XmlElementAttribute("contentSnapshotDescription", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.ContentSnapshotDescription contentSnapshotDescription {
            get {
                return this.contentSnapshotDescriptionField;
            }
            set {
                this.contentSnapshotDescriptionField = value;
                this.RaisePropertyChanged("contentSnapshotDescription");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class ContentSnapshotsListResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xdata.ContentSnapshotInformation[] contentSnapshotInformationField;

                    [System.Xml.Serialization.XmlElementAttribute("contentSnapshotInformation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.ContentSnapshotInformation[] contentSnapshotInformation {
            get {
                return this.contentSnapshotInformationField;
            }
            set {
                this.contentSnapshotInformationField = value;
                this.RaisePropertyChanged("contentSnapshotInformation");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class CreateContentSnapshotRequest : com.ptvgroup.xserver.service.RequestBase {

        private string labelField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
                this.RaisePropertyChanged("label");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class CreateFeatureLayerRequest : com.ptvgroup.xserver.service.RequestBase {

        private string themeIdField;
        private string featureScenarioField;
        private com.ptvgroup.xserver.xdata.Feature[] featuresField;
        private com.ptvgroup.xserver.xdata.CreateFeatureLayerResultFields resultFieldsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string themeId {
            get {
                return this.themeIdField;
            }
            set {
                this.themeIdField = value;
                this.RaisePropertyChanged("themeId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string featureScenario {
            get {
                return this.featureScenarioField;
            }
            set {
                this.featureScenarioField = value;
                this.RaisePropertyChanged("featureScenario");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("features", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.Feature[] features {
            get {
                return this.featuresField;
            }
            set {
                this.featuresField = value;
                this.RaisePropertyChanged("features");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.CreateFeatureLayerResultFields resultFields {
            get {
                return this.resultFieldsField;
            }
            set {
                this.resultFieldsField = value;
                this.RaisePropertyChanged("resultFields");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class CreateFeatureLayerResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool binaryFeatureLayerField;
        private bool binaryFeatureLayerFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool binaryFeatureLayer {
            get {
                return this.binaryFeatureLayerField;
            }
            set {
                this.binaryFeatureLayerField = value;
                this.RaisePropertyChanged("binaryFeatureLayer");
                this.binaryFeatureLayerFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool binaryFeatureLayerSpecified {
            get {
                return this.binaryFeatureLayerFieldSpecified;
            }
            set {
                this.binaryFeatureLayerFieldSpecified = value;
                this.RaisePropertyChanged("binaryFeatureLayerSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class CreateHighPerformanceRoutingNetworkRequest : com.ptvgroup.xserver.service.RequestBase {

        private string labelField;
        private com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkOptions highPerformanceRoutingNetworkOptionsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
                this.RaisePropertyChanged("label");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("highPerformanceRoutingNetworkOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkOptions highPerformanceRoutingNetworkOptions {
            get {
                return this.highPerformanceRoutingNetworkOptionsField;
            }
            set {
                this.highPerformanceRoutingNetworkOptionsField = value;
                this.RaisePropertyChanged("highPerformanceRoutingNetworkOptions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class DeleteContentSnapshotRequest : com.ptvgroup.xserver.service.RequestBase {

        private string idField;

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class DeleteFeatureLayerRequest : com.ptvgroup.xserver.service.RequestBase {

        private string themeIdField;
        private string featureScenarioField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string themeId {
            get {
                return this.themeIdField;
            }
            set {
                this.themeIdField = value;
                this.RaisePropertyChanged("themeId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string featureScenario {
            get {
                return this.featureScenarioField;
            }
            set {
                this.featureScenarioField = value;
                this.RaisePropertyChanged("featureScenario");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class DeleteHighPerformanceRoutingNetworkRequest : com.ptvgroup.xserver.service.RequestBase {

        private string idField;

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class Feature : object, System.ComponentModel.INotifyPropertyChanged {

        private string[] segmentIdsField;
        private com.ptvgroup.xserver.segments.SegmentDirection directionField;
        private bool directionFieldSpecified;
        private com.ptvgroup.xserver.xdata.FeatureDescription[] descriptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("segmentIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] segmentIds {
            get {
                return this.segmentIdsField;
            }
            set {
                this.segmentIdsField = value;
                this.RaisePropertyChanged("segmentIds");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.segments.SegmentDirection direction {
            get {
                return this.directionField;
            }
            set {
                this.directionField = value;
                this.RaisePropertyChanged("direction");
                this.directionFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directionSpecified {
            get {
                return this.directionFieldSpecified;
            }
            set {
                this.directionFieldSpecified = value;
                this.RaisePropertyChanged("directionSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("descriptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.FeatureDescription[] descriptions {
            get {
                return this.descriptionsField;
            }
            set {
                this.descriptionsField = value;
                this.RaisePropertyChanged("descriptions");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class FeatureDescription : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.types.KeyValuePair[] attributesField;
        private string timeDomainField;

                    [System.Xml.Serialization.XmlElementAttribute("attributes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.KeyValuePair[] attributes {
            get {
                return this.attributesField;
            }
            set {
                this.attributesField = value;
                this.RaisePropertyChanged("attributes");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string timeDomain {
            get {
                return this.timeDomainField;
            }
            set {
                this.timeDomainField = value;
                this.RaisePropertyChanged("timeDomain");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class FeatureLayerDescription : object, System.ComponentModel.INotifyPropertyChanged {

        private string themeIdField;
        private string featureScenarioField;
        private string tenantField;
        private string scopeField;
        private System.DateTime createdAtField;
        private bool createdAtFieldSpecified;
        private System.DateTime lastUsedAtField;
        private bool lastUsedAtFieldSpecified;
        private long sizeField;
        private bool sizeFieldSpecified;
        private string providerInformationField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string themeId {
            get {
                return this.themeIdField;
            }
            set {
                this.themeIdField = value;
                this.RaisePropertyChanged("themeId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string featureScenario {
            get {
                return this.featureScenarioField;
            }
            set {
                this.featureScenarioField = value;
                this.RaisePropertyChanged("featureScenario");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tenant {
            get {
                return this.tenantField;
            }
            set {
                this.tenantField = value;
                this.RaisePropertyChanged("tenant");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
                this.RaisePropertyChanged("scope");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime createdAt {
            get {
                return this.createdAtField;
            }
            set {
                this.createdAtField = value;
                this.RaisePropertyChanged("createdAt");
                this.createdAtFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdAtSpecified {
            get {
                return this.createdAtFieldSpecified;
            }
            set {
                this.createdAtFieldSpecified = value;
                this.RaisePropertyChanged("createdAtSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime lastUsedAt {
            get {
                return this.lastUsedAtField;
            }
            set {
                this.lastUsedAtField = value;
                this.RaisePropertyChanged("lastUsedAt");
                this.lastUsedAtFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastUsedAtSpecified {
            get {
                return this.lastUsedAtFieldSpecified;
            }
            set {
                this.lastUsedAtFieldSpecified = value;
                this.RaisePropertyChanged("lastUsedAtSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
                this.RaisePropertyChanged("size");
                this.sizeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeSpecified {
            get {
                return this.sizeFieldSpecified;
            }
            set {
                this.sizeFieldSpecified = value;
                this.RaisePropertyChanged("sizeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string providerInformation {
            get {
                return this.providerInformationField;
            }
            set {
                this.providerInformationField = value;
                this.RaisePropertyChanged("providerInformation");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class FeatureLayerInformation : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xdata.FeatureLayerDescription featureLayerDescriptionField;
        private com.ptvgroup.xserver.exceptions.SuppressedXServerException listExceptionField;

                    [System.Xml.Serialization.XmlElementAttribute("featureLayerDescription", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.FeatureLayerDescription featureLayerDescription {
            get {
                return this.featureLayerDescriptionField;
            }
            set {
                this.featureLayerDescriptionField = value;
                this.RaisePropertyChanged("featureLayerDescription");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("listException", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.exceptions.SuppressedXServerException listException {
            get {
                return this.listExceptionField;
            }
            set {
                this.listExceptionField = value;
                this.RaisePropertyChanged("listException");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class FeatureLayerResponse : com.ptvgroup.xserver.service.ResponseBase {

        private string binaryFeatureLayerField;
        private com.ptvgroup.xserver.xdata.FeatureLayerDescription featureLayerDescriptionField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string binaryFeatureLayer {
            get {
                return this.binaryFeatureLayerField;
            }
            set {
                this.binaryFeatureLayerField = value;
                this.RaisePropertyChanged("binaryFeatureLayer");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("featureLayerDescription", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.FeatureLayerDescription featureLayerDescription {
            get {
                return this.featureLayerDescriptionField;
            }
            set {
                this.featureLayerDescriptionField = value;
                this.RaisePropertyChanged("featureLayerDescription");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class FeatureLayersListResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xdata.FeatureLayerInformation[] featureLayerInformationField;

                    [System.Xml.Serialization.XmlElementAttribute("featureLayerInformation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.FeatureLayerInformation[] featureLayerInformation {
            get {
                return this.featureLayerInformationField;
            }
            set {
                this.featureLayerInformationField = value;
                this.RaisePropertyChanged("featureLayerInformation");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class HighPerformanceRoutingNetworkAlreadyAvailableLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string idField;

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class HighPerformanceRoutingNetworkDescription : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private string labelField;
        private com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkOptions highPerformanceRoutingNetworkOptionsField;
        private com.ptvgroup.xserver.profile.RequestProfile profileField;
        private string tenantField;
        private string scopeField;
        private System.DateTime lastUsedAtField;
        private bool lastUsedAtFieldSpecified;
        private long sizeField;
        private bool sizeFieldSpecified;

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
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
                this.RaisePropertyChanged("label");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("highPerformanceRoutingNetworkOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkOptions highPerformanceRoutingNetworkOptions {
            get {
                return this.highPerformanceRoutingNetworkOptionsField;
            }
            set {
                this.highPerformanceRoutingNetworkOptionsField = value;
                this.RaisePropertyChanged("highPerformanceRoutingNetworkOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("profile", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.profile.RequestProfile profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
                this.RaisePropertyChanged("profile");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tenant {
            get {
                return this.tenantField;
            }
            set {
                this.tenantField = value;
                this.RaisePropertyChanged("tenant");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
                this.RaisePropertyChanged("scope");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime lastUsedAt {
            get {
                return this.lastUsedAtField;
            }
            set {
                this.lastUsedAtField = value;
                this.RaisePropertyChanged("lastUsedAt");
                this.lastUsedAtFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastUsedAtSpecified {
            get {
                return this.lastUsedAtFieldSpecified;
            }
            set {
                this.lastUsedAtFieldSpecified = value;
                this.RaisePropertyChanged("lastUsedAtSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
                this.RaisePropertyChanged("size");
                this.sizeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeSpecified {
            get {
                return this.sizeFieldSpecified;
            }
            set {
                this.sizeFieldSpecified = value;
                this.RaisePropertyChanged("sizeSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class HighPerformanceRoutingNetworkInformation : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkDescription highPerformanceRoutingNetworkDescriptionField;
        private com.ptvgroup.xserver.exceptions.SuppressedXServerException listExceptionField;

                    [System.Xml.Serialization.XmlElementAttribute("highPerformanceRoutingNetworkDescription", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkDescription highPerformanceRoutingNetworkDescription {
            get {
                return this.highPerformanceRoutingNetworkDescriptionField;
            }
            set {
                this.highPerformanceRoutingNetworkDescriptionField = value;
                this.RaisePropertyChanged("highPerformanceRoutingNetworkDescription");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("listException", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.exceptions.SuppressedXServerException listException {
            get {
                return this.listExceptionField;
            }
            set {
                this.listExceptionField = value;
                this.RaisePropertyChanged("listException");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class HighPerformanceRoutingNetworkOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.timeconsideration.TimeConsideration timeConsiderationField;
        private string contentSnapshotIdField;
        private com.ptvgroup.xserver.routing.GeographicRestrictions geographicRestrictionsField;

                    [System.Xml.Serialization.XmlElementAttribute("timeConsideration", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.timeconsideration.TimeConsideration timeConsideration {
            get {
                return this.timeConsiderationField;
            }
            set {
                this.timeConsiderationField = value;
                this.RaisePropertyChanged("timeConsideration");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contentSnapshotId {
            get {
                return this.contentSnapshotIdField;
            }
            set {
                this.contentSnapshotIdField = value;
                this.RaisePropertyChanged("contentSnapshotId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("geographicRestrictions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.GeographicRestrictions geographicRestrictions {
            get {
                return this.geographicRestrictionsField;
            }
            set {
                this.geographicRestrictionsField = value;
                this.RaisePropertyChanged("geographicRestrictions");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class HighPerformanceRoutingNetworkProgress : com.ptvgroup.xserver.jobs.JobProgress {

        private com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkProgressStatus statusField;
        private double progressField;
        private bool progressFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkProgressStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double progress {
            get {
                return this.progressField;
            }
            set {
                this.progressField = value;
                this.RaisePropertyChanged("progress");
                this.progressFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool progressSpecified {
            get {
                return this.progressFieldSpecified;
            }
            set {
                this.progressFieldSpecified = value;
                this.RaisePropertyChanged("progressSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class HighPerformanceRoutingNetworkResponse : com.ptvgroup.xserver.service.ResponseBase {

        private string idField;

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class HighPerformanceRoutingNetworksListResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkInformation[] highPerformanceRoutingNetworkInformationField;

                    [System.Xml.Serialization.XmlElementAttribute("highPerformanceRoutingNetworkInformation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkInformation[] highPerformanceRoutingNetworkInformation {
            get {
                return this.highPerformanceRoutingNetworkInformationField;
            }
            set {
                this.highPerformanceRoutingNetworkInformationField = value;
                this.RaisePropertyChanged("highPerformanceRoutingNetworkInformation");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class IncludedNetworkClasses : object, System.ComponentModel.INotifyPropertyChanged {

        private bool[] includedField;

                    [System.Xml.Serialization.XmlElementAttribute("included", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool[] included {
            get {
                return this.includedField;
            }
            set {
                this.includedField = value;
                this.RaisePropertyChanged("included");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class ListContentSnapshotsRequest : com.ptvgroup.xserver.service.RequestBase {

        private string[] idsField;

                    [System.Xml.Serialization.XmlElementAttribute("ids", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] ids {
            get {
                return this.idsField;
            }
            set {
                this.idsField = value;
                this.RaisePropertyChanged("ids");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class ListFeatureLayersRequest : com.ptvgroup.xserver.service.RequestBase {

        private string[] themeIdsField;

                    [System.Xml.Serialization.XmlElementAttribute("themeIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] themeIds {
            get {
                return this.themeIdsField;
            }
            set {
                this.themeIdsField = value;
                this.RaisePropertyChanged("themeIds");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class ListHighPerformanceRoutingNetworksRequest : com.ptvgroup.xserver.service.RequestBase {

        private string[] idsField;
        private bool returnOnlyMatchingNetworksField;
        private bool returnOnlyMatchingNetworksFieldSpecified;
        private com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkOptions highPerformanceRoutingNetworkOptionsField;
        private com.ptvgroup.xserver.xdata.ListHighPerformanceRoutingNetworksResultFields resultFieldsField;

                    [System.Xml.Serialization.XmlElementAttribute("ids", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] ids {
            get {
                return this.idsField;
            }
            set {
                this.idsField = value;
                this.RaisePropertyChanged("ids");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool returnOnlyMatchingNetworks {
            get {
                return this.returnOnlyMatchingNetworksField;
            }
            set {
                this.returnOnlyMatchingNetworksField = value;
                this.RaisePropertyChanged("returnOnlyMatchingNetworks");
                this.returnOnlyMatchingNetworksFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool returnOnlyMatchingNetworksSpecified {
            get {
                return this.returnOnlyMatchingNetworksFieldSpecified;
            }
            set {
                this.returnOnlyMatchingNetworksFieldSpecified = value;
                this.RaisePropertyChanged("returnOnlyMatchingNetworksSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("highPerformanceRoutingNetworkOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkOptions highPerformanceRoutingNetworkOptions {
            get {
                return this.highPerformanceRoutingNetworkOptionsField;
            }
            set {
                this.highPerformanceRoutingNetworkOptionsField = value;
                this.RaisePropertyChanged("highPerformanceRoutingNetworkOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.ListHighPerformanceRoutingNetworksResultFields resultFields {
            get {
                return this.resultFieldsField;
            }
            set {
                this.resultFieldsField = value;
                this.RaisePropertyChanged("resultFields");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class ListHighPerformanceRoutingNetworksResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool highPerformanceRoutingNetworkOptionsField;
        private bool highPerformanceRoutingNetworkOptionsFieldSpecified;
        private bool profilesField;
        private bool profilesFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool highPerformanceRoutingNetworkOptions {
            get {
                return this.highPerformanceRoutingNetworkOptionsField;
            }
            set {
                this.highPerformanceRoutingNetworkOptionsField = value;
                this.RaisePropertyChanged("highPerformanceRoutingNetworkOptions");
                this.highPerformanceRoutingNetworkOptionsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool highPerformanceRoutingNetworkOptionsSpecified {
            get {
                return this.highPerformanceRoutingNetworkOptionsFieldSpecified;
            }
            set {
                this.highPerformanceRoutingNetworkOptionsFieldSpecified = value;
                this.RaisePropertyChanged("highPerformanceRoutingNetworkOptionsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool profiles {
            get {
                return this.profilesField;
            }
            set {
                this.profilesField = value;
                this.RaisePropertyChanged("profiles");
                this.profilesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool profilesSpecified {
            get {
                return this.profilesFieldSpecified;
            }
            set {
                this.profilesFieldSpecified = value;
                this.RaisePropertyChanged("profilesSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class MapSegment : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.segments.SegmentType typeField;
        private com.ptvgroup.xserver.geometry.EncodedGeometry polylineField;
        private com.ptvgroup.xserver.segments.SegmentDescriptors descriptorsField;
        private com.ptvgroup.xserver.segments.CombinedTransportAttributes combinedTransportField;
        private string idField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.segments.SegmentType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
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

                    [System.Xml.Serialization.XmlElementAttribute("descriptors", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.segments.SegmentDescriptors descriptors {
            get {
                return this.descriptorsField;
            }
            set {
                this.descriptorsField = value;
                this.RaisePropertyChanged("descriptors");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("combinedTransport", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.segments.CombinedTransportAttributes combinedTransport {
            get {
                return this.combinedTransportField;
            }
            set {
                this.combinedTransportField = value;
                this.RaisePropertyChanged("combinedTransport");
            }
        }

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class SegmentsByCoordinateRequest : com.ptvgroup.xserver.xdata.SegmentsRequest {

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class SegmentsByIdRequest : com.ptvgroup.xserver.xdata.SegmentsRequest {

        private string[] idsField;

                    [System.Xml.Serialization.XmlElementAttribute("ids", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] ids {
            get {
                return this.idsField;
            }
            set {
                this.idsField = value;
                this.RaisePropertyChanged("ids");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class SegmentsByIntersectingPolylineRequest : com.ptvgroup.xserver.xdata.SegmentsRequest {

        private com.ptvgroup.xserver.geometry.EncodedGeometry polylineField;

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class SegmentsBySurroundingPolygonRequest : com.ptvgroup.xserver.xdata.SegmentsRequest {

        private com.ptvgroup.xserver.geometry.EncodedGeometry polygonField;

                    [System.Xml.Serialization.XmlElementAttribute("polygon", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.EncodedGeometry polygon {
            get {
                return this.polygonField;
            }
            set {
                this.polygonField = value;
                this.RaisePropertyChanged("polygon");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class SegmentsOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xdata.IncludedNetworkClasses includedNetworkClassesField;
        private com.ptvgroup.xserver.segments.SegmentType[] includedSegmentTypesField;

                    [System.Xml.Serialization.XmlElementAttribute("includedNetworkClasses", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.IncludedNetworkClasses includedNetworkClasses {
            get {
                return this.includedNetworkClassesField;
            }
            set {
                this.includedNetworkClassesField = value;
                this.RaisePropertyChanged("includedNetworkClasses");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("includedSegmentTypes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.segments.SegmentType[] includedSegmentTypes {
            get {
                return this.includedSegmentTypesField;
            }
            set {
                this.includedSegmentTypesField = value;
                this.RaisePropertyChanged("includedSegmentTypes");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.SegmentsByCoordinateRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.SegmentsByIdRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.SegmentsByIntersectingPolylineRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.SegmentsBySurroundingPolygonRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public abstract partial class SegmentsRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xdata.SegmentsResultFields resultFieldsField;
        private com.ptvgroup.xserver.xdata.SegmentsOptions segmentsOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.SegmentsResultFields resultFields {
            get {
                return this.resultFieldsField;
            }
            set {
                this.resultFieldsField = value;
                this.RaisePropertyChanged("resultFields");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("segmentsOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.SegmentsOptions segmentsOptions {
            get {
                return this.segmentsOptionsField;
            }
            set {
                this.segmentsOptionsField = value;
                this.RaisePropertyChanged("segmentsOptions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class SegmentsResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xdata.MapSegment[] segmentsField;

                    [System.Xml.Serialization.XmlElementAttribute("segments", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdata.MapSegment[] segments {
            get {
                return this.segmentsField;
            }
            set {
                this.segmentsField = value;
                this.RaisePropertyChanged("segments");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class SegmentsResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool polylineField;
        private bool polylineFieldSpecified;
        private bool descriptorsField;
        private bool descriptorsFieldSpecified;
        private bool combinedTransportField;
        private bool combinedTransportFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool polyline {
            get {
                return this.polylineField;
            }
            set {
                this.polylineField = value;
                this.RaisePropertyChanged("polyline");
                this.polylineFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool polylineSpecified {
            get {
                return this.polylineFieldSpecified;
            }
            set {
                this.polylineFieldSpecified = value;
                this.RaisePropertyChanged("polylineSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool descriptors {
            get {
                return this.descriptorsField;
            }
            set {
                this.descriptorsField = value;
                this.RaisePropertyChanged("descriptors");
                this.descriptorsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool descriptorsSpecified {
            get {
                return this.descriptorsFieldSpecified;
            }
            set {
                this.descriptorsFieldSpecified = value;
                this.RaisePropertyChanged("descriptorsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool combinedTransport {
            get {
                return this.combinedTransportField;
            }
            set {
                this.combinedTransportField = value;
                this.RaisePropertyChanged("combinedTransport");
                this.combinedTransportFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool combinedTransportSpecified {
            get {
                return this.combinedTransportFieldSpecified;
            }
            set {
                this.combinedTransportFieldSpecified = value;
                this.RaisePropertyChanged("combinedTransportSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class TimeZoneRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.geometry.Coordinate coordinateField;
        private System.DateTime referenceDateField;
        private bool referenceDateFieldSpecified;

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

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime referenceDate {
            get {
                return this.referenceDateField;
            }
            set {
                this.referenceDateField = value;
                this.RaisePropertyChanged("referenceDate");
                this.referenceDateFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referenceDateSpecified {
            get {
                return this.referenceDateFieldSpecified;
            }
            set {
                this.referenceDateFieldSpecified = value;
                this.RaisePropertyChanged("referenceDateSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public partial class TimeZoneResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.types.TimeZone timeZoneField;

                    [System.Xml.Serialization.XmlElementAttribute("timeZone", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.TimeZone timeZone {
            get {
                return this.timeZoneField;
            }
            set {
                this.timeZoneField = value;
                this.RaisePropertyChanged("timeZone");
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdata.xserver.ptvgroup.com")]
    public enum HighPerformanceRoutingNetworkProgressStatus {
        /**
         * Indicates that some tasks have to be done before generating the high-performance routing network.
* The actual progress of this state is available in <a href="xdata.html#com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkProgress.progress">HighPerformanceRoutingNetworkProgress.progress</a>.
         */
        PREPROCESSING,

        /**
         * Indicates the generation of the high-performance routing network is ongoing.
* The actual progress of this state is available in <a href="xdata.html#com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkProgress.progress">HighPerformanceRoutingNetworkProgress.progress</a>.
         */
        GENERATING_NETWORK,

        /**
         * Indicates that the generation of the high-performance routing network is finished.
         */
        DONE
    }


}
