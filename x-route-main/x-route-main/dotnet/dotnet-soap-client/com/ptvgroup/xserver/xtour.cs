// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.xtour 
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public interface XTour {


            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.planToursResponse planTours(com.ptvgroup.xserver.xtour.planTours request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.startPlanToursResponse startPlanTours(com.ptvgroup.xserver.xtour.startPlanTours request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.changeToursResponse changeTours(com.ptvgroup.xserver.xtour.changeTours request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.startChangeToursResponse startChangeTours(com.ptvgroup.xserver.xtour.startChangeTours request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.findChangeToursProposalsResponse findChangeToursProposals(com.ptvgroup.xserver.xtour.findChangeToursProposals request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.startFindChangeToursProposalsResponse startFindChangeToursProposals(com.ptvgroup.xserver.xtour.startFindChangeToursProposals request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.evaluateToursInExecutionResponse evaluateToursInExecution(com.ptvgroup.xserver.xtour.evaluateToursInExecution request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.startEvaluateToursInExecutionResponse startEvaluateToursInExecution(com.ptvgroup.xserver.xtour.startEvaluateToursInExecution request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.fetchChangeToursProposalsResponseResponse fetchChangeToursProposalsResponse(com.ptvgroup.xserver.xtour.fetchChangeToursProposalsResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.fetchToursResponseResponse fetchToursResponse(com.ptvgroup.xserver.xtour.fetchToursResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.watchJobResponse watchJob(com.ptvgroup.xserver.xtour.watchJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.stopJobResponse stopJob(com.ptvgroup.xserver.xtour.stopJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xtour.deleteJobResponse deleteJob(com.ptvgroup.xserver.xtour.deleteJob request);
    }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="planTours", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class planTours {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.PlanToursRequest request;

                public planTours() {
                }

                public planTours(com.ptvgroup.xserver.xtour.PlanToursRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="planToursResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class planToursResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.ToursResponse @return;

                public planToursResponse() {
                }

                public planToursResponse(com.ptvgroup.xserver.xtour.ToursResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startPlanTours", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startPlanTours {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.PlanToursRequest request;

                public startPlanTours() {
                }

                public startPlanTours(com.ptvgroup.xserver.xtour.PlanToursRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startPlanToursResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startPlanToursResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startPlanToursResponse() {
                }

                public startPlanToursResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="changeTours", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class changeTours {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.ChangeToursRequest request;

                public changeTours() {
                }

                public changeTours(com.ptvgroup.xserver.xtour.ChangeToursRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="changeToursResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class changeToursResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.ToursResponse @return;

                public changeToursResponse() {
                }

                public changeToursResponse(com.ptvgroup.xserver.xtour.ToursResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startChangeTours", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startChangeTours {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.ChangeToursRequest request;

                public startChangeTours() {
                }

                public startChangeTours(com.ptvgroup.xserver.xtour.ChangeToursRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startChangeToursResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startChangeToursResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startChangeToursResponse() {
                }

                public startChangeToursResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="findChangeToursProposals", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class findChangeToursProposals {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.FindChangeToursProposalsRequest request;

                public findChangeToursProposals() {
                }

                public findChangeToursProposals(com.ptvgroup.xserver.xtour.FindChangeToursProposalsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="findChangeToursProposalsResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class findChangeToursProposalsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.ChangeToursProposalsResponse @return;

                public findChangeToursProposalsResponse() {
                }

                public findChangeToursProposalsResponse(com.ptvgroup.xserver.xtour.ChangeToursProposalsResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startFindChangeToursProposals", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startFindChangeToursProposals {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.FindChangeToursProposalsRequest request;

                public startFindChangeToursProposals() {
                }

                public startFindChangeToursProposals(com.ptvgroup.xserver.xtour.FindChangeToursProposalsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startFindChangeToursProposalsResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startFindChangeToursProposalsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startFindChangeToursProposalsResponse() {
                }

                public startFindChangeToursProposalsResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="evaluateToursInExecution", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class evaluateToursInExecution {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.ToursInExecutionRequest request;

                public evaluateToursInExecution() {
                }

                public evaluateToursInExecution(com.ptvgroup.xserver.xtour.ToursInExecutionRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="evaluateToursInExecutionResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class evaluateToursInExecutionResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.ToursResponse @return;

                public evaluateToursInExecutionResponse() {
                }

                public evaluateToursInExecutionResponse(com.ptvgroup.xserver.xtour.ToursResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startEvaluateToursInExecution", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startEvaluateToursInExecution {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.ToursInExecutionRequest request;

                public startEvaluateToursInExecution() {
                }

                public startEvaluateToursInExecution(com.ptvgroup.xserver.xtour.ToursInExecutionRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startEvaluateToursInExecutionResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startEvaluateToursInExecutionResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startEvaluateToursInExecutionResponse() {
                }

                public startEvaluateToursInExecutionResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchChangeToursProposalsResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchChangeToursProposalsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchChangeToursProposalsResponse() {
                }

                public fetchChangeToursProposalsResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchChangeToursProposalsResponseResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchChangeToursProposalsResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.ChangeToursProposalsResponse @return;

                public fetchChangeToursProposalsResponseResponse() {
                }

                public fetchChangeToursProposalsResponseResponse(com.ptvgroup.xserver.xtour.ChangeToursProposalsResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchToursResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchToursResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchToursResponse() {
                }

                public fetchToursResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchToursResponseResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchToursResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xtour.ToursResponse @return;

                public fetchToursResponseResponse() {
                }

                public fetchToursResponseResponse(com.ptvgroup.xserver.xtour.ToursResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJob", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJobResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJob", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJobResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJob", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJobResponse", WrapperNamespace="http://xtour.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xtour.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public deleteJobResponse() {
                }

                public deleteJobResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XTourChannel : com.ptvgroup.xserver.xtour.XTour, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XTourClient : System.ServiceModel.ClientBase<com.ptvgroup.xserver.xtour.XTour>, com.ptvgroup.xserver.xtour.XTour {

        public XTourClient() :
            this("http://localhost:50000/services/ws/XTour") {
        }

        public XTourClient(string baseUri , string version="") :
            this(new System.ServiceModel.BasicHttpBinding { MaxReceivedMessageSize = System.Int32.MaxValue }, new System.ServiceModel.EndpointAddress(baseUri+"/services/ws/XTour/"+version)) {
        }

        public XTourClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress) {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xtour.planToursResponse com.ptvgroup.xserver.xtour.XTour.planTours(com.ptvgroup.xserver.xtour.planTours request) {
            return base.Channel.planTours(request);
        }

        public com.ptvgroup.xserver.xtour.ToursResponse planTours(com.ptvgroup.xserver.xtour.PlanToursRequest request) {
            com.ptvgroup.xserver.xtour.planTours inValue = new com.ptvgroup.xserver.xtour.planTours();
            inValue.request = request;
            com.ptvgroup.xserver.xtour.planToursResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).planTours(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xtour.startPlanToursResponse com.ptvgroup.xserver.xtour.XTour.startPlanTours(com.ptvgroup.xserver.xtour.startPlanTours request) {
                return base.Channel.startPlanTours(request);
            }

            public com.ptvgroup.xserver.jobs.Job startPlanTours(com.ptvgroup.xserver.xtour.PlanToursRequest request) {
                com.ptvgroup.xserver.xtour.startPlanTours inValue = new com.ptvgroup.xserver.xtour.startPlanTours();
                inValue.request = request;
                com.ptvgroup.xserver.xtour.startPlanToursResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).startPlanTours(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xtour.changeToursResponse com.ptvgroup.xserver.xtour.XTour.changeTours(com.ptvgroup.xserver.xtour.changeTours request) {
            return base.Channel.changeTours(request);
        }

        public com.ptvgroup.xserver.xtour.ToursResponse changeTours(com.ptvgroup.xserver.xtour.ChangeToursRequest request) {
            com.ptvgroup.xserver.xtour.changeTours inValue = new com.ptvgroup.xserver.xtour.changeTours();
            inValue.request = request;
            com.ptvgroup.xserver.xtour.changeToursResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).changeTours(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xtour.startChangeToursResponse com.ptvgroup.xserver.xtour.XTour.startChangeTours(com.ptvgroup.xserver.xtour.startChangeTours request) {
                return base.Channel.startChangeTours(request);
            }

            public com.ptvgroup.xserver.jobs.Job startChangeTours(com.ptvgroup.xserver.xtour.ChangeToursRequest request) {
                com.ptvgroup.xserver.xtour.startChangeTours inValue = new com.ptvgroup.xserver.xtour.startChangeTours();
                inValue.request = request;
                com.ptvgroup.xserver.xtour.startChangeToursResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).startChangeTours(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xtour.findChangeToursProposalsResponse com.ptvgroup.xserver.xtour.XTour.findChangeToursProposals(com.ptvgroup.xserver.xtour.findChangeToursProposals request) {
            return base.Channel.findChangeToursProposals(request);
        }

        public com.ptvgroup.xserver.xtour.ChangeToursProposalsResponse findChangeToursProposals(com.ptvgroup.xserver.xtour.FindChangeToursProposalsRequest request) {
            com.ptvgroup.xserver.xtour.findChangeToursProposals inValue = new com.ptvgroup.xserver.xtour.findChangeToursProposals();
            inValue.request = request;
            com.ptvgroup.xserver.xtour.findChangeToursProposalsResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).findChangeToursProposals(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xtour.startFindChangeToursProposalsResponse com.ptvgroup.xserver.xtour.XTour.startFindChangeToursProposals(com.ptvgroup.xserver.xtour.startFindChangeToursProposals request) {
                return base.Channel.startFindChangeToursProposals(request);
            }

            public com.ptvgroup.xserver.jobs.Job startFindChangeToursProposals(com.ptvgroup.xserver.xtour.FindChangeToursProposalsRequest request) {
                com.ptvgroup.xserver.xtour.startFindChangeToursProposals inValue = new com.ptvgroup.xserver.xtour.startFindChangeToursProposals();
                inValue.request = request;
                com.ptvgroup.xserver.xtour.startFindChangeToursProposalsResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).startFindChangeToursProposals(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xtour.evaluateToursInExecutionResponse com.ptvgroup.xserver.xtour.XTour.evaluateToursInExecution(com.ptvgroup.xserver.xtour.evaluateToursInExecution request) {
            return base.Channel.evaluateToursInExecution(request);
        }

        public com.ptvgroup.xserver.xtour.ToursResponse evaluateToursInExecution(com.ptvgroup.xserver.xtour.ToursInExecutionRequest request) {
            com.ptvgroup.xserver.xtour.evaluateToursInExecution inValue = new com.ptvgroup.xserver.xtour.evaluateToursInExecution();
            inValue.request = request;
            com.ptvgroup.xserver.xtour.evaluateToursInExecutionResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).evaluateToursInExecution(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xtour.startEvaluateToursInExecutionResponse com.ptvgroup.xserver.xtour.XTour.startEvaluateToursInExecution(com.ptvgroup.xserver.xtour.startEvaluateToursInExecution request) {
                return base.Channel.startEvaluateToursInExecution(request);
            }

            public com.ptvgroup.xserver.jobs.Job startEvaluateToursInExecution(com.ptvgroup.xserver.xtour.ToursInExecutionRequest request) {
                com.ptvgroup.xserver.xtour.startEvaluateToursInExecution inValue = new com.ptvgroup.xserver.xtour.startEvaluateToursInExecution();
                inValue.request = request;
                com.ptvgroup.xserver.xtour.startEvaluateToursInExecutionResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).startEvaluateToursInExecution(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xtour.fetchChangeToursProposalsResponseResponse com.ptvgroup.xserver.xtour.XTour.fetchChangeToursProposalsResponse(com.ptvgroup.xserver.xtour.fetchChangeToursProposalsResponse request) {
                return base.Channel.fetchChangeToursProposalsResponse(request);
            }

            public com.ptvgroup.xserver.xtour.ChangeToursProposalsResponse fetchChangeToursProposalsResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xtour.fetchChangeToursProposalsResponse inValue = new com.ptvgroup.xserver.xtour.fetchChangeToursProposalsResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xtour.fetchChangeToursProposalsResponseResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).fetchChangeToursProposalsResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xtour.fetchToursResponseResponse com.ptvgroup.xserver.xtour.XTour.fetchToursResponse(com.ptvgroup.xserver.xtour.fetchToursResponse request) {
                return base.Channel.fetchToursResponse(request);
            }

            public com.ptvgroup.xserver.xtour.ToursResponse fetchToursResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xtour.fetchToursResponse inValue = new com.ptvgroup.xserver.xtour.fetchToursResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xtour.fetchToursResponseResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).fetchToursResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xtour.watchJobResponse com.ptvgroup.xserver.xtour.XTour.watchJob(com.ptvgroup.xserver.xtour.watchJob request) {
                return base.Channel.watchJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job watchJob(com.ptvgroup.xserver.jobs.WatchRequest request) {
                com.ptvgroup.xserver.xtour.watchJob inValue = new com.ptvgroup.xserver.xtour.watchJob();
                inValue.request = request;
                com.ptvgroup.xserver.xtour.watchJobResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).watchJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xtour.stopJobResponse com.ptvgroup.xserver.xtour.XTour.stopJob(com.ptvgroup.xserver.xtour.stopJob request) {
                return base.Channel.stopJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job stopJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xtour.stopJob inValue = new com.ptvgroup.xserver.xtour.stopJob();
                inValue.request = request;
                com.ptvgroup.xserver.xtour.stopJobResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).stopJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xtour.deleteJobResponse com.ptvgroup.xserver.xtour.XTour.deleteJob(com.ptvgroup.xserver.xtour.deleteJob request) {
                return base.Channel.deleteJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job deleteJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xtour.deleteJob inValue = new com.ptvgroup.xserver.xtour.deleteJob();
                inValue.request = request;
                com.ptvgroup.xserver.xtour.deleteJobResponse retVal = ((com.ptvgroup.xserver.xtour.XTour)(this)).deleteJob(inValue);
                return retVal.@return;
            }

   }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class AddFixationsAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private com.ptvgroup.xserver.xtour.Fixation[] fixationsField;

                    [System.Xml.Serialization.XmlElementAttribute("fixations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Fixation[] fixations {
            get {
                return this.fixationsField;
            }
            set {
                this.fixationsField = value;
                this.RaisePropertyChanged("fixations");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class AddTripAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private string[] orderIdsField;
        private string targetVehicleIdField;
        private com.ptvgroup.xserver.xtour.InsertionPosition insertionPositionField;

                    [System.Xml.Serialization.XmlElementAttribute("orderIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] orderIds {
            get {
                return this.orderIdsField;
            }
            set {
                this.orderIdsField = value;
                this.RaisePropertyChanged("orderIds");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetVehicleId {
            get {
                return this.targetVehicleIdField;
            }
            set {
                this.targetVehicleIdField = value;
                this.RaisePropertyChanged("targetVehicleId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("insertionPosition", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.InsertionPosition insertionPosition {
            get {
                return this.insertionPositionField;
            }
            set {
                this.insertionPositionField = value;
                this.RaisePropertyChanged("insertionPosition");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class AddTripStartIntervalsAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private com.ptvgroup.xserver.xtour.TripStartInterval[] tripStartIntervalsField;

                    [System.Xml.Serialization.XmlElementAttribute("tripStartIntervals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.TripStartInterval[] tripStartIntervals {
            get {
                return this.tripStartIntervalsField;
            }
            set {
                this.tripStartIntervalsField = value;
                this.RaisePropertyChanged("tripStartIntervals");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class BreakInterval : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.time.Interval intervalField;
        private double breakTimeField;

                    [System.Xml.Serialization.XmlElementAttribute("interval", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.time.Interval interval {
            get {
                return this.intervalField;
            }
            set {
                this.intervalField = value;
                this.RaisePropertyChanged("interval");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double breakTime {
            get {
                return this.breakTimeField;
            }
            set {
                this.breakTimeField = value;
                this.RaisePropertyChanged("breakTime");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.AddFixationsAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.AddTripAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.AddTripStartIntervalsAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.ChangeVehicleAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.MoveOrdersAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.MoveStopsAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.MoveTripsAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.OptimizeStopSequenceAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.RemoveFixationsAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.RemoveOrdersAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.RemoveToursAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.RemoveTripStartIntervalsAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.RemoveTripsAction))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public abstract partial class ChangeToursAction : object, System.ComponentModel.INotifyPropertyChanged {

        private string storedRequestIdField;

                    [System.Xml.Serialization.XmlElementAttribute("storedRequestId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string storedRequestId {
            get {
                return this.storedRequestIdField;
            }
            set {
                this.storedRequestIdField = value;
                this.RaisePropertyChanged("storedRequestId");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class ChangeToursProposal : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xtour.ChangeToursAction changeToursActionField;
        private com.ptvgroup.xserver.xtour.Tour[] toursField;
        private com.ptvgroup.xserver.xtour.TourReport[] tourReportsField;
        private string[] vehicleIdsNotPlannedField;
        private bool violatedField;
        private bool violatedFieldSpecified;
        private bool preferencesRespectedField;
        private bool preferencesRespectedFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("changeToursAction", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.ChangeToursAction changeToursAction {
            get {
                return this.changeToursActionField;
            }
            set {
                this.changeToursActionField = value;
                this.RaisePropertyChanged("changeToursAction");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tours", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Tour[] tours {
            get {
                return this.toursField;
            }
            set {
                this.toursField = value;
                this.RaisePropertyChanged("tours");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tourReports", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.TourReport[] tourReports {
            get {
                return this.tourReportsField;
            }
            set {
                this.tourReportsField = value;
                this.RaisePropertyChanged("tourReports");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("vehicleIdsNotPlanned", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] vehicleIdsNotPlanned {
            get {
                return this.vehicleIdsNotPlannedField;
            }
            set {
                this.vehicleIdsNotPlannedField = value;
                this.RaisePropertyChanged("vehicleIdsNotPlanned");
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
        public bool preferencesRespected {
            get {
                return this.preferencesRespectedField;
            }
            set {
                this.preferencesRespectedField = value;
                this.RaisePropertyChanged("preferencesRespected");
                this.preferencesRespectedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool preferencesRespectedSpecified {
            get {
                return this.preferencesRespectedFieldSpecified;
            }
            set {
                this.preferencesRespectedFieldSpecified = value;
                this.RaisePropertyChanged("preferencesRespectedSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class ChangeToursProposalsOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private bool returnViolatedToursField;
        private bool returnViolatedToursFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool returnViolatedTours {
            get {
                return this.returnViolatedToursField;
            }
            set {
                this.returnViolatedToursField = value;
                this.RaisePropertyChanged("returnViolatedTours");
                this.returnViolatedToursFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool returnViolatedToursSpecified {
            get {
                return this.returnViolatedToursFieldSpecified;
            }
            set {
                this.returnViolatedToursFieldSpecified = value;
                this.RaisePropertyChanged("returnViolatedToursSpecified");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.VehiclesForTripsQuery))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public abstract partial class ChangeToursProposalsQuery : object, System.ComponentModel.INotifyPropertyChanged {

        private string storedRequestIdField;

                    [System.Xml.Serialization.XmlElementAttribute("storedRequestId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string storedRequestId {
            get {
                return this.storedRequestIdField;
            }
            set {
                this.storedRequestIdField = value;
                this.RaisePropertyChanged("storedRequestId");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class ChangeToursProposalsResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xtour.ChangeToursProposal[] proposalsField;

                    [System.Xml.Serialization.XmlElementAttribute("proposals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.ChangeToursProposal[] proposals {
            get {
                return this.proposalsField;
            }
            set {
                this.proposalsField = value;
                this.RaisePropertyChanged("proposals");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class ChangeToursRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xtour.ChangeToursAction changeToursActionField;

                    [System.Xml.Serialization.XmlElementAttribute("changeToursAction", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.ChangeToursAction changeToursAction {
            get {
                return this.changeToursActionField;
            }
            set {
                this.changeToursActionField = value;
                this.RaisePropertyChanged("changeToursAction");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class ChangeVehicleAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private string currentVehicleIdField;
        private string targetVehicleIdField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currentVehicleId {
            get {
                return this.currentVehicleIdField;
            }
            set {
                this.currentVehicleIdField = value;
                this.RaisePropertyChanged("currentVehicleId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetVehicleId {
            get {
                return this.targetVehicleIdField;
            }
            set {
                this.targetVehicleIdField = value;
                this.RaisePropertyChanged("targetVehicleId");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class CostReport : object, System.ComponentModel.INotifyPropertyChanged {

        private double travelTimeField;
        private double drivingTimeField;
        private double serviceTimeField;
        private bool serviceTimeFieldSpecified;
        private double distanceField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double travelTime {
            get {
                return this.travelTimeField;
            }
            set {
                this.travelTimeField = value;
                this.RaisePropertyChanged("travelTime");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double drivingTime {
            get {
                return this.drivingTimeField;
            }
            set {
                this.drivingTimeField = value;
                this.RaisePropertyChanged("drivingTime");
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
        public double distance {
            get {
                return this.distanceField;
            }
            set {
                this.distanceField = value;
                this.RaisePropertyChanged("distance");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class CustomerSite : com.ptvgroup.xserver.xtour.Site {

        private string customerIdField;
        private com.ptvgroup.xserver.xtour.PositionInTrip positionInTripField;
        private bool positionInTripFieldSpecified;
        private int tripSectionNumberField;
        private bool tripSectionNumberFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string customerId {
            get {
                return this.customerIdField;
            }
            set {
                this.customerIdField = value;
                this.RaisePropertyChanged("customerId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xtour.PositionInTrip positionInTrip {
            get {
                return this.positionInTripField;
            }
            set {
                this.positionInTripField = value;
                this.RaisePropertyChanged("positionInTrip");
                this.positionInTripFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool positionInTripSpecified {
            get {
                return this.positionInTripFieldSpecified;
            }
            set {
                this.positionInTripFieldSpecified = value;
                this.RaisePropertyChanged("positionInTripSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int tripSectionNumber {
            get {
                return this.tripSectionNumberField;
            }
            set {
                this.tripSectionNumberField = value;
                this.RaisePropertyChanged("tripSectionNumber");
                this.tripSectionNumberFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tripSectionNumberSpecified {
            get {
                return this.tripSectionNumberFieldSpecified;
            }
            set {
                this.tripSectionNumberFieldSpecified = value;
                this.RaisePropertyChanged("tripSectionNumberSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class DepotSite : com.ptvgroup.xserver.xtour.Site {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class Driver : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private com.ptvgroup.xserver.time.Interval[] operatingIntervalsField;
        private com.ptvgroup.xserver.xtour.BreakInterval[] breakIntervalsField;
        private string vehicleIdField;
        private com.ptvgroup.xserver.tourplanning.WorkLogbookSummary workLogbookSummaryField;

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

                    [System.Xml.Serialization.XmlElementAttribute("operatingIntervals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.time.Interval[] operatingIntervals {
            get {
                return this.operatingIntervalsField;
            }
            set {
                this.operatingIntervalsField = value;
                this.RaisePropertyChanged("operatingIntervals");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("breakIntervals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.BreakInterval[] breakIntervals {
            get {
                return this.breakIntervalsField;
            }
            set {
                this.breakIntervalsField = value;
                this.RaisePropertyChanged("breakIntervals");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vehicleId {
            get {
                return this.vehicleIdField;
            }
            set {
                this.vehicleIdField = value;
                this.RaisePropertyChanged("vehicleId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("workLogbookSummary", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.tourplanning.WorkLogbookSummary workLogbookSummary {
            get {
                return this.workLogbookSummaryField;
            }
            set {
                this.workLogbookSummaryField = value;
                this.RaisePropertyChanged("workLogbookSummary");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class EstimateByReferenceMatrix : com.ptvgroup.xserver.dima.DistanceMode {

        private string idField;
        private com.ptvgroup.xserver.xtour.ReferenceLocationMapping[] referenceLocationMappingsField;

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

                    [System.Xml.Serialization.XmlElementAttribute("referenceLocationMappings", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.ReferenceLocationMapping[] referenceLocationMappings {
            get {
                return this.referenceLocationMappingsField;
            }
            set {
                this.referenceLocationMappingsField = value;
                this.RaisePropertyChanged("referenceLocationMappings");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class ExecutionState : object, System.ComponentModel.INotifyPropertyChanged {

        private string vehicleIdField;
        private com.ptvgroup.xserver.xtour.VehiclePosition vehiclePositionField;
        private System.DateTime currentTimeField;
        private com.ptvgroup.xserver.tourplanning.WorkLogbookSummary workLogbookSummaryField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vehicleId {
            get {
                return this.vehicleIdField;
            }
            set {
                this.vehicleIdField = value;
                this.RaisePropertyChanged("vehicleId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("vehiclePosition", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.VehiclePosition vehiclePosition {
            get {
                return this.vehiclePositionField;
            }
            set {
                this.vehiclePositionField = value;
                this.RaisePropertyChanged("vehiclePosition");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime currentTime {
            get {
                return this.currentTimeField;
            }
            set {
                this.currentTimeField = value;
                this.RaisePropertyChanged("currentTime");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("workLogbookSummary", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.tourplanning.WorkLogbookSummary workLogbookSummary {
            get {
                return this.workLogbookSummaryField;
            }
            set {
                this.workLogbookSummaryField = value;
                this.RaisePropertyChanged("workLogbookSummary");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class ExistingDistanceMatrixPerVehicle : com.ptvgroup.xserver.dima.DistanceMode {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class FindChangeToursProposalsRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xtour.ChangeToursProposalsQuery proposalsQueryField;
        private com.ptvgroup.xserver.xtour.ChangeToursProposalsOptions proposalsOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("proposalsQuery", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.ChangeToursProposalsQuery proposalsQuery {
            get {
                return this.proposalsQueryField;
            }
            set {
                this.proposalsQueryField = value;
                this.RaisePropertyChanged("proposalsQuery");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("proposalsOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.ChangeToursProposalsOptions proposalsOptions {
            get {
                return this.proposalsOptionsField;
            }
            set {
                this.proposalsOptionsField = value;
                this.RaisePropertyChanged("proposalsOptions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class Fixation : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private com.ptvgroup.xserver.xtour.FixationType fixationTypeField;

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
        public com.ptvgroup.xserver.xtour.FixationType fixationType {
            get {
                return this.fixationTypeField;
            }
            set {
                this.fixationTypeField = value;
                this.RaisePropertyChanged("fixationType");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class Fleet : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xtour.Vehicle[] vehiclesField;
        private com.ptvgroup.xserver.xtour.Driver[] driversField;

                    [System.Xml.Serialization.XmlElementAttribute("vehicles", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Vehicle[] vehicles {
            get {
                return this.vehiclesField;
            }
            set {
                this.vehiclesField = value;
                this.RaisePropertyChanged("vehicles");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("drivers", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Driver[] drivers {
            get {
                return this.driversField;
            }
            set {
                this.driversField = value;
                this.RaisePropertyChanged("drivers");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class InputPlan : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xtour.Tour[] toursField;
        private com.ptvgroup.xserver.xtour.Fixation[] fixationsField;
        private com.ptvgroup.xserver.xtour.TripStartInterval[] tripStartIntervalsField;

                    [System.Xml.Serialization.XmlElementAttribute("tours", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Tour[] tours {
            get {
                return this.toursField;
            }
            set {
                this.toursField = value;
                this.RaisePropertyChanged("tours");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("fixations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Fixation[] fixations {
            get {
                return this.fixationsField;
            }
            set {
                this.fixationsField = value;
                this.RaisePropertyChanged("fixations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tripStartIntervals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.TripStartInterval[] tripStartIntervals {
            get {
                return this.tripStartIntervalsField;
            }
            set {
                this.tripStartIntervalsField = value;
                this.RaisePropertyChanged("tripStartIntervals");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class InsertionAfterSpecifiedPosition : com.ptvgroup.xserver.xtour.InsertionPosition {

        private int positionField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
                this.RaisePropertyChanged("position");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class InsertionAtBestPosition : com.ptvgroup.xserver.xtour.InsertionPosition {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class InsertionBeforeSpecifiedPosition : com.ptvgroup.xserver.xtour.InsertionPosition {

        private int positionField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
                this.RaisePropertyChanged("position");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class InsertionIntoEmptyTour : com.ptvgroup.xserver.xtour.InsertionPosition {



    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.InsertionAfterSpecifiedPosition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.InsertionAtBestPosition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.InsertionBeforeSpecifiedPosition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.InsertionIntoEmptyTour))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public abstract partial class InsertionPosition : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class LegReport : object, System.ComponentModel.INotifyPropertyChanged {

        private int startTourEventIndexField;
        private bool startTourEventIndexFieldSpecified;
        private int endTourEventIndexField;
        private bool endTourEventIndexFieldSpecified;
        private double drivingTimeField;
        private bool drivingTimeFieldSpecified;
        private double distanceField;
        private bool distanceFieldSpecified;
        private bool estimatedByDirectDistanceField;
        private bool estimatedByDirectDistanceFieldSpecified;
        private bool routeViolatedField;
        private bool routeViolatedFieldSpecified;
        private double[] transportQuantitiesField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int startTourEventIndex {
            get {
                return this.startTourEventIndexField;
            }
            set {
                this.startTourEventIndexField = value;
                this.RaisePropertyChanged("startTourEventIndex");
                this.startTourEventIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startTourEventIndexSpecified {
            get {
                return this.startTourEventIndexFieldSpecified;
            }
            set {
                this.startTourEventIndexFieldSpecified = value;
                this.RaisePropertyChanged("startTourEventIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int endTourEventIndex {
            get {
                return this.endTourEventIndexField;
            }
            set {
                this.endTourEventIndexField = value;
                this.RaisePropertyChanged("endTourEventIndex");
                this.endTourEventIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endTourEventIndexSpecified {
            get {
                return this.endTourEventIndexFieldSpecified;
            }
            set {
                this.endTourEventIndexFieldSpecified = value;
                this.RaisePropertyChanged("endTourEventIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double drivingTime {
            get {
                return this.drivingTimeField;
            }
            set {
                this.drivingTimeField = value;
                this.RaisePropertyChanged("drivingTime");
                this.drivingTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drivingTimeSpecified {
            get {
                return this.drivingTimeFieldSpecified;
            }
            set {
                this.drivingTimeFieldSpecified = value;
                this.RaisePropertyChanged("drivingTimeSpecified");
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
        public bool routeViolated {
            get {
                return this.routeViolatedField;
            }
            set {
                this.routeViolatedField = value;
                this.RaisePropertyChanged("routeViolated");
                this.routeViolatedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool routeViolatedSpecified {
            get {
                return this.routeViolatedFieldSpecified;
            }
            set {
                this.routeViolatedFieldSpecified = value;
                this.RaisePropertyChanged("routeViolatedSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("transportQuantities", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double[] transportQuantities {
            get {
                return this.transportQuantitiesField;
            }
            set {
                this.transportQuantitiesField = value;
                this.RaisePropertyChanged("transportQuantities");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.CustomerSite))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.DepotSite))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.Site))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.VehicleLocation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public abstract partial class Location : object, System.ComponentModel.INotifyPropertyChanged {

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class MaximumQuantityScenario : object, System.ComponentModel.INotifyPropertyChanged {

        private double[] quantitiesField;

                    [System.Xml.Serialization.XmlElementAttribute("quantities", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double[] quantities {
            get {
                return this.quantitiesField;
            }
            set {
                this.quantitiesField = value;
                this.RaisePropertyChanged("quantities");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class MixedLoadingProhibition : object, System.ComponentModel.INotifyPropertyChanged {

        private string conflictingCategory1Field;
        private string conflictingCategory2Field;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string conflictingCategory1 {
            get {
                return this.conflictingCategory1Field;
            }
            set {
                this.conflictingCategory1Field = value;
                this.RaisePropertyChanged("conflictingCategory1");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string conflictingCategory2 {
            get {
                return this.conflictingCategory2Field;
            }
            set {
                this.conflictingCategory2Field = value;
                this.RaisePropertyChanged("conflictingCategory2");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class MoveOrdersAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private string[] orderIdsField;
        private string targetTripIdField;
        private com.ptvgroup.xserver.xtour.InsertionPosition visitInsertionPositionField;
        private com.ptvgroup.xserver.xtour.InsertionPosition pickupInsertionPositionField;
        private com.ptvgroup.xserver.xtour.InsertionPosition deliveryInsertionPositionField;

                    [System.Xml.Serialization.XmlElementAttribute("orderIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] orderIds {
            get {
                return this.orderIdsField;
            }
            set {
                this.orderIdsField = value;
                this.RaisePropertyChanged("orderIds");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetTripId {
            get {
                return this.targetTripIdField;
            }
            set {
                this.targetTripIdField = value;
                this.RaisePropertyChanged("targetTripId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("visitInsertionPosition", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.InsertionPosition visitInsertionPosition {
            get {
                return this.visitInsertionPositionField;
            }
            set {
                this.visitInsertionPositionField = value;
                this.RaisePropertyChanged("visitInsertionPosition");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("pickupInsertionPosition", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.InsertionPosition pickupInsertionPosition {
            get {
                return this.pickupInsertionPositionField;
            }
            set {
                this.pickupInsertionPositionField = value;
                this.RaisePropertyChanged("pickupInsertionPosition");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("deliveryInsertionPosition", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.InsertionPosition deliveryInsertionPosition {
            get {
                return this.deliveryInsertionPositionField;
            }
            set {
                this.deliveryInsertionPositionField = value;
                this.RaisePropertyChanged("deliveryInsertionPosition");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class MoveStopsAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private com.ptvgroup.xserver.xtour.StopIdentifier[] stopIdentifiersField;
        private string targetTripIdField;
        private com.ptvgroup.xserver.xtour.InsertionPosition insertionPositionField;

                    [System.Xml.Serialization.XmlElementAttribute("stopIdentifiers", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.StopIdentifier[] stopIdentifiers {
            get {
                return this.stopIdentifiersField;
            }
            set {
                this.stopIdentifiersField = value;
                this.RaisePropertyChanged("stopIdentifiers");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetTripId {
            get {
                return this.targetTripIdField;
            }
            set {
                this.targetTripIdField = value;
                this.RaisePropertyChanged("targetTripId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("insertionPosition", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.InsertionPosition insertionPosition {
            get {
                return this.insertionPositionField;
            }
            set {
                this.insertionPositionField = value;
                this.RaisePropertyChanged("insertionPosition");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class MoveTripsAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private string[] tripIdsField;
        private string targetVehicleIdField;
        private com.ptvgroup.xserver.xtour.InsertionPosition insertionPositionField;

                    [System.Xml.Serialization.XmlElementAttribute("tripIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] tripIds {
            get {
                return this.tripIdsField;
            }
            set {
                this.tripIdsField = value;
                this.RaisePropertyChanged("tripIds");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetVehicleId {
            get {
                return this.targetVehicleIdField;
            }
            set {
                this.targetVehicleIdField = value;
                this.RaisePropertyChanged("targetVehicleId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("insertionPosition", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.InsertionPosition insertionPosition {
            get {
                return this.insertionPositionField;
            }
            set {
                this.insertionPositionField = value;
                this.RaisePropertyChanged("insertionPosition");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class NoValidInsertionPositionsFoundLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string[] objectIdsField;

                    [System.Xml.Serialization.XmlElementAttribute("objectIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] objectIds {
            get {
                return this.objectIdsField;
            }
            set {
                this.objectIdsField = value;
                this.RaisePropertyChanged("objectIds");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class OptimizeStopSequenceAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private string[] tripIdsField;

                    [System.Xml.Serialization.XmlElementAttribute("tripIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] tripIds {
            get {
                return this.tripIdsField;
            }
            set {
                this.tripIdsField = value;
                this.RaisePropertyChanged("tripIds");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.OrderWithAlternativeDeliveryDepots))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.OrderWithAlternativePickupDepots))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.PickupDeliveryOrder))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.TransportOrder))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.VisitOrder))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public abstract partial class Order : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private int priorityField;
        private bool priorityFieldSpecified;
        private string groupIdField;
        private string[] requiredVehicleEquipmentField;
        private string categoryField;

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
        public int priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
                this.RaisePropertyChanged("priority");
                this.priorityFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prioritySpecified {
            get {
                return this.priorityFieldSpecified;
            }
            set {
                this.priorityFieldSpecified = value;
                this.RaisePropertyChanged("prioritySpecified");
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

                    [System.Xml.Serialization.XmlElementAttribute("requiredVehicleEquipment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] requiredVehicleEquipment {
            get {
                return this.requiredVehicleEquipmentField;
            }
            set {
                this.requiredVehicleEquipmentField = value;
                this.RaisePropertyChanged("requiredVehicleEquipment");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
                this.RaisePropertyChanged("category");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class OrderGroupConsideration : object, System.ComponentModel.INotifyPropertyChanged {

        private bool oneGroupPerTripField;
        private bool oneGroupPerTripFieldSpecified;
        private bool oneTripPerGroupField;
        private bool oneTripPerGroupFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool oneGroupPerTrip {
            get {
                return this.oneGroupPerTripField;
            }
            set {
                this.oneGroupPerTripField = value;
                this.RaisePropertyChanged("oneGroupPerTrip");
                this.oneGroupPerTripFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool oneGroupPerTripSpecified {
            get {
                return this.oneGroupPerTripFieldSpecified;
            }
            set {
                this.oneGroupPerTripFieldSpecified = value;
                this.RaisePropertyChanged("oneGroupPerTripSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool oneTripPerGroup {
            get {
                return this.oneTripPerGroupField;
            }
            set {
                this.oneTripPerGroupField = value;
                this.RaisePropertyChanged("oneTripPerGroup");
                this.oneTripPerGroupFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool oneTripPerGroupSpecified {
            get {
                return this.oneTripPerGroupFieldSpecified;
            }
            set {
                this.oneTripPerGroupFieldSpecified = value;
                this.RaisePropertyChanged("oneTripPerGroupSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class OrderWithAlternativeDeliveryDepots : com.ptvgroup.xserver.xtour.TransportOrder {

        private string pickupLocationIdField;
        private string[] deliveryLocationIdsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pickupLocationId {
            get {
                return this.pickupLocationIdField;
            }
            set {
                this.pickupLocationIdField = value;
                this.RaisePropertyChanged("pickupLocationId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("deliveryLocationIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] deliveryLocationIds {
            get {
                return this.deliveryLocationIdsField;
            }
            set {
                this.deliveryLocationIdsField = value;
                this.RaisePropertyChanged("deliveryLocationIds");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class OrderWithAlternativePickupDepots : com.ptvgroup.xserver.xtour.TransportOrder {

        private string[] pickupLocationIdsField;
        private string deliveryLocationIdField;

                    [System.Xml.Serialization.XmlElementAttribute("pickupLocationIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] pickupLocationIds {
            get {
                return this.pickupLocationIdsField;
            }
            set {
                this.pickupLocationIdsField = value;
                this.RaisePropertyChanged("pickupLocationIds");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryLocationId {
            get {
                return this.deliveryLocationIdField;
            }
            set {
                this.deliveryLocationIdField = value;
                this.RaisePropertyChanged("deliveryLocationId");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class PickupDeliveryOrder : com.ptvgroup.xserver.xtour.TransportOrder {

        private string pickupLocationIdField;
        private string deliveryLocationIdField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pickupLocationId {
            get {
                return this.pickupLocationIdField;
            }
            set {
                this.pickupLocationIdField = value;
                this.RaisePropertyChanged("pickupLocationId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryLocationId {
            get {
                return this.deliveryLocationIdField;
            }
            set {
                this.deliveryLocationIdField = value;
                this.RaisePropertyChanged("deliveryLocationId");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class PlanToursOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.time.StartEndInterval planningHorizonField;
        private com.ptvgroup.xserver.xtour.TourRestrictions restrictionsField;
        private com.ptvgroup.xserver.xtour.CalculationMode calculationModeField;
        private bool calculationModeFieldSpecified;
        private string customCalculationModeConfigurationField;
        private com.ptvgroup.xserver.xtour.TweaksToObjective tweaksToObjectiveField;
        private com.ptvgroup.xserver.xtour.OrderGroupConsideration orderGroupConsiderationField;
        private bool singleStopPerCustomerSiteField;
        private bool singleStopPerCustomerSiteFieldSpecified;
        private bool considerOrderPrioritiesField;
        private bool considerOrderPrioritiesFieldSpecified;
        private bool ignoreRouteViolationsField;
        private bool ignoreRouteViolationsFieldSpecified;
        private bool ignoreReachabilityViolationsField;
        private bool ignoreReachabilityViolationsFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("planningHorizon", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.time.StartEndInterval planningHorizon {
            get {
                return this.planningHorizonField;
            }
            set {
                this.planningHorizonField = value;
                this.RaisePropertyChanged("planningHorizon");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("restrictions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.TourRestrictions restrictions {
            get {
                return this.restrictionsField;
            }
            set {
                this.restrictionsField = value;
                this.RaisePropertyChanged("restrictions");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xtour.CalculationMode calculationMode {
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

                    [System.Xml.Serialization.XmlElementAttribute("tweaksToObjective", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.TweaksToObjective tweaksToObjective {
            get {
                return this.tweaksToObjectiveField;
            }
            set {
                this.tweaksToObjectiveField = value;
                this.RaisePropertyChanged("tweaksToObjective");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("orderGroupConsideration", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.OrderGroupConsideration orderGroupConsideration {
            get {
                return this.orderGroupConsiderationField;
            }
            set {
                this.orderGroupConsiderationField = value;
                this.RaisePropertyChanged("orderGroupConsideration");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool singleStopPerCustomerSite {
            get {
                return this.singleStopPerCustomerSiteField;
            }
            set {
                this.singleStopPerCustomerSiteField = value;
                this.RaisePropertyChanged("singleStopPerCustomerSite");
                this.singleStopPerCustomerSiteFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool singleStopPerCustomerSiteSpecified {
            get {
                return this.singleStopPerCustomerSiteFieldSpecified;
            }
            set {
                this.singleStopPerCustomerSiteFieldSpecified = value;
                this.RaisePropertyChanged("singleStopPerCustomerSiteSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool considerOrderPriorities {
            get {
                return this.considerOrderPrioritiesField;
            }
            set {
                this.considerOrderPrioritiesField = value;
                this.RaisePropertyChanged("considerOrderPriorities");
                this.considerOrderPrioritiesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool considerOrderPrioritiesSpecified {
            get {
                return this.considerOrderPrioritiesFieldSpecified;
            }
            set {
                this.considerOrderPrioritiesFieldSpecified = value;
                this.RaisePropertyChanged("considerOrderPrioritiesSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoreRouteViolations {
            get {
                return this.ignoreRouteViolationsField;
            }
            set {
                this.ignoreRouteViolationsField = value;
                this.RaisePropertyChanged("ignoreRouteViolations");
                this.ignoreRouteViolationsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoreRouteViolationsSpecified {
            get {
                return this.ignoreRouteViolationsFieldSpecified;
            }
            set {
                this.ignoreRouteViolationsFieldSpecified = value;
                this.RaisePropertyChanged("ignoreRouteViolationsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoreReachabilityViolations {
            get {
                return this.ignoreReachabilityViolationsField;
            }
            set {
                this.ignoreReachabilityViolationsField = value;
                this.RaisePropertyChanged("ignoreReachabilityViolations");
                this.ignoreReachabilityViolationsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoreReachabilityViolationsSpecified {
            get {
                return this.ignoreReachabilityViolationsFieldSpecified;
            }
            set {
                this.ignoreReachabilityViolationsFieldSpecified = value;
                this.RaisePropertyChanged("ignoreReachabilityViolationsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class PlanToursRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xtour.Location[] locationsField;
        private com.ptvgroup.xserver.xtour.Order[] ordersField;
        private com.ptvgroup.xserver.xtour.Fleet fleetField;
        private com.ptvgroup.xserver.xtour.InputPlan inputPlanField;
        private com.ptvgroup.xserver.xtour.PlanToursOptions planToursOptionsField;
        private com.ptvgroup.xserver.dima.DistanceMode distanceModeField;
        private bool storeRequestField;
        private bool storeRequestFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("locations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Location[] locations {
            get {
                return this.locationsField;
            }
            set {
                this.locationsField = value;
                this.RaisePropertyChanged("locations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("orders", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Order[] orders {
            get {
                return this.ordersField;
            }
            set {
                this.ordersField = value;
                this.RaisePropertyChanged("orders");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("fleet", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Fleet fleet {
            get {
                return this.fleetField;
            }
            set {
                this.fleetField = value;
                this.RaisePropertyChanged("fleet");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("inputPlan", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.InputPlan inputPlan {
            get {
                return this.inputPlanField;
            }
            set {
                this.inputPlanField = value;
                this.RaisePropertyChanged("inputPlan");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("planToursOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.PlanToursOptions planToursOptions {
            get {
                return this.planToursOptionsField;
            }
            set {
                this.planToursOptionsField = value;
                this.RaisePropertyChanged("planToursOptions");
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

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool storeRequest {
            get {
                return this.storeRequestField;
            }
            set {
                this.storeRequestField = value;
                this.RaisePropertyChanged("storeRequest");
                this.storeRequestFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool storeRequestSpecified {
            get {
                return this.storeRequestFieldSpecified;
            }
            set {
                this.storeRequestFieldSpecified = value;
                this.RaisePropertyChanged("storeRequestSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class PositionAtStop : com.ptvgroup.xserver.xtour.VehiclePosition {

        private com.ptvgroup.xserver.tourplanning.ServiceStatus serviceStatusField;
        private string tripIdField;
        private int stopIndexField;

                    [System.Xml.Serialization.XmlElementAttribute("serviceStatus", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.tourplanning.ServiceStatus serviceStatus {
            get {
                return this.serviceStatusField;
            }
            set {
                this.serviceStatusField = value;
                this.RaisePropertyChanged("serviceStatus");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tripId {
            get {
                return this.tripIdField;
            }
            set {
                this.tripIdField = value;
                this.RaisePropertyChanged("tripId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int stopIndex {
            get {
                return this.stopIndexField;
            }
            set {
                this.stopIndexField = value;
                this.RaisePropertyChanged("stopIndex");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class PositionAtVehicleStartLocation : com.ptvgroup.xserver.xtour.VehiclePosition {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class PositionEnRouteToStop : com.ptvgroup.xserver.xtour.VehiclePosition {

        private com.ptvgroup.xserver.geometry.Coordinate currentLocationField;
        private string tripIdField;
        private int indexOfNextStopField;

                    [System.Xml.Serialization.XmlElementAttribute("currentLocation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate currentLocation {
            get {
                return this.currentLocationField;
            }
            set {
                this.currentLocationField = value;
                this.RaisePropertyChanged("currentLocation");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tripId {
            get {
                return this.tripIdField;
            }
            set {
                this.tripIdField = value;
                this.RaisePropertyChanged("tripId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int indexOfNextStop {
            get {
                return this.indexOfNextStopField;
            }
            set {
                this.indexOfNextStopField = value;
                this.RaisePropertyChanged("indexOfNextStop");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class PositionEnRouteToVehicleEndLocation : com.ptvgroup.xserver.xtour.VehiclePosition {

        private com.ptvgroup.xserver.geometry.Coordinate currentLocationField;

                    [System.Xml.Serialization.XmlElementAttribute("currentLocation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate currentLocation {
            get {
                return this.currentLocationField;
            }
            set {
                this.currentLocationField = value;
                this.RaisePropertyChanged("currentLocation");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class ReferenceLocationMapping : object, System.ComponentModel.INotifyPropertyChanged {

        private string locationIdField;
        private com.ptvgroup.xserver.routing.RouteLocation referenceLocationField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class RemoveFixationsAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private com.ptvgroup.xserver.xtour.Fixation[] fixationsField;

                    [System.Xml.Serialization.XmlElementAttribute("fixations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Fixation[] fixations {
            get {
                return this.fixationsField;
            }
            set {
                this.fixationsField = value;
                this.RaisePropertyChanged("fixations");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class RemoveOrdersAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private string[] orderIdsField;

                    [System.Xml.Serialization.XmlElementAttribute("orderIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] orderIds {
            get {
                return this.orderIdsField;
            }
            set {
                this.orderIdsField = value;
                this.RaisePropertyChanged("orderIds");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class RemoveToursAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private string[] vehicleIdsField;

                    [System.Xml.Serialization.XmlElementAttribute("vehicleIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] vehicleIds {
            get {
                return this.vehicleIdsField;
            }
            set {
                this.vehicleIdsField = value;
                this.RaisePropertyChanged("vehicleIds");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class RemoveTripStartIntervalsAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private string[] tripIdsField;

                    [System.Xml.Serialization.XmlElementAttribute("tripIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] tripIds {
            get {
                return this.tripIdsField;
            }
            set {
                this.tripIdsField = value;
                this.RaisePropertyChanged("tripIds");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class RemoveTripsAction : com.ptvgroup.xserver.xtour.ChangeToursAction {

        private string[] tripIdsField;

                    [System.Xml.Serialization.XmlElementAttribute("tripIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] tripIds {
            get {
                return this.tripIdsField;
            }
            set {
                this.tripIdsField = value;
                this.RaisePropertyChanged("tripIds");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.CustomerSite))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.DepotSite))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public abstract partial class Site : com.ptvgroup.xserver.xtour.Location {

        private com.ptvgroup.xserver.time.Interval[] openingIntervalsField;
        private double serviceTimePerStopField;
        private bool serviceTimePerStopFieldSpecified;
        private bool ignoreVehicleDependentServiceTimeFactorForOrdersField;
        private bool ignoreVehicleDependentServiceTimeFactorForOrdersFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("openingIntervals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.time.Interval[] openingIntervals {
            get {
                return this.openingIntervalsField;
            }
            set {
                this.openingIntervalsField = value;
                this.RaisePropertyChanged("openingIntervals");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double serviceTimePerStop {
            get {
                return this.serviceTimePerStopField;
            }
            set {
                this.serviceTimePerStopField = value;
                this.RaisePropertyChanged("serviceTimePerStop");
                this.serviceTimePerStopFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool serviceTimePerStopSpecified {
            get {
                return this.serviceTimePerStopFieldSpecified;
            }
            set {
                this.serviceTimePerStopFieldSpecified = value;
                this.RaisePropertyChanged("serviceTimePerStopSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoreVehicleDependentServiceTimeFactorForOrders {
            get {
                return this.ignoreVehicleDependentServiceTimeFactorForOrdersField;
            }
            set {
                this.ignoreVehicleDependentServiceTimeFactorForOrdersField = value;
                this.RaisePropertyChanged("ignoreVehicleDependentServiceTimeFactorForOrders");
                this.ignoreVehicleDependentServiceTimeFactorForOrdersFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoreVehicleDependentServiceTimeFactorForOrdersSpecified {
            get {
                return this.ignoreVehicleDependentServiceTimeFactorForOrdersFieldSpecified;
            }
            set {
                this.ignoreVehicleDependentServiceTimeFactorForOrdersFieldSpecified = value;
                this.RaisePropertyChanged("ignoreVehicleDependentServiceTimeFactorForOrdersSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class Stop : object, System.ComponentModel.INotifyPropertyChanged {

        private string locationIdField;
        private string customerIdField;
        private com.ptvgroup.xserver.xtour.Task[] tasksField;

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
        public string customerId {
            get {
                return this.customerIdField;
            }
            set {
                this.customerIdField = value;
                this.RaisePropertyChanged("customerId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tasks", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Task[] tasks {
            get {
                return this.tasksField;
            }
            set {
                this.tasksField = value;
                this.RaisePropertyChanged("tasks");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class StopIdentifier : object, System.ComponentModel.INotifyPropertyChanged {

        private string tripIdField;
        private int positionField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tripId {
            get {
                return this.tripIdField;
            }
            set {
                this.tripIdField = value;
                this.RaisePropertyChanged("tripId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
                this.RaisePropertyChanged("position");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class Task : object, System.ComponentModel.INotifyPropertyChanged {

        private string orderIdField;
        private com.ptvgroup.xserver.xtour.TaskType taskTypeField;

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
        public com.ptvgroup.xserver.xtour.TaskType taskType {
            get {
                return this.taskTypeField;
            }
            set {
                this.taskTypeField = value;
                this.RaisePropertyChanged("taskType");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class Tour : object, System.ComponentModel.INotifyPropertyChanged {

        private string vehicleIdField;
        private string vehicleStartLocationIdField;
        private string vehicleEndLocationIdField;
        private com.ptvgroup.xserver.xtour.Trip[] tripsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vehicleId {
            get {
                return this.vehicleIdField;
            }
            set {
                this.vehicleIdField = value;
                this.RaisePropertyChanged("vehicleId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vehicleStartLocationId {
            get {
                return this.vehicleStartLocationIdField;
            }
            set {
                this.vehicleStartLocationIdField = value;
                this.RaisePropertyChanged("vehicleStartLocationId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vehicleEndLocationId {
            get {
                return this.vehicleEndLocationIdField;
            }
            set {
                this.vehicleEndLocationIdField = value;
                this.RaisePropertyChanged("vehicleEndLocationId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("trips", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Trip[] trips {
            get {
                return this.tripsField;
            }
            set {
                this.tripsField = value;
                this.RaisePropertyChanged("trips");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class TourEvent : object, System.ComponentModel.INotifyPropertyChanged {

        private System.DateTime startTimeField;
        private string tripIdField;
        private string locationIdField;
        private string orderIdField;
        private com.ptvgroup.xserver.tourplanning.TourEventType[] eventTypesField;
        private com.ptvgroup.xserver.tourplanning.TourViolation[] tourViolationsField;
        private double durationField;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime startTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
                this.RaisePropertyChanged("startTime");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tripId {
            get {
                return this.tripIdField;
            }
            set {
                this.tripIdField = value;
                this.RaisePropertyChanged("tripId");
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
        public string orderId {
            get {
                return this.orderIdField;
            }
            set {
                this.orderIdField = value;
                this.RaisePropertyChanged("orderId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("eventTypes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.tourplanning.TourEventType[] eventTypes {
            get {
                return this.eventTypesField;
            }
            set {
                this.eventTypesField = value;
                this.RaisePropertyChanged("eventTypes");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tourViolations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.tourplanning.TourViolation[] tourViolations {
            get {
                return this.tourViolationsField;
            }
            set {
                this.tourViolationsField = value;
                this.RaisePropertyChanged("tourViolations");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double duration {
            get {
                return this.durationField;
            }
            set {
                this.durationField = value;
                this.RaisePropertyChanged("duration");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class TourPlanProgress : com.ptvgroup.xserver.jobs.JobProgress {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class TourReport : object, System.ComponentModel.INotifyPropertyChanged {

        private string vehicleIdField;
        private com.ptvgroup.xserver.xtour.CostReport costReportField;
        private com.ptvgroup.xserver.xtour.TourViolationReport violationReportField;
        private com.ptvgroup.xserver.xtour.TripReport[] tripReportsField;
        private com.ptvgroup.xserver.xtour.TourEvent[] tourEventsField;
        private com.ptvgroup.xserver.xtour.LegReport[] legReportsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vehicleId {
            get {
                return this.vehicleIdField;
            }
            set {
                this.vehicleIdField = value;
                this.RaisePropertyChanged("vehicleId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("costReport", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.CostReport costReport {
            get {
                return this.costReportField;
            }
            set {
                this.costReportField = value;
                this.RaisePropertyChanged("costReport");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("violationReport", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.TourViolationReport violationReport {
            get {
                return this.violationReportField;
            }
            set {
                this.violationReportField = value;
                this.RaisePropertyChanged("violationReport");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tripReports", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.TripReport[] tripReports {
            get {
                return this.tripReportsField;
            }
            set {
                this.tripReportsField = value;
                this.RaisePropertyChanged("tripReports");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tourEvents", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.TourEvent[] tourEvents {
            get {
                return this.tourEventsField;
            }
            set {
                this.tourEventsField = value;
                this.RaisePropertyChanged("tourEvents");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("legReports", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.LegReport[] legReports {
            get {
                return this.legReportsField;
            }
            set {
                this.legReportsField = value;
                this.RaisePropertyChanged("legReports");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class TourRestrictions : object, System.ComponentModel.INotifyPropertyChanged {

        private bool singleTripPerTourField;
        private bool singleTripPerTourFieldSpecified;
        private bool singleDepotPerTourField;
        private bool singleDepotPerTourFieldSpecified;
        private int maximumNumberOfCustomerStopsPerTourField;
        private bool maximumNumberOfCustomerStopsPerTourFieldSpecified;
        private double maximumDistancePerTourField;
        private bool maximumDistancePerTourFieldSpecified;
        private double maximumTravelTimePerTourField;
        private bool maximumTravelTimePerTourFieldSpecified;
        private double maximumDrivingTimePerTourField;
        private bool maximumDrivingTimePerTourFieldSpecified;
        private com.ptvgroup.xserver.tourplanning.WorkingHours workingHoursField;
        private com.ptvgroup.xserver.xtour.MixedLoadingProhibition[] mixedLoadingProhibitionsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool singleTripPerTour {
            get {
                return this.singleTripPerTourField;
            }
            set {
                this.singleTripPerTourField = value;
                this.RaisePropertyChanged("singleTripPerTour");
                this.singleTripPerTourFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool singleTripPerTourSpecified {
            get {
                return this.singleTripPerTourFieldSpecified;
            }
            set {
                this.singleTripPerTourFieldSpecified = value;
                this.RaisePropertyChanged("singleTripPerTourSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool singleDepotPerTour {
            get {
                return this.singleDepotPerTourField;
            }
            set {
                this.singleDepotPerTourField = value;
                this.RaisePropertyChanged("singleDepotPerTour");
                this.singleDepotPerTourFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool singleDepotPerTourSpecified {
            get {
                return this.singleDepotPerTourFieldSpecified;
            }
            set {
                this.singleDepotPerTourFieldSpecified = value;
                this.RaisePropertyChanged("singleDepotPerTourSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumNumberOfCustomerStopsPerTour {
            get {
                return this.maximumNumberOfCustomerStopsPerTourField;
            }
            set {
                this.maximumNumberOfCustomerStopsPerTourField = value;
                this.RaisePropertyChanged("maximumNumberOfCustomerStopsPerTour");
                this.maximumNumberOfCustomerStopsPerTourFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumNumberOfCustomerStopsPerTourSpecified {
            get {
                return this.maximumNumberOfCustomerStopsPerTourFieldSpecified;
            }
            set {
                this.maximumNumberOfCustomerStopsPerTourFieldSpecified = value;
                this.RaisePropertyChanged("maximumNumberOfCustomerStopsPerTourSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumDistancePerTour {
            get {
                return this.maximumDistancePerTourField;
            }
            set {
                this.maximumDistancePerTourField = value;
                this.RaisePropertyChanged("maximumDistancePerTour");
                this.maximumDistancePerTourFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumDistancePerTourSpecified {
            get {
                return this.maximumDistancePerTourFieldSpecified;
            }
            set {
                this.maximumDistancePerTourFieldSpecified = value;
                this.RaisePropertyChanged("maximumDistancePerTourSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumTravelTimePerTour {
            get {
                return this.maximumTravelTimePerTourField;
            }
            set {
                this.maximumTravelTimePerTourField = value;
                this.RaisePropertyChanged("maximumTravelTimePerTour");
                this.maximumTravelTimePerTourFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumTravelTimePerTourSpecified {
            get {
                return this.maximumTravelTimePerTourFieldSpecified;
            }
            set {
                this.maximumTravelTimePerTourFieldSpecified = value;
                this.RaisePropertyChanged("maximumTravelTimePerTourSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumDrivingTimePerTour {
            get {
                return this.maximumDrivingTimePerTourField;
            }
            set {
                this.maximumDrivingTimePerTourField = value;
                this.RaisePropertyChanged("maximumDrivingTimePerTour");
                this.maximumDrivingTimePerTourFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumDrivingTimePerTourSpecified {
            get {
                return this.maximumDrivingTimePerTourFieldSpecified;
            }
            set {
                this.maximumDrivingTimePerTourFieldSpecified = value;
                this.RaisePropertyChanged("maximumDrivingTimePerTourSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("workingHours", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.tourplanning.WorkingHours workingHours {
            get {
                return this.workingHoursField;
            }
            set {
                this.workingHoursField = value;
                this.RaisePropertyChanged("workingHours");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("mixedLoadingProhibitions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.MixedLoadingProhibition[] mixedLoadingProhibitions {
            get {
                return this.mixedLoadingProhibitionsField;
            }
            set {
                this.mixedLoadingProhibitionsField = value;
                this.RaisePropertyChanged("mixedLoadingProhibitions");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class TourViolationReport : com.ptvgroup.xserver.xtour.ViolationReport {

        private double planningHorizonExceedanceField;
        private bool planningHorizonExceedanceFieldSpecified;
        private double operatingIntervalExceedanceField;
        private bool operatingIntervalExceedanceFieldSpecified;
        private double tourStartIntervalExceedanceField;
        private bool tourStartIntervalExceedanceFieldSpecified;
        private double maximumDrivingTimePerTourExceedanceField;
        private bool maximumDrivingTimePerTourExceedanceFieldSpecified;
        private double maximumTravelTimePerTourExceedanceField;
        private bool maximumTravelTimePerTourExceedanceFieldSpecified;
        private double maximumDrivingTimePerDriverExceedanceField;
        private bool maximumDrivingTimePerDriverExceedanceFieldSpecified;
        private double maximumTravelTimePerDriverExceedanceField;
        private bool maximumTravelTimePerDriverExceedanceFieldSpecified;
        private double maximumTripStartIntervalExceedanceField;
        private bool maximumTripStartIntervalExceedanceFieldSpecified;
        private int maximumNumberOfCustomerStopsExceedanceField;
        private bool maximumNumberOfCustomerStopsExceedanceFieldSpecified;
        private double maximumDistanceExceedanceField;
        private bool maximumDistanceExceedanceFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double planningHorizonExceedance {
            get {
                return this.planningHorizonExceedanceField;
            }
            set {
                this.planningHorizonExceedanceField = value;
                this.RaisePropertyChanged("planningHorizonExceedance");
                this.planningHorizonExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool planningHorizonExceedanceSpecified {
            get {
                return this.planningHorizonExceedanceFieldSpecified;
            }
            set {
                this.planningHorizonExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("planningHorizonExceedanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double operatingIntervalExceedance {
            get {
                return this.operatingIntervalExceedanceField;
            }
            set {
                this.operatingIntervalExceedanceField = value;
                this.RaisePropertyChanged("operatingIntervalExceedance");
                this.operatingIntervalExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operatingIntervalExceedanceSpecified {
            get {
                return this.operatingIntervalExceedanceFieldSpecified;
            }
            set {
                this.operatingIntervalExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("operatingIntervalExceedanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double tourStartIntervalExceedance {
            get {
                return this.tourStartIntervalExceedanceField;
            }
            set {
                this.tourStartIntervalExceedanceField = value;
                this.RaisePropertyChanged("tourStartIntervalExceedance");
                this.tourStartIntervalExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tourStartIntervalExceedanceSpecified {
            get {
                return this.tourStartIntervalExceedanceFieldSpecified;
            }
            set {
                this.tourStartIntervalExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("tourStartIntervalExceedanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumDrivingTimePerTourExceedance {
            get {
                return this.maximumDrivingTimePerTourExceedanceField;
            }
            set {
                this.maximumDrivingTimePerTourExceedanceField = value;
                this.RaisePropertyChanged("maximumDrivingTimePerTourExceedance");
                this.maximumDrivingTimePerTourExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumDrivingTimePerTourExceedanceSpecified {
            get {
                return this.maximumDrivingTimePerTourExceedanceFieldSpecified;
            }
            set {
                this.maximumDrivingTimePerTourExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("maximumDrivingTimePerTourExceedanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumTravelTimePerTourExceedance {
            get {
                return this.maximumTravelTimePerTourExceedanceField;
            }
            set {
                this.maximumTravelTimePerTourExceedanceField = value;
                this.RaisePropertyChanged("maximumTravelTimePerTourExceedance");
                this.maximumTravelTimePerTourExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumTravelTimePerTourExceedanceSpecified {
            get {
                return this.maximumTravelTimePerTourExceedanceFieldSpecified;
            }
            set {
                this.maximumTravelTimePerTourExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("maximumTravelTimePerTourExceedanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumDrivingTimePerDriverExceedance {
            get {
                return this.maximumDrivingTimePerDriverExceedanceField;
            }
            set {
                this.maximumDrivingTimePerDriverExceedanceField = value;
                this.RaisePropertyChanged("maximumDrivingTimePerDriverExceedance");
                this.maximumDrivingTimePerDriverExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumDrivingTimePerDriverExceedanceSpecified {
            get {
                return this.maximumDrivingTimePerDriverExceedanceFieldSpecified;
            }
            set {
                this.maximumDrivingTimePerDriverExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("maximumDrivingTimePerDriverExceedanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumTravelTimePerDriverExceedance {
            get {
                return this.maximumTravelTimePerDriverExceedanceField;
            }
            set {
                this.maximumTravelTimePerDriverExceedanceField = value;
                this.RaisePropertyChanged("maximumTravelTimePerDriverExceedance");
                this.maximumTravelTimePerDriverExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumTravelTimePerDriverExceedanceSpecified {
            get {
                return this.maximumTravelTimePerDriverExceedanceFieldSpecified;
            }
            set {
                this.maximumTravelTimePerDriverExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("maximumTravelTimePerDriverExceedanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumTripStartIntervalExceedance {
            get {
                return this.maximumTripStartIntervalExceedanceField;
            }
            set {
                this.maximumTripStartIntervalExceedanceField = value;
                this.RaisePropertyChanged("maximumTripStartIntervalExceedance");
                this.maximumTripStartIntervalExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumTripStartIntervalExceedanceSpecified {
            get {
                return this.maximumTripStartIntervalExceedanceFieldSpecified;
            }
            set {
                this.maximumTripStartIntervalExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("maximumTripStartIntervalExceedanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumNumberOfCustomerStopsExceedance {
            get {
                return this.maximumNumberOfCustomerStopsExceedanceField;
            }
            set {
                this.maximumNumberOfCustomerStopsExceedanceField = value;
                this.RaisePropertyChanged("maximumNumberOfCustomerStopsExceedance");
                this.maximumNumberOfCustomerStopsExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumNumberOfCustomerStopsExceedanceSpecified {
            get {
                return this.maximumNumberOfCustomerStopsExceedanceFieldSpecified;
            }
            set {
                this.maximumNumberOfCustomerStopsExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("maximumNumberOfCustomerStopsExceedanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumDistanceExceedance {
            get {
                return this.maximumDistanceExceedanceField;
            }
            set {
                this.maximumDistanceExceedanceField = value;
                this.RaisePropertyChanged("maximumDistanceExceedance");
                this.maximumDistanceExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumDistanceExceedanceSpecified {
            get {
                return this.maximumDistanceExceedanceFieldSpecified;
            }
            set {
                this.maximumDistanceExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("maximumDistanceExceedanceSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class ToursInExecutionRequest : com.ptvgroup.xserver.service.RequestBase {

        private string storedRequestIdField;
        private com.ptvgroup.xserver.xtour.ExecutionState[] executionStatesField;

                    [System.Xml.Serialization.XmlElementAttribute("storedRequestId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string storedRequestId {
            get {
                return this.storedRequestIdField;
            }
            set {
                this.storedRequestIdField = value;
                this.RaisePropertyChanged("storedRequestId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("executionStates", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.ExecutionState[] executionStates {
            get {
                return this.executionStatesField;
            }
            set {
                this.executionStatesField = value;
                this.RaisePropertyChanged("executionStates");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class ToursResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xtour.CostReport costReportField;
        private com.ptvgroup.xserver.xtour.Tour[] toursField;
        private com.ptvgroup.xserver.xtour.TourReport[] tourReportsField;
        private string[] orderIdsNotPlannedField;
        private string[] vehicleIdsNotPlannedField;
        private string[] vehicleIdsWithTourViolationsField;
        private string[] vehicleIdsWithRouteViolationsField;
        private string[] vehicleIdsWithDirectDistanceEstimationField;
        private bool violatedField;
        private bool violatedFieldSpecified;
        private bool routeViolatedField;
        private bool routeViolatedFieldSpecified;
        private string storedRequestIdField;

                    [System.Xml.Serialization.XmlElementAttribute("costReport", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.CostReport costReport {
            get {
                return this.costReportField;
            }
            set {
                this.costReportField = value;
                this.RaisePropertyChanged("costReport");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tours", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Tour[] tours {
            get {
                return this.toursField;
            }
            set {
                this.toursField = value;
                this.RaisePropertyChanged("tours");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tourReports", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.TourReport[] tourReports {
            get {
                return this.tourReportsField;
            }
            set {
                this.tourReportsField = value;
                this.RaisePropertyChanged("tourReports");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("orderIdsNotPlanned", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] orderIdsNotPlanned {
            get {
                return this.orderIdsNotPlannedField;
            }
            set {
                this.orderIdsNotPlannedField = value;
                this.RaisePropertyChanged("orderIdsNotPlanned");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("vehicleIdsNotPlanned", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] vehicleIdsNotPlanned {
            get {
                return this.vehicleIdsNotPlannedField;
            }
            set {
                this.vehicleIdsNotPlannedField = value;
                this.RaisePropertyChanged("vehicleIdsNotPlanned");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("vehicleIdsWithTourViolations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] vehicleIdsWithTourViolations {
            get {
                return this.vehicleIdsWithTourViolationsField;
            }
            set {
                this.vehicleIdsWithTourViolationsField = value;
                this.RaisePropertyChanged("vehicleIdsWithTourViolations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("vehicleIdsWithRouteViolations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] vehicleIdsWithRouteViolations {
            get {
                return this.vehicleIdsWithRouteViolationsField;
            }
            set {
                this.vehicleIdsWithRouteViolationsField = value;
                this.RaisePropertyChanged("vehicleIdsWithRouteViolations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("vehicleIdsWithDirectDistanceEstimation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] vehicleIdsWithDirectDistanceEstimation {
            get {
                return this.vehicleIdsWithDirectDistanceEstimationField;
            }
            set {
                this.vehicleIdsWithDirectDistanceEstimationField = value;
                this.RaisePropertyChanged("vehicleIdsWithDirectDistanceEstimation");
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
        public bool routeViolated {
            get {
                return this.routeViolatedField;
            }
            set {
                this.routeViolatedField = value;
                this.RaisePropertyChanged("routeViolated");
                this.routeViolatedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool routeViolatedSpecified {
            get {
                return this.routeViolatedFieldSpecified;
            }
            set {
                this.routeViolatedFieldSpecified = value;
                this.RaisePropertyChanged("routeViolatedSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("storedRequestId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string storedRequestId {
            get {
                return this.storedRequestIdField;
            }
            set {
                this.storedRequestIdField = value;
                this.RaisePropertyChanged("storedRequestId");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.OrderWithAlternativeDeliveryDepots))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.OrderWithAlternativePickupDepots))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.PickupDeliveryOrder))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public abstract partial class TransportOrder : com.ptvgroup.xserver.xtour.Order {

        private double[] quantitiesField;
        private double serviceTimeForPickupField;
        private bool serviceTimeForPickupFieldSpecified;
        private double serviceTimeForDeliveryField;
        private bool serviceTimeForDeliveryFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("quantities", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double[] quantities {
            get {
                return this.quantitiesField;
            }
            set {
                this.quantitiesField = value;
                this.RaisePropertyChanged("quantities");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double serviceTimeForPickup {
            get {
                return this.serviceTimeForPickupField;
            }
            set {
                this.serviceTimeForPickupField = value;
                this.RaisePropertyChanged("serviceTimeForPickup");
                this.serviceTimeForPickupFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool serviceTimeForPickupSpecified {
            get {
                return this.serviceTimeForPickupFieldSpecified;
            }
            set {
                this.serviceTimeForPickupFieldSpecified = value;
                this.RaisePropertyChanged("serviceTimeForPickupSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double serviceTimeForDelivery {
            get {
                return this.serviceTimeForDeliveryField;
            }
            set {
                this.serviceTimeForDeliveryField = value;
                this.RaisePropertyChanged("serviceTimeForDelivery");
                this.serviceTimeForDeliveryFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool serviceTimeForDeliverySpecified {
            get {
                return this.serviceTimeForDeliveryFieldSpecified;
            }
            set {
                this.serviceTimeForDeliveryFieldSpecified = value;
                this.RaisePropertyChanged("serviceTimeForDeliverySpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class Trip : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private com.ptvgroup.xserver.xtour.Stop[] stopsField;

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

                    [System.Xml.Serialization.XmlElementAttribute("stops", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.Stop[] stops {
            get {
                return this.stopsField;
            }
            set {
                this.stopsField = value;
                this.RaisePropertyChanged("stops");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class TripReport : object, System.ComponentModel.INotifyPropertyChanged {

        private string tripIdField;
        private com.ptvgroup.xserver.xtour.CostReport costReportField;
        private com.ptvgroup.xserver.xtour.TripViolationReport violationReportField;
        private string orderGroupIdField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tripId {
            get {
                return this.tripIdField;
            }
            set {
                this.tripIdField = value;
                this.RaisePropertyChanged("tripId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("costReport", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.CostReport costReport {
            get {
                return this.costReportField;
            }
            set {
                this.costReportField = value;
                this.RaisePropertyChanged("costReport");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("violationReport", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.TripViolationReport violationReport {
            get {
                return this.violationReportField;
            }
            set {
                this.violationReportField = value;
                this.RaisePropertyChanged("violationReport");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderGroupId {
            get {
                return this.orderGroupIdField;
            }
            set {
                this.orderGroupIdField = value;
                this.RaisePropertyChanged("orderGroupId");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class TripStartInterval : object, System.ComponentModel.INotifyPropertyChanged {

        private string tripIdField;
        private com.ptvgroup.xserver.time.StartEndInterval intervalField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tripId {
            get {
                return this.tripIdField;
            }
            set {
                this.tripIdField = value;
                this.RaisePropertyChanged("tripId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("interval", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.time.StartEndInterval interval {
            get {
                return this.intervalField;
            }
            set {
                this.intervalField = value;
                this.RaisePropertyChanged("interval");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class TripViolationReport : com.ptvgroup.xserver.xtour.ViolationReport {

        private double tripStartIntervalExceedanceField;
        private bool tripStartIntervalExceedanceFieldSpecified;
        private double operatingIntervalExceedanceField;
        private bool operatingIntervalExceedanceFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double tripStartIntervalExceedance {
            get {
                return this.tripStartIntervalExceedanceField;
            }
            set {
                this.tripStartIntervalExceedanceField = value;
                this.RaisePropertyChanged("tripStartIntervalExceedance");
                this.tripStartIntervalExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tripStartIntervalExceedanceSpecified {
            get {
                return this.tripStartIntervalExceedanceFieldSpecified;
            }
            set {
                this.tripStartIntervalExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("tripStartIntervalExceedanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double operatingIntervalExceedance {
            get {
                return this.operatingIntervalExceedanceField;
            }
            set {
                this.operatingIntervalExceedanceField = value;
                this.RaisePropertyChanged("operatingIntervalExceedance");
                this.operatingIntervalExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operatingIntervalExceedanceSpecified {
            get {
                return this.operatingIntervalExceedanceFieldSpecified;
            }
            set {
                this.operatingIntervalExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("operatingIntervalExceedanceSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class TweaksToObjective : object, System.ComponentModel.INotifyPropertyChanged {

        private bool avoidIntersectionsField;
        private bool avoidIntersectionsFieldSpecified;
        private bool minimizeNumberOfToursField;
        private bool minimizeNumberOfToursFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool avoidIntersections {
            get {
                return this.avoidIntersectionsField;
            }
            set {
                this.avoidIntersectionsField = value;
                this.RaisePropertyChanged("avoidIntersections");
                this.avoidIntersectionsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool avoidIntersectionsSpecified {
            get {
                return this.avoidIntersectionsFieldSpecified;
            }
            set {
                this.avoidIntersectionsFieldSpecified = value;
                this.RaisePropertyChanged("avoidIntersectionsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool minimizeNumberOfTours {
            get {
                return this.minimizeNumberOfToursField;
            }
            set {
                this.minimizeNumberOfToursField = value;
                this.RaisePropertyChanged("minimizeNumberOfTours");
                this.minimizeNumberOfToursFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimizeNumberOfToursSpecified {
            get {
                return this.minimizeNumberOfToursFieldSpecified;
            }
            set {
                this.minimizeNumberOfToursFieldSpecified = value;
                this.RaisePropertyChanged("minimizeNumberOfToursSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class Vehicle : object, System.ComponentModel.INotifyPropertyChanged {

        private string[] idsField;
        private com.ptvgroup.xserver.xtour.MaximumQuantityScenario[] maximumQuantityScenariosField;
        private string distanceMatrixIdField;
        private string startLocationIdField;
        private string endLocationIdField;
        private double serviceTimeFactorForOrdersField;
        private bool serviceTimeFactorForOrdersFieldSpecified;
        private double serviceTimePerStopField;
        private bool serviceTimePerStopFieldSpecified;
        private string[] equipmentField;
        private string[] orderGroupIdsField;
        private com.ptvgroup.xserver.time.StartEndInterval tourStartIntervalField;
        private int maximumNumberOfCustomerStopsField;
        private bool maximumNumberOfCustomerStopsFieldSpecified;
        private double maximumDistanceField;
        private bool maximumDistanceFieldSpecified;
        private double maximumTravelTimeField;
        private bool maximumTravelTimeFieldSpecified;
        private double maximumDrivingTimeField;
        private bool maximumDrivingTimeFieldSpecified;
        private bool ignoreMixedLoadingProhibitionsField;
        private bool ignoreMixedLoadingProhibitionsFieldSpecified;

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

                    [System.Xml.Serialization.XmlElementAttribute("maximumQuantityScenarios", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.MaximumQuantityScenario[] maximumQuantityScenarios {
            get {
                return this.maximumQuantityScenariosField;
            }
            set {
                this.maximumQuantityScenariosField = value;
                this.RaisePropertyChanged("maximumQuantityScenarios");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string distanceMatrixId {
            get {
                return this.distanceMatrixIdField;
            }
            set {
                this.distanceMatrixIdField = value;
                this.RaisePropertyChanged("distanceMatrixId");
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

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double serviceTimeFactorForOrders {
            get {
                return this.serviceTimeFactorForOrdersField;
            }
            set {
                this.serviceTimeFactorForOrdersField = value;
                this.RaisePropertyChanged("serviceTimeFactorForOrders");
                this.serviceTimeFactorForOrdersFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool serviceTimeFactorForOrdersSpecified {
            get {
                return this.serviceTimeFactorForOrdersFieldSpecified;
            }
            set {
                this.serviceTimeFactorForOrdersFieldSpecified = value;
                this.RaisePropertyChanged("serviceTimeFactorForOrdersSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double serviceTimePerStop {
            get {
                return this.serviceTimePerStopField;
            }
            set {
                this.serviceTimePerStopField = value;
                this.RaisePropertyChanged("serviceTimePerStop");
                this.serviceTimePerStopFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool serviceTimePerStopSpecified {
            get {
                return this.serviceTimePerStopFieldSpecified;
            }
            set {
                this.serviceTimePerStopFieldSpecified = value;
                this.RaisePropertyChanged("serviceTimePerStopSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("equipment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] equipment {
            get {
                return this.equipmentField;
            }
            set {
                this.equipmentField = value;
                this.RaisePropertyChanged("equipment");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("orderGroupIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] orderGroupIds {
            get {
                return this.orderGroupIdsField;
            }
            set {
                this.orderGroupIdsField = value;
                this.RaisePropertyChanged("orderGroupIds");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tourStartInterval", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.time.StartEndInterval tourStartInterval {
            get {
                return this.tourStartIntervalField;
            }
            set {
                this.tourStartIntervalField = value;
                this.RaisePropertyChanged("tourStartInterval");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumNumberOfCustomerStops {
            get {
                return this.maximumNumberOfCustomerStopsField;
            }
            set {
                this.maximumNumberOfCustomerStopsField = value;
                this.RaisePropertyChanged("maximumNumberOfCustomerStops");
                this.maximumNumberOfCustomerStopsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumNumberOfCustomerStopsSpecified {
            get {
                return this.maximumNumberOfCustomerStopsFieldSpecified;
            }
            set {
                this.maximumNumberOfCustomerStopsFieldSpecified = value;
                this.RaisePropertyChanged("maximumNumberOfCustomerStopsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumDistance {
            get {
                return this.maximumDistanceField;
            }
            set {
                this.maximumDistanceField = value;
                this.RaisePropertyChanged("maximumDistance");
                this.maximumDistanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumDistanceSpecified {
            get {
                return this.maximumDistanceFieldSpecified;
            }
            set {
                this.maximumDistanceFieldSpecified = value;
                this.RaisePropertyChanged("maximumDistanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumTravelTime {
            get {
                return this.maximumTravelTimeField;
            }
            set {
                this.maximumTravelTimeField = value;
                this.RaisePropertyChanged("maximumTravelTime");
                this.maximumTravelTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumTravelTimeSpecified {
            get {
                return this.maximumTravelTimeFieldSpecified;
            }
            set {
                this.maximumTravelTimeFieldSpecified = value;
                this.RaisePropertyChanged("maximumTravelTimeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumDrivingTime {
            get {
                return this.maximumDrivingTimeField;
            }
            set {
                this.maximumDrivingTimeField = value;
                this.RaisePropertyChanged("maximumDrivingTime");
                this.maximumDrivingTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumDrivingTimeSpecified {
            get {
                return this.maximumDrivingTimeFieldSpecified;
            }
            set {
                this.maximumDrivingTimeFieldSpecified = value;
                this.RaisePropertyChanged("maximumDrivingTimeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoreMixedLoadingProhibitions {
            get {
                return this.ignoreMixedLoadingProhibitionsField;
            }
            set {
                this.ignoreMixedLoadingProhibitionsField = value;
                this.RaisePropertyChanged("ignoreMixedLoadingProhibitions");
                this.ignoreMixedLoadingProhibitionsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoreMixedLoadingProhibitionsSpecified {
            get {
                return this.ignoreMixedLoadingProhibitionsFieldSpecified;
            }
            set {
                this.ignoreMixedLoadingProhibitionsFieldSpecified = value;
                this.RaisePropertyChanged("ignoreMixedLoadingProhibitionsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class VehicleLocation : com.ptvgroup.xserver.xtour.Location {



    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.PositionAtStop))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.PositionAtVehicleStartLocation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.PositionEnRouteToStop))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.PositionEnRouteToVehicleEndLocation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public abstract partial class VehiclePosition : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class VehiclesForTripsQuery : com.ptvgroup.xserver.xtour.ChangeToursProposalsQuery {

        private string[] tripIdsField;
        private string[] targetVehicleIdsField;

                    [System.Xml.Serialization.XmlElementAttribute("tripIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] tripIds {
            get {
                return this.tripIdsField;
            }
            set {
                this.tripIdsField = value;
                this.RaisePropertyChanged("tripIds");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("targetVehicleIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] targetVehicleIds {
            get {
                return this.targetVehicleIdsField;
            }
            set {
                this.targetVehicleIdsField = value;
                this.RaisePropertyChanged("targetVehicleIds");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.TourViolationReport))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.TripViolationReport))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class ViolationReport : object, System.ComponentModel.INotifyPropertyChanged {

        private double maximumOpeningIntervalExceedanceField;
        private bool maximumOpeningIntervalExceedanceFieldSpecified;
        private double[] maximumQuantityScenarioExceedanceField;
        private string[] vehicleEquipmentViolationsField;
        private bool restPositionViolatedField;
        private bool restPositionViolatedFieldSpecified;
        private bool customerStopPositionInTripViolatedField;
        private bool customerStopPositionInTripViolatedFieldSpecified;
        private bool tripSectionViolatedField;
        private bool tripSectionViolatedFieldSpecified;
        private com.ptvgroup.xserver.xtour.MixedLoadingProhibition[] mixedLoadingProhibitionsViolationsField;
        private bool routeViolatedField;
        private bool routeViolatedFieldSpecified;
        private bool reachabilityViolatedField;
        private bool reachabilityViolatedFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumOpeningIntervalExceedance {
            get {
                return this.maximumOpeningIntervalExceedanceField;
            }
            set {
                this.maximumOpeningIntervalExceedanceField = value;
                this.RaisePropertyChanged("maximumOpeningIntervalExceedance");
                this.maximumOpeningIntervalExceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumOpeningIntervalExceedanceSpecified {
            get {
                return this.maximumOpeningIntervalExceedanceFieldSpecified;
            }
            set {
                this.maximumOpeningIntervalExceedanceFieldSpecified = value;
                this.RaisePropertyChanged("maximumOpeningIntervalExceedanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("maximumQuantityScenarioExceedance", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double[] maximumQuantityScenarioExceedance {
            get {
                return this.maximumQuantityScenarioExceedanceField;
            }
            set {
                this.maximumQuantityScenarioExceedanceField = value;
                this.RaisePropertyChanged("maximumQuantityScenarioExceedance");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("vehicleEquipmentViolations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] vehicleEquipmentViolations {
            get {
                return this.vehicleEquipmentViolationsField;
            }
            set {
                this.vehicleEquipmentViolationsField = value;
                this.RaisePropertyChanged("vehicleEquipmentViolations");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool restPositionViolated {
            get {
                return this.restPositionViolatedField;
            }
            set {
                this.restPositionViolatedField = value;
                this.RaisePropertyChanged("restPositionViolated");
                this.restPositionViolatedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restPositionViolatedSpecified {
            get {
                return this.restPositionViolatedFieldSpecified;
            }
            set {
                this.restPositionViolatedFieldSpecified = value;
                this.RaisePropertyChanged("restPositionViolatedSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool customerStopPositionInTripViolated {
            get {
                return this.customerStopPositionInTripViolatedField;
            }
            set {
                this.customerStopPositionInTripViolatedField = value;
                this.RaisePropertyChanged("customerStopPositionInTripViolated");
                this.customerStopPositionInTripViolatedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool customerStopPositionInTripViolatedSpecified {
            get {
                return this.customerStopPositionInTripViolatedFieldSpecified;
            }
            set {
                this.customerStopPositionInTripViolatedFieldSpecified = value;
                this.RaisePropertyChanged("customerStopPositionInTripViolatedSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool tripSectionViolated {
            get {
                return this.tripSectionViolatedField;
            }
            set {
                this.tripSectionViolatedField = value;
                this.RaisePropertyChanged("tripSectionViolated");
                this.tripSectionViolatedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tripSectionViolatedSpecified {
            get {
                return this.tripSectionViolatedFieldSpecified;
            }
            set {
                this.tripSectionViolatedFieldSpecified = value;
                this.RaisePropertyChanged("tripSectionViolatedSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("mixedLoadingProhibitionsViolations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.MixedLoadingProhibition[] mixedLoadingProhibitionsViolations {
            get {
                return this.mixedLoadingProhibitionsViolationsField;
            }
            set {
                this.mixedLoadingProhibitionsViolationsField = value;
                this.RaisePropertyChanged("mixedLoadingProhibitionsViolations");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool routeViolated {
            get {
                return this.routeViolatedField;
            }
            set {
                this.routeViolatedField = value;
                this.RaisePropertyChanged("routeViolated");
                this.routeViolatedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool routeViolatedSpecified {
            get {
                return this.routeViolatedFieldSpecified;
            }
            set {
                this.routeViolatedFieldSpecified = value;
                this.RaisePropertyChanged("routeViolatedSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool reachabilityViolated {
            get {
                return this.reachabilityViolatedField;
            }
            set {
                this.reachabilityViolatedField = value;
                this.RaisePropertyChanged("reachabilityViolated");
                this.reachabilityViolatedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reachabilityViolatedSpecified {
            get {
                return this.reachabilityViolatedFieldSpecified;
            }
            set {
                this.reachabilityViolatedFieldSpecified = value;
                this.RaisePropertyChanged("reachabilityViolatedSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public partial class VisitOrder : com.ptvgroup.xserver.xtour.Order {

        private string locationIdField;
        private double serviceTimeField;
        private bool serviceTimeFieldSpecified;

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
        

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public enum CalculationMode {
        /**
         * The algorithm's focus is on performance. A smaller search space for solutions is considered during the computation.
         */
        PERFORMANCE,

        /**
         * The algorithm chooses a standard trade-off between quality and performance of the algorithm.
         */
        STANDARD,

        /**
         * The algorithm's focus is on high solution quality. A larger search space for solutions is considered during the computation.
         */
        QUALITY,

        /**
         * The algorithm's focus is to avoid intersections of legs.
* Note that the number of planned vehicles may be higher compared to the results of the calculation modes <a href="xtour.html#com.ptvgroup.xserver.xtour.CalculationMode.PERFORMANCE">performance</a>, <a href="xtour.html#com.ptvgroup.xserver.xtour.CalculationMode.STANDARD">standard</a> and <a href="xtour.html#com.ptvgroup.xserver.xtour.CalculationMode.QUALITY">quality</a>, especially for requests with many restrictions such as disjoint opening intervals.
* A larger search space for solutions is considered during the computation.
         */
        AVOID_INTERSECTIONS,

        /**
         * The algorithm's focus is adapted to the customer's needs. It is necessary to define the <a href="xtour.html#com.ptvgroup.xserver.xtour.PlanToursOptions.customCalculationModeConfiguration">custom calculation mode configuration</a> accordingly.
         */
        CUSTOM,

        /**
         * The algorithm does not plan anything. A <a href="xtour.html#com.ptvgroup.xserver.xtour.ToursResponse">response</a> is generated for all input tours of the <a href="xtour.html#com.ptvgroup.xserver.xtour.PlanToursRequest">request's</a>
* <a href="xtour.html#com.ptvgroup.xserver.xtour.PlanToursRequest.inputPlan">input plan</a> without changing these tours.
         */
        EVALUATE
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public enum FixationType {
        /**
         * All orders that are served by a vehicle must remain served by this vehicle. Additional orders can be assigned to this vehicle.
* In this case, the ID of the <a href="xtour.html#com.ptvgroup.xserver.xtour.Fixation">fixation</a> corresponds to the <a href="xtour.html#com.ptvgroup.xserver.xtour.Tour.vehicleId">vehicleId</a>.
         */
        VEHICLE_ORDERS,

        /**
         * The trip is part of the input plan and must remain "as is". It also must remain served by the same vehicle as in the input plan.
* In this case, the ID of the <a href="xtour.html#com.ptvgroup.xserver.xtour.Fixation">fixation</a> corresponds to the <a href="xtour.html#com.ptvgroup.xserver.xtour.Trip.id">trip ID</a>.
         */
        TRIP_TO_VEHICLE
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public enum PositionInTrip {
        /**
         * A stop at a customer site with this position type has to be the very first customer stop in its trip.
         */
        FIRST_CUSTOMER_STOP,

        /**
         * A stop at a customer site with this position type has to be the very last customer stop in its trip.
         */
        LAST_CUSTOMER_STOP
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xtour.xserver.ptvgroup.com")]
    public enum TaskType {
        /**
         * An <a href="xtour.html#com.ptvgroup.xserver.xtour.TransportOrder">order</a> is picked up.
         */
        PICKUP,

        /**
         * An <a href="xtour.html#com.ptvgroup.xserver.xtour.TransportOrder">order</a> is delivered.
         */
        DELIVERY,

        /**
         * A <a href="xtour.html#com.ptvgroup.xserver.xtour.VisitOrder">customer</a> is visited.
         */
        VISIT
    }


}
