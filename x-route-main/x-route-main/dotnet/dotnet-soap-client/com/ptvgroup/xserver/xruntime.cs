// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.xruntime 
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public interface XRuntime {


            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.getRuntimeInformationResponse getRuntimeInformation(com.ptvgroup.xserver.xruntime.getRuntimeInformation request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.getLicenseInformationResponse getLicenseInformation(com.ptvgroup.xserver.xruntime.getLicenseInformation request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.getDataInformationResponse getDataInformation(com.ptvgroup.xserver.xruntime.getDataInformation request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.triggerContentUpdateResponse triggerContentUpdate(com.ptvgroup.xserver.xruntime.triggerContentUpdate request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.getContentUpdateTriggerStatusResponse getContentUpdateTriggerStatus(com.ptvgroup.xserver.xruntime.getContentUpdateTriggerStatus request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.resetMetricsResponse resetMetrics(com.ptvgroup.xserver.xruntime.resetMetrics request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.shutdownServerResponse shutdownServer(com.ptvgroup.xserver.xruntime.shutdownServer request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.restartModulesResponse restartModules(com.ptvgroup.xserver.xruntime.restartModules request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.stopRequestResponse stopRequest(com.ptvgroup.xserver.xruntime.stopRequest request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.deleteRequestResponse deleteRequest(com.ptvgroup.xserver.xruntime.deleteRequest request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.convertResponse convert(com.ptvgroup.xserver.xruntime.convert request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.createSupportPackageResponse createSupportPackage(com.ptvgroup.xserver.xruntime.createSupportPackage request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.getServerConfigurationResponse getServerConfiguration(com.ptvgroup.xserver.xruntime.getServerConfiguration request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.getConfigurationFileResponse getConfigurationFile(com.ptvgroup.xserver.xruntime.getConfigurationFile request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.watchJobResponse watchJob(com.ptvgroup.xserver.xruntime.watchJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.stopJobResponse stopJob(com.ptvgroup.xserver.xruntime.stopJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xruntime.deleteJobResponse deleteJob(com.ptvgroup.xserver.xruntime.deleteJob request);
    }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getRuntimeInformation", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getRuntimeInformation {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.RuntimeInformationRequest request;

                public getRuntimeInformation() {
                }

                public getRuntimeInformation(com.ptvgroup.xserver.xruntime.RuntimeInformationRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getRuntimeInformationResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getRuntimeInformationResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.RuntimeInformation @return;

                public getRuntimeInformationResponse() {
                }

                public getRuntimeInformationResponse(com.ptvgroup.xserver.xruntime.RuntimeInformation @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getLicenseInformation", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getLicenseInformation {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.LicenseInformationRequest request;

                public getLicenseInformation() {
                }

                public getLicenseInformation(com.ptvgroup.xserver.xruntime.LicenseInformationRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getLicenseInformationResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getLicenseInformationResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.LicenseInformation @return;

                public getLicenseInformationResponse() {
                }

                public getLicenseInformationResponse(com.ptvgroup.xserver.xruntime.LicenseInformation @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getDataInformation", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getDataInformation {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.DataInformationRequest request;

                public getDataInformation() {
                }

                public getDataInformation(com.ptvgroup.xserver.xruntime.DataInformationRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getDataInformationResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getDataInformationResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.DataInformationResponse @return;

                public getDataInformationResponse() {
                }

                public getDataInformationResponse(com.ptvgroup.xserver.xruntime.DataInformationResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="triggerContentUpdate", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class triggerContentUpdate {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ContentUpdateTriggerRequest request;

                public triggerContentUpdate() {
                }

                public triggerContentUpdate(com.ptvgroup.xserver.xruntime.ContentUpdateTriggerRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="triggerContentUpdateResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class triggerContentUpdateResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ContentUpdateTriggerResponse @return;

                public triggerContentUpdateResponse() {
                }

                public triggerContentUpdateResponse(com.ptvgroup.xserver.xruntime.ContentUpdateTriggerResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getContentUpdateTriggerStatus", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getContentUpdateTriggerStatus {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatusRequest request;

                public getContentUpdateTriggerStatus() {
                }

                public getContentUpdateTriggerStatus(com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatusRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getContentUpdateTriggerStatusResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getContentUpdateTriggerStatusResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatusResponse @return;

                public getContentUpdateTriggerStatusResponse() {
                }

                public getContentUpdateTriggerStatusResponse(com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatusResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="resetMetrics", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class resetMetrics {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ResetMetricsRequest request;

                public resetMetrics() {
                }

                public resetMetrics(com.ptvgroup.xserver.xruntime.ResetMetricsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="resetMetricsResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class resetMetricsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.service.VoidResponse @return;

                public resetMetricsResponse() {
                }

                public resetMetricsResponse(com.ptvgroup.xserver.service.VoidResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="shutdownServer", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class shutdownServer {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ShutdownServerRequest request;

                public shutdownServer() {
                }

                public shutdownServer(com.ptvgroup.xserver.xruntime.ShutdownServerRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="shutdownServerResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class shutdownServerResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.service.VoidResponse @return;

                public shutdownServerResponse() {
                }

                public shutdownServerResponse(com.ptvgroup.xserver.service.VoidResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="restartModules", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class restartModules {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.RestartModulesRequest request;

                public restartModules() {
                }

                public restartModules(com.ptvgroup.xserver.xruntime.RestartModulesRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="restartModulesResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class restartModulesResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.service.VoidResponse @return;

                public restartModulesResponse() {
                }

                public restartModulesResponse(com.ptvgroup.xserver.service.VoidResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopRequest", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopRequest {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.StopDeleteRequest request;

                public stopRequest() {
                }

                public stopRequest(com.ptvgroup.xserver.xruntime.StopDeleteRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopRequestResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopRequestResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.service.VoidResponse @return;

                public stopRequestResponse() {
                }

                public stopRequestResponse(com.ptvgroup.xserver.service.VoidResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteRequest", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteRequest {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.StopDeleteRequest request;

                public deleteRequest() {
                }

                public deleteRequest(com.ptvgroup.xserver.xruntime.StopDeleteRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteRequestResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteRequestResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.service.VoidResponse @return;

                public deleteRequestResponse() {
                }

                public deleteRequestResponse(com.ptvgroup.xserver.service.VoidResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="convert", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class convert {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ConversionRequest request;

                public convert() {
                }

                public convert(com.ptvgroup.xserver.xruntime.ConversionRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="convertResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class convertResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ConversionResponse @return;

                public convertResponse() {
                }

                public convertResponse(com.ptvgroup.xserver.xruntime.ConversionResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="createSupportPackage", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class createSupportPackage {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.SupportPackageRequest request;

                public createSupportPackage() {
                }

                public createSupportPackage(com.ptvgroup.xserver.xruntime.SupportPackageRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="createSupportPackageResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class createSupportPackageResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.SupportPackageResponse @return;

                public createSupportPackageResponse() {
                }

                public createSupportPackageResponse(com.ptvgroup.xserver.xruntime.SupportPackageResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getServerConfiguration", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getServerConfiguration {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ServerConfigurationRequest request;

                public getServerConfiguration() {
                }

                public getServerConfiguration(com.ptvgroup.xserver.xruntime.ServerConfigurationRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getServerConfigurationResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getServerConfigurationResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ServerConfigurationResponse @return;

                public getServerConfigurationResponse() {
                }

                public getServerConfigurationResponse(com.ptvgroup.xserver.xruntime.ServerConfigurationResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getConfigurationFile", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getConfigurationFile {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ConfigurationFileRequest request;

                public getConfigurationFile() {
                }

                public getConfigurationFile(com.ptvgroup.xserver.xruntime.ConfigurationFileRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getConfigurationFileResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getConfigurationFileResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xruntime.ConfigurationFileResponse @return;

                public getConfigurationFileResponse() {
                }

                public getConfigurationFileResponse(com.ptvgroup.xserver.xruntime.ConfigurationFileResponse @return) {
                    this.@return = @return;
                }
            }


            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJob", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJobResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJob", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJobResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJob", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJobResponse", WrapperNamespace="http://xruntime.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xruntime.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public deleteJobResponse() {
                }

                public deleteJobResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XRuntimeChannel : com.ptvgroup.xserver.xruntime.XRuntime, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XRuntimeClient : System.ServiceModel.ClientBase<com.ptvgroup.xserver.xruntime.XRuntime>, com.ptvgroup.xserver.xruntime.XRuntime {

        public XRuntimeClient() :
            this("http://localhost:50000/services/ws/XRuntime") {
        }

        public XRuntimeClient(string baseUri , string version="") :
            this(new System.ServiceModel.BasicHttpBinding { MaxReceivedMessageSize = System.Int32.MaxValue }, new System.ServiceModel.EndpointAddress(baseUri+"/services/ws/XRuntime/"+version)) {
        }

        public XRuntimeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress) {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.getRuntimeInformationResponse com.ptvgroup.xserver.xruntime.XRuntime.getRuntimeInformation(com.ptvgroup.xserver.xruntime.getRuntimeInformation request) {
            return base.Channel.getRuntimeInformation(request);
        }

        public com.ptvgroup.xserver.xruntime.RuntimeInformation getRuntimeInformation(com.ptvgroup.xserver.xruntime.RuntimeInformationRequest request) {
            com.ptvgroup.xserver.xruntime.getRuntimeInformation inValue = new com.ptvgroup.xserver.xruntime.getRuntimeInformation();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.getRuntimeInformationResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).getRuntimeInformation(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.getLicenseInformationResponse com.ptvgroup.xserver.xruntime.XRuntime.getLicenseInformation(com.ptvgroup.xserver.xruntime.getLicenseInformation request) {
            return base.Channel.getLicenseInformation(request);
        }

        public com.ptvgroup.xserver.xruntime.LicenseInformation getLicenseInformation(com.ptvgroup.xserver.xruntime.LicenseInformationRequest request) {
            com.ptvgroup.xserver.xruntime.getLicenseInformation inValue = new com.ptvgroup.xserver.xruntime.getLicenseInformation();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.getLicenseInformationResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).getLicenseInformation(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.getDataInformationResponse com.ptvgroup.xserver.xruntime.XRuntime.getDataInformation(com.ptvgroup.xserver.xruntime.getDataInformation request) {
            return base.Channel.getDataInformation(request);
        }

        public com.ptvgroup.xserver.xruntime.DataInformationResponse getDataInformation(com.ptvgroup.xserver.xruntime.DataInformationRequest request) {
            com.ptvgroup.xserver.xruntime.getDataInformation inValue = new com.ptvgroup.xserver.xruntime.getDataInformation();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.getDataInformationResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).getDataInformation(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.triggerContentUpdateResponse com.ptvgroup.xserver.xruntime.XRuntime.triggerContentUpdate(com.ptvgroup.xserver.xruntime.triggerContentUpdate request) {
            return base.Channel.triggerContentUpdate(request);
        }

        public com.ptvgroup.xserver.xruntime.ContentUpdateTriggerResponse triggerContentUpdate(com.ptvgroup.xserver.xruntime.ContentUpdateTriggerRequest request) {
            com.ptvgroup.xserver.xruntime.triggerContentUpdate inValue = new com.ptvgroup.xserver.xruntime.triggerContentUpdate();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.triggerContentUpdateResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).triggerContentUpdate(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.getContentUpdateTriggerStatusResponse com.ptvgroup.xserver.xruntime.XRuntime.getContentUpdateTriggerStatus(com.ptvgroup.xserver.xruntime.getContentUpdateTriggerStatus request) {
            return base.Channel.getContentUpdateTriggerStatus(request);
        }

        public com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatusResponse getContentUpdateTriggerStatus(com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatusRequest request) {
            com.ptvgroup.xserver.xruntime.getContentUpdateTriggerStatus inValue = new com.ptvgroup.xserver.xruntime.getContentUpdateTriggerStatus();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.getContentUpdateTriggerStatusResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).getContentUpdateTriggerStatus(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.resetMetricsResponse com.ptvgroup.xserver.xruntime.XRuntime.resetMetrics(com.ptvgroup.xserver.xruntime.resetMetrics request) {
            return base.Channel.resetMetrics(request);
        }

        public com.ptvgroup.xserver.service.VoidResponse resetMetrics(com.ptvgroup.xserver.xruntime.ResetMetricsRequest request) {
            com.ptvgroup.xserver.xruntime.resetMetrics inValue = new com.ptvgroup.xserver.xruntime.resetMetrics();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.resetMetricsResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).resetMetrics(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.shutdownServerResponse com.ptvgroup.xserver.xruntime.XRuntime.shutdownServer(com.ptvgroup.xserver.xruntime.shutdownServer request) {
            return base.Channel.shutdownServer(request);
        }

        public com.ptvgroup.xserver.service.VoidResponse shutdownServer(com.ptvgroup.xserver.xruntime.ShutdownServerRequest request) {
            com.ptvgroup.xserver.xruntime.shutdownServer inValue = new com.ptvgroup.xserver.xruntime.shutdownServer();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.shutdownServerResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).shutdownServer(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.restartModulesResponse com.ptvgroup.xserver.xruntime.XRuntime.restartModules(com.ptvgroup.xserver.xruntime.restartModules request) {
            return base.Channel.restartModules(request);
        }

        public com.ptvgroup.xserver.service.VoidResponse restartModules(com.ptvgroup.xserver.xruntime.RestartModulesRequest request) {
            com.ptvgroup.xserver.xruntime.restartModules inValue = new com.ptvgroup.xserver.xruntime.restartModules();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.restartModulesResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).restartModules(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.stopRequestResponse com.ptvgroup.xserver.xruntime.XRuntime.stopRequest(com.ptvgroup.xserver.xruntime.stopRequest request) {
            return base.Channel.stopRequest(request);
        }

        public com.ptvgroup.xserver.service.VoidResponse stopRequest(com.ptvgroup.xserver.xruntime.StopDeleteRequest request) {
            com.ptvgroup.xserver.xruntime.stopRequest inValue = new com.ptvgroup.xserver.xruntime.stopRequest();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.stopRequestResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).stopRequest(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.deleteRequestResponse com.ptvgroup.xserver.xruntime.XRuntime.deleteRequest(com.ptvgroup.xserver.xruntime.deleteRequest request) {
            return base.Channel.deleteRequest(request);
        }

        public com.ptvgroup.xserver.service.VoidResponse deleteRequest(com.ptvgroup.xserver.xruntime.StopDeleteRequest request) {
            com.ptvgroup.xserver.xruntime.deleteRequest inValue = new com.ptvgroup.xserver.xruntime.deleteRequest();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.deleteRequestResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).deleteRequest(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.convertResponse com.ptvgroup.xserver.xruntime.XRuntime.convert(com.ptvgroup.xserver.xruntime.convert request) {
            return base.Channel.convert(request);
        }

        public com.ptvgroup.xserver.xruntime.ConversionResponse convert(com.ptvgroup.xserver.xruntime.ConversionRequest request) {
            com.ptvgroup.xserver.xruntime.convert inValue = new com.ptvgroup.xserver.xruntime.convert();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.convertResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).convert(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.createSupportPackageResponse com.ptvgroup.xserver.xruntime.XRuntime.createSupportPackage(com.ptvgroup.xserver.xruntime.createSupportPackage request) {
            return base.Channel.createSupportPackage(request);
        }

        public com.ptvgroup.xserver.xruntime.SupportPackageResponse createSupportPackage(com.ptvgroup.xserver.xruntime.SupportPackageRequest request) {
            com.ptvgroup.xserver.xruntime.createSupportPackage inValue = new com.ptvgroup.xserver.xruntime.createSupportPackage();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.createSupportPackageResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).createSupportPackage(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.getServerConfigurationResponse com.ptvgroup.xserver.xruntime.XRuntime.getServerConfiguration(com.ptvgroup.xserver.xruntime.getServerConfiguration request) {
            return base.Channel.getServerConfiguration(request);
        }

        public com.ptvgroup.xserver.xruntime.ServerConfigurationResponse getServerConfiguration(com.ptvgroup.xserver.xruntime.ServerConfigurationRequest request) {
            com.ptvgroup.xserver.xruntime.getServerConfiguration inValue = new com.ptvgroup.xserver.xruntime.getServerConfiguration();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.getServerConfigurationResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).getServerConfiguration(inValue);
            return retVal.@return;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xruntime.getConfigurationFileResponse com.ptvgroup.xserver.xruntime.XRuntime.getConfigurationFile(com.ptvgroup.xserver.xruntime.getConfigurationFile request) {
            return base.Channel.getConfigurationFile(request);
        }

        public com.ptvgroup.xserver.xruntime.ConfigurationFileResponse getConfigurationFile(com.ptvgroup.xserver.xruntime.ConfigurationFileRequest request) {
            com.ptvgroup.xserver.xruntime.getConfigurationFile inValue = new com.ptvgroup.xserver.xruntime.getConfigurationFile();
            inValue.request = request;
            com.ptvgroup.xserver.xruntime.getConfigurationFileResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).getConfigurationFile(inValue);
            return retVal.@return;
        }


            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xruntime.watchJobResponse com.ptvgroup.xserver.xruntime.XRuntime.watchJob(com.ptvgroup.xserver.xruntime.watchJob request) {
                return base.Channel.watchJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job watchJob(com.ptvgroup.xserver.jobs.WatchRequest request) {
                com.ptvgroup.xserver.xruntime.watchJob inValue = new com.ptvgroup.xserver.xruntime.watchJob();
                inValue.request = request;
                com.ptvgroup.xserver.xruntime.watchJobResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).watchJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xruntime.stopJobResponse com.ptvgroup.xserver.xruntime.XRuntime.stopJob(com.ptvgroup.xserver.xruntime.stopJob request) {
                return base.Channel.stopJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job stopJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xruntime.stopJob inValue = new com.ptvgroup.xserver.xruntime.stopJob();
                inValue.request = request;
                com.ptvgroup.xserver.xruntime.stopJobResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).stopJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xruntime.deleteJobResponse com.ptvgroup.xserver.xruntime.XRuntime.deleteJob(com.ptvgroup.xserver.xruntime.deleteJob request) {
                return base.Channel.deleteJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job deleteJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xruntime.deleteJob inValue = new com.ptvgroup.xserver.xruntime.deleteJob();
                inValue.request = request;
                com.ptvgroup.xserver.xruntime.deleteJobResponse retVal = ((com.ptvgroup.xserver.xruntime.XRuntime)(this)).deleteJob(inValue);
                return retVal.@return;
            }

   }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ConfigurationFileRequest : com.ptvgroup.xserver.service.RequestBase {

        private string fileNameField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
                this.RaisePropertyChanged("fileName");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ConfigurationFileResponse : com.ptvgroup.xserver.service.ResponseBase {

        private string fileNameField;
        private string contentsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
                this.RaisePropertyChanged("fileName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contents {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ConfigurationResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool profilesField;
        private bool profilesFieldSpecified;
        private bool configurationFileNamesField;
        private bool configurationFileNamesFieldSpecified;
        private bool thirdPartyLibrariesField;
        private bool thirdPartyLibrariesFieldSpecified;
        private bool internalLibrariesField;
        private bool internalLibrariesFieldSpecified;

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
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool configurationFileNames {
            get {
                return this.configurationFileNamesField;
            }
            set {
                this.configurationFileNamesField = value;
                this.RaisePropertyChanged("configurationFileNames");
                this.configurationFileNamesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool configurationFileNamesSpecified {
            get {
                return this.configurationFileNamesFieldSpecified;
            }
            set {
                this.configurationFileNamesFieldSpecified = value;
                this.RaisePropertyChanged("configurationFileNamesSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool thirdPartyLibraries {
            get {
                return this.thirdPartyLibrariesField;
            }
            set {
                this.thirdPartyLibrariesField = value;
                this.RaisePropertyChanged("thirdPartyLibraries");
                this.thirdPartyLibrariesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool thirdPartyLibrariesSpecified {
            get {
                return this.thirdPartyLibrariesFieldSpecified;
            }
            set {
                this.thirdPartyLibrariesFieldSpecified = value;
                this.RaisePropertyChanged("thirdPartyLibrariesSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool internalLibraries {
            get {
                return this.internalLibrariesField;
            }
            set {
                this.internalLibrariesField = value;
                this.RaisePropertyChanged("internalLibraries");
                this.internalLibrariesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool internalLibrariesSpecified {
            get {
                return this.internalLibrariesFieldSpecified;
            }
            set {
                this.internalLibrariesFieldSpecified = value;
                this.RaisePropertyChanged("internalLibrariesSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ContentUpdateTriggerRequest : com.ptvgroup.xserver.service.RequestBase {

        private bool trafficIncidentsField;
        private bool trafficIncidentsFieldSpecified;
        private bool basicTollField;
        private bool basicTollFieldSpecified;
        private bool detailedTollField;
        private bool detailedTollFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool trafficIncidents {
            get {
                return this.trafficIncidentsField;
            }
            set {
                this.trafficIncidentsField = value;
                this.RaisePropertyChanged("trafficIncidents");
                this.trafficIncidentsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trafficIncidentsSpecified {
            get {
                return this.trafficIncidentsFieldSpecified;
            }
            set {
                this.trafficIncidentsFieldSpecified = value;
                this.RaisePropertyChanged("trafficIncidentsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool basicToll {
            get {
                return this.basicTollField;
            }
            set {
                this.basicTollField = value;
                this.RaisePropertyChanged("basicToll");
                this.basicTollFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool basicTollSpecified {
            get {
                return this.basicTollFieldSpecified;
            }
            set {
                this.basicTollFieldSpecified = value;
                this.RaisePropertyChanged("basicTollSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool detailedToll {
            get {
                return this.detailedTollField;
            }
            set {
                this.detailedTollField = value;
                this.RaisePropertyChanged("detailedToll");
                this.detailedTollFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool detailedTollSpecified {
            get {
                return this.detailedTollFieldSpecified;
            }
            set {
                this.detailedTollFieldSpecified = value;
                this.RaisePropertyChanged("detailedTollSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ContentUpdateTriggerResponse : com.ptvgroup.xserver.service.ResponseBase {

        private bool trafficIncidentsTriggeredField;
        private bool trafficIncidentsTriggeredFieldSpecified;
        private bool basicTollTriggeredField;
        private bool basicTollTriggeredFieldSpecified;
        private bool detailedTollTriggeredField;
        private bool detailedTollTriggeredFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool trafficIncidentsTriggered {
            get {
                return this.trafficIncidentsTriggeredField;
            }
            set {
                this.trafficIncidentsTriggeredField = value;
                this.RaisePropertyChanged("trafficIncidentsTriggered");
                this.trafficIncidentsTriggeredFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trafficIncidentsTriggeredSpecified {
            get {
                return this.trafficIncidentsTriggeredFieldSpecified;
            }
            set {
                this.trafficIncidentsTriggeredFieldSpecified = value;
                this.RaisePropertyChanged("trafficIncidentsTriggeredSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool basicTollTriggered {
            get {
                return this.basicTollTriggeredField;
            }
            set {
                this.basicTollTriggeredField = value;
                this.RaisePropertyChanged("basicTollTriggered");
                this.basicTollTriggeredFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool basicTollTriggeredSpecified {
            get {
                return this.basicTollTriggeredFieldSpecified;
            }
            set {
                this.basicTollTriggeredFieldSpecified = value;
                this.RaisePropertyChanged("basicTollTriggeredSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool detailedTollTriggered {
            get {
                return this.detailedTollTriggeredField;
            }
            set {
                this.detailedTollTriggeredField = value;
                this.RaisePropertyChanged("detailedTollTriggered");
                this.detailedTollTriggeredFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool detailedTollTriggeredSpecified {
            get {
                return this.detailedTollTriggeredFieldSpecified;
            }
            set {
                this.detailedTollTriggeredFieldSpecified = value;
                this.RaisePropertyChanged("detailedTollTriggeredSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ContentUpdateTriggerStatusRequest : com.ptvgroup.xserver.service.RequestBase {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ContentUpdateTriggerStatusResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatus trafficIncidentsField;
        private bool trafficIncidentsFieldSpecified;
        private com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatus basicTollField;
        private bool basicTollFieldSpecified;
        private com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatus detailedTollField;
        private bool detailedTollFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatus trafficIncidents {
            get {
                return this.trafficIncidentsField;
            }
            set {
                this.trafficIncidentsField = value;
                this.RaisePropertyChanged("trafficIncidents");
                this.trafficIncidentsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trafficIncidentsSpecified {
            get {
                return this.trafficIncidentsFieldSpecified;
            }
            set {
                this.trafficIncidentsFieldSpecified = value;
                this.RaisePropertyChanged("trafficIncidentsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatus basicToll {
            get {
                return this.basicTollField;
            }
            set {
                this.basicTollField = value;
                this.RaisePropertyChanged("basicToll");
                this.basicTollFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool basicTollSpecified {
            get {
                return this.basicTollFieldSpecified;
            }
            set {
                this.basicTollFieldSpecified = value;
                this.RaisePropertyChanged("basicTollSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatus detailedToll {
            get {
                return this.detailedTollField;
            }
            set {
                this.detailedTollField = value;
                this.RaisePropertyChanged("detailedToll");
                this.detailedTollFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool detailedTollSpecified {
            get {
                return this.detailedTollFieldSpecified;
            }
            set {
                this.detailedTollFieldSpecified = value;
                this.RaisePropertyChanged("detailedTollSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Continent : object, System.ComponentModel.INotifyPropertyChanged {

        private string codeField;
        private com.ptvgroup.xserver.xruntime.Country[] countriesField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("countries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Country[] countries {
            get {
                return this.countriesField;
            }
            set {
                this.countriesField = value;
                this.RaisePropertyChanged("countries");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ConversionRequest : com.ptvgroup.xserver.service.RequestBase {

        private string contentField;
        private bool isJsonField;
        private bool isRequestField;
        private string serviceNameField;
        private string methodNameField;
        private string serviceVersionField;
        private bool keepProtocolField;
        private bool keepProtocolFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isJson {
            get {
                return this.isJsonField;
            }
            set {
                this.isJsonField = value;
                this.RaisePropertyChanged("isJson");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isRequest {
            get {
                return this.isRequestField;
            }
            set {
                this.isRequestField = value;
                this.RaisePropertyChanged("isRequest");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceName {
            get {
                return this.serviceNameField;
            }
            set {
                this.serviceNameField = value;
                this.RaisePropertyChanged("serviceName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string methodName {
            get {
                return this.methodNameField;
            }
            set {
                this.methodNameField = value;
                this.RaisePropertyChanged("methodName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceVersion {
            get {
                return this.serviceVersionField;
            }
            set {
                this.serviceVersionField = value;
                this.RaisePropertyChanged("serviceVersion");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool keepProtocol {
            get {
                return this.keepProtocolField;
            }
            set {
                this.keepProtocolField = value;
                this.RaisePropertyChanged("keepProtocol");
                this.keepProtocolFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool keepProtocolSpecified {
            get {
                return this.keepProtocolFieldSpecified;
            }
            set {
                this.keepProtocolFieldSpecified = value;
                this.RaisePropertyChanged("keepProtocolSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ConversionResponse : com.ptvgroup.xserver.service.ResponseBase {

        private string contentField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Copyright : object, System.ComponentModel.INotifyPropertyChanged {

        private string[] basemapField;
        private com.ptvgroup.xserver.xruntime.FeatureLayerCopyright[] featureLayersField;

                    [System.Xml.Serialization.XmlElementAttribute("basemap", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] basemap {
            get {
                return this.basemapField;
            }
            set {
                this.basemapField = value;
                this.RaisePropertyChanged("basemap");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("featureLayers", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.FeatureLayerCopyright[] featureLayers {
            get {
                return this.featureLayersField;
            }
            set {
                this.featureLayersField = value;
                this.RaisePropertyChanged("featureLayers");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Country : object, System.ComponentModel.INotifyPropertyChanged {

        private string codeField;
        private com.ptvgroup.xserver.xruntime.RegionDescription descriptionField;
        private com.ptvgroup.xserver.xruntime.RegionFeatures featuresField;
        private com.ptvgroup.xserver.xruntime.Subdivision[] subdivisionsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("description", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.RegionDescription description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("features", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.RegionFeatures features {
            get {
                return this.featuresField;
            }
            set {
                this.featuresField = value;
                this.RaisePropertyChanged("features");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("subdivisions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Subdivision[] subdivisions {
            get {
                return this.subdivisionsField;
            }
            set {
                this.subdivisionsField = value;
                this.RaisePropertyChanged("subdivisions");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class DataInformationOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private bool returnOnlyLicensedMapFeaturesField;
        private bool returnOnlyLicensedMapFeaturesFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool returnOnlyLicensedMapFeatures {
            get {
                return this.returnOnlyLicensedMapFeaturesField;
            }
            set {
                this.returnOnlyLicensedMapFeaturesField = value;
                this.RaisePropertyChanged("returnOnlyLicensedMapFeatures");
                this.returnOnlyLicensedMapFeaturesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool returnOnlyLicensedMapFeaturesSpecified {
            get {
                return this.returnOnlyLicensedMapFeaturesFieldSpecified;
            }
            set {
                this.returnOnlyLicensedMapFeaturesFieldSpecified = value;
                this.RaisePropertyChanged("returnOnlyLicensedMapFeaturesSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class DataInformationRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xruntime.DataInformationOptions dataInformationOptionsField;
        private com.ptvgroup.xserver.xruntime.DataInformationResultFields resultFieldsField;

                    [System.Xml.Serialization.XmlElementAttribute("dataInformationOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.DataInformationOptions dataInformationOptions {
            get {
                return this.dataInformationOptionsField;
            }
            set {
                this.dataInformationOptionsField = value;
                this.RaisePropertyChanged("dataInformationOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.DataInformationResultFields resultFields {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class DataInformationResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xruntime.MapDescription mapDescriptionField;
        private com.ptvgroup.xserver.xruntime.MapFeatures mapFeaturesField;
        private com.ptvgroup.xserver.xruntime.Continent[] continentsField;

                    [System.Xml.Serialization.XmlElementAttribute("mapDescription", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.MapDescription mapDescription {
            get {
                return this.mapDescriptionField;
            }
            set {
                this.mapDescriptionField = value;
                this.RaisePropertyChanged("mapDescription");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("mapFeatures", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.MapFeatures mapFeatures {
            get {
                return this.mapFeaturesField;
            }
            set {
                this.mapFeaturesField = value;
                this.RaisePropertyChanged("mapFeatures");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("continents", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Continent[] continents {
            get {
                return this.continentsField;
            }
            set {
                this.continentsField = value;
                this.RaisePropertyChanged("continents");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class DataInformationResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool continentsField;
        private bool continentsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool continents {
            get {
                return this.continentsField;
            }
            set {
                this.continentsField = value;
                this.RaisePropertyChanged("continents");
                this.continentsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool continentsSpecified {
            get {
                return this.continentsFieldSpecified;
            }
            set {
                this.continentsFieldSpecified = value;
                this.RaisePropertyChanged("continentsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Environment : object, System.ComponentModel.INotifyPropertyChanged {

        private string operatingSystemField;
        private string cpuArchitectureField;
        private int numberOfProcessorsField;
        private string hostNameField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string operatingSystem {
            get {
                return this.operatingSystemField;
            }
            set {
                this.operatingSystemField = value;
                this.RaisePropertyChanged("operatingSystem");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cpuArchitecture {
            get {
                return this.cpuArchitectureField;
            }
            set {
                this.cpuArchitectureField = value;
                this.RaisePropertyChanged("cpuArchitecture");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfProcessors {
            get {
                return this.numberOfProcessorsField;
            }
            set {
                this.numberOfProcessorsField = value;
                this.RaisePropertyChanged("numberOfProcessors");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hostName {
            get {
                return this.hostNameField;
            }
            set {
                this.hostNameField = value;
                this.RaisePropertyChanged("hostName");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class FeatureLayerCopyright : object, System.ComponentModel.INotifyPropertyChanged {

        private string themeIdField;
        private string[] copyrightField;

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

                    [System.Xml.Serialization.XmlElementAttribute("copyright", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] copyright {
            get {
                return this.copyrightField;
            }
            set {
                this.copyrightField = value;
                this.RaisePropertyChanged("copyright");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class FeatureLayerTheme : object, System.ComponentModel.INotifyPropertyChanged {

        private string themeIdField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Gauge : object, System.ComponentModel.INotifyPropertyChanged {

        private int valueField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int value {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Gauges : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xruntime.Gauge queueSizeField;

                    [System.Xml.Serialization.XmlElementAttribute("queueSize", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Gauge queueSize {
            get {
                return this.queueSizeField;
            }
            set {
                this.queueSizeField = value;
                this.RaisePropertyChanged("queueSize");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Histogram : object, System.ComponentModel.INotifyPropertyChanged {

        private int sizeField;
        private long minField;
        private long maxField;
        private double meanField;
        private double medianField;
        private double standardDeviationField;
        private double percentile75Field;
        private double percentile95Field;
        private double percentile98Field;
        private double percentile99Field;
        private double percentile999Field;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
                this.RaisePropertyChanged("size");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long min {
            get {
                return this.minField;
            }
            set {
                this.minField = value;
                this.RaisePropertyChanged("min");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long max {
            get {
                return this.maxField;
            }
            set {
                this.maxField = value;
                this.RaisePropertyChanged("max");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double mean {
            get {
                return this.meanField;
            }
            set {
                this.meanField = value;
                this.RaisePropertyChanged("mean");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double median {
            get {
                return this.medianField;
            }
            set {
                this.medianField = value;
                this.RaisePropertyChanged("median");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double standardDeviation {
            get {
                return this.standardDeviationField;
            }
            set {
                this.standardDeviationField = value;
                this.RaisePropertyChanged("standardDeviation");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double percentile75 {
            get {
                return this.percentile75Field;
            }
            set {
                this.percentile75Field = value;
                this.RaisePropertyChanged("percentile75");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double percentile95 {
            get {
                return this.percentile95Field;
            }
            set {
                this.percentile95Field = value;
                this.RaisePropertyChanged("percentile95");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double percentile98 {
            get {
                return this.percentile98Field;
            }
            set {
                this.percentile98Field = value;
                this.RaisePropertyChanged("percentile98");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double percentile99 {
            get {
                return this.percentile99Field;
            }
            set {
                this.percentile99Field = value;
                this.RaisePropertyChanged("percentile99");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double percentile999 {
            get {
                return this.percentile999Field;
            }
            set {
                this.percentile999Field = value;
                this.RaisePropertyChanged("percentile999");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Histograms : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xruntime.Histogram queuingTimeField;
        private com.ptvgroup.xserver.xruntime.Histogram computationTimeField;
        private com.ptvgroup.xserver.xruntime.Histogram overallTimeField;

                    [System.Xml.Serialization.XmlElementAttribute("queuingTime", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Histogram queuingTime {
            get {
                return this.queuingTimeField;
            }
            set {
                this.queuingTimeField = value;
                this.RaisePropertyChanged("queuingTime");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("computationTime", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Histogram computationTime {
            get {
                return this.computationTimeField;
            }
            set {
                this.computationTimeField = value;
                this.RaisePropertyChanged("computationTime");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("overallTime", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Histogram overallTime {
            get {
                return this.overallTimeField;
            }
            set {
                this.overallTimeField = value;
                this.RaisePropertyChanged("overallTime");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Library : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private string groupIdField;
        private string nameField;
        private string versionField;
        private com.ptvgroup.xserver.xruntime.License[] licensesField;
        private string urlField;

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
        public string groupId {
            get {
                return this.groupIdField;
            }
            set {
                this.groupIdField = value;
                this.RaisePropertyChanged("groupId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
                this.RaisePropertyChanged("version");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("licenses", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.License[] licenses {
            get {
                return this.licensesField;
            }
            set {
                this.licensesField = value;
                this.RaisePropertyChanged("licenses");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
                this.RaisePropertyChanged("url");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class License : object, System.ComponentModel.INotifyPropertyChanged {

        private string nameField;
        private string urlField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
                this.RaisePropertyChanged("url");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class LicenseInformation : com.ptvgroup.xserver.service.ResponseBase {

        private System.DateTime creationDateField;
        private bool floatingLicenseField;
        private string floatingLicenseServerAddressField;
        private string productNameField;
        private string licenseHardwareIdField;
        private string localHardwareIdField;
        private int quantityField;
        private int usageField;
        private System.DateTime expireDateField;
        private int expireDaysRemainingField;
        private com.ptvgroup.xserver.types.KeyValuePair[] customFeaturesField;
        private bool partnerLicenseField;
        private bool partnerLicenseFieldSpecified;
        private string partnerLicenseNameField;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime creationDate {
            get {
                return this.creationDateField;
            }
            set {
                this.creationDateField = value;
                this.RaisePropertyChanged("creationDate");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool floatingLicense {
            get {
                return this.floatingLicenseField;
            }
            set {
                this.floatingLicenseField = value;
                this.RaisePropertyChanged("floatingLicense");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string floatingLicenseServerAddress {
            get {
                return this.floatingLicenseServerAddressField;
            }
            set {
                this.floatingLicenseServerAddressField = value;
                this.RaisePropertyChanged("floatingLicenseServerAddress");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string productName {
            get {
                return this.productNameField;
            }
            set {
                this.productNameField = value;
                this.RaisePropertyChanged("productName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string licenseHardwareId {
            get {
                return this.licenseHardwareIdField;
            }
            set {
                this.licenseHardwareIdField = value;
                this.RaisePropertyChanged("licenseHardwareId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string localHardwareId {
            get {
                return this.localHardwareIdField;
            }
            set {
                this.localHardwareIdField = value;
                this.RaisePropertyChanged("localHardwareId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
                this.RaisePropertyChanged("quantity");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int usage {
            get {
                return this.usageField;
            }
            set {
                this.usageField = value;
                this.RaisePropertyChanged("usage");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime expireDate {
            get {
                return this.expireDateField;
            }
            set {
                this.expireDateField = value;
                this.RaisePropertyChanged("expireDate");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int expireDaysRemaining {
            get {
                return this.expireDaysRemainingField;
            }
            set {
                this.expireDaysRemainingField = value;
                this.RaisePropertyChanged("expireDaysRemaining");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("customFeatures", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.KeyValuePair[] customFeatures {
            get {
                return this.customFeaturesField;
            }
            set {
                this.customFeaturesField = value;
                this.RaisePropertyChanged("customFeatures");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool partnerLicense {
            get {
                return this.partnerLicenseField;
            }
            set {
                this.partnerLicenseField = value;
                this.RaisePropertyChanged("partnerLicense");
                this.partnerLicenseFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool partnerLicenseSpecified {
            get {
                return this.partnerLicenseFieldSpecified;
            }
            set {
                this.partnerLicenseFieldSpecified = value;
                this.RaisePropertyChanged("partnerLicenseSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string partnerLicenseName {
            get {
                return this.partnerLicenseNameField;
            }
            set {
                this.partnerLicenseNameField = value;
                this.RaisePropertyChanged("partnerLicenseName");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class LicenseInformationRequest : com.ptvgroup.xserver.service.RequestBase {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class MapDescription : object, System.ComponentModel.INotifyPropertyChanged {

        private string displayNameField;
        private string providerInformationField;
        private com.ptvgroup.xserver.xruntime.MapDetailLevel detailLevelField;
        private bool detailLevelFieldSpecified;
        private com.ptvgroup.xserver.xruntime.Copyright copyrightField;
        private int dataCompatibilityVersionField;
        private bool dataCompatibilityVersionFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
                this.RaisePropertyChanged("displayName");
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

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xruntime.MapDetailLevel detailLevel {
            get {
                return this.detailLevelField;
            }
            set {
                this.detailLevelField = value;
                this.RaisePropertyChanged("detailLevel");
                this.detailLevelFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool detailLevelSpecified {
            get {
                return this.detailLevelFieldSpecified;
            }
            set {
                this.detailLevelFieldSpecified = value;
                this.RaisePropertyChanged("detailLevelSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("copyright", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Copyright copyright {
            get {
                return this.copyrightField;
            }
            set {
                this.copyrightField = value;
                this.RaisePropertyChanged("copyright");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int dataCompatibilityVersion {
            get {
                return this.dataCompatibilityVersionField;
            }
            set {
                this.dataCompatibilityVersionField = value;
                this.RaisePropertyChanged("dataCompatibilityVersion");
                this.dataCompatibilityVersionFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataCompatibilityVersionSpecified {
            get {
                return this.dataCompatibilityVersionFieldSpecified;
            }
            set {
                this.dataCompatibilityVersionFieldSpecified = value;
                this.RaisePropertyChanged("dataCompatibilityVersionSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class MapFeatures : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xruntime.FeatureLayerTheme[] featureLayerThemesField;
        private com.ptvgroup.xserver.types.Language[] directionDescriptionLanguagesField;
        private com.ptvgroup.xserver.xruntime.TollFeatures tollFeaturesField;

                    [System.Xml.Serialization.XmlElementAttribute("featureLayerThemes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.FeatureLayerTheme[] featureLayerThemes {
            get {
                return this.featureLayerThemesField;
            }
            set {
                this.featureLayerThemesField = value;
                this.RaisePropertyChanged("featureLayerThemes");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("directionDescriptionLanguages", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.Language[] directionDescriptionLanguages {
            get {
                return this.directionDescriptionLanguagesField;
            }
            set {
                this.directionDescriptionLanguagesField = value;
                this.RaisePropertyChanged("directionDescriptionLanguages");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tollFeatures", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.TollFeatures tollFeatures {
            get {
                return this.tollFeaturesField;
            }
            set {
                this.tollFeaturesField = value;
                this.RaisePropertyChanged("tollFeatures");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class MemoryStatistics : object, System.ComponentModel.INotifyPropertyChanged {

        private long memoryUsageField;
        private bool memoryUsageFieldSpecified;
        private long committedVirtualMemorySizeField;
        private long heapCommittedMemorySizeField;
        private long heapUsedMemorySizeField;
        private long nonHeapCommittedMemorySizeField;
        private long nonHeapUsedMemorySizeField;
        private long processCPUTimeField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long memoryUsage {
            get {
                return this.memoryUsageField;
            }
            set {
                this.memoryUsageField = value;
                this.RaisePropertyChanged("memoryUsage");
                this.memoryUsageFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool memoryUsageSpecified {
            get {
                return this.memoryUsageFieldSpecified;
            }
            set {
                this.memoryUsageFieldSpecified = value;
                this.RaisePropertyChanged("memoryUsageSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long committedVirtualMemorySize {
            get {
                return this.committedVirtualMemorySizeField;
            }
            set {
                this.committedVirtualMemorySizeField = value;
                this.RaisePropertyChanged("committedVirtualMemorySize");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long heapCommittedMemorySize {
            get {
                return this.heapCommittedMemorySizeField;
            }
            set {
                this.heapCommittedMemorySizeField = value;
                this.RaisePropertyChanged("heapCommittedMemorySize");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long heapUsedMemorySize {
            get {
                return this.heapUsedMemorySizeField;
            }
            set {
                this.heapUsedMemorySizeField = value;
                this.RaisePropertyChanged("heapUsedMemorySize");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long nonHeapCommittedMemorySize {
            get {
                return this.nonHeapCommittedMemorySizeField;
            }
            set {
                this.nonHeapCommittedMemorySizeField = value;
                this.RaisePropertyChanged("nonHeapCommittedMemorySize");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long nonHeapUsedMemorySize {
            get {
                return this.nonHeapUsedMemorySizeField;
            }
            set {
                this.nonHeapUsedMemorySizeField = value;
                this.RaisePropertyChanged("nonHeapUsedMemorySize");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long processCPUTime {
            get {
                return this.processCPUTimeField;
            }
            set {
                this.processCPUTimeField = value;
                this.RaisePropertyChanged("processCPUTime");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Meter : object, System.ComponentModel.INotifyPropertyChanged {

        private long countField;
        private double meanRateField;
        private double fifteenMinuteRateField;
        private double fiveMinuteRateField;
        private double oneMinuteRateField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
                this.RaisePropertyChanged("count");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double meanRate {
            get {
                return this.meanRateField;
            }
            set {
                this.meanRateField = value;
                this.RaisePropertyChanged("meanRate");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double fifteenMinuteRate {
            get {
                return this.fifteenMinuteRateField;
            }
            set {
                this.fifteenMinuteRateField = value;
                this.RaisePropertyChanged("fifteenMinuteRate");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double fiveMinuteRate {
            get {
                return this.fiveMinuteRateField;
            }
            set {
                this.fiveMinuteRateField = value;
                this.RaisePropertyChanged("fiveMinuteRate");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double oneMinuteRate {
            get {
                return this.oneMinuteRateField;
            }
            set {
                this.oneMinuteRateField = value;
                this.RaisePropertyChanged("oneMinuteRate");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Meters : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xruntime.Meter failedRequestsField;
        private com.ptvgroup.xserver.xruntime.Meter successfulRequestsField;
        private com.ptvgroup.xserver.xruntime.Meter rejectedRequestsField;

                    [System.Xml.Serialization.XmlElementAttribute("failedRequests", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Meter failedRequests {
            get {
                return this.failedRequestsField;
            }
            set {
                this.failedRequestsField = value;
                this.RaisePropertyChanged("failedRequests");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("successfulRequests", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Meter successfulRequests {
            get {
                return this.successfulRequestsField;
            }
            set {
                this.successfulRequestsField = value;
                this.RaisePropertyChanged("successfulRequests");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("rejectedRequests", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Meter rejectedRequests {
            get {
                return this.rejectedRequestsField;
            }
            set {
                this.rejectedRequestsField = value;
                this.RaisePropertyChanged("rejectedRequests");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ModuleInstance : object, System.ComponentModel.INotifyPropertyChanged {

        private string instanceIdField;
        private string[] servicesField;
        private long uptimeField;
        private int numberOfRestartsField;
        private bool inUseField;
        private long useCounterField;
        private com.ptvgroup.xserver.xruntime.MemoryStatistics memoryStatisticsField;
        private string stateField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string instanceId {
            get {
                return this.instanceIdField;
            }
            set {
                this.instanceIdField = value;
                this.RaisePropertyChanged("instanceId");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("services", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] services {
            get {
                return this.servicesField;
            }
            set {
                this.servicesField = value;
                this.RaisePropertyChanged("services");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long uptime {
            get {
                return this.uptimeField;
            }
            set {
                this.uptimeField = value;
                this.RaisePropertyChanged("uptime");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfRestarts {
            get {
                return this.numberOfRestartsField;
            }
            set {
                this.numberOfRestartsField = value;
                this.RaisePropertyChanged("numberOfRestarts");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool inUse {
            get {
                return this.inUseField;
            }
            set {
                this.inUseField = value;
                this.RaisePropertyChanged("inUse");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long useCounter {
            get {
                return this.useCounterField;
            }
            set {
                this.useCounterField = value;
                this.RaisePropertyChanged("useCounter");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("memoryStatistics", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.MemoryStatistics memoryStatistics {
            get {
                return this.memoryStatisticsField;
            }
            set {
                this.memoryStatisticsField = value;
                this.RaisePropertyChanged("memoryStatistics");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ProfileDescription : object, System.ComponentModel.INotifyPropertyChanged {

        private string nameField;
        private string descriptionField;
        private string[] useCasesField;
        private string displayNameField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("useCases", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] useCases {
            get {
                return this.useCasesField;
            }
            set {
                this.useCasesField = value;
                this.RaisePropertyChanged("useCases");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
                this.RaisePropertyChanged("displayName");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class RegionDescription : object, System.ComponentModel.INotifyPropertyChanged {

        private string providerNameField;
        private string providerDataVersionField;
        private com.ptvgroup.xserver.xruntime.MapDetailLevel detailLevelField;
        private bool detailLevelFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string providerName {
            get {
                return this.providerNameField;
            }
            set {
                this.providerNameField = value;
                this.RaisePropertyChanged("providerName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string providerDataVersion {
            get {
                return this.providerDataVersionField;
            }
            set {
                this.providerDataVersionField = value;
                this.RaisePropertyChanged("providerDataVersion");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xruntime.MapDetailLevel detailLevel {
            get {
                return this.detailLevelField;
            }
            set {
                this.detailLevelField = value;
                this.RaisePropertyChanged("detailLevel");
                this.detailLevelFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool detailLevelSpecified {
            get {
                return this.detailLevelFieldSpecified;
            }
            set {
                this.detailLevelFieldSpecified = value;
                this.RaisePropertyChanged("detailLevelSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class RegionFeatureLayerTheme : object, System.ComponentModel.INotifyPropertyChanged {

        private string themeIdField;
        private string providerNameField;
        private string referenceProviderNameField;
        private string referenceProviderDataVersionField;

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
        public string providerName {
            get {
                return this.providerNameField;
            }
            set {
                this.providerNameField = value;
                this.RaisePropertyChanged("providerName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceProviderName {
            get {
                return this.referenceProviderNameField;
            }
            set {
                this.referenceProviderNameField = value;
                this.RaisePropertyChanged("referenceProviderName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceProviderDataVersion {
            get {
                return this.referenceProviderDataVersionField;
            }
            set {
                this.referenceProviderDataVersionField = value;
                this.RaisePropertyChanged("referenceProviderDataVersion");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class RegionFeatures : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xruntime.RegionFeatureLayerTheme[] featureLayerThemesField;
        private com.ptvgroup.xserver.xruntime.RegionTollFeatures tollFeaturesField;

                    [System.Xml.Serialization.XmlElementAttribute("featureLayerThemes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.RegionFeatureLayerTheme[] featureLayerThemes {
            get {
                return this.featureLayerThemesField;
            }
            set {
                this.featureLayerThemesField = value;
                this.RaisePropertyChanged("featureLayerThemes");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tollFeatures", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.RegionTollFeatures tollFeatures {
            get {
                return this.tollFeaturesField;
            }
            set {
                this.tollFeaturesField = value;
                this.RaisePropertyChanged("tollFeatures");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class RegionTollFeatures : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xruntime.TollDetailLevel detailLevelField;
        private bool detailLevelFieldSpecified;
        private string referenceProviderNameField;
        private string referenceProviderDataVersionField;
        private string[] electronicTollCollectionSubscriptionsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xruntime.TollDetailLevel detailLevel {
            get {
                return this.detailLevelField;
            }
            set {
                this.detailLevelField = value;
                this.RaisePropertyChanged("detailLevel");
                this.detailLevelFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool detailLevelSpecified {
            get {
                return this.detailLevelFieldSpecified;
            }
            set {
                this.detailLevelFieldSpecified = value;
                this.RaisePropertyChanged("detailLevelSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceProviderName {
            get {
                return this.referenceProviderNameField;
            }
            set {
                this.referenceProviderNameField = value;
                this.RaisePropertyChanged("referenceProviderName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceProviderDataVersion {
            get {
                return this.referenceProviderDataVersionField;
            }
            set {
                this.referenceProviderDataVersionField = value;
                this.RaisePropertyChanged("referenceProviderDataVersion");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("electronicTollCollectionSubscriptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] electronicTollCollectionSubscriptions {
            get {
                return this.electronicTollCollectionSubscriptionsField;
            }
            set {
                this.electronicTollCollectionSubscriptionsField = value;
                this.RaisePropertyChanged("electronicTollCollectionSubscriptions");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Request : object, System.ComponentModel.INotifyPropertyChanged {

        private string requestIdField;
        private string serviceNameField;
        private string methodNameField;
        private com.ptvgroup.xserver.jobs.JobStatus statusField;
        private bool statusFieldSpecified;
        private com.ptvgroup.xserver.xruntime.RequestInformation[] requestInformationField;
        private System.DateTime finishedField;
        private bool finishedFieldSpecified;
        private System.DateTime finishedAtField;
        private bool finishedAtFieldSpecified;
        private long calculationTimeField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestId {
            get {
                return this.requestIdField;
            }
            set {
                this.requestIdField = value;
                this.RaisePropertyChanged("requestId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceName {
            get {
                return this.serviceNameField;
            }
            set {
                this.serviceNameField = value;
                this.RaisePropertyChanged("serviceName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string methodName {
            get {
                return this.methodNameField;
            }
            set {
                this.methodNameField = value;
                this.RaisePropertyChanged("methodName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.jobs.JobStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
                this.statusFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
                this.RaisePropertyChanged("statusSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("requestInformation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.RequestInformation[] requestInformation {
            get {
                return this.requestInformationField;
            }
            set {
                this.requestInformationField = value;
                this.RaisePropertyChanged("requestInformation");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime finished {
            get {
                return this.finishedField;
            }
            set {
                this.finishedField = value;
                this.RaisePropertyChanged("finished");
                this.finishedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool finishedSpecified {
            get {
                return this.finishedFieldSpecified;
            }
            set {
                this.finishedFieldSpecified = value;
                this.RaisePropertyChanged("finishedSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime finishedAt {
            get {
                return this.finishedAtField;
            }
            set {
                this.finishedAtField = value;
                this.RaisePropertyChanged("finishedAt");
                this.finishedAtFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool finishedAtSpecified {
            get {
                return this.finishedAtFieldSpecified;
            }
            set {
                this.finishedAtFieldSpecified = value;
                this.RaisePropertyChanged("finishedAtSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long calculationTime {
            get {
                return this.calculationTimeField;
            }
            set {
                this.calculationTimeField = value;
                this.RaisePropertyChanged("calculationTime");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class RequestInformation : object, System.ComponentModel.INotifyPropertyChanged {

        private string keyField;
        private string valueField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
                this.RaisePropertyChanged("key");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ResetMetricsRequest : com.ptvgroup.xserver.service.RequestBase {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class RestartModulesRequest : com.ptvgroup.xserver.service.RequestBase {

        private int timeoutField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
                this.RaisePropertyChanged("timeout");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class RuntimeInformation : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xruntime.ServiceInformation[] serviceInformationField;
        private com.ptvgroup.xserver.xruntime.MemoryStatistics memoryStatisticsField;
        private com.ptvgroup.xserver.xruntime.VersionInformation versionInformationField;
        private com.ptvgroup.xserver.xruntime.Environment environmentField;
        private com.ptvgroup.xserver.xruntime.ModuleInstance[] moduleInstancesField;
        private com.ptvgroup.xserver.xruntime.Request[] activeRequestsField;
        private long uptimeField;
        private bool clientIsAdminField;

                    [System.Xml.Serialization.XmlElementAttribute("serviceInformation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.ServiceInformation[] serviceInformation {
            get {
                return this.serviceInformationField;
            }
            set {
                this.serviceInformationField = value;
                this.RaisePropertyChanged("serviceInformation");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("memoryStatistics", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.MemoryStatistics memoryStatistics {
            get {
                return this.memoryStatisticsField;
            }
            set {
                this.memoryStatisticsField = value;
                this.RaisePropertyChanged("memoryStatistics");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("versionInformation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.VersionInformation versionInformation {
            get {
                return this.versionInformationField;
            }
            set {
                this.versionInformationField = value;
                this.RaisePropertyChanged("versionInformation");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("environment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Environment environment {
            get {
                return this.environmentField;
            }
            set {
                this.environmentField = value;
                this.RaisePropertyChanged("environment");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("moduleInstances", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.ModuleInstance[] moduleInstances {
            get {
                return this.moduleInstancesField;
            }
            set {
                this.moduleInstancesField = value;
                this.RaisePropertyChanged("moduleInstances");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("activeRequests", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Request[] activeRequests {
            get {
                return this.activeRequestsField;
            }
            set {
                this.activeRequestsField = value;
                this.RaisePropertyChanged("activeRequests");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public long uptime {
            get {
                return this.uptimeField;
            }
            set {
                this.uptimeField = value;
                this.RaisePropertyChanged("uptime");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool clientIsAdmin {
            get {
                return this.clientIsAdminField;
            }
            set {
                this.clientIsAdminField = value;
                this.RaisePropertyChanged("clientIsAdmin");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class RuntimeInformationRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xruntime.RuntimeResultFields resultFieldsField;

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.RuntimeResultFields resultFields {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class RuntimeMetrics : com.ptvgroup.xserver.service.ResponseBase {

        private string serviceField;
        private string methodField;
        private com.ptvgroup.xserver.xruntime.Histograms histogramsField;
        private com.ptvgroup.xserver.xruntime.Meters metersField;
        private com.ptvgroup.xserver.xruntime.Gauges gaugesField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
                this.RaisePropertyChanged("service");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string method {
            get {
                return this.methodField;
            }
            set {
                this.methodField = value;
                this.RaisePropertyChanged("method");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("histograms", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Histograms histograms {
            get {
                return this.histogramsField;
            }
            set {
                this.histogramsField = value;
                this.RaisePropertyChanged("histograms");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("meters", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Meters meters {
            get {
                return this.metersField;
            }
            set {
                this.metersField = value;
                this.RaisePropertyChanged("meters");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("gauges", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Gauges gauges {
            get {
                return this.gaugesField;
            }
            set {
                this.gaugesField = value;
                this.RaisePropertyChanged("gauges");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class RuntimeResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool versionInformationField;
        private bool versionInformationFieldSpecified;
        private bool serviceInformationField;
        private bool serviceInformationFieldSpecified;
        private bool memoryStatisticsField;
        private bool memoryStatisticsFieldSpecified;
        private bool environmentField;
        private bool environmentFieldSpecified;
        private bool moduleInstancesField;
        private bool moduleInstancesFieldSpecified;
        private bool activeRequestsField;
        private bool activeRequestsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool versionInformation {
            get {
                return this.versionInformationField;
            }
            set {
                this.versionInformationField = value;
                this.RaisePropertyChanged("versionInformation");
                this.versionInformationFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool versionInformationSpecified {
            get {
                return this.versionInformationFieldSpecified;
            }
            set {
                this.versionInformationFieldSpecified = value;
                this.RaisePropertyChanged("versionInformationSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool serviceInformation {
            get {
                return this.serviceInformationField;
            }
            set {
                this.serviceInformationField = value;
                this.RaisePropertyChanged("serviceInformation");
                this.serviceInformationFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool serviceInformationSpecified {
            get {
                return this.serviceInformationFieldSpecified;
            }
            set {
                this.serviceInformationFieldSpecified = value;
                this.RaisePropertyChanged("serviceInformationSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool memoryStatistics {
            get {
                return this.memoryStatisticsField;
            }
            set {
                this.memoryStatisticsField = value;
                this.RaisePropertyChanged("memoryStatistics");
                this.memoryStatisticsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool memoryStatisticsSpecified {
            get {
                return this.memoryStatisticsFieldSpecified;
            }
            set {
                this.memoryStatisticsFieldSpecified = value;
                this.RaisePropertyChanged("memoryStatisticsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool environment {
            get {
                return this.environmentField;
            }
            set {
                this.environmentField = value;
                this.RaisePropertyChanged("environment");
                this.environmentFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool environmentSpecified {
            get {
                return this.environmentFieldSpecified;
            }
            set {
                this.environmentFieldSpecified = value;
                this.RaisePropertyChanged("environmentSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool moduleInstances {
            get {
                return this.moduleInstancesField;
            }
            set {
                this.moduleInstancesField = value;
                this.RaisePropertyChanged("moduleInstances");
                this.moduleInstancesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool moduleInstancesSpecified {
            get {
                return this.moduleInstancesFieldSpecified;
            }
            set {
                this.moduleInstancesFieldSpecified = value;
                this.RaisePropertyChanged("moduleInstancesSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool activeRequests {
            get {
                return this.activeRequestsField;
            }
            set {
                this.activeRequestsField = value;
                this.RaisePropertyChanged("activeRequests");
                this.activeRequestsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activeRequestsSpecified {
            get {
                return this.activeRequestsFieldSpecified;
            }
            set {
                this.activeRequestsFieldSpecified = value;
                this.RaisePropertyChanged("activeRequestsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ServerConfigurationRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xruntime.ConfigurationResultFields resultFieldsField;

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.ConfigurationResultFields resultFields {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ServerConfigurationResponse : com.ptvgroup.xserver.service.ResponseBase {

        private string versionField;
        private com.ptvgroup.xserver.xruntime.ProfileDescription[] profilesField;
        private string[] configFileNamesField;
        private com.ptvgroup.xserver.xruntime.Library[] used3rdPartyLibrariesField;
        private com.ptvgroup.xserver.xruntime.Library[] internalLibrariesField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
                this.RaisePropertyChanged("version");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("profiles", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.ProfileDescription[] profiles {
            get {
                return this.profilesField;
            }
            set {
                this.profilesField = value;
                this.RaisePropertyChanged("profiles");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("configFileNames", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] configFileNames {
            get {
                return this.configFileNamesField;
            }
            set {
                this.configFileNamesField = value;
                this.RaisePropertyChanged("configFileNames");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("used3rdPartyLibraries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Library[] used3rdPartyLibraries {
            get {
                return this.used3rdPartyLibrariesField;
            }
            set {
                this.used3rdPartyLibrariesField = value;
                this.RaisePropertyChanged("used3rdPartyLibraries");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("internalLibraries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.Library[] internalLibraries {
            get {
                return this.internalLibrariesField;
            }
            set {
                this.internalLibrariesField = value;
                this.RaisePropertyChanged("internalLibraries");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ServiceInformation : object, System.ComponentModel.INotifyPropertyChanged {

        private string nameField;
        private string versionField;
        private string[] supportedVersionsField;
        private bool asyncField;
        private bool licensedField;
        private bool activeField;
        private bool pluginField;
        private com.ptvgroup.xserver.xruntime.ServiceMethod[] methodsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
                this.RaisePropertyChanged("version");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("supportedVersions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] supportedVersions {
            get {
                return this.supportedVersionsField;
            }
            set {
                this.supportedVersionsField = value;
                this.RaisePropertyChanged("supportedVersions");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool async {
            get {
                return this.asyncField;
            }
            set {
                this.asyncField = value;
                this.RaisePropertyChanged("async");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool licensed {
            get {
                return this.licensedField;
            }
            set {
                this.licensedField = value;
                this.RaisePropertyChanged("licensed");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active {
            get {
                return this.activeField;
            }
            set {
                this.activeField = value;
                this.RaisePropertyChanged("active");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool plugin {
            get {
                return this.pluginField;
            }
            set {
                this.pluginField = value;
                this.RaisePropertyChanged("plugin");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("methods", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.ServiceMethod[] methods {
            get {
                return this.methodsField;
            }
            set {
                this.methodsField = value;
                this.RaisePropertyChanged("methods");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ServiceMethod : object, System.ComponentModel.INotifyPropertyChanged {

        private string nameField;
        private bool restfulField;
        private bool asyncField;
        private string fetcherMethodNameField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool restful {
            get {
                return this.restfulField;
            }
            set {
                this.restfulField = value;
                this.RaisePropertyChanged("restful");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool async {
            get {
                return this.asyncField;
            }
            set {
                this.asyncField = value;
                this.RaisePropertyChanged("async");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fetcherMethodName {
            get {
                return this.fetcherMethodNameField;
            }
            set {
                this.fetcherMethodNameField = value;
                this.RaisePropertyChanged("fetcherMethodName");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class ShutdownServerRequest : com.ptvgroup.xserver.service.RequestBase {

        private bool restartField;
        private bool restartFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool restart {
            get {
                return this.restartField;
            }
            set {
                this.restartField = value;
                this.RaisePropertyChanged("restart");
                this.restartFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restartSpecified {
            get {
                return this.restartFieldSpecified;
            }
            set {
                this.restartFieldSpecified = value;
                this.RaisePropertyChanged("restartSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class StopDeleteRequest : com.ptvgroup.xserver.service.RequestBase {

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class Subdivision : object, System.ComponentModel.INotifyPropertyChanged {

        private string codeField;
        private com.ptvgroup.xserver.xruntime.RegionDescription descriptionField;
        private com.ptvgroup.xserver.xruntime.RegionFeatures featuresField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("description", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.RegionDescription description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("features", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xruntime.RegionFeatures features {
            get {
                return this.featuresField;
            }
            set {
                this.featuresField = value;
                this.RaisePropertyChanged("features");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class SupportPackageRequest : com.ptvgroup.xserver.service.RequestBase {

        private string requestField;
        private string responseField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string request {
            get {
                return this.requestField;
            }
            set {
                this.requestField = value;
                this.RaisePropertyChanged("request");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
                this.RaisePropertyChanged("response");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class SupportPackageResponse : com.ptvgroup.xserver.service.ResponseBase {

        private string urlField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
                this.RaisePropertyChanged("url");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class TollFeatures : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xruntime.TollDetailLevel detailLevelField;
        private bool detailLevelFieldSpecified;
        private string[] electronicTollCollectionSubscriptionsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xruntime.TollDetailLevel detailLevel {
            get {
                return this.detailLevelField;
            }
            set {
                this.detailLevelField = value;
                this.RaisePropertyChanged("detailLevel");
                this.detailLevelFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool detailLevelSpecified {
            get {
                return this.detailLevelFieldSpecified;
            }
            set {
                this.detailLevelFieldSpecified = value;
                this.RaisePropertyChanged("detailLevelSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("electronicTollCollectionSubscriptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] electronicTollCollectionSubscriptions {
            get {
                return this.electronicTollCollectionSubscriptionsField;
            }
            set {
                this.electronicTollCollectionSubscriptionsField = value;
                this.RaisePropertyChanged("electronicTollCollectionSubscriptions");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public partial class VersionInformation : object, System.ComponentModel.INotifyPropertyChanged {

        private string releaseVersionField;
        private string buildNumberField;
        private string apiVersionField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string releaseVersion {
            get {
                return this.releaseVersionField;
            }
            set {
                this.releaseVersionField = value;
                this.RaisePropertyChanged("releaseVersion");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string buildNumber {
            get {
                return this.buildNumberField;
            }
            set {
                this.buildNumberField = value;
                this.RaisePropertyChanged("buildNumber");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string apiVersion {
            get {
                return this.apiVersionField;
            }
            set {
                this.apiVersionField = value;
                this.RaisePropertyChanged("apiVersion");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public enum ContentUpdateTriggerStatus {
        /**
         * Specified type of content updates are not configured.
* They cannot be triggered without changing the xServer configuration.
         */
        DISABLED,

        /**
         * Specified type of content updates are enabled and can be triggered.
         */
        NEVER_TRIGGERED,

        /**
         * Specified type of content updates are enabled and an update is in progress.
         */
        RUNNING,

        /**
         * Specified type of content updates are enabled but failed during last update.
         */
        FAILED,

        /**
         * Specified type of content updates are enabled and the last update was successful.
         */
        SUCCESSFUL
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public enum MapDetailLevel {
        /**
         * Full map coverage and functionality according to PTVs current state of technology and coverage status by the data supplier.
         */
        DETAILED,

        /**
         * Thinned out street network (less important streets are omitted), full town coverage and search functionality, street and house number search are not possible.
         */
        EXTRACTED,

        /**
         * Only major road network, reduced town coverage, street and house number search are not possible, town search is only possible for included towns.
         */
        TRANSIT,

        /**
         * The map is composed of countries at different detail levels. Only used for the complete map, not for a country or a subdivision.
         */
        MIXED,

        /**
         * The detail level is unknown. This is probably the case when the map version is newer than the xServer version and contains unsupported data.
         */
        UNSPECIFIED
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xruntime.xserver.ptvgroup.com")]
    public enum TollDetailLevel {
        /**
         * Only basic <a href="xroute.html#com.ptvgroup.xserver.xroute.TollSummary">toll summaries</a> for a route and its legs are supported,
* as well as the <a href="routingprofile.html#com.ptvgroup.xserver.routingprofile.Toll.tollPenalty">Toll.tollPenalty</a> to avoid or prefer toll roads.
* Not supported is the <a href="xroute.html#com.ptvgroup.xserver.xroute.Toll">detailed toll information</a> for a route including toll
* costs and toll systems, and the toll events.
* Rendering of toll roads is also not supported.
         */
        BASIC,

        /**
         * <a href="xroute.html#com.ptvgroup.xserver.xroute.Toll">Detailed toll information</a> is supported: besides the toll summaries also detailed
* information about the toll costs, toll systems, and toll events along the route are supported.
* The <a href="routingprofile.html#com.ptvgroup.xserver.routingprofile.Toll.tollPenalty">Toll.tollPenalty</a> to avoid or prefer toll roads supports vehicle dependency.
* Rendering of toll roads is supported as well.
         */
        DETAILED,

        /**
         * The map is composed of countries at different detail levels. Only used for the complete map, not for a country or a subdivision.
         */
        MIXED,

        /**
         * The detail level is unknown. This is probably the case when the map version is newer than the xServer version and contains unsupported data.
         */
        UNSPECIFIED
    }


}
