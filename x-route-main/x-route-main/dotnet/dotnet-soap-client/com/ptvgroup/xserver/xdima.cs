// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.xdima 
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public interface XDima {


            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdima.createDistanceMatrixResponse createDistanceMatrix(com.ptvgroup.xserver.xdima.createDistanceMatrix request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdima.startCreateDistanceMatrixResponse startCreateDistanceMatrix(com.ptvgroup.xserver.xdima.startCreateDistanceMatrix request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdima.listDistanceMatricesResponse listDistanceMatrices(com.ptvgroup.xserver.xdima.listDistanceMatrices request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdima.updateDistanceMatrixResponse updateDistanceMatrix(com.ptvgroup.xserver.xdima.updateDistanceMatrix request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdima.startUpdateDistanceMatrixResponse startUpdateDistanceMatrix(com.ptvgroup.xserver.xdima.startUpdateDistanceMatrix request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdima.deleteDistanceMatrixResponse deleteDistanceMatrix(com.ptvgroup.xserver.xdima.deleteDistanceMatrix request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdima.getDistanceMatrixResponse getDistanceMatrix(com.ptvgroup.xserver.xdima.getDistanceMatrix request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdima.fetchDistanceMatrixResponseResponse fetchDistanceMatrixResponse(com.ptvgroup.xserver.xdima.fetchDistanceMatrixResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdima.watchJobResponse watchJob(com.ptvgroup.xserver.xdima.watchJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdima.stopJobResponse stopJob(com.ptvgroup.xserver.xdima.stopJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xdima.deleteJobResponse deleteJob(com.ptvgroup.xserver.xdima.deleteJob request);
    }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="createDistanceMatrix", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class createDistanceMatrix {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.CreateDistanceMatrixRequest request;

                public createDistanceMatrix() {
                }

                public createDistanceMatrix(com.ptvgroup.xserver.xdima.CreateDistanceMatrixRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="createDistanceMatrixResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class createDistanceMatrixResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.DistanceMatrixResponse @return;

                public createDistanceMatrixResponse() {
                }

                public createDistanceMatrixResponse(com.ptvgroup.xserver.xdima.DistanceMatrixResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCreateDistanceMatrix", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCreateDistanceMatrix {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.CreateDistanceMatrixRequest request;

                public startCreateDistanceMatrix() {
                }

                public startCreateDistanceMatrix(com.ptvgroup.xserver.xdima.CreateDistanceMatrixRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCreateDistanceMatrixResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCreateDistanceMatrixResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startCreateDistanceMatrixResponse() {
                }

                public startCreateDistanceMatrixResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="listDistanceMatrices", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class listDistanceMatrices {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.ListDistanceMatricesRequest request;

                public listDistanceMatrices() {
                }

                public listDistanceMatrices(com.ptvgroup.xserver.xdima.ListDistanceMatricesRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="listDistanceMatricesResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class listDistanceMatricesResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.DistanceMatrixListResponse @return;

                public listDistanceMatricesResponse() {
                }

                public listDistanceMatricesResponse(com.ptvgroup.xserver.xdima.DistanceMatrixListResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="updateDistanceMatrix", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class updateDistanceMatrix {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.UpdateDistanceMatrixRequest request;

                public updateDistanceMatrix() {
                }

                public updateDistanceMatrix(com.ptvgroup.xserver.xdima.UpdateDistanceMatrixRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="updateDistanceMatrixResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class updateDistanceMatrixResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.DistanceMatrixResponse @return;

                public updateDistanceMatrixResponse() {
                }

                public updateDistanceMatrixResponse(com.ptvgroup.xserver.xdima.DistanceMatrixResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startUpdateDistanceMatrix", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startUpdateDistanceMatrix {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.UpdateDistanceMatrixRequest request;

                public startUpdateDistanceMatrix() {
                }

                public startUpdateDistanceMatrix(com.ptvgroup.xserver.xdima.UpdateDistanceMatrixRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startUpdateDistanceMatrixResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startUpdateDistanceMatrixResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startUpdateDistanceMatrixResponse() {
                }

                public startUpdateDistanceMatrixResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteDistanceMatrix", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteDistanceMatrix {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.DeleteDistanceMatrixRequest request;

                public deleteDistanceMatrix() {
                }

                public deleteDistanceMatrix(com.ptvgroup.xserver.xdima.DeleteDistanceMatrixRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteDistanceMatrixResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteDistanceMatrixResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.service.VoidResponse @return;

                public deleteDistanceMatrixResponse() {
                }

                public deleteDistanceMatrixResponse(com.ptvgroup.xserver.service.VoidResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getDistanceMatrix", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getDistanceMatrix {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.GetDistanceMatrixRequest request;

                public getDistanceMatrix() {
                }

                public getDistanceMatrix(com.ptvgroup.xserver.xdima.GetDistanceMatrixRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getDistanceMatrixResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getDistanceMatrixResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.DistanceMatrixResponse @return;

                public getDistanceMatrixResponse() {
                }

                public getDistanceMatrixResponse(com.ptvgroup.xserver.xdima.DistanceMatrixResponse @return) {
                    this.@return = @return;
                }
            }


            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchDistanceMatrixResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchDistanceMatrixResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchDistanceMatrixResponse() {
                }

                public fetchDistanceMatrixResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchDistanceMatrixResponseResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchDistanceMatrixResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xdima.DistanceMatrixResponse @return;

                public fetchDistanceMatrixResponseResponse() {
                }

                public fetchDistanceMatrixResponseResponse(com.ptvgroup.xserver.xdima.DistanceMatrixResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJob", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJobResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJob", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJobResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJob", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJobResponse", WrapperNamespace="http://xdima.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xdima.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public deleteJobResponse() {
                }

                public deleteJobResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XDimaChannel : com.ptvgroup.xserver.xdima.XDima, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XDimaClient : System.ServiceModel.ClientBase<com.ptvgroup.xserver.xdima.XDima>, com.ptvgroup.xserver.xdima.XDima {

        public XDimaClient() :
            this("http://localhost:50000/services/ws/XDima") {
        }

        public XDimaClient(string baseUri , string version="") :
            this(new System.ServiceModel.BasicHttpBinding { MaxReceivedMessageSize = System.Int32.MaxValue }, new System.ServiceModel.EndpointAddress(baseUri+"/services/ws/XDima/"+version)) {
        }

        public XDimaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress) {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdima.createDistanceMatrixResponse com.ptvgroup.xserver.xdima.XDima.createDistanceMatrix(com.ptvgroup.xserver.xdima.createDistanceMatrix request) {
            return base.Channel.createDistanceMatrix(request);
        }

        public com.ptvgroup.xserver.xdima.DistanceMatrixResponse createDistanceMatrix(com.ptvgroup.xserver.xdima.CreateDistanceMatrixRequest request) {
            com.ptvgroup.xserver.xdima.createDistanceMatrix inValue = new com.ptvgroup.xserver.xdima.createDistanceMatrix();
            inValue.request = request;
            com.ptvgroup.xserver.xdima.createDistanceMatrixResponse retVal = ((com.ptvgroup.xserver.xdima.XDima)(this)).createDistanceMatrix(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdima.startCreateDistanceMatrixResponse com.ptvgroup.xserver.xdima.XDima.startCreateDistanceMatrix(com.ptvgroup.xserver.xdima.startCreateDistanceMatrix request) {
                return base.Channel.startCreateDistanceMatrix(request);
            }

            public com.ptvgroup.xserver.jobs.Job startCreateDistanceMatrix(com.ptvgroup.xserver.xdima.CreateDistanceMatrixRequest request) {
                com.ptvgroup.xserver.xdima.startCreateDistanceMatrix inValue = new com.ptvgroup.xserver.xdima.startCreateDistanceMatrix();
                inValue.request = request;
                com.ptvgroup.xserver.xdima.startCreateDistanceMatrixResponse retVal = ((com.ptvgroup.xserver.xdima.XDima)(this)).startCreateDistanceMatrix(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdima.listDistanceMatricesResponse com.ptvgroup.xserver.xdima.XDima.listDistanceMatrices(com.ptvgroup.xserver.xdima.listDistanceMatrices request) {
            return base.Channel.listDistanceMatrices(request);
        }

        public com.ptvgroup.xserver.xdima.DistanceMatrixListResponse listDistanceMatrices(com.ptvgroup.xserver.xdima.ListDistanceMatricesRequest request) {
            com.ptvgroup.xserver.xdima.listDistanceMatrices inValue = new com.ptvgroup.xserver.xdima.listDistanceMatrices();
            inValue.request = request;
            com.ptvgroup.xserver.xdima.listDistanceMatricesResponse retVal = ((com.ptvgroup.xserver.xdima.XDima)(this)).listDistanceMatrices(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdima.updateDistanceMatrixResponse com.ptvgroup.xserver.xdima.XDima.updateDistanceMatrix(com.ptvgroup.xserver.xdima.updateDistanceMatrix request) {
            return base.Channel.updateDistanceMatrix(request);
        }

        public com.ptvgroup.xserver.xdima.DistanceMatrixResponse updateDistanceMatrix(com.ptvgroup.xserver.xdima.UpdateDistanceMatrixRequest request) {
            com.ptvgroup.xserver.xdima.updateDistanceMatrix inValue = new com.ptvgroup.xserver.xdima.updateDistanceMatrix();
            inValue.request = request;
            com.ptvgroup.xserver.xdima.updateDistanceMatrixResponse retVal = ((com.ptvgroup.xserver.xdima.XDima)(this)).updateDistanceMatrix(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdima.startUpdateDistanceMatrixResponse com.ptvgroup.xserver.xdima.XDima.startUpdateDistanceMatrix(com.ptvgroup.xserver.xdima.startUpdateDistanceMatrix request) {
                return base.Channel.startUpdateDistanceMatrix(request);
            }

            public com.ptvgroup.xserver.jobs.Job startUpdateDistanceMatrix(com.ptvgroup.xserver.xdima.UpdateDistanceMatrixRequest request) {
                com.ptvgroup.xserver.xdima.startUpdateDistanceMatrix inValue = new com.ptvgroup.xserver.xdima.startUpdateDistanceMatrix();
                inValue.request = request;
                com.ptvgroup.xserver.xdima.startUpdateDistanceMatrixResponse retVal = ((com.ptvgroup.xserver.xdima.XDima)(this)).startUpdateDistanceMatrix(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdima.deleteDistanceMatrixResponse com.ptvgroup.xserver.xdima.XDima.deleteDistanceMatrix(com.ptvgroup.xserver.xdima.deleteDistanceMatrix request) {
            return base.Channel.deleteDistanceMatrix(request);
        }

        public com.ptvgroup.xserver.service.VoidResponse deleteDistanceMatrix(com.ptvgroup.xserver.xdima.DeleteDistanceMatrixRequest request) {
            com.ptvgroup.xserver.xdima.deleteDistanceMatrix inValue = new com.ptvgroup.xserver.xdima.deleteDistanceMatrix();
            inValue.request = request;
            com.ptvgroup.xserver.xdima.deleteDistanceMatrixResponse retVal = ((com.ptvgroup.xserver.xdima.XDima)(this)).deleteDistanceMatrix(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xdima.getDistanceMatrixResponse com.ptvgroup.xserver.xdima.XDima.getDistanceMatrix(com.ptvgroup.xserver.xdima.getDistanceMatrix request) {
            return base.Channel.getDistanceMatrix(request);
        }

        public com.ptvgroup.xserver.xdima.DistanceMatrixResponse getDistanceMatrix(com.ptvgroup.xserver.xdima.GetDistanceMatrixRequest request) {
            com.ptvgroup.xserver.xdima.getDistanceMatrix inValue = new com.ptvgroup.xserver.xdima.getDistanceMatrix();
            inValue.request = request;
            com.ptvgroup.xserver.xdima.getDistanceMatrixResponse retVal = ((com.ptvgroup.xserver.xdima.XDima)(this)).getDistanceMatrix(inValue);
            return retVal.@return;
        }


            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdima.fetchDistanceMatrixResponseResponse com.ptvgroup.xserver.xdima.XDima.fetchDistanceMatrixResponse(com.ptvgroup.xserver.xdima.fetchDistanceMatrixResponse request) {
                return base.Channel.fetchDistanceMatrixResponse(request);
            }

            public com.ptvgroup.xserver.xdima.DistanceMatrixResponse fetchDistanceMatrixResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xdima.fetchDistanceMatrixResponse inValue = new com.ptvgroup.xserver.xdima.fetchDistanceMatrixResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xdima.fetchDistanceMatrixResponseResponse retVal = ((com.ptvgroup.xserver.xdima.XDima)(this)).fetchDistanceMatrixResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdima.watchJobResponse com.ptvgroup.xserver.xdima.XDima.watchJob(com.ptvgroup.xserver.xdima.watchJob request) {
                return base.Channel.watchJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job watchJob(com.ptvgroup.xserver.jobs.WatchRequest request) {
                com.ptvgroup.xserver.xdima.watchJob inValue = new com.ptvgroup.xserver.xdima.watchJob();
                inValue.request = request;
                com.ptvgroup.xserver.xdima.watchJobResponse retVal = ((com.ptvgroup.xserver.xdima.XDima)(this)).watchJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdima.stopJobResponse com.ptvgroup.xserver.xdima.XDima.stopJob(com.ptvgroup.xserver.xdima.stopJob request) {
                return base.Channel.stopJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job stopJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xdima.stopJob inValue = new com.ptvgroup.xserver.xdima.stopJob();
                inValue.request = request;
                com.ptvgroup.xserver.xdima.stopJobResponse retVal = ((com.ptvgroup.xserver.xdima.XDima)(this)).stopJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xdima.deleteJobResponse com.ptvgroup.xserver.xdima.XDima.deleteJob(com.ptvgroup.xserver.xdima.deleteJob request) {
                return base.Channel.deleteJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job deleteJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xdima.deleteJob inValue = new com.ptvgroup.xserver.xdima.deleteJob();
                inValue.request = request;
                com.ptvgroup.xserver.xdima.deleteJobResponse retVal = ((com.ptvgroup.xserver.xdima.XDima)(this)).deleteJob(inValue);
                return retVal.@return;
            }

   }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class CreateAndGetDistanceMatrixRequest : com.ptvgroup.xserver.xdima.CreateDistanceMatrixRequest {

        private com.ptvgroup.xserver.xdima.DistanceMatrixContentsResultFields resultFieldsField;
        private com.ptvgroup.xserver.xdima.DistanceMatrixContentsOptions contentsOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdima.DistanceMatrixContentsResultFields resultFields {
            get {
                return this.resultFieldsField;
            }
            set {
                this.resultFieldsField = value;
                this.RaisePropertyChanged("resultFields");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("contentsOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdima.DistanceMatrixContentsOptions contentsOptions {
            get {
                return this.contentsOptionsField;
            }
            set {
                this.contentsOptionsField = value;
                this.RaisePropertyChanged("contentsOptions");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.CreateAndGetDistanceMatrixRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class CreateDistanceMatrixRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.routing.RouteLocation[] startLocationsField;
        private com.ptvgroup.xserver.routing.RouteLocation[] destinationLocationsField;
        private string labelField;
        private com.ptvgroup.xserver.dima.DistanceMatrixOptions distanceMatrixOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("startLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation[] startLocations {
            get {
                return this.startLocationsField;
            }
            set {
                this.startLocationsField = value;
                this.RaisePropertyChanged("startLocations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("destinationLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation[] destinationLocations {
            get {
                return this.destinationLocationsField;
            }
            set {
                this.destinationLocationsField = value;
                this.RaisePropertyChanged("destinationLocations");
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

                    [System.Xml.Serialization.XmlElementAttribute("distanceMatrixOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.dima.DistanceMatrixOptions distanceMatrixOptions {
            get {
                return this.distanceMatrixOptionsField;
            }
            set {
                this.distanceMatrixOptionsField = value;
                this.RaisePropertyChanged("distanceMatrixOptions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class DeleteDistanceMatrixRequest : com.ptvgroup.xserver.service.RequestBase {

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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.DistanceMatrixContentsArrays))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.DistanceMatrixContentsEncodedArrays))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public abstract partial class DistanceMatrixContents : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixContentsArrays : com.ptvgroup.xserver.xdima.DistanceMatrixContents {

        private double[] distancesField;
        private double[] travelTimesField;
        private bool[] violatedField;
        private bool[] estimatedByDirectDistanceField;
        private double[] tollCostsField;

                    [System.Xml.Serialization.XmlElementAttribute("distances", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double[] distances {
            get {
                return this.distancesField;
            }
            set {
                this.distancesField = value;
                this.RaisePropertyChanged("distances");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("travelTimes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double[] travelTimes {
            get {
                return this.travelTimesField;
            }
            set {
                this.travelTimesField = value;
                this.RaisePropertyChanged("travelTimes");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("violated", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool[] violated {
            get {
                return this.violatedField;
            }
            set {
                this.violatedField = value;
                this.RaisePropertyChanged("violated");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("estimatedByDirectDistance", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool[] estimatedByDirectDistance {
            get {
                return this.estimatedByDirectDistanceField;
            }
            set {
                this.estimatedByDirectDistanceField = value;
                this.RaisePropertyChanged("estimatedByDirectDistance");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tollCosts", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double[] tollCosts {
            get {
                return this.tollCostsField;
            }
            set {
                this.tollCostsField = value;
                this.RaisePropertyChanged("tollCosts");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixContentsEncodedArrays : com.ptvgroup.xserver.xdima.DistanceMatrixContents {

        private byte[] distancesField;
        private byte[] travelTimesField;
        private byte[] violatedField;
        private byte[] estimatedByDirectDistanceField;
        private byte[] tollCostsField;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
        public byte[] distances {
            get {
                return this.distancesField;
            }
            set {
                this.distancesField = value;
                this.RaisePropertyChanged("distances");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
        public byte[] travelTimes {
            get {
                return this.travelTimesField;
            }
            set {
                this.travelTimesField = value;
                this.RaisePropertyChanged("travelTimes");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
        public byte[] violated {
            get {
                return this.violatedField;
            }
            set {
                this.violatedField = value;
                this.RaisePropertyChanged("violated");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
        public byte[] estimatedByDirectDistance {
            get {
                return this.estimatedByDirectDistanceField;
            }
            set {
                this.estimatedByDirectDistanceField = value;
                this.RaisePropertyChanged("estimatedByDirectDistance");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
        public byte[] tollCosts {
            get {
                return this.tollCostsField;
            }
            set {
                this.tollCostsField = value;
                this.RaisePropertyChanged("tollCosts");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixContentsOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private bool returnEncodedArraysField;
        private bool returnEncodedArraysFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool returnEncodedArrays {
            get {
                return this.returnEncodedArraysField;
            }
            set {
                this.returnEncodedArraysField = value;
                this.RaisePropertyChanged("returnEncodedArrays");
                this.returnEncodedArraysFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool returnEncodedArraysSpecified {
            get {
                return this.returnEncodedArraysFieldSpecified;
            }
            set {
                this.returnEncodedArraysFieldSpecified = value;
                this.RaisePropertyChanged("returnEncodedArraysSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixContentsResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool distancesField;
        private bool distancesFieldSpecified;
        private bool travelTimesField;
        private bool travelTimesFieldSpecified;
        private bool violatedField;
        private bool violatedFieldSpecified;
        private bool estimatedByDirectDistanceField;
        private bool estimatedByDirectDistanceFieldSpecified;
        private bool tollCostsField;
        private bool tollCostsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool distances {
            get {
                return this.distancesField;
            }
            set {
                this.distancesField = value;
                this.RaisePropertyChanged("distances");
                this.distancesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool distancesSpecified {
            get {
                return this.distancesFieldSpecified;
            }
            set {
                this.distancesFieldSpecified = value;
                this.RaisePropertyChanged("distancesSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool travelTimes {
            get {
                return this.travelTimesField;
            }
            set {
                this.travelTimesField = value;
                this.RaisePropertyChanged("travelTimes");
                this.travelTimesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool travelTimesSpecified {
            get {
                return this.travelTimesFieldSpecified;
            }
            set {
                this.travelTimesFieldSpecified = value;
                this.RaisePropertyChanged("travelTimesSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool violated {
            get {
                return this.violatedField;
            }
            set {
                this.violatedField = value;
                this.RaisePropertyChanged("violated");
                this.violatedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool violatedSpecified {
            get {
                return this.violatedFieldSpecified;
            }
            set {
                this.violatedFieldSpecified = value;
                this.RaisePropertyChanged("violatedSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool estimatedByDirectDistance {
            get {
                return this.estimatedByDirectDistanceField;
            }
            set {
                this.estimatedByDirectDistanceField = value;
                this.RaisePropertyChanged("estimatedByDirectDistance");
                this.estimatedByDirectDistanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedByDirectDistanceSpecified {
            get {
                return this.estimatedByDirectDistanceFieldSpecified;
            }
            set {
                this.estimatedByDirectDistanceFieldSpecified = value;
                this.RaisePropertyChanged("estimatedByDirectDistanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool tollCosts {
            get {
                return this.tollCostsField;
            }
            set {
                this.tollCostsField = value;
                this.RaisePropertyChanged("tollCosts");
                this.tollCostsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tollCostsSpecified {
            get {
                return this.tollCostsFieldSpecified;
            }
            set {
                this.tollCostsFieldSpecified = value;
                this.RaisePropertyChanged("tollCostsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixDescription : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.dima.DistanceMatrixSummary summaryField;
        private com.ptvgroup.xserver.routing.RouteLocation[] startLocationsField;
        private com.ptvgroup.xserver.routing.RouteLocation[] destinationLocationsField;
        private com.ptvgroup.xserver.xdima.Relation[] directDistanceRelationsField;
        private com.ptvgroup.xserver.dima.DistanceMatrixOptions distanceMatrixOptionsField;
        private com.ptvgroup.xserver.profile.RequestProfile profileField;
        private string tenantField;
        private string scopeField;
        private System.DateTime lastUsedAtField;
        private bool lastUsedAtFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("summary", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.dima.DistanceMatrixSummary summary {
            get {
                return this.summaryField;
            }
            set {
                this.summaryField = value;
                this.RaisePropertyChanged("summary");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("startLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation[] startLocations {
            get {
                return this.startLocationsField;
            }
            set {
                this.startLocationsField = value;
                this.RaisePropertyChanged("startLocations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("destinationLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation[] destinationLocations {
            get {
                return this.destinationLocationsField;
            }
            set {
                this.destinationLocationsField = value;
                this.RaisePropertyChanged("destinationLocations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("directDistanceRelations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdima.Relation[] directDistanceRelations {
            get {
                return this.directDistanceRelationsField;
            }
            set {
                this.directDistanceRelationsField = value;
                this.RaisePropertyChanged("directDistanceRelations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("distanceMatrixOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.dima.DistanceMatrixOptions distanceMatrixOptions {
            get {
                return this.distanceMatrixOptionsField;
            }
            set {
                this.distanceMatrixOptionsField = value;
                this.RaisePropertyChanged("distanceMatrixOptions");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixInformation : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xdima.DistanceMatrixDescription distanceMatrixDescriptionField;
        private com.ptvgroup.xserver.exceptions.SuppressedXServerException listExceptionField;

                    [System.Xml.Serialization.XmlElementAttribute("distanceMatrixDescription", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdima.DistanceMatrixDescription distanceMatrixDescription {
            get {
                return this.distanceMatrixDescriptionField;
            }
            set {
                this.distanceMatrixDescriptionField = value;
                this.RaisePropertyChanged("distanceMatrixDescription");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixListResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xdima.DistanceMatrixInformation[] distanceMatrixInformationField;

                    [System.Xml.Serialization.XmlElementAttribute("distanceMatrixInformation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdima.DistanceMatrixInformation[] distanceMatrixInformation {
            get {
                return this.distanceMatrixInformationField;
            }
            set {
                this.distanceMatrixInformationField = value;
                this.RaisePropertyChanged("distanceMatrixInformation");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.dima.DistanceMatrixSummary summaryField;
        private com.ptvgroup.xserver.xdima.DistanceMatrixContents contentsField;

                    [System.Xml.Serialization.XmlElementAttribute("summary", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.dima.DistanceMatrixSummary summary {
            get {
                return this.summaryField;
            }
            set {
                this.summaryField = value;
                this.RaisePropertyChanged("summary");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("contents", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdima.DistanceMatrixContents contents {
            get {
                return this.contentsField;
            }
            set {
                this.contentsField = value;
                this.RaisePropertyChanged("contents");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool summaryField;
        private bool summaryFieldSpecified;
        private com.ptvgroup.xserver.xdima.DistanceMatrixContentsResultFields distanceMatrixContentsResultFieldsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool summary {
            get {
                return this.summaryField;
            }
            set {
                this.summaryField = value;
                this.RaisePropertyChanged("summary");
                this.summaryFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool summarySpecified {
            get {
                return this.summaryFieldSpecified;
            }
            set {
                this.summaryFieldSpecified = value;
                this.RaisePropertyChanged("summarySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("distanceMatrixContentsResultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdima.DistanceMatrixContentsResultFields distanceMatrixContentsResultFields {
            get {
                return this.distanceMatrixContentsResultFieldsField;
            }
            set {
                this.distanceMatrixContentsResultFieldsField = value;
                this.RaisePropertyChanged("distanceMatrixContentsResultFields");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class ExtendDistanceMatrixRequest : com.ptvgroup.xserver.xdima.UpdateDistanceMatrixRequest {

        private com.ptvgroup.xserver.routing.RouteLocation[] startLocationsField;
        private com.ptvgroup.xserver.routing.RouteLocation[] destinationLocationsField;

                    [System.Xml.Serialization.XmlElementAttribute("startLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation[] startLocations {
            get {
                return this.startLocationsField;
            }
            set {
                this.startLocationsField = value;
                this.RaisePropertyChanged("startLocations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("destinationLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation[] destinationLocations {
            get {
                return this.destinationLocationsField;
            }
            set {
                this.destinationLocationsField = value;
                this.RaisePropertyChanged("destinationLocations");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class GetDistanceMatrixByLocationsRequest : com.ptvgroup.xserver.xdima.GetDistanceMatrixRequest {

        private com.ptvgroup.xserver.routing.RouteLocation[] startLocationsField;
        private com.ptvgroup.xserver.routing.RouteLocation[] destinationLocationsField;

                    [System.Xml.Serialization.XmlElementAttribute("startLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation[] startLocations {
            get {
                return this.startLocationsField;
            }
            set {
                this.startLocationsField = value;
                this.RaisePropertyChanged("startLocations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("destinationLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation[] destinationLocations {
            get {
                return this.destinationLocationsField;
            }
            set {
                this.destinationLocationsField = value;
                this.RaisePropertyChanged("destinationLocations");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class GetDistanceMatrixByRelationsRequest : com.ptvgroup.xserver.xdima.GetDistanceMatrixRequest {

        private com.ptvgroup.xserver.xdima.Relation[] relationsField;

                    [System.Xml.Serialization.XmlElementAttribute("relations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdima.Relation[] relations {
            get {
                return this.relationsField;
            }
            set {
                this.relationsField = value;
                this.RaisePropertyChanged("relations");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.GetDistanceMatrixByLocationsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.GetDistanceMatrixByRelationsRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public abstract partial class GetDistanceMatrixRequest : com.ptvgroup.xserver.service.RequestBase {

        private string idField;
        private com.ptvgroup.xserver.xdima.DistanceMatrixResultFields resultFieldsField;
        private com.ptvgroup.xserver.xdima.DistanceMatrixContentsOptions contentsOptionsField;

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

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdima.DistanceMatrixResultFields resultFields {
            get {
                return this.resultFieldsField;
            }
            set {
                this.resultFieldsField = value;
                this.RaisePropertyChanged("resultFields");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("contentsOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdima.DistanceMatrixContentsOptions contentsOptions {
            get {
                return this.contentsOptionsField;
            }
            set {
                this.contentsOptionsField = value;
                this.RaisePropertyChanged("contentsOptions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class ListDistanceMatricesRequest : com.ptvgroup.xserver.service.RequestBase {

        private string[] idsField;
        private com.ptvgroup.xserver.xdima.ListDistanceMatricesResultFields resultFieldsField;

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

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xdima.ListDistanceMatricesResultFields resultFields {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class ListDistanceMatricesResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool startLocationsField;
        private bool startLocationsFieldSpecified;
        private bool destinationLocationsField;
        private bool destinationLocationsFieldSpecified;
        private bool directDistanceRelationsField;
        private bool directDistanceRelationsFieldSpecified;
        private bool distanceMatrixOptionsField;
        private bool distanceMatrixOptionsFieldSpecified;
        private bool profilesField;
        private bool profilesFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool startLocations {
            get {
                return this.startLocationsField;
            }
            set {
                this.startLocationsField = value;
                this.RaisePropertyChanged("startLocations");
                this.startLocationsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startLocationsSpecified {
            get {
                return this.startLocationsFieldSpecified;
            }
            set {
                this.startLocationsFieldSpecified = value;
                this.RaisePropertyChanged("startLocationsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool destinationLocations {
            get {
                return this.destinationLocationsField;
            }
            set {
                this.destinationLocationsField = value;
                this.RaisePropertyChanged("destinationLocations");
                this.destinationLocationsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool destinationLocationsSpecified {
            get {
                return this.destinationLocationsFieldSpecified;
            }
            set {
                this.destinationLocationsFieldSpecified = value;
                this.RaisePropertyChanged("destinationLocationsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool directDistanceRelations {
            get {
                return this.directDistanceRelationsField;
            }
            set {
                this.directDistanceRelationsField = value;
                this.RaisePropertyChanged("directDistanceRelations");
                this.directDistanceRelationsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directDistanceRelationsSpecified {
            get {
                return this.directDistanceRelationsFieldSpecified;
            }
            set {
                this.directDistanceRelationsFieldSpecified = value;
                this.RaisePropertyChanged("directDistanceRelationsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool distanceMatrixOptions {
            get {
                return this.distanceMatrixOptionsField;
            }
            set {
                this.distanceMatrixOptionsField = value;
                this.RaisePropertyChanged("distanceMatrixOptions");
                this.distanceMatrixOptionsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool distanceMatrixOptionsSpecified {
            get {
                return this.distanceMatrixOptionsFieldSpecified;
            }
            set {
                this.distanceMatrixOptionsFieldSpecified = value;
                this.RaisePropertyChanged("distanceMatrixOptionsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public partial class Relation : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routing.RouteLocation startLocationField;
        private com.ptvgroup.xserver.routing.RouteLocation destinationLocationField;

                    [System.Xml.Serialization.XmlElementAttribute("startLocation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation startLocation {
            get {
                return this.startLocationField;
            }
            set {
                this.startLocationField = value;
                this.RaisePropertyChanged("startLocation");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("destinationLocation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation destinationLocation {
            get {
                return this.destinationLocationField;
            }
            set {
                this.destinationLocationField = value;
                this.RaisePropertyChanged("destinationLocation");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.ExtendDistanceMatrixRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xdima.xserver.ptvgroup.com")]
    public abstract partial class UpdateDistanceMatrixRequest : com.ptvgroup.xserver.service.RequestBase {

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



}
