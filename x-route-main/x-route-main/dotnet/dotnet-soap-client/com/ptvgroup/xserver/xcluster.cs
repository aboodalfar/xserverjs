// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.xcluster 
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public interface XCluster {


            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.planClustersResponse planClusters(com.ptvgroup.xserver.xcluster.planClusters request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.startPlanClustersResponse startPlanClusters(com.ptvgroup.xserver.xcluster.startPlanClusters request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.coverLocationsResponse coverLocations(com.ptvgroup.xserver.xcluster.coverLocations request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.startCoverLocationsResponse startCoverLocations(com.ptvgroup.xserver.xcluster.startCoverLocations request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.planVisitsResponse planVisits(com.ptvgroup.xserver.xcluster.planVisits request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.startPlanVisitsResponse startPlanVisits(com.ptvgroup.xserver.xcluster.startPlanVisits request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.optimizeVisitSequenceResponse optimizeVisitSequence(com.ptvgroup.xserver.xcluster.optimizeVisitSequence request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.startOptimizeVisitSequenceResponse startOptimizeVisitSequence(com.ptvgroup.xserver.xcluster.startOptimizeVisitSequence request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.fetchClustersResponseResponse fetchClustersResponse(com.ptvgroup.xserver.xcluster.fetchClustersResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.fetchVisitSequenceResponseResponse fetchVisitSequenceResponse(com.ptvgroup.xserver.xcluster.fetchVisitSequenceResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.fetchVisitsResponseResponse fetchVisitsResponse(com.ptvgroup.xserver.xcluster.fetchVisitsResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.watchJobResponse watchJob(com.ptvgroup.xserver.xcluster.watchJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.stopJobResponse stopJob(com.ptvgroup.xserver.xcluster.stopJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xcluster.deleteJobResponse deleteJob(com.ptvgroup.xserver.xcluster.deleteJob request);
    }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="planClusters", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class planClusters {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.PlanClustersRequest request;

                public planClusters() {
                }

                public planClusters(com.ptvgroup.xserver.xcluster.PlanClustersRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="planClustersResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class planClustersResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.ClustersResponse @return;

                public planClustersResponse() {
                }

                public planClustersResponse(com.ptvgroup.xserver.xcluster.ClustersResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startPlanClusters", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startPlanClusters {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.PlanClustersRequest request;

                public startPlanClusters() {
                }

                public startPlanClusters(com.ptvgroup.xserver.xcluster.PlanClustersRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startPlanClustersResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startPlanClustersResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startPlanClustersResponse() {
                }

                public startPlanClustersResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="coverLocations", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class coverLocations {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.CoverLocationsRequest request;

                public coverLocations() {
                }

                public coverLocations(com.ptvgroup.xserver.xcluster.CoverLocationsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="coverLocationsResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class coverLocationsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.ClustersResponse @return;

                public coverLocationsResponse() {
                }

                public coverLocationsResponse(com.ptvgroup.xserver.xcluster.ClustersResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCoverLocations", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCoverLocations {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.CoverLocationsRequest request;

                public startCoverLocations() {
                }

                public startCoverLocations(com.ptvgroup.xserver.xcluster.CoverLocationsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCoverLocationsResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCoverLocationsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startCoverLocationsResponse() {
                }

                public startCoverLocationsResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="planVisits", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class planVisits {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.PlanVisitsRequest request;

                public planVisits() {
                }

                public planVisits(com.ptvgroup.xserver.xcluster.PlanVisitsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="planVisitsResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class planVisitsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.VisitsResponse @return;

                public planVisitsResponse() {
                }

                public planVisitsResponse(com.ptvgroup.xserver.xcluster.VisitsResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startPlanVisits", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startPlanVisits {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.PlanVisitsRequest request;

                public startPlanVisits() {
                }

                public startPlanVisits(com.ptvgroup.xserver.xcluster.PlanVisitsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startPlanVisitsResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startPlanVisitsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startPlanVisitsResponse() {
                }

                public startPlanVisitsResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="optimizeVisitSequence", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class optimizeVisitSequence {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.OptimizeVisitSequenceRequest request;

                public optimizeVisitSequence() {
                }

                public optimizeVisitSequence(com.ptvgroup.xserver.xcluster.OptimizeVisitSequenceRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="optimizeVisitSequenceResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class optimizeVisitSequenceResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.VisitSequenceResponse @return;

                public optimizeVisitSequenceResponse() {
                }

                public optimizeVisitSequenceResponse(com.ptvgroup.xserver.xcluster.VisitSequenceResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startOptimizeVisitSequence", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startOptimizeVisitSequence {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.OptimizeVisitSequenceRequest request;

                public startOptimizeVisitSequence() {
                }

                public startOptimizeVisitSequence(com.ptvgroup.xserver.xcluster.OptimizeVisitSequenceRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startOptimizeVisitSequenceResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startOptimizeVisitSequenceResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startOptimizeVisitSequenceResponse() {
                }

                public startOptimizeVisitSequenceResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchClustersResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchClustersResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchClustersResponse() {
                }

                public fetchClustersResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchClustersResponseResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchClustersResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.ClustersResponse @return;

                public fetchClustersResponseResponse() {
                }

                public fetchClustersResponseResponse(com.ptvgroup.xserver.xcluster.ClustersResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchVisitSequenceResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchVisitSequenceResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchVisitSequenceResponse() {
                }

                public fetchVisitSequenceResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchVisitSequenceResponseResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchVisitSequenceResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.VisitSequenceResponse @return;

                public fetchVisitSequenceResponseResponse() {
                }

                public fetchVisitSequenceResponseResponse(com.ptvgroup.xserver.xcluster.VisitSequenceResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchVisitsResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchVisitsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchVisitsResponse() {
                }

                public fetchVisitsResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchVisitsResponseResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchVisitsResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xcluster.VisitsResponse @return;

                public fetchVisitsResponseResponse() {
                }

                public fetchVisitsResponseResponse(com.ptvgroup.xserver.xcluster.VisitsResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJob", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJobResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJob", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJobResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJob", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJobResponse", WrapperNamespace="http://xcluster.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xcluster.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public deleteJobResponse() {
                }

                public deleteJobResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XClusterChannel : com.ptvgroup.xserver.xcluster.XCluster, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XClusterClient : System.ServiceModel.ClientBase<com.ptvgroup.xserver.xcluster.XCluster>, com.ptvgroup.xserver.xcluster.XCluster {

        public XClusterClient() :
            this("http://localhost:50000/services/ws/XCluster") {
        }

        public XClusterClient(string baseUri , string version="") :
            this(new System.ServiceModel.BasicHttpBinding { MaxReceivedMessageSize = System.Int32.MaxValue }, new System.ServiceModel.EndpointAddress(baseUri+"/services/ws/XCluster/"+version)) {
        }

        public XClusterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress) {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xcluster.planClustersResponse com.ptvgroup.xserver.xcluster.XCluster.planClusters(com.ptvgroup.xserver.xcluster.planClusters request) {
            return base.Channel.planClusters(request);
        }

        public com.ptvgroup.xserver.xcluster.ClustersResponse planClusters(com.ptvgroup.xserver.xcluster.PlanClustersRequest request) {
            com.ptvgroup.xserver.xcluster.planClusters inValue = new com.ptvgroup.xserver.xcluster.planClusters();
            inValue.request = request;
            com.ptvgroup.xserver.xcluster.planClustersResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).planClusters(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xcluster.startPlanClustersResponse com.ptvgroup.xserver.xcluster.XCluster.startPlanClusters(com.ptvgroup.xserver.xcluster.startPlanClusters request) {
                return base.Channel.startPlanClusters(request);
            }

            public com.ptvgroup.xserver.jobs.Job startPlanClusters(com.ptvgroup.xserver.xcluster.PlanClustersRequest request) {
                com.ptvgroup.xserver.xcluster.startPlanClusters inValue = new com.ptvgroup.xserver.xcluster.startPlanClusters();
                inValue.request = request;
                com.ptvgroup.xserver.xcluster.startPlanClustersResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).startPlanClusters(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xcluster.coverLocationsResponse com.ptvgroup.xserver.xcluster.XCluster.coverLocations(com.ptvgroup.xserver.xcluster.coverLocations request) {
            return base.Channel.coverLocations(request);
        }

        public com.ptvgroup.xserver.xcluster.ClustersResponse coverLocations(com.ptvgroup.xserver.xcluster.CoverLocationsRequest request) {
            com.ptvgroup.xserver.xcluster.coverLocations inValue = new com.ptvgroup.xserver.xcluster.coverLocations();
            inValue.request = request;
            com.ptvgroup.xserver.xcluster.coverLocationsResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).coverLocations(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xcluster.startCoverLocationsResponse com.ptvgroup.xserver.xcluster.XCluster.startCoverLocations(com.ptvgroup.xserver.xcluster.startCoverLocations request) {
                return base.Channel.startCoverLocations(request);
            }

            public com.ptvgroup.xserver.jobs.Job startCoverLocations(com.ptvgroup.xserver.xcluster.CoverLocationsRequest request) {
                com.ptvgroup.xserver.xcluster.startCoverLocations inValue = new com.ptvgroup.xserver.xcluster.startCoverLocations();
                inValue.request = request;
                com.ptvgroup.xserver.xcluster.startCoverLocationsResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).startCoverLocations(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xcluster.planVisitsResponse com.ptvgroup.xserver.xcluster.XCluster.planVisits(com.ptvgroup.xserver.xcluster.planVisits request) {
            return base.Channel.planVisits(request);
        }

        public com.ptvgroup.xserver.xcluster.VisitsResponse planVisits(com.ptvgroup.xserver.xcluster.PlanVisitsRequest request) {
            com.ptvgroup.xserver.xcluster.planVisits inValue = new com.ptvgroup.xserver.xcluster.planVisits();
            inValue.request = request;
            com.ptvgroup.xserver.xcluster.planVisitsResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).planVisits(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xcluster.startPlanVisitsResponse com.ptvgroup.xserver.xcluster.XCluster.startPlanVisits(com.ptvgroup.xserver.xcluster.startPlanVisits request) {
                return base.Channel.startPlanVisits(request);
            }

            public com.ptvgroup.xserver.jobs.Job startPlanVisits(com.ptvgroup.xserver.xcluster.PlanVisitsRequest request) {
                com.ptvgroup.xserver.xcluster.startPlanVisits inValue = new com.ptvgroup.xserver.xcluster.startPlanVisits();
                inValue.request = request;
                com.ptvgroup.xserver.xcluster.startPlanVisitsResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).startPlanVisits(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xcluster.optimizeVisitSequenceResponse com.ptvgroup.xserver.xcluster.XCluster.optimizeVisitSequence(com.ptvgroup.xserver.xcluster.optimizeVisitSequence request) {
            return base.Channel.optimizeVisitSequence(request);
        }

        public com.ptvgroup.xserver.xcluster.VisitSequenceResponse optimizeVisitSequence(com.ptvgroup.xserver.xcluster.OptimizeVisitSequenceRequest request) {
            com.ptvgroup.xserver.xcluster.optimizeVisitSequence inValue = new com.ptvgroup.xserver.xcluster.optimizeVisitSequence();
            inValue.request = request;
            com.ptvgroup.xserver.xcluster.optimizeVisitSequenceResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).optimizeVisitSequence(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xcluster.startOptimizeVisitSequenceResponse com.ptvgroup.xserver.xcluster.XCluster.startOptimizeVisitSequence(com.ptvgroup.xserver.xcluster.startOptimizeVisitSequence request) {
                return base.Channel.startOptimizeVisitSequence(request);
            }

            public com.ptvgroup.xserver.jobs.Job startOptimizeVisitSequence(com.ptvgroup.xserver.xcluster.OptimizeVisitSequenceRequest request) {
                com.ptvgroup.xserver.xcluster.startOptimizeVisitSequence inValue = new com.ptvgroup.xserver.xcluster.startOptimizeVisitSequence();
                inValue.request = request;
                com.ptvgroup.xserver.xcluster.startOptimizeVisitSequenceResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).startOptimizeVisitSequence(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xcluster.fetchClustersResponseResponse com.ptvgroup.xserver.xcluster.XCluster.fetchClustersResponse(com.ptvgroup.xserver.xcluster.fetchClustersResponse request) {
                return base.Channel.fetchClustersResponse(request);
            }

            public com.ptvgroup.xserver.xcluster.ClustersResponse fetchClustersResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xcluster.fetchClustersResponse inValue = new com.ptvgroup.xserver.xcluster.fetchClustersResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xcluster.fetchClustersResponseResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).fetchClustersResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xcluster.fetchVisitSequenceResponseResponse com.ptvgroup.xserver.xcluster.XCluster.fetchVisitSequenceResponse(com.ptvgroup.xserver.xcluster.fetchVisitSequenceResponse request) {
                return base.Channel.fetchVisitSequenceResponse(request);
            }

            public com.ptvgroup.xserver.xcluster.VisitSequenceResponse fetchVisitSequenceResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xcluster.fetchVisitSequenceResponse inValue = new com.ptvgroup.xserver.xcluster.fetchVisitSequenceResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xcluster.fetchVisitSequenceResponseResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).fetchVisitSequenceResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xcluster.fetchVisitsResponseResponse com.ptvgroup.xserver.xcluster.XCluster.fetchVisitsResponse(com.ptvgroup.xserver.xcluster.fetchVisitsResponse request) {
                return base.Channel.fetchVisitsResponse(request);
            }

            public com.ptvgroup.xserver.xcluster.VisitsResponse fetchVisitsResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xcluster.fetchVisitsResponse inValue = new com.ptvgroup.xserver.xcluster.fetchVisitsResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xcluster.fetchVisitsResponseResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).fetchVisitsResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xcluster.watchJobResponse com.ptvgroup.xserver.xcluster.XCluster.watchJob(com.ptvgroup.xserver.xcluster.watchJob request) {
                return base.Channel.watchJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job watchJob(com.ptvgroup.xserver.jobs.WatchRequest request) {
                com.ptvgroup.xserver.xcluster.watchJob inValue = new com.ptvgroup.xserver.xcluster.watchJob();
                inValue.request = request;
                com.ptvgroup.xserver.xcluster.watchJobResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).watchJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xcluster.stopJobResponse com.ptvgroup.xserver.xcluster.XCluster.stopJob(com.ptvgroup.xserver.xcluster.stopJob request) {
                return base.Channel.stopJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job stopJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xcluster.stopJob inValue = new com.ptvgroup.xserver.xcluster.stopJob();
                inValue.request = request;
                com.ptvgroup.xserver.xcluster.stopJobResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).stopJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xcluster.deleteJobResponse com.ptvgroup.xserver.xcluster.XCluster.deleteJob(com.ptvgroup.xserver.xcluster.deleteJob request) {
                return base.Channel.deleteJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job deleteJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xcluster.deleteJob inValue = new com.ptvgroup.xserver.xcluster.deleteJob();
                inValue.request = request;
                com.ptvgroup.xserver.xcluster.deleteJobResponse retVal = ((com.ptvgroup.xserver.xcluster.XCluster)(this)).deleteJob(inValue);
                return retVal.@return;
            }

   }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class ActivityCapacity : object, System.ComponentModel.INotifyPropertyChanged {

        private string clusterIdField;
        private double valueField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clusterId {
            get {
                return this.clusterIdField;
            }
            set {
                this.clusterIdField = value;
                this.RaisePropertyChanged("clusterId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("value");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class Cluster : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private com.ptvgroup.xserver.routing.RouteLocation referenceLocationField;

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

                    [System.Xml.Serialization.XmlElementAttribute("referenceLocation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation referenceLocation {
            get {
                return this.referenceLocationField;
            }
            set {
                this.referenceLocationField = value;
                this.RaisePropertyChanged("referenceLocation");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class ClusterCompatibility : object, System.ComponentModel.INotifyPropertyChanged {

        private string[] clusterIdsField;
        private bool compatibleField;

                    [System.Xml.Serialization.XmlElementAttribute("clusterIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] clusterIds {
            get {
                return this.clusterIdsField;
            }
            set {
                this.clusterIdsField = value;
                this.RaisePropertyChanged("clusterIds");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool compatible {
            get {
                return this.compatibleField;
            }
            set {
                this.compatibleField = value;
                this.RaisePropertyChanged("compatible");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class ClusterFacility : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xcluster.Cluster clusterField;
        private int costField;
        private bool costFieldSpecified;
        private double capacityField;
        private bool capacityFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("cluster", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.Cluster cluster {
            get {
                return this.clusterField;
            }
            set {
                this.clusterField = value;
                this.RaisePropertyChanged("cluster");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
                this.RaisePropertyChanged("cost");
                this.costFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costSpecified {
            get {
                return this.costFieldSpecified;
            }
            set {
                this.costFieldSpecified = value;
                this.RaisePropertyChanged("costSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double capacity {
            get {
                return this.capacityField;
            }
            set {
                this.capacityField = value;
                this.RaisePropertyChanged("capacity");
                this.capacityFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool capacitySpecified {
            get {
                return this.capacityFieldSpecified;
            }
            set {
                this.capacityFieldSpecified = value;
                this.RaisePropertyChanged("capacitySpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class ClusterPlanningProgress : com.ptvgroup.xserver.jobs.JobProgress {

        private com.ptvgroup.xserver.xcluster.ProgressStatus statusField;
        private double optimizationProgressField;
        private bool optimizationProgressFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xcluster.ProgressStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double optimizationProgress {
            get {
                return this.optimizationProgressField;
            }
            set {
                this.optimizationProgressField = value;
                this.RaisePropertyChanged("optimizationProgress");
                this.optimizationProgressFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool optimizationProgressSpecified {
            get {
                return this.optimizationProgressFieldSpecified;
            }
            set {
                this.optimizationProgressFieldSpecified = value;
                this.RaisePropertyChanged("optimizationProgressSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class ClusterReport : object, System.ComponentModel.INotifyPropertyChanged {

        private string clusterIdField;
        private double totalActivityField;
        private int numberOfLocationsField;
        private double estimatedTravelTimeToClusterField;
        private bool estimatedTravelTimeToClusterFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clusterId {
            get {
                return this.clusterIdField;
            }
            set {
                this.clusterIdField = value;
                this.RaisePropertyChanged("clusterId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double totalActivity {
            get {
                return this.totalActivityField;
            }
            set {
                this.totalActivityField = value;
                this.RaisePropertyChanged("totalActivity");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfLocations {
            get {
                return this.numberOfLocationsField;
            }
            set {
                this.numberOfLocationsField = value;
                this.RaisePropertyChanged("numberOfLocations");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double estimatedTravelTimeToCluster {
            get {
                return this.estimatedTravelTimeToClusterField;
            }
            set {
                this.estimatedTravelTimeToClusterField = value;
                this.RaisePropertyChanged("estimatedTravelTimeToCluster");
                this.estimatedTravelTimeToClusterFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedTravelTimeToClusterSpecified {
            get {
                return this.estimatedTravelTimeToClusterFieldSpecified;
            }
            set {
                this.estimatedTravelTimeToClusterFieldSpecified = value;
                this.RaisePropertyChanged("estimatedTravelTimeToClusterSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class ClusteredLocations : object, System.ComponentModel.INotifyPropertyChanged {

        private string clusterIdField;
        private string[] locationIdsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clusterId {
            get {
                return this.clusterIdField;
            }
            set {
                this.clusterIdField = value;
                this.RaisePropertyChanged("clusterId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("locationIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] locationIds {
            get {
                return this.locationIdsField;
            }
            set {
                this.locationIdsField = value;
                this.RaisePropertyChanged("locationIds");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class ClustersResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xcluster.Cluster[] clustersField;
        private com.ptvgroup.xserver.xcluster.ClusterReport[] clusterReportsField;
        private com.ptvgroup.xserver.xcluster.ClusteredLocations[] clusteredLocationsField;
        private string[] locationIdsNotPlannedField;
        private int totalClusterFacilityCostField;
        private bool totalClusterFacilityCostFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("clusters", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.Cluster[] clusters {
            get {
                return this.clustersField;
            }
            set {
                this.clustersField = value;
                this.RaisePropertyChanged("clusters");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("clusterReports", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.ClusterReport[] clusterReports {
            get {
                return this.clusterReportsField;
            }
            set {
                this.clusterReportsField = value;
                this.RaisePropertyChanged("clusterReports");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("clusteredLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.ClusteredLocations[] clusteredLocations {
            get {
                return this.clusteredLocationsField;
            }
            set {
                this.clusteredLocationsField = value;
                this.RaisePropertyChanged("clusteredLocations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("locationIdsNotPlanned", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] locationIdsNotPlanned {
            get {
                return this.locationIdsNotPlannedField;
            }
            set {
                this.locationIdsNotPlannedField = value;
                this.RaisePropertyChanged("locationIdsNotPlanned");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalClusterFacilityCost {
            get {
                return this.totalClusterFacilityCostField;
            }
            set {
                this.totalClusterFacilityCostField = value;
                this.RaisePropertyChanged("totalClusterFacilityCost");
                this.totalClusterFacilityCostFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalClusterFacilityCostSpecified {
            get {
                return this.totalClusterFacilityCostFieldSpecified;
            }
            set {
                this.totalClusterFacilityCostFieldSpecified = value;
                this.RaisePropertyChanged("totalClusterFacilityCostSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class CoverLocationsOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routing.Horizon coveringHorizonField;
        private com.ptvgroup.xserver.xcluster.OptimizationGoal optimizationGoalField;
        private string[] mandatoryLocationIdsField;
        private string[] mandatoryClusterIdsField;

                    [System.Xml.Serialization.XmlElementAttribute("coveringHorizon", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.Horizon coveringHorizon {
            get {
                return this.coveringHorizonField;
            }
            set {
                this.coveringHorizonField = value;
                this.RaisePropertyChanged("coveringHorizon");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("optimizationGoal", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.OptimizationGoal optimizationGoal {
            get {
                return this.optimizationGoalField;
            }
            set {
                this.optimizationGoalField = value;
                this.RaisePropertyChanged("optimizationGoal");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("mandatoryLocationIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] mandatoryLocationIds {
            get {
                return this.mandatoryLocationIdsField;
            }
            set {
                this.mandatoryLocationIdsField = value;
                this.RaisePropertyChanged("mandatoryLocationIds");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("mandatoryClusterIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] mandatoryClusterIds {
            get {
                return this.mandatoryClusterIdsField;
            }
            set {
                this.mandatoryClusterIdsField = value;
                this.RaisePropertyChanged("mandatoryClusterIds");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class CoverLocationsRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xcluster.PlanningLocation[] planningLocationsField;
        private com.ptvgroup.xserver.xcluster.CoverLocationsOptions coverLocationsOptionsField;
        private com.ptvgroup.xserver.dima.DistanceMode distanceModeField;
        private com.ptvgroup.xserver.xcluster.ClusterFacility[] clusterFacilitiesField;

                    [System.Xml.Serialization.XmlElementAttribute("planningLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.PlanningLocation[] planningLocations {
            get {
                return this.planningLocationsField;
            }
            set {
                this.planningLocationsField = value;
                this.RaisePropertyChanged("planningLocations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("coverLocationsOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.CoverLocationsOptions coverLocationsOptions {
            get {
                return this.coverLocationsOptionsField;
            }
            set {
                this.coverLocationsOptionsField = value;
                this.RaisePropertyChanged("coverLocationsOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("distanceMode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.dima.DistanceMode distanceMode {
            get {
                return this.distanceModeField;
            }
            set {
                this.distanceModeField = value;
                this.RaisePropertyChanged("distanceMode");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("clusterFacilities", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.ClusterFacility[] clusterFacilities {
            get {
                return this.clusterFacilitiesField;
            }
            set {
                this.clusterFacilitiesField = value;
                this.RaisePropertyChanged("clusterFacilities");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class FieldWorker : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private com.ptvgroup.xserver.routing.RouteLocation locationField;

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

                    [System.Xml.Serialization.XmlElementAttribute("location", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
                this.RaisePropertyChanged("location");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class Hotel : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private com.ptvgroup.xserver.routing.RouteLocation locationField;

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

                    [System.Xml.Serialization.XmlElementAttribute("location", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
                this.RaisePropertyChanged("location");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class HotelStayOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private double maximumTravelDistanceToHotelField;
        private bool maximumTravelDistanceToHotelFieldSpecified;
        private double maximumTravelDistanceFromHotelField;
        private bool maximumTravelDistanceFromHotelFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumTravelDistanceToHotel {
            get {
                return this.maximumTravelDistanceToHotelField;
            }
            set {
                this.maximumTravelDistanceToHotelField = value;
                this.RaisePropertyChanged("maximumTravelDistanceToHotel");
                this.maximumTravelDistanceToHotelFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumTravelDistanceToHotelSpecified {
            get {
                return this.maximumTravelDistanceToHotelFieldSpecified;
            }
            set {
                this.maximumTravelDistanceToHotelFieldSpecified = value;
                this.RaisePropertyChanged("maximumTravelDistanceToHotelSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumTravelDistanceFromHotel {
            get {
                return this.maximumTravelDistanceFromHotelField;
            }
            set {
                this.maximumTravelDistanceFromHotelField = value;
                this.RaisePropertyChanged("maximumTravelDistanceFromHotel");
                this.maximumTravelDistanceFromHotelFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumTravelDistanceFromHotelSpecified {
            get {
                return this.maximumTravelDistanceFromHotelFieldSpecified;
            }
            set {
                this.maximumTravelDistanceFromHotelFieldSpecified = value;
                this.RaisePropertyChanged("maximumTravelDistanceFromHotelSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class Location : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private com.ptvgroup.xserver.routing.RouteLocation routeLocationField;

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

                    [System.Xml.Serialization.XmlElementAttribute("routeLocation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation routeLocation {
            get {
                return this.routeLocationField;
            }
            set {
                this.routeLocationField = value;
                this.RaisePropertyChanged("routeLocation");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class MaximumAllowedCostGoal : com.ptvgroup.xserver.xcluster.OptimizationGoal {

        private int costLimitField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int costLimit {
            get {
                return this.costLimitField;
            }
            set {
                this.costLimitField = value;
                this.RaisePropertyChanged("costLimit");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class MinimumCoverageGoal : com.ptvgroup.xserver.xcluster.OptimizationGoal {

        private double minimumCoverageField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double minimumCoverage {
            get {
                return this.minimumCoverageField;
            }
            set {
                this.minimumCoverageField = value;
                this.RaisePropertyChanged("minimumCoverage");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xcluster.MaximumAllowedCostGoal))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xcluster.MinimumCoverageGoal))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public abstract partial class OptimizationGoal : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class OptimizeVisitSequenceOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xcluster.VisitSequenceOptimizationGoal optimizationGoalField;
        private bool optimizationGoalFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xcluster.VisitSequenceOptimizationGoal optimizationGoal {
            get {
                return this.optimizationGoalField;
            }
            set {
                this.optimizationGoalField = value;
                this.RaisePropertyChanged("optimizationGoal");
                this.optimizationGoalFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool optimizationGoalSpecified {
            get {
                return this.optimizationGoalFieldSpecified;
            }
            set {
                this.optimizationGoalFieldSpecified = value;
                this.RaisePropertyChanged("optimizationGoalSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class OptimizeVisitSequenceRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xcluster.Location[] locationsField;
        private string startLocationIdField;
        private string endLocationIdField;
        private com.ptvgroup.xserver.xcluster.OptimizeVisitSequenceOptions optimizeVisitSequenceOptionsField;
        private com.ptvgroup.xserver.dima.DistanceMode distanceModeField;

                    [System.Xml.Serialization.XmlElementAttribute("locations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.Location[] locations {
            get {
                return this.locationsField;
            }
            set {
                this.locationsField = value;
                this.RaisePropertyChanged("locations");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string startLocationId {
            get {
                return this.startLocationIdField;
            }
            set {
                this.startLocationIdField = value;
                this.RaisePropertyChanged("startLocationId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string endLocationId {
            get {
                return this.endLocationIdField;
            }
            set {
                this.endLocationIdField = value;
                this.RaisePropertyChanged("endLocationId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("optimizeVisitSequenceOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.OptimizeVisitSequenceOptions optimizeVisitSequenceOptions {
            get {
                return this.optimizeVisitSequenceOptionsField;
            }
            set {
                this.optimizeVisitSequenceOptionsField = value;
                this.RaisePropertyChanged("optimizeVisitSequenceOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("distanceMode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.dima.DistanceMode distanceMode {
            get {
                return this.distanceModeField;
            }
            set {
                this.distanceModeField = value;
                this.RaisePropertyChanged("distanceMode");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class OvernightStayOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private double minimumTravelTimeToFieldWorkerLocationField;
        private bool minimumTravelTimeToFieldWorkerLocationFieldSpecified;
        private int maximumOvernightStaysPerWeekField;
        private bool maximumOvernightStaysPerWeekFieldSpecified;
        private System.DateTime[] forbiddenDaysField;
        private double minimumTimeSavingPerOvernightStayField;
        private bool minimumTimeSavingPerOvernightStayFieldSpecified;
        private double maximumTravelTimeBetweenDaysField;
        private bool maximumTravelTimeBetweenDaysFieldSpecified;
        private com.ptvgroup.xserver.xcluster.HotelStayOptions hotelStayOptionsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double minimumTravelTimeToFieldWorkerLocation {
            get {
                return this.minimumTravelTimeToFieldWorkerLocationField;
            }
            set {
                this.minimumTravelTimeToFieldWorkerLocationField = value;
                this.RaisePropertyChanged("minimumTravelTimeToFieldWorkerLocation");
                this.minimumTravelTimeToFieldWorkerLocationFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimumTravelTimeToFieldWorkerLocationSpecified {
            get {
                return this.minimumTravelTimeToFieldWorkerLocationFieldSpecified;
            }
            set {
                this.minimumTravelTimeToFieldWorkerLocationFieldSpecified = value;
                this.RaisePropertyChanged("minimumTravelTimeToFieldWorkerLocationSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumOvernightStaysPerWeek {
            get {
                return this.maximumOvernightStaysPerWeekField;
            }
            set {
                this.maximumOvernightStaysPerWeekField = value;
                this.RaisePropertyChanged("maximumOvernightStaysPerWeek");
                this.maximumOvernightStaysPerWeekFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumOvernightStaysPerWeekSpecified {
            get {
                return this.maximumOvernightStaysPerWeekFieldSpecified;
            }
            set {
                this.maximumOvernightStaysPerWeekFieldSpecified = value;
                this.RaisePropertyChanged("maximumOvernightStaysPerWeekSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("forbiddenDays", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime[] forbiddenDays {
            get {
                return this.forbiddenDaysField;
            }
            set {
                this.forbiddenDaysField = value;
                this.RaisePropertyChanged("forbiddenDays");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double minimumTimeSavingPerOvernightStay {
            get {
                return this.minimumTimeSavingPerOvernightStayField;
            }
            set {
                this.minimumTimeSavingPerOvernightStayField = value;
                this.RaisePropertyChanged("minimumTimeSavingPerOvernightStay");
                this.minimumTimeSavingPerOvernightStayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimumTimeSavingPerOvernightStaySpecified {
            get {
                return this.minimumTimeSavingPerOvernightStayFieldSpecified;
            }
            set {
                this.minimumTimeSavingPerOvernightStayFieldSpecified = value;
                this.RaisePropertyChanged("minimumTimeSavingPerOvernightStaySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumTravelTimeBetweenDays {
            get {
                return this.maximumTravelTimeBetweenDaysField;
            }
            set {
                this.maximumTravelTimeBetweenDaysField = value;
                this.RaisePropertyChanged("maximumTravelTimeBetweenDays");
                this.maximumTravelTimeBetweenDaysFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumTravelTimeBetweenDaysSpecified {
            get {
                return this.maximumTravelTimeBetweenDaysFieldSpecified;
            }
            set {
                this.maximumTravelTimeBetweenDaysFieldSpecified = value;
                this.RaisePropertyChanged("maximumTravelTimeBetweenDaysSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("hotelStayOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.HotelStayOptions hotelStayOptions {
            get {
                return this.hotelStayOptionsField;
            }
            set {
                this.hotelStayOptionsField = value;
                this.RaisePropertyChanged("hotelStayOptions");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class PlanClustersOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private int numberOfClustersField;
        private bool ignoreImbalanceToleranceField;
        private bool ignoreImbalanceToleranceFieldSpecified;
        private double imbalanceToleranceField;
        private bool imbalanceToleranceFieldSpecified;
        private string[] optionalClusterIdsField;
        private bool reduceOverlappingInClustersField;
        private bool reduceOverlappingInClustersFieldSpecified;
        private bool considerActivitiesAsServiceTimesField;
        private bool considerActivitiesAsServiceTimesFieldSpecified;
        private com.ptvgroup.xserver.xcluster.ActivityCapacity[] activityCapacitiesField;
        private bool activityCapacitiesAreAbsoluteField;
        private bool activityCapacitiesAreAbsoluteFieldSpecified;
        private com.ptvgroup.xserver.xcluster.CalculationMode calculationModeField;
        private bool calculationModeFieldSpecified;
        private bool useTravelDistanceField;
        private bool useTravelDistanceFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfClusters {
            get {
                return this.numberOfClustersField;
            }
            set {
                this.numberOfClustersField = value;
                this.RaisePropertyChanged("numberOfClusters");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoreImbalanceTolerance {
            get {
                return this.ignoreImbalanceToleranceField;
            }
            set {
                this.ignoreImbalanceToleranceField = value;
                this.RaisePropertyChanged("ignoreImbalanceTolerance");
                this.ignoreImbalanceToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoreImbalanceToleranceSpecified {
            get {
                return this.ignoreImbalanceToleranceFieldSpecified;
            }
            set {
                this.ignoreImbalanceToleranceFieldSpecified = value;
                this.RaisePropertyChanged("ignoreImbalanceToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double imbalanceTolerance {
            get {
                return this.imbalanceToleranceField;
            }
            set {
                this.imbalanceToleranceField = value;
                this.RaisePropertyChanged("imbalanceTolerance");
                this.imbalanceToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool imbalanceToleranceSpecified {
            get {
                return this.imbalanceToleranceFieldSpecified;
            }
            set {
                this.imbalanceToleranceFieldSpecified = value;
                this.RaisePropertyChanged("imbalanceToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("optionalClusterIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] optionalClusterIds {
            get {
                return this.optionalClusterIdsField;
            }
            set {
                this.optionalClusterIdsField = value;
                this.RaisePropertyChanged("optionalClusterIds");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool reduceOverlappingInClusters {
            get {
                return this.reduceOverlappingInClustersField;
            }
            set {
                this.reduceOverlappingInClustersField = value;
                this.RaisePropertyChanged("reduceOverlappingInClusters");
                this.reduceOverlappingInClustersFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reduceOverlappingInClustersSpecified {
            get {
                return this.reduceOverlappingInClustersFieldSpecified;
            }
            set {
                this.reduceOverlappingInClustersFieldSpecified = value;
                this.RaisePropertyChanged("reduceOverlappingInClustersSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool considerActivitiesAsServiceTimes {
            get {
                return this.considerActivitiesAsServiceTimesField;
            }
            set {
                this.considerActivitiesAsServiceTimesField = value;
                this.RaisePropertyChanged("considerActivitiesAsServiceTimes");
                this.considerActivitiesAsServiceTimesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool considerActivitiesAsServiceTimesSpecified {
            get {
                return this.considerActivitiesAsServiceTimesFieldSpecified;
            }
            set {
                this.considerActivitiesAsServiceTimesFieldSpecified = value;
                this.RaisePropertyChanged("considerActivitiesAsServiceTimesSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("activityCapacities", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.ActivityCapacity[] activityCapacities {
            get {
                return this.activityCapacitiesField;
            }
            set {
                this.activityCapacitiesField = value;
                this.RaisePropertyChanged("activityCapacities");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool activityCapacitiesAreAbsolute {
            get {
                return this.activityCapacitiesAreAbsoluteField;
            }
            set {
                this.activityCapacitiesAreAbsoluteField = value;
                this.RaisePropertyChanged("activityCapacitiesAreAbsolute");
                this.activityCapacitiesAreAbsoluteFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activityCapacitiesAreAbsoluteSpecified {
            get {
                return this.activityCapacitiesAreAbsoluteFieldSpecified;
            }
            set {
                this.activityCapacitiesAreAbsoluteFieldSpecified = value;
                this.RaisePropertyChanged("activityCapacitiesAreAbsoluteSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xcluster.CalculationMode calculationMode {
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
        public bool useTravelDistance {
            get {
                return this.useTravelDistanceField;
            }
            set {
                this.useTravelDistanceField = value;
                this.RaisePropertyChanged("useTravelDistance");
                this.useTravelDistanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useTravelDistanceSpecified {
            get {
                return this.useTravelDistanceFieldSpecified;
            }
            set {
                this.useTravelDistanceFieldSpecified = value;
                this.RaisePropertyChanged("useTravelDistanceSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class PlanClustersRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xcluster.PlanningLocation[] planningLocationsField;
        private com.ptvgroup.xserver.xcluster.Cluster[] clustersField;
        private com.ptvgroup.xserver.xcluster.PlanClustersOptions planClustersOptionsField;
        private com.ptvgroup.xserver.dima.DistanceMode distanceModeField;

                    [System.Xml.Serialization.XmlElementAttribute("planningLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.PlanningLocation[] planningLocations {
            get {
                return this.planningLocationsField;
            }
            set {
                this.planningLocationsField = value;
                this.RaisePropertyChanged("planningLocations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("clusters", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.Cluster[] clusters {
            get {
                return this.clustersField;
            }
            set {
                this.clustersField = value;
                this.RaisePropertyChanged("clusters");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("planClustersOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.PlanClustersOptions planClustersOptions {
            get {
                return this.planClustersOptionsField;
            }
            set {
                this.planClustersOptionsField = value;
                this.RaisePropertyChanged("planClustersOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("distanceMode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.dima.DistanceMode distanceMode {
            get {
                return this.distanceModeField;
            }
            set {
                this.distanceModeField = value;
                this.RaisePropertyChanged("distanceMode");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class PlanVisitsOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xcluster.PlanningPeriod planningPeriodField;
        private com.ptvgroup.xserver.xcluster.Week workDaysField;
        private bool ignoreWeeklyImbalanceToleranceField;
        private bool ignoreWeeklyImbalanceToleranceFieldSpecified;
        private double weeklyImbalanceToleranceField;
        private bool weeklyImbalanceToleranceFieldSpecified;
        private bool ignoreDailyImbalanceToleranceField;
        private bool ignoreDailyImbalanceToleranceFieldSpecified;
        private double dailyImbalanceToleranceField;
        private bool dailyImbalanceToleranceFieldSpecified;
        private bool determineShortestVisitSequencePerDayField;
        private bool determineShortestVisitSequencePerDayFieldSpecified;
        private bool improveDailyWorkloadBalanceField;
        private bool improveDailyWorkloadBalanceFieldSpecified;
        private com.ptvgroup.xserver.xcluster.OvernightStayOptions overnightStayOptionsField;
        private com.ptvgroup.xserver.xcluster.WorkloadOptions workloadOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("planningPeriod", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.PlanningPeriod planningPeriod {
            get {
                return this.planningPeriodField;
            }
            set {
                this.planningPeriodField = value;
                this.RaisePropertyChanged("planningPeriod");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("workDays", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.Week workDays {
            get {
                return this.workDaysField;
            }
            set {
                this.workDaysField = value;
                this.RaisePropertyChanged("workDays");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoreWeeklyImbalanceTolerance {
            get {
                return this.ignoreWeeklyImbalanceToleranceField;
            }
            set {
                this.ignoreWeeklyImbalanceToleranceField = value;
                this.RaisePropertyChanged("ignoreWeeklyImbalanceTolerance");
                this.ignoreWeeklyImbalanceToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoreWeeklyImbalanceToleranceSpecified {
            get {
                return this.ignoreWeeklyImbalanceToleranceFieldSpecified;
            }
            set {
                this.ignoreWeeklyImbalanceToleranceFieldSpecified = value;
                this.RaisePropertyChanged("ignoreWeeklyImbalanceToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double weeklyImbalanceTolerance {
            get {
                return this.weeklyImbalanceToleranceField;
            }
            set {
                this.weeklyImbalanceToleranceField = value;
                this.RaisePropertyChanged("weeklyImbalanceTolerance");
                this.weeklyImbalanceToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weeklyImbalanceToleranceSpecified {
            get {
                return this.weeklyImbalanceToleranceFieldSpecified;
            }
            set {
                this.weeklyImbalanceToleranceFieldSpecified = value;
                this.RaisePropertyChanged("weeklyImbalanceToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoreDailyImbalanceTolerance {
            get {
                return this.ignoreDailyImbalanceToleranceField;
            }
            set {
                this.ignoreDailyImbalanceToleranceField = value;
                this.RaisePropertyChanged("ignoreDailyImbalanceTolerance");
                this.ignoreDailyImbalanceToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoreDailyImbalanceToleranceSpecified {
            get {
                return this.ignoreDailyImbalanceToleranceFieldSpecified;
            }
            set {
                this.ignoreDailyImbalanceToleranceFieldSpecified = value;
                this.RaisePropertyChanged("ignoreDailyImbalanceToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double dailyImbalanceTolerance {
            get {
                return this.dailyImbalanceToleranceField;
            }
            set {
                this.dailyImbalanceToleranceField = value;
                this.RaisePropertyChanged("dailyImbalanceTolerance");
                this.dailyImbalanceToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dailyImbalanceToleranceSpecified {
            get {
                return this.dailyImbalanceToleranceFieldSpecified;
            }
            set {
                this.dailyImbalanceToleranceFieldSpecified = value;
                this.RaisePropertyChanged("dailyImbalanceToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool determineShortestVisitSequencePerDay {
            get {
                return this.determineShortestVisitSequencePerDayField;
            }
            set {
                this.determineShortestVisitSequencePerDayField = value;
                this.RaisePropertyChanged("determineShortestVisitSequencePerDay");
                this.determineShortestVisitSequencePerDayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool determineShortestVisitSequencePerDaySpecified {
            get {
                return this.determineShortestVisitSequencePerDayFieldSpecified;
            }
            set {
                this.determineShortestVisitSequencePerDayFieldSpecified = value;
                this.RaisePropertyChanged("determineShortestVisitSequencePerDaySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool improveDailyWorkloadBalance {
            get {
                return this.improveDailyWorkloadBalanceField;
            }
            set {
                this.improveDailyWorkloadBalanceField = value;
                this.RaisePropertyChanged("improveDailyWorkloadBalance");
                this.improveDailyWorkloadBalanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool improveDailyWorkloadBalanceSpecified {
            get {
                return this.improveDailyWorkloadBalanceFieldSpecified;
            }
            set {
                this.improveDailyWorkloadBalanceFieldSpecified = value;
                this.RaisePropertyChanged("improveDailyWorkloadBalanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("overnightStayOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.OvernightStayOptions overnightStayOptions {
            get {
                return this.overnightStayOptionsField;
            }
            set {
                this.overnightStayOptionsField = value;
                this.RaisePropertyChanged("overnightStayOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("workloadOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.WorkloadOptions workloadOptions {
            get {
                return this.workloadOptionsField;
            }
            set {
                this.workloadOptionsField = value;
                this.RaisePropertyChanged("workloadOptions");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class PlanVisitsRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xcluster.FieldWorker fieldWorkerField;
        private com.ptvgroup.xserver.xcluster.Location[] locationsField;
        private com.ptvgroup.xserver.xcluster.VisitOrder[] ordersField;
        private com.ptvgroup.xserver.xcluster.PlanVisitsOptions planVisitsOptionsField;
        private com.ptvgroup.xserver.dima.DistanceMode distanceModeField;
        private com.ptvgroup.xserver.xcluster.Hotel[] hotelsField;

                    [System.Xml.Serialization.XmlElementAttribute("fieldWorker", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.FieldWorker fieldWorker {
            get {
                return this.fieldWorkerField;
            }
            set {
                this.fieldWorkerField = value;
                this.RaisePropertyChanged("fieldWorker");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("locations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.Location[] locations {
            get {
                return this.locationsField;
            }
            set {
                this.locationsField = value;
                this.RaisePropertyChanged("locations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("orders", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.VisitOrder[] orders {
            get {
                return this.ordersField;
            }
            set {
                this.ordersField = value;
                this.RaisePropertyChanged("orders");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("planVisitsOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.PlanVisitsOptions planVisitsOptions {
            get {
                return this.planVisitsOptionsField;
            }
            set {
                this.planVisitsOptionsField = value;
                this.RaisePropertyChanged("planVisitsOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("distanceMode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.dima.DistanceMode distanceMode {
            get {
                return this.distanceModeField;
            }
            set {
                this.distanceModeField = value;
                this.RaisePropertyChanged("distanceMode");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("hotels", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.Hotel[] hotels {
            get {
                return this.hotelsField;
            }
            set {
                this.hotelsField = value;
                this.RaisePropertyChanged("hotels");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class PlanningLocation : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xcluster.Location locationField;
        private double activityField;
        private string groupIdField;
        private com.ptvgroup.xserver.xcluster.ClusterCompatibility clusterCompatibilityField;

                    [System.Xml.Serialization.XmlElementAttribute("location", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.Location location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
                this.RaisePropertyChanged("location");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double activity {
            get {
                return this.activityField;
            }
            set {
                this.activityField = value;
                this.RaisePropertyChanged("activity");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string groupId {
            get {
                return this.groupIdField;
            }
            set {
                this.groupIdField = value;
                this.RaisePropertyChanged("groupId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("clusterCompatibility", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.ClusterCompatibility clusterCompatibility {
            get {
                return this.clusterCompatibilityField;
            }
            set {
                this.clusterCompatibilityField = value;
                this.RaisePropertyChanged("clusterCompatibility");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class PlanningPeriod : object, System.ComponentModel.INotifyPropertyChanged {

        private System.DateTime startDateField;
        private int numberOfWeeksField;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
                this.RaisePropertyChanged("startDate");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfWeeks {
            get {
                return this.numberOfWeeksField;
            }
            set {
                this.numberOfWeeksField = value;
                this.RaisePropertyChanged("numberOfWeeks");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class Visit : object, System.ComponentModel.INotifyPropertyChanged {

        private System.DateTime visitDateField;
        private double serviceTimeField;
        private string orderIdField;
        private int visitNumberField;
        private double travelTimeToVisitField;
        private bool travelTimeToVisitFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime visitDate {
            get {
                return this.visitDateField;
            }
            set {
                this.visitDateField = value;
                this.RaisePropertyChanged("visitDate");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double serviceTime {
            get {
                return this.serviceTimeField;
            }
            set {
                this.serviceTimeField = value;
                this.RaisePropertyChanged("serviceTime");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId {
            get {
                return this.orderIdField;
            }
            set {
                this.orderIdField = value;
                this.RaisePropertyChanged("orderId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int visitNumber {
            get {
                return this.visitNumberField;
            }
            set {
                this.visitNumberField = value;
                this.RaisePropertyChanged("visitNumber");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double travelTimeToVisit {
            get {
                return this.travelTimeToVisitField;
            }
            set {
                this.travelTimeToVisitField = value;
                this.RaisePropertyChanged("travelTimeToVisit");
                this.travelTimeToVisitFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool travelTimeToVisitSpecified {
            get {
                return this.travelTimeToVisitFieldSpecified;
            }
            set {
                this.travelTimeToVisitFieldSpecified = value;
                this.RaisePropertyChanged("travelTimeToVisitSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class VisitDay : object, System.ComponentModel.INotifyPropertyChanged {

        private System.DateTime visitDateField;
        private bool visitDateFieldSpecified;
        private int startIndexField;
        private bool startIndexFieldSpecified;
        private int endIndexField;
        private bool endIndexFieldSpecified;
        private double travelTimeField;
        private bool travelTimeFieldSpecified;
        private double serviceTimeField;
        private bool serviceTimeFieldSpecified;
        private double travelTimeAfterLastVisitField;
        private bool travelTimeAfterLastVisitFieldSpecified;
        private bool overnightStayField;
        private bool overnightStayFieldSpecified;
        private string hotelIdField;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime visitDate {
            get {
                return this.visitDateField;
            }
            set {
                this.visitDateField = value;
                this.RaisePropertyChanged("visitDate");
                this.visitDateFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool visitDateSpecified {
            get {
                return this.visitDateFieldSpecified;
            }
            set {
                this.visitDateFieldSpecified = value;
                this.RaisePropertyChanged("visitDateSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int startIndex {
            get {
                return this.startIndexField;
            }
            set {
                this.startIndexField = value;
                this.RaisePropertyChanged("startIndex");
                this.startIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startIndexSpecified {
            get {
                return this.startIndexFieldSpecified;
            }
            set {
                this.startIndexFieldSpecified = value;
                this.RaisePropertyChanged("startIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int endIndex {
            get {
                return this.endIndexField;
            }
            set {
                this.endIndexField = value;
                this.RaisePropertyChanged("endIndex");
                this.endIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endIndexSpecified {
            get {
                return this.endIndexFieldSpecified;
            }
            set {
                this.endIndexFieldSpecified = value;
                this.RaisePropertyChanged("endIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double travelTime {
            get {
                return this.travelTimeField;
            }
            set {
                this.travelTimeField = value;
                this.RaisePropertyChanged("travelTime");
                this.travelTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool travelTimeSpecified {
            get {
                return this.travelTimeFieldSpecified;
            }
            set {
                this.travelTimeFieldSpecified = value;
                this.RaisePropertyChanged("travelTimeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double serviceTime {
            get {
                return this.serviceTimeField;
            }
            set {
                this.serviceTimeField = value;
                this.RaisePropertyChanged("serviceTime");
                this.serviceTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool serviceTimeSpecified {
            get {
                return this.serviceTimeFieldSpecified;
            }
            set {
                this.serviceTimeFieldSpecified = value;
                this.RaisePropertyChanged("serviceTimeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double travelTimeAfterLastVisit {
            get {
                return this.travelTimeAfterLastVisitField;
            }
            set {
                this.travelTimeAfterLastVisitField = value;
                this.RaisePropertyChanged("travelTimeAfterLastVisit");
                this.travelTimeAfterLastVisitFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool travelTimeAfterLastVisitSpecified {
            get {
                return this.travelTimeAfterLastVisitFieldSpecified;
            }
            set {
                this.travelTimeAfterLastVisitFieldSpecified = value;
                this.RaisePropertyChanged("travelTimeAfterLastVisitSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool overnightStay {
            get {
                return this.overnightStayField;
            }
            set {
                this.overnightStayField = value;
                this.RaisePropertyChanged("overnightStay");
                this.overnightStayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overnightStaySpecified {
            get {
                return this.overnightStayFieldSpecified;
            }
            set {
                this.overnightStayFieldSpecified = value;
                this.RaisePropertyChanged("overnightStaySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hotelId {
            get {
                return this.hotelIdField;
            }
            set {
                this.hotelIdField = value;
                this.RaisePropertyChanged("hotelId");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class VisitLocation : object, System.ComponentModel.INotifyPropertyChanged {

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class VisitOrder : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private string locationIdField;
        private int visitRhythmInWeeksField;
        private int numberOfVisitsPerWeekField;
        private com.ptvgroup.xserver.xcluster.VisitPatternOptions visitPatternOptionsField;
        private int weekOfPossibleFirstVisitField;
        private bool weekOfPossibleFirstVisitFieldSpecified;
        private int weekOfPossibleLastVisitField;
        private bool weekOfPossibleLastVisitFieldSpecified;
        private double[] serviceTimesField;
        private int scoreField;
        private bool scoreFieldSpecified;

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
        public string locationId {
            get {
                return this.locationIdField;
            }
            set {
                this.locationIdField = value;
                this.RaisePropertyChanged("locationId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int visitRhythmInWeeks {
            get {
                return this.visitRhythmInWeeksField;
            }
            set {
                this.visitRhythmInWeeksField = value;
                this.RaisePropertyChanged("visitRhythmInWeeks");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfVisitsPerWeek {
            get {
                return this.numberOfVisitsPerWeekField;
            }
            set {
                this.numberOfVisitsPerWeekField = value;
                this.RaisePropertyChanged("numberOfVisitsPerWeek");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("visitPatternOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.VisitPatternOptions visitPatternOptions {
            get {
                return this.visitPatternOptionsField;
            }
            set {
                this.visitPatternOptionsField = value;
                this.RaisePropertyChanged("visitPatternOptions");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int weekOfPossibleFirstVisit {
            get {
                return this.weekOfPossibleFirstVisitField;
            }
            set {
                this.weekOfPossibleFirstVisitField = value;
                this.RaisePropertyChanged("weekOfPossibleFirstVisit");
                this.weekOfPossibleFirstVisitFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weekOfPossibleFirstVisitSpecified {
            get {
                return this.weekOfPossibleFirstVisitFieldSpecified;
            }
            set {
                this.weekOfPossibleFirstVisitFieldSpecified = value;
                this.RaisePropertyChanged("weekOfPossibleFirstVisitSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int weekOfPossibleLastVisit {
            get {
                return this.weekOfPossibleLastVisitField;
            }
            set {
                this.weekOfPossibleLastVisitField = value;
                this.RaisePropertyChanged("weekOfPossibleLastVisit");
                this.weekOfPossibleLastVisitFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weekOfPossibleLastVisitSpecified {
            get {
                return this.weekOfPossibleLastVisitFieldSpecified;
            }
            set {
                this.weekOfPossibleLastVisitFieldSpecified = value;
                this.RaisePropertyChanged("weekOfPossibleLastVisitSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("serviceTimes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double[] serviceTimes {
            get {
                return this.serviceTimesField;
            }
            set {
                this.serviceTimesField = value;
                this.RaisePropertyChanged("serviceTimes");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int score {
            get {
                return this.scoreField;
            }
            set {
                this.scoreField = value;
                this.RaisePropertyChanged("score");
                this.scoreFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scoreSpecified {
            get {
                return this.scoreFieldSpecified;
            }
            set {
                this.scoreFieldSpecified = value;
                this.RaisePropertyChanged("scoreSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class VisitPatternOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xcluster.Week[] visitPatternsField;
        private bool flexibleChoiceOfVisitPatternsField;
        private bool flexibleChoiceOfVisitPatternsFieldSpecified;
        private int maximumNumberOfVisitPatternDeviationsField;
        private bool maximumNumberOfVisitPatternDeviationsFieldSpecified;
        private System.DateTime[] forbiddenVisitDaysField;
        private System.DateTime firstVisitDayField;
        private bool firstVisitDayFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("visitPatterns", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.Week[] visitPatterns {
            get {
                return this.visitPatternsField;
            }
            set {
                this.visitPatternsField = value;
                this.RaisePropertyChanged("visitPatterns");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool flexibleChoiceOfVisitPatterns {
            get {
                return this.flexibleChoiceOfVisitPatternsField;
            }
            set {
                this.flexibleChoiceOfVisitPatternsField = value;
                this.RaisePropertyChanged("flexibleChoiceOfVisitPatterns");
                this.flexibleChoiceOfVisitPatternsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool flexibleChoiceOfVisitPatternsSpecified {
            get {
                return this.flexibleChoiceOfVisitPatternsFieldSpecified;
            }
            set {
                this.flexibleChoiceOfVisitPatternsFieldSpecified = value;
                this.RaisePropertyChanged("flexibleChoiceOfVisitPatternsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumNumberOfVisitPatternDeviations {
            get {
                return this.maximumNumberOfVisitPatternDeviationsField;
            }
            set {
                this.maximumNumberOfVisitPatternDeviationsField = value;
                this.RaisePropertyChanged("maximumNumberOfVisitPatternDeviations");
                this.maximumNumberOfVisitPatternDeviationsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumNumberOfVisitPatternDeviationsSpecified {
            get {
                return this.maximumNumberOfVisitPatternDeviationsFieldSpecified;
            }
            set {
                this.maximumNumberOfVisitPatternDeviationsFieldSpecified = value;
                this.RaisePropertyChanged("maximumNumberOfVisitPatternDeviationsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("forbiddenVisitDays", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime[] forbiddenVisitDays {
            get {
                return this.forbiddenVisitDaysField;
            }
            set {
                this.forbiddenVisitDaysField = value;
                this.RaisePropertyChanged("forbiddenVisitDays");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime firstVisitDay {
            get {
                return this.firstVisitDayField;
            }
            set {
                this.firstVisitDayField = value;
                this.RaisePropertyChanged("firstVisitDay");
                this.firstVisitDayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool firstVisitDaySpecified {
            get {
                return this.firstVisitDayFieldSpecified;
            }
            set {
                this.firstVisitDayFieldSpecified = value;
                this.RaisePropertyChanged("firstVisitDaySpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class VisitSequenceResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xcluster.VisitLocation[] sequenceField;
        private double distanceField;
        private bool distanceFieldSpecified;
        private double travelTimeField;
        private bool travelTimeFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("sequence", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.VisitLocation[] sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
                this.RaisePropertyChanged("sequence");
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
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double travelTime {
            get {
                return this.travelTimeField;
            }
            set {
                this.travelTimeField = value;
                this.RaisePropertyChanged("travelTime");
                this.travelTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool travelTimeSpecified {
            get {
                return this.travelTimeFieldSpecified;
            }
            set {
                this.travelTimeFieldSpecified = value;
                this.RaisePropertyChanged("travelTimeSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class VisitWeek : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xcluster.VisitDay[] visitDaysField;
        private string[] visitOrderIdsSkippedField;
        private double travelTimeField;
        private bool travelTimeFieldSpecified;
        private double serviceTimeField;
        private bool serviceTimeFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("visitDays", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.VisitDay[] visitDays {
            get {
                return this.visitDaysField;
            }
            set {
                this.visitDaysField = value;
                this.RaisePropertyChanged("visitDays");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("visitOrderIdsSkipped", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] visitOrderIdsSkipped {
            get {
                return this.visitOrderIdsSkippedField;
            }
            set {
                this.visitOrderIdsSkippedField = value;
                this.RaisePropertyChanged("visitOrderIdsSkipped");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double travelTime {
            get {
                return this.travelTimeField;
            }
            set {
                this.travelTimeField = value;
                this.RaisePropertyChanged("travelTime");
                this.travelTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool travelTimeSpecified {
            get {
                return this.travelTimeFieldSpecified;
            }
            set {
                this.travelTimeFieldSpecified = value;
                this.RaisePropertyChanged("travelTimeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double serviceTime {
            get {
                return this.serviceTimeField;
            }
            set {
                this.serviceTimeField = value;
                this.RaisePropertyChanged("serviceTime");
                this.serviceTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool serviceTimeSpecified {
            get {
                return this.serviceTimeFieldSpecified;
            }
            set {
                this.serviceTimeFieldSpecified = value;
                this.RaisePropertyChanged("serviceTimeSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class VisitsResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xcluster.Visit[] visitsField;
        private com.ptvgroup.xserver.xcluster.VisitWeek[] visitWeeksField;
        private string[] visitOrderIdsNotPlannedField;

                    [System.Xml.Serialization.XmlElementAttribute("visits", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.Visit[] visits {
            get {
                return this.visitsField;
            }
            set {
                this.visitsField = value;
                this.RaisePropertyChanged("visits");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("visitWeeks", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.VisitWeek[] visitWeeks {
            get {
                return this.visitWeeksField;
            }
            set {
                this.visitWeeksField = value;
                this.RaisePropertyChanged("visitWeeks");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("visitOrderIdsNotPlanned", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] visitOrderIdsNotPlanned {
            get {
                return this.visitOrderIdsNotPlannedField;
            }
            set {
                this.visitOrderIdsNotPlannedField = value;
                this.RaisePropertyChanged("visitOrderIdsNotPlanned");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class Week : object, System.ComponentModel.INotifyPropertyChanged {

        private bool mondayField;
        private bool mondayFieldSpecified;
        private bool tuesdayField;
        private bool tuesdayFieldSpecified;
        private bool wednesdayField;
        private bool wednesdayFieldSpecified;
        private bool thursdayField;
        private bool thursdayFieldSpecified;
        private bool fridayField;
        private bool fridayFieldSpecified;
        private bool saturdayField;
        private bool saturdayFieldSpecified;
        private bool sundayField;
        private bool sundayFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool monday {
            get {
                return this.mondayField;
            }
            set {
                this.mondayField = value;
                this.RaisePropertyChanged("monday");
                this.mondayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mondaySpecified {
            get {
                return this.mondayFieldSpecified;
            }
            set {
                this.mondayFieldSpecified = value;
                this.RaisePropertyChanged("mondaySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool tuesday {
            get {
                return this.tuesdayField;
            }
            set {
                this.tuesdayField = value;
                this.RaisePropertyChanged("tuesday");
                this.tuesdayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tuesdaySpecified {
            get {
                return this.tuesdayFieldSpecified;
            }
            set {
                this.tuesdayFieldSpecified = value;
                this.RaisePropertyChanged("tuesdaySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool wednesday {
            get {
                return this.wednesdayField;
            }
            set {
                this.wednesdayField = value;
                this.RaisePropertyChanged("wednesday");
                this.wednesdayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wednesdaySpecified {
            get {
                return this.wednesdayFieldSpecified;
            }
            set {
                this.wednesdayFieldSpecified = value;
                this.RaisePropertyChanged("wednesdaySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool thursday {
            get {
                return this.thursdayField;
            }
            set {
                this.thursdayField = value;
                this.RaisePropertyChanged("thursday");
                this.thursdayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool thursdaySpecified {
            get {
                return this.thursdayFieldSpecified;
            }
            set {
                this.thursdayFieldSpecified = value;
                this.RaisePropertyChanged("thursdaySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool friday {
            get {
                return this.fridayField;
            }
            set {
                this.fridayField = value;
                this.RaisePropertyChanged("friday");
                this.fridayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fridaySpecified {
            get {
                return this.fridayFieldSpecified;
            }
            set {
                this.fridayFieldSpecified = value;
                this.RaisePropertyChanged("fridaySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool saturday {
            get {
                return this.saturdayField;
            }
            set {
                this.saturdayField = value;
                this.RaisePropertyChanged("saturday");
                this.saturdayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool saturdaySpecified {
            get {
                return this.saturdayFieldSpecified;
            }
            set {
                this.saturdayFieldSpecified = value;
                this.RaisePropertyChanged("saturdaySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool sunday {
            get {
                return this.sundayField;
            }
            set {
                this.sundayField = value;
                this.RaisePropertyChanged("sunday");
                this.sundayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sundaySpecified {
            get {
                return this.sundayFieldSpecified;
            }
            set {
                this.sundayFieldSpecified = value;
                this.RaisePropertyChanged("sundaySpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class WorkloadByDay : object, System.ComponentModel.INotifyPropertyChanged {

        private double maximumWorkloadField;
        private double desiredWorkloadField;
        private bool desiredWorkloadFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumWorkload {
            get {
                return this.maximumWorkloadField;
            }
            set {
                this.maximumWorkloadField = value;
                this.RaisePropertyChanged("maximumWorkload");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double desiredWorkload {
            get {
                return this.desiredWorkloadField;
            }
            set {
                this.desiredWorkloadField = value;
                this.RaisePropertyChanged("desiredWorkload");
                this.desiredWorkloadFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool desiredWorkloadSpecified {
            get {
                return this.desiredWorkloadFieldSpecified;
            }
            set {
                this.desiredWorkloadFieldSpecified = value;
                this.RaisePropertyChanged("desiredWorkloadSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public partial class WorkloadOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private double maximumWeeklyWorkloadField;
        private com.ptvgroup.xserver.xcluster.WorkloadByDay[] workloadsByDayField;
        private bool allowSkippingVisitsField;
        private bool allowSkippingVisitsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumWeeklyWorkload {
            get {
                return this.maximumWeeklyWorkloadField;
            }
            set {
                this.maximumWeeklyWorkloadField = value;
                this.RaisePropertyChanged("maximumWeeklyWorkload");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("workloadsByDay", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xcluster.WorkloadByDay[] workloadsByDay {
            get {
                return this.workloadsByDayField;
            }
            set {
                this.workloadsByDayField = value;
                this.RaisePropertyChanged("workloadsByDay");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowSkippingVisits {
            get {
                return this.allowSkippingVisitsField;
            }
            set {
                this.allowSkippingVisitsField = value;
                this.RaisePropertyChanged("allowSkippingVisits");
                this.allowSkippingVisitsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowSkippingVisitsSpecified {
            get {
                return this.allowSkippingVisitsFieldSpecified;
            }
            set {
                this.allowSkippingVisitsFieldSpecified = value;
                this.RaisePropertyChanged("allowSkippingVisitsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public enum CalculationMode {
        /**
         * The algorithm's focus is on performance. A smaller search space for solutions is considered during the computation.
         */
        PERFORMANCE,

        /**
         * The algorithm's focus is on high solution quality. A larger search space for solutions is considered during the computation.
         */
        QUALITY
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public enum ProgressStatus {
        /**
         * Indicates that the algorithm is currently in a pre-processing stage.
         */
        PREPROCESSING,

        /**
         * Indicates that the algorithm is currently in the main processing stage.
         */
        PROCESSING,

        /**
         * Indicates that the algorithm is currently in a post-processing stage.
         */
        POSTPROCESSING,

        /**
         * Indicates that the algorithm has finished.
         */
        DONE
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xcluster.xserver.ptvgroup.com")]
    public enum VisitSequenceOptimizationGoal {
        /**
         * Optimize for minimum travel time (<a href="xcluster.html#com.ptvgroup.xserver.xcluster.VisitSequenceResponse.travelTime">VisitSequenceResponse.travelTime</a>)
         */
        MINIMUM_TRAVEL_TIME,

        /**
         * Optimize for minimum traveled distance (<a href="xcluster.html#com.ptvgroup.xserver.xcluster.VisitSequenceResponse.distance">VisitSequenceResponse.distance</a>)
         */
        MINIMUM_DISTANCE
    }


}
