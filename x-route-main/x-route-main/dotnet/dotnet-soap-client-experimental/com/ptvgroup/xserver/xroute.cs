// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.xroute 
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public interface XRoute {


            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.calculateRouteResponse calculateRoute(com.ptvgroup.xserver.xroute.calculateRoute request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.startCalculateRouteResponse startCalculateRoute(com.ptvgroup.xserver.xroute.startCalculateRoute request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.calculateReachableAreasResponse calculateReachableAreas(com.ptvgroup.xserver.xroute.calculateReachableAreas request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.startCalculateReachableAreasResponse startCalculateReachableAreas(com.ptvgroup.xserver.xroute.startCalculateReachableAreas request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.calculateReachableLocationsResponse calculateReachableLocations(com.ptvgroup.xserver.xroute.calculateReachableLocations request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.startCalculateReachableLocationsResponse startCalculateReachableLocations(com.ptvgroup.xserver.xroute.startCalculateReachableLocations request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.getProfileResponse getProfile(com.ptvgroup.xserver.xroute.getProfile request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.fetchReachableAreasResponseResponse fetchReachableAreasResponse(com.ptvgroup.xserver.xroute.fetchReachableAreasResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.fetchReachableLocationsResponseResponse fetchReachableLocationsResponse(com.ptvgroup.xserver.xroute.fetchReachableLocationsResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.fetchRouteResponseResponse fetchRouteResponse(com.ptvgroup.xserver.xroute.fetchRouteResponse request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.watchJobResponse watchJob(com.ptvgroup.xserver.xroute.watchJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.stopJobResponse stopJob(com.ptvgroup.xserver.xroute.stopJob request);

            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xroute.deleteJobResponse deleteJob(com.ptvgroup.xserver.xroute.deleteJob request);
    }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="calculateRoute", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class calculateRoute {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.RouteRequest request;

                public calculateRoute() {
                }

                public calculateRoute(com.ptvgroup.xserver.xroute.RouteRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="calculateRouteResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class calculateRouteResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.RouteResponse @return;

                public calculateRouteResponse() {
                }

                public calculateRouteResponse(com.ptvgroup.xserver.xroute.RouteResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCalculateRoute", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCalculateRoute {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.RouteRequest request;

                public startCalculateRoute() {
                }

                public startCalculateRoute(com.ptvgroup.xserver.xroute.RouteRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCalculateRouteResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCalculateRouteResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startCalculateRouteResponse() {
                }

                public startCalculateRouteResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="calculateReachableAreas", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class calculateReachableAreas {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.ReachableAreasRequest request;

                public calculateReachableAreas() {
                }

                public calculateReachableAreas(com.ptvgroup.xserver.xroute.ReachableAreasRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="calculateReachableAreasResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class calculateReachableAreasResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.ReachableAreasResponse @return;

                public calculateReachableAreasResponse() {
                }

                public calculateReachableAreasResponse(com.ptvgroup.xserver.xroute.ReachableAreasResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCalculateReachableAreas", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCalculateReachableAreas {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.ReachableAreasRequest request;

                public startCalculateReachableAreas() {
                }

                public startCalculateReachableAreas(com.ptvgroup.xserver.xroute.ReachableAreasRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCalculateReachableAreasResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCalculateReachableAreasResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startCalculateReachableAreasResponse() {
                }

                public startCalculateReachableAreasResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="calculateReachableLocations", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class calculateReachableLocations {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.ReachableLocationsRequest request;

                public calculateReachableLocations() {
                }

                public calculateReachableLocations(com.ptvgroup.xserver.xroute.ReachableLocationsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="calculateReachableLocationsResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class calculateReachableLocationsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.ReachableLocationsResponse @return;

                public calculateReachableLocationsResponse() {
                }

                public calculateReachableLocationsResponse(com.ptvgroup.xserver.xroute.ReachableLocationsResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCalculateReachableLocations", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCalculateReachableLocations {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.ReachableLocationsRequest request;

                public startCalculateReachableLocations() {
                }

                public startCalculateReachableLocations(com.ptvgroup.xserver.xroute.ReachableLocationsRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="startCalculateReachableLocationsResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class startCalculateReachableLocationsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public startCalculateReachableLocationsResponse() {
                }

                public startCalculateReachableLocationsResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getProfile", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getProfile {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.ProfileRequest request;

                public getProfile() {
                }

                public getProfile(com.ptvgroup.xserver.xroute.ProfileRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="getProfileResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class getProfileResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.ProfileResponse @return;

                public getProfileResponse() {
                }

                public getProfileResponse(com.ptvgroup.xserver.xroute.ProfileResponse @return) {
                    this.@return = @return;
                }
            }


            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchReachableAreasResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchReachableAreasResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchReachableAreasResponse() {
                }

                public fetchReachableAreasResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchReachableAreasResponseResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchReachableAreasResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.ReachableAreasResponse @return;

                public fetchReachableAreasResponseResponse() {
                }

                public fetchReachableAreasResponseResponse(com.ptvgroup.xserver.xroute.ReachableAreasResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchReachableLocationsResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchReachableLocationsResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchReachableLocationsResponse() {
                }

                public fetchReachableLocationsResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchReachableLocationsResponseResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchReachableLocationsResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.ReachableLocationsResponse @return;

                public fetchReachableLocationsResponseResponse() {
                }

                public fetchReachableLocationsResponseResponse(com.ptvgroup.xserver.xroute.ReachableLocationsResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchRouteResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchRouteResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.JobRequest request;

                public fetchRouteResponse() {
                }

                public fetchRouteResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="fetchRouteResponseResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class fetchRouteResponseResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xroute.RouteResponse @return;

                public fetchRouteResponseResponse() {
                }

                public fetchRouteResponseResponse(com.ptvgroup.xserver.xroute.RouteResponse @return) {
                    this.@return = @return;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJob", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="watchJobResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class watchJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJob", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="stopJobResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class stopJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJob", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJob {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
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
            [System.ServiceModel.MessageContractAttribute(WrapperName="deleteJobResponse", WrapperNamespace="http://xroute.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class deleteJobResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xroute.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.jobs.Job @return;

                public deleteJobResponse() {
                }

                public deleteJobResponse(com.ptvgroup.xserver.jobs.Job @return) {
                    this.@return = @return;
                }
            }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XRouteChannel : com.ptvgroup.xserver.xroute.XRoute, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XRouteClient : System.ServiceModel.ClientBase<com.ptvgroup.xserver.xroute.XRoute>, com.ptvgroup.xserver.xroute.XRoute {

        public XRouteClient() :
            this("http://localhost:50000/services/ws/XRoute/experimental") {
        }

        public XRouteClient(string baseUri ) :
            this(new System.ServiceModel.BasicHttpBinding { MaxReceivedMessageSize = System.Int32.MaxValue }, new System.ServiceModel.EndpointAddress(baseUri+"/services/ws/XRoute/experimental/")) {
        }

        public XRouteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress) {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xroute.calculateRouteResponse com.ptvgroup.xserver.xroute.XRoute.calculateRoute(com.ptvgroup.xserver.xroute.calculateRoute request) {
            return base.Channel.calculateRoute(request);
        }

        public com.ptvgroup.xserver.xroute.RouteResponse calculateRoute(com.ptvgroup.xserver.xroute.RouteRequest request) {
            com.ptvgroup.xserver.xroute.calculateRoute inValue = new com.ptvgroup.xserver.xroute.calculateRoute();
            inValue.request = request;
            com.ptvgroup.xserver.xroute.calculateRouteResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).calculateRoute(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xroute.startCalculateRouteResponse com.ptvgroup.xserver.xroute.XRoute.startCalculateRoute(com.ptvgroup.xserver.xroute.startCalculateRoute request) {
                return base.Channel.startCalculateRoute(request);
            }

            public com.ptvgroup.xserver.jobs.Job startCalculateRoute(com.ptvgroup.xserver.xroute.RouteRequest request) {
                com.ptvgroup.xserver.xroute.startCalculateRoute inValue = new com.ptvgroup.xserver.xroute.startCalculateRoute();
                inValue.request = request;
                com.ptvgroup.xserver.xroute.startCalculateRouteResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).startCalculateRoute(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xroute.calculateReachableAreasResponse com.ptvgroup.xserver.xroute.XRoute.calculateReachableAreas(com.ptvgroup.xserver.xroute.calculateReachableAreas request) {
            return base.Channel.calculateReachableAreas(request);
        }

        public com.ptvgroup.xserver.xroute.ReachableAreasResponse calculateReachableAreas(com.ptvgroup.xserver.xroute.ReachableAreasRequest request) {
            com.ptvgroup.xserver.xroute.calculateReachableAreas inValue = new com.ptvgroup.xserver.xroute.calculateReachableAreas();
            inValue.request = request;
            com.ptvgroup.xserver.xroute.calculateReachableAreasResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).calculateReachableAreas(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xroute.startCalculateReachableAreasResponse com.ptvgroup.xserver.xroute.XRoute.startCalculateReachableAreas(com.ptvgroup.xserver.xroute.startCalculateReachableAreas request) {
                return base.Channel.startCalculateReachableAreas(request);
            }

            public com.ptvgroup.xserver.jobs.Job startCalculateReachableAreas(com.ptvgroup.xserver.xroute.ReachableAreasRequest request) {
                com.ptvgroup.xserver.xroute.startCalculateReachableAreas inValue = new com.ptvgroup.xserver.xroute.startCalculateReachableAreas();
                inValue.request = request;
                com.ptvgroup.xserver.xroute.startCalculateReachableAreasResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).startCalculateReachableAreas(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xroute.calculateReachableLocationsResponse com.ptvgroup.xserver.xroute.XRoute.calculateReachableLocations(com.ptvgroup.xserver.xroute.calculateReachableLocations request) {
            return base.Channel.calculateReachableLocations(request);
        }

        public com.ptvgroup.xserver.xroute.ReachableLocationsResponse calculateReachableLocations(com.ptvgroup.xserver.xroute.ReachableLocationsRequest request) {
            com.ptvgroup.xserver.xroute.calculateReachableLocations inValue = new com.ptvgroup.xserver.xroute.calculateReachableLocations();
            inValue.request = request;
            com.ptvgroup.xserver.xroute.calculateReachableLocationsResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).calculateReachableLocations(inValue);
            return retVal.@return;
        }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xroute.startCalculateReachableLocationsResponse com.ptvgroup.xserver.xroute.XRoute.startCalculateReachableLocations(com.ptvgroup.xserver.xroute.startCalculateReachableLocations request) {
                return base.Channel.startCalculateReachableLocations(request);
            }

            public com.ptvgroup.xserver.jobs.Job startCalculateReachableLocations(com.ptvgroup.xserver.xroute.ReachableLocationsRequest request) {
                com.ptvgroup.xserver.xroute.startCalculateReachableLocations inValue = new com.ptvgroup.xserver.xroute.startCalculateReachableLocations();
                inValue.request = request;
                com.ptvgroup.xserver.xroute.startCalculateReachableLocationsResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).startCalculateReachableLocations(inValue);
                return retVal.@return;
            }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xroute.getProfileResponse com.ptvgroup.xserver.xroute.XRoute.getProfile(com.ptvgroup.xserver.xroute.getProfile request) {
            return base.Channel.getProfile(request);
        }

        public com.ptvgroup.xserver.xroute.ProfileResponse getProfile(com.ptvgroup.xserver.xroute.ProfileRequest request) {
            com.ptvgroup.xserver.xroute.getProfile inValue = new com.ptvgroup.xserver.xroute.getProfile();
            inValue.request = request;
            com.ptvgroup.xserver.xroute.getProfileResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).getProfile(inValue);
            return retVal.@return;
        }


            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xroute.fetchReachableAreasResponseResponse com.ptvgroup.xserver.xroute.XRoute.fetchReachableAreasResponse(com.ptvgroup.xserver.xroute.fetchReachableAreasResponse request) {
                return base.Channel.fetchReachableAreasResponse(request);
            }

            public com.ptvgroup.xserver.xroute.ReachableAreasResponse fetchReachableAreasResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xroute.fetchReachableAreasResponse inValue = new com.ptvgroup.xserver.xroute.fetchReachableAreasResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xroute.fetchReachableAreasResponseResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).fetchReachableAreasResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xroute.fetchReachableLocationsResponseResponse com.ptvgroup.xserver.xroute.XRoute.fetchReachableLocationsResponse(com.ptvgroup.xserver.xroute.fetchReachableLocationsResponse request) {
                return base.Channel.fetchReachableLocationsResponse(request);
            }

            public com.ptvgroup.xserver.xroute.ReachableLocationsResponse fetchReachableLocationsResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xroute.fetchReachableLocationsResponse inValue = new com.ptvgroup.xserver.xroute.fetchReachableLocationsResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xroute.fetchReachableLocationsResponseResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).fetchReachableLocationsResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xroute.fetchRouteResponseResponse com.ptvgroup.xserver.xroute.XRoute.fetchRouteResponse(com.ptvgroup.xserver.xroute.fetchRouteResponse request) {
                return base.Channel.fetchRouteResponse(request);
            }

            public com.ptvgroup.xserver.xroute.RouteResponse fetchRouteResponse(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xroute.fetchRouteResponse inValue = new com.ptvgroup.xserver.xroute.fetchRouteResponse();
                inValue.request = request;
                com.ptvgroup.xserver.xroute.fetchRouteResponseResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).fetchRouteResponse(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xroute.watchJobResponse com.ptvgroup.xserver.xroute.XRoute.watchJob(com.ptvgroup.xserver.xroute.watchJob request) {
                return base.Channel.watchJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job watchJob(com.ptvgroup.xserver.jobs.WatchRequest request) {
                com.ptvgroup.xserver.xroute.watchJob inValue = new com.ptvgroup.xserver.xroute.watchJob();
                inValue.request = request;
                com.ptvgroup.xserver.xroute.watchJobResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).watchJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xroute.stopJobResponse com.ptvgroup.xserver.xroute.XRoute.stopJob(com.ptvgroup.xserver.xroute.stopJob request) {
                return base.Channel.stopJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job stopJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xroute.stopJob inValue = new com.ptvgroup.xserver.xroute.stopJob();
                inValue.request = request;
                com.ptvgroup.xserver.xroute.stopJobResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).stopJob(inValue);
                return retVal.@return;
            }

            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            com.ptvgroup.xserver.xroute.deleteJobResponse com.ptvgroup.xserver.xroute.XRoute.deleteJob(com.ptvgroup.xserver.xroute.deleteJob request) {
                return base.Channel.deleteJob(request);
            }

            public com.ptvgroup.xserver.jobs.Job deleteJob(com.ptvgroup.xserver.jobs.JobRequest request) {
                com.ptvgroup.xserver.xroute.deleteJob inValue = new com.ptvgroup.xserver.xroute.deleteJob();
                inValue.request = request;
                com.ptvgroup.xserver.xroute.deleteJobResponse retVal = ((com.ptvgroup.xserver.xroute.XRoute)(this)).deleteJob(inValue);
                return retVal.@return;
            }

   }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class AlternativeRoute : object, System.ComponentModel.INotifyPropertyChanged {

        private double distanceField;
        private double travelTimeField;
        private bool violatedField;
        private string encodedPathField;
        private com.ptvgroup.xserver.geometry.EncodedGeometry polylineField;
        private string[] providerIdsField;

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
        public bool violated {
            get {
                return this.violatedField;
            }
            set {
                this.violatedField = value;
                this.RaisePropertyChanged("violated");
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

                    [System.Xml.Serialization.XmlElementAttribute("providerIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] providerIds {
            get {
                return this.providerIdsField;
            }
            set {
                this.providerIdsField = value;
                this.RaisePropertyChanged("providerIds");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class CombinedTransportEvent : com.ptvgroup.xserver.xroute.RouteEvent {

        private string combinedTransportIdField;
        private string combinedTransportNameField;
        private com.ptvgroup.xserver.segments.CombinedTransportType combinedTransportTypeField;
        private bool combinedTransportTypeFieldSpecified;
        private com.ptvgroup.xserver.xroute.AccessType accessTypeField;
        private bool accessTypeFieldSpecified;
        private int relatedEventIndexField;
        private bool relatedEventIndexFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string combinedTransportId {
            get {
                return this.combinedTransportIdField;
            }
            set {
                this.combinedTransportIdField = value;
                this.RaisePropertyChanged("combinedTransportId");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string combinedTransportName {
            get {
                return this.combinedTransportNameField;
            }
            set {
                this.combinedTransportNameField = value;
                this.RaisePropertyChanged("combinedTransportName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.segments.CombinedTransportType combinedTransportType {
            get {
                return this.combinedTransportTypeField;
            }
            set {
                this.combinedTransportTypeField = value;
                this.RaisePropertyChanged("combinedTransportType");
                this.combinedTransportTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool combinedTransportTypeSpecified {
            get {
                return this.combinedTransportTypeFieldSpecified;
            }
            set {
                this.combinedTransportTypeFieldSpecified = value;
                this.RaisePropertyChanged("combinedTransportTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xroute.AccessType accessType {
            get {
                return this.accessTypeField;
            }
            set {
                this.accessTypeField = value;
                this.RaisePropertyChanged("accessType");
                this.accessTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accessTypeSpecified {
            get {
                return this.accessTypeFieldSpecified;
            }
            set {
                this.accessTypeFieldSpecified = value;
                this.RaisePropertyChanged("accessTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int relatedEventIndex {
            get {
                return this.relatedEventIndexField;
            }
            set {
                this.relatedEventIndexField = value;
                this.RaisePropertyChanged("relatedEventIndex");
                this.relatedEventIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relatedEventIndexSpecified {
            get {
                return this.relatedEventIndexFieldSpecified;
            }
            set {
                this.relatedEventIndexFieldSpecified = value;
                this.RaisePropertyChanged("relatedEventIndexSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class CombinedTransportViaWaypoint : com.ptvgroup.xserver.xroute.InputWaypoint {

        private string combinedTransportIdField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string combinedTransportId {
            get {
                return this.combinedTransportIdField;
            }
            set {
                this.combinedTransportIdField = value;
                this.RaisePropertyChanged("combinedTransportId");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class CountryCost : object, System.ComponentModel.INotifyPropertyChanged {

        private string countryField;
        private com.ptvgroup.xserver.types.Cost costField;
        private com.ptvgroup.xserver.types.Cost convertedCostField;

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

                    [System.Xml.Serialization.XmlElementAttribute("cost", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.Cost cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
                this.RaisePropertyChanged("cost");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("convertedCost", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.Cost convertedCost {
            get {
                return this.convertedCostField;
            }
            set {
                this.convertedCostField = value;
                this.RaisePropertyChanged("convertedCost");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class CountryEvent : com.ptvgroup.xserver.xroute.RouteEvent {

        private string countryField;

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ETACalculationOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xroute.VehiclePosition vehiclePositionField;

                    [System.Xml.Serialization.XmlElementAttribute("vehiclePosition", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.VehiclePosition vehiclePosition {
            get {
                return this.vehiclePositionField;
            }
            set {
                this.vehiclePositionField = value;
                this.RaisePropertyChanged("vehiclePosition");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ETACalculationReport : object, System.ComponentModel.INotifyPropertyChanged {

        private bool newRouteField;
        private bool newRouteFieldSpecified;
        private bool travelTimeExceededField;
        private bool travelTimeExceededFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool newRoute {
            get {
                return this.newRouteField;
            }
            set {
                this.newRouteField = value;
                this.RaisePropertyChanged("newRoute");
                this.newRouteFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newRouteSpecified {
            get {
                return this.newRouteFieldSpecified;
            }
            set {
                this.newRouteFieldSpecified = value;
                this.RaisePropertyChanged("newRouteSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool travelTimeExceeded {
            get {
                return this.travelTimeExceededField;
            }
            set {
                this.travelTimeExceededField = value;
                this.RaisePropertyChanged("travelTimeExceeded");
                this.travelTimeExceededFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool travelTimeExceededSpecified {
            get {
                return this.travelTimeExceededFieldSpecified;
            }
            set {
                this.travelTimeExceededFieldSpecified = value;
                this.RaisePropertyChanged("travelTimeExceededSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class EffectiveFuelConsumption : object, System.ComponentModel.INotifyPropertyChanged {

        private double fleetSpecificAverageFuelConsumptionField;
        private bool fleetSpecificAverageFuelConsumptionFieldSpecified;
        private double routeSpecificAverageFuelConsumptionField;
        private bool routeSpecificAverageFuelConsumptionFieldSpecified;
        private double actualFuelConsumptionForThisRouteField;
        private bool actualFuelConsumptionForThisRouteFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double fleetSpecificAverageFuelConsumption {
            get {
                return this.fleetSpecificAverageFuelConsumptionField;
            }
            set {
                this.fleetSpecificAverageFuelConsumptionField = value;
                this.RaisePropertyChanged("fleetSpecificAverageFuelConsumption");
                this.fleetSpecificAverageFuelConsumptionFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fleetSpecificAverageFuelConsumptionSpecified {
            get {
                return this.fleetSpecificAverageFuelConsumptionFieldSpecified;
            }
            set {
                this.fleetSpecificAverageFuelConsumptionFieldSpecified = value;
                this.RaisePropertyChanged("fleetSpecificAverageFuelConsumptionSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double routeSpecificAverageFuelConsumption {
            get {
                return this.routeSpecificAverageFuelConsumptionField;
            }
            set {
                this.routeSpecificAverageFuelConsumptionField = value;
                this.RaisePropertyChanged("routeSpecificAverageFuelConsumption");
                this.routeSpecificAverageFuelConsumptionFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool routeSpecificAverageFuelConsumptionSpecified {
            get {
                return this.routeSpecificAverageFuelConsumptionFieldSpecified;
            }
            set {
                this.routeSpecificAverageFuelConsumptionFieldSpecified = value;
                this.RaisePropertyChanged("routeSpecificAverageFuelConsumptionSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double actualFuelConsumptionForThisRoute {
            get {
                return this.actualFuelConsumptionForThisRouteField;
            }
            set {
                this.actualFuelConsumptionForThisRouteField = value;
                this.RaisePropertyChanged("actualFuelConsumptionForThisRoute");
                this.actualFuelConsumptionForThisRouteFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actualFuelConsumptionForThisRouteSpecified {
            get {
                return this.actualFuelConsumptionForThisRouteFieldSpecified;
            }
            set {
                this.actualFuelConsumptionForThisRouteFieldSpecified = value;
                this.RaisePropertyChanged("actualFuelConsumptionForThisRouteSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ElevationsNotAvailableLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private com.ptvgroup.xserver.types.IndexInterval[] routePolylineIndicesField;
        private com.ptvgroup.xserver.types.IndexPairInterval[] segmentPolylineIndicesField;
        private com.ptvgroup.xserver.types.IndexPairInterval[] legPolylineIndicesField;
        private bool elevationsDataAvailableField;

                    [System.Xml.Serialization.XmlElementAttribute("routePolylineIndices", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.IndexInterval[] routePolylineIndices {
            get {
                return this.routePolylineIndicesField;
            }
            set {
                this.routePolylineIndicesField = value;
                this.RaisePropertyChanged("routePolylineIndices");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("segmentPolylineIndices", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.IndexPairInterval[] segmentPolylineIndices {
            get {
                return this.segmentPolylineIndicesField;
            }
            set {
                this.segmentPolylineIndicesField = value;
                this.RaisePropertyChanged("segmentPolylineIndices");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("legPolylineIndices", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.IndexPairInterval[] legPolylineIndices {
            get {
                return this.legPolylineIndicesField;
            }
            set {
                this.legPolylineIndicesField = value;
                this.RaisePropertyChanged("legPolylineIndices");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool elevationsDataAvailable {
            get {
                return this.elevationsDataAvailableField;
            }
            set {
                this.elevationsDataAvailableField = value;
                this.RaisePropertyChanged("elevationsDataAvailable");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class EmissionOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.emissions.EmissionValueScenario[] valueScenariosField;

                    [System.Xml.Serialization.XmlElementAttribute("valueScenarios", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.EmissionValueScenario[] valueScenarios {
            get {
                return this.valueScenariosField;
            }
            set {
                this.valueScenariosField = value;
                this.RaisePropertyChanged("valueScenarios");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class HeadingIgnoredLimitation : com.ptvgroup.xserver.service.ResultLimitation {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class HeadingToleranceIgnoredLimitation : com.ptvgroup.xserver.service.ResultLimitation {



    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.CombinedTransportViaWaypoint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.ManipulateRouteWaypoint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.MultiCoordinateOnRoadWaypoint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.OffRoadWaypoint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.OnRoadWaypoint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.PathWaypoint))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public abstract partial class InputWaypoint : object, System.ComponentModel.INotifyPropertyChanged {

        private string nameField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class Leg : object, System.ComponentModel.INotifyPropertyChanged {

        private string startWaypointNameField;
        private string endWaypointNameField;
        private int startSegmentIndexField;
        private bool startSegmentIndexFieldSpecified;
        private int endSegmentIndexField;
        private bool endSegmentIndexFieldSpecified;
        private int startNodeIndexField;
        private bool startNodeIndexFieldSpecified;
        private int endNodeIndexField;
        private bool endNodeIndexFieldSpecified;
        private int startTollSectionIndexField;
        private bool startTollSectionIndexFieldSpecified;
        private int endTollSectionIndexField;
        private bool endTollSectionIndexFieldSpecified;
        private double distanceField;
        private double travelTimeField;
        private com.ptvgroup.xserver.xroute.TollSummary tollSummaryField;
        private com.ptvgroup.xserver.emissions.Emissions emissionsField;
        private com.ptvgroup.xserver.geometry.EncodedGeometry polylineField;
        private string[] providerIdsField;
        private bool violatedField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string startWaypointName {
            get {
                return this.startWaypointNameField;
            }
            set {
                this.startWaypointNameField = value;
                this.RaisePropertyChanged("startWaypointName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string endWaypointName {
            get {
                return this.endWaypointNameField;
            }
            set {
                this.endWaypointNameField = value;
                this.RaisePropertyChanged("endWaypointName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int startSegmentIndex {
            get {
                return this.startSegmentIndexField;
            }
            set {
                this.startSegmentIndexField = value;
                this.RaisePropertyChanged("startSegmentIndex");
                this.startSegmentIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startSegmentIndexSpecified {
            get {
                return this.startSegmentIndexFieldSpecified;
            }
            set {
                this.startSegmentIndexFieldSpecified = value;
                this.RaisePropertyChanged("startSegmentIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int endSegmentIndex {
            get {
                return this.endSegmentIndexField;
            }
            set {
                this.endSegmentIndexField = value;
                this.RaisePropertyChanged("endSegmentIndex");
                this.endSegmentIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endSegmentIndexSpecified {
            get {
                return this.endSegmentIndexFieldSpecified;
            }
            set {
                this.endSegmentIndexFieldSpecified = value;
                this.RaisePropertyChanged("endSegmentIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int startNodeIndex {
            get {
                return this.startNodeIndexField;
            }
            set {
                this.startNodeIndexField = value;
                this.RaisePropertyChanged("startNodeIndex");
                this.startNodeIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startNodeIndexSpecified {
            get {
                return this.startNodeIndexFieldSpecified;
            }
            set {
                this.startNodeIndexFieldSpecified = value;
                this.RaisePropertyChanged("startNodeIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int endNodeIndex {
            get {
                return this.endNodeIndexField;
            }
            set {
                this.endNodeIndexField = value;
                this.RaisePropertyChanged("endNodeIndex");
                this.endNodeIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endNodeIndexSpecified {
            get {
                return this.endNodeIndexFieldSpecified;
            }
            set {
                this.endNodeIndexFieldSpecified = value;
                this.RaisePropertyChanged("endNodeIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int startTollSectionIndex {
            get {
                return this.startTollSectionIndexField;
            }
            set {
                this.startTollSectionIndexField = value;
                this.RaisePropertyChanged("startTollSectionIndex");
                this.startTollSectionIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startTollSectionIndexSpecified {
            get {
                return this.startTollSectionIndexFieldSpecified;
            }
            set {
                this.startTollSectionIndexFieldSpecified = value;
                this.RaisePropertyChanged("startTollSectionIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int endTollSectionIndex {
            get {
                return this.endTollSectionIndexField;
            }
            set {
                this.endTollSectionIndexField = value;
                this.RaisePropertyChanged("endTollSectionIndex");
                this.endTollSectionIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endTollSectionIndexSpecified {
            get {
                return this.endTollSectionIndexFieldSpecified;
            }
            set {
                this.endTollSectionIndexFieldSpecified = value;
                this.RaisePropertyChanged("endTollSectionIndexSpecified");
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

                    [System.Xml.Serialization.XmlElementAttribute("tollSummary", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TollSummary tollSummary {
            get {
                return this.tollSummaryField;
            }
            set {
                this.tollSummaryField = value;
                this.RaisePropertyChanged("tollSummary");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("emissions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.Emissions emissions {
            get {
                return this.emissionsField;
            }
            set {
                this.emissionsField = value;
                this.RaisePropertyChanged("emissions");
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

                    [System.Xml.Serialization.XmlElementAttribute("providerIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] providerIds {
            get {
                return this.providerIdsField;
            }
            set {
                this.providerIdsField = value;
                this.RaisePropertyChanged("providerIds");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class LegResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool enabledField;
        private bool enabledFieldSpecified;
        private bool polylineField;
        private bool polylineFieldSpecified;
        private bool tollSummaryField;
        private bool tollSummaryFieldSpecified;
        private bool emissionsField;
        private bool emissionsFieldSpecified;
        private bool providerIdsField;
        private bool providerIdsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
                this.RaisePropertyChanged("enabled");
                this.enabledFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enabledSpecified {
            get {
                return this.enabledFieldSpecified;
            }
            set {
                this.enabledFieldSpecified = value;
                this.RaisePropertyChanged("enabledSpecified");
            }
        }
        
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
        public bool tollSummary {
            get {
                return this.tollSummaryField;
            }
            set {
                this.tollSummaryField = value;
                this.RaisePropertyChanged("tollSummary");
                this.tollSummaryFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tollSummarySpecified {
            get {
                return this.tollSummaryFieldSpecified;
            }
            set {
                this.tollSummaryFieldSpecified = value;
                this.RaisePropertyChanged("tollSummarySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool emissions {
            get {
                return this.emissionsField;
            }
            set {
                this.emissionsField = value;
                this.RaisePropertyChanged("emissions");
                this.emissionsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emissionsSpecified {
            get {
                return this.emissionsFieldSpecified;
            }
            set {
                this.emissionsFieldSpecified = value;
                this.RaisePropertyChanged("emissionsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool providerIds {
            get {
                return this.providerIdsField;
            }
            set {
                this.providerIdsField = value;
                this.RaisePropertyChanged("providerIds");
                this.providerIdsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool providerIdsSpecified {
            get {
                return this.providerIdsFieldSpecified;
            }
            set {
                this.providerIdsFieldSpecified = value;
                this.RaisePropertyChanged("providerIdsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ManeuverEvent : com.ptvgroup.xserver.xroute.RouteEvent {

        private com.ptvgroup.xserver.xroute.ManeuverType maneuverTypeField;
        private bool maneuverTypeFieldSpecified;
        private int relativeDirectionField;
        private bool relativeDirectionFieldSpecified;
        private int absoluteDirectionField;
        private bool absoluteDirectionFieldSpecified;
        private string directionDescriptionField;
        private string directionDescriptionLanguageField;
        private com.ptvgroup.xserver.xroute.RoadDescriptor roadAheadField;
        private string directionSignTextField;
        private string exitNumberField;
        private string exitNameField;
        private int roundaboutExitField;
        private bool roundaboutExitFieldSpecified;
        private string combinedTransportNameField;
        private com.ptvgroup.xserver.segments.CombinedTransportType combinedTransportTypeField;
        private bool combinedTransportTypeFieldSpecified;
        private string crossingRoadNameField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xroute.ManeuverType maneuverType {
            get {
                return this.maneuverTypeField;
            }
            set {
                this.maneuverTypeField = value;
                this.RaisePropertyChanged("maneuverType");
                this.maneuverTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maneuverTypeSpecified {
            get {
                return this.maneuverTypeFieldSpecified;
            }
            set {
                this.maneuverTypeFieldSpecified = value;
                this.RaisePropertyChanged("maneuverTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int relativeDirection {
            get {
                return this.relativeDirectionField;
            }
            set {
                this.relativeDirectionField = value;
                this.RaisePropertyChanged("relativeDirection");
                this.relativeDirectionFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeDirectionSpecified {
            get {
                return this.relativeDirectionFieldSpecified;
            }
            set {
                this.relativeDirectionFieldSpecified = value;
                this.RaisePropertyChanged("relativeDirectionSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int absoluteDirection {
            get {
                return this.absoluteDirectionField;
            }
            set {
                this.absoluteDirectionField = value;
                this.RaisePropertyChanged("absoluteDirection");
                this.absoluteDirectionFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool absoluteDirectionSpecified {
            get {
                return this.absoluteDirectionFieldSpecified;
            }
            set {
                this.absoluteDirectionFieldSpecified = value;
                this.RaisePropertyChanged("absoluteDirectionSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string directionDescription {
            get {
                return this.directionDescriptionField;
            }
            set {
                this.directionDescriptionField = value;
                this.RaisePropertyChanged("directionDescription");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string directionDescriptionLanguage {
            get {
                return this.directionDescriptionLanguageField;
            }
            set {
                this.directionDescriptionLanguageField = value;
                this.RaisePropertyChanged("directionDescriptionLanguage");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("roadAhead", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.RoadDescriptor roadAhead {
            get {
                return this.roadAheadField;
            }
            set {
                this.roadAheadField = value;
                this.RaisePropertyChanged("roadAhead");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string directionSignText {
            get {
                return this.directionSignTextField;
            }
            set {
                this.directionSignTextField = value;
                this.RaisePropertyChanged("directionSignText");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exitNumber {
            get {
                return this.exitNumberField;
            }
            set {
                this.exitNumberField = value;
                this.RaisePropertyChanged("exitNumber");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exitName {
            get {
                return this.exitNameField;
            }
            set {
                this.exitNameField = value;
                this.RaisePropertyChanged("exitName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int roundaboutExit {
            get {
                return this.roundaboutExitField;
            }
            set {
                this.roundaboutExitField = value;
                this.RaisePropertyChanged("roundaboutExit");
                this.roundaboutExitFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool roundaboutExitSpecified {
            get {
                return this.roundaboutExitFieldSpecified;
            }
            set {
                this.roundaboutExitFieldSpecified = value;
                this.RaisePropertyChanged("roundaboutExitSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string combinedTransportName {
            get {
                return this.combinedTransportNameField;
            }
            set {
                this.combinedTransportNameField = value;
                this.RaisePropertyChanged("combinedTransportName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.segments.CombinedTransportType combinedTransportType {
            get {
                return this.combinedTransportTypeField;
            }
            set {
                this.combinedTransportTypeField = value;
                this.RaisePropertyChanged("combinedTransportType");
                this.combinedTransportTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool combinedTransportTypeSpecified {
            get {
                return this.combinedTransportTypeFieldSpecified;
            }
            set {
                this.combinedTransportTypeFieldSpecified = value;
                this.RaisePropertyChanged("combinedTransportTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string crossingRoadName {
            get {
                return this.crossingRoadNameField;
            }
            set {
                this.crossingRoadNameField = value;
                this.RaisePropertyChanged("crossingRoadName");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ManipulateRouteWaypoint : com.ptvgroup.xserver.xroute.InputWaypoint {

        private com.ptvgroup.xserver.geometry.Coordinate coordinateField;
        private double radiusField;

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
        public double radius {
            get {
                return this.radiusField;
            }
            set {
                this.radiusField = value;
                this.RaisePropertyChanged("radius");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class MonetaryCostsReport : object, System.ComponentModel.INotifyPropertyChanged {

        private double totalCostField;
        private bool totalCostFieldSpecified;
        private double distanceCostField;
        private bool distanceCostFieldSpecified;
        private double workingTimeCostField;
        private bool workingTimeCostFieldSpecified;
        private double energyCostField;
        private bool energyCostFieldSpecified;
        private double tollCostField;
        private bool tollCostFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double totalCost {
            get {
                return this.totalCostField;
            }
            set {
                this.totalCostField = value;
                this.RaisePropertyChanged("totalCost");
                this.totalCostFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCostSpecified {
            get {
                return this.totalCostFieldSpecified;
            }
            set {
                this.totalCostFieldSpecified = value;
                this.RaisePropertyChanged("totalCostSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double distanceCost {
            get {
                return this.distanceCostField;
            }
            set {
                this.distanceCostField = value;
                this.RaisePropertyChanged("distanceCost");
                this.distanceCostFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool distanceCostSpecified {
            get {
                return this.distanceCostFieldSpecified;
            }
            set {
                this.distanceCostFieldSpecified = value;
                this.RaisePropertyChanged("distanceCostSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double workingTimeCost {
            get {
                return this.workingTimeCostField;
            }
            set {
                this.workingTimeCostField = value;
                this.RaisePropertyChanged("workingTimeCost");
                this.workingTimeCostFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool workingTimeCostSpecified {
            get {
                return this.workingTimeCostFieldSpecified;
            }
            set {
                this.workingTimeCostFieldSpecified = value;
                this.RaisePropertyChanged("workingTimeCostSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double energyCost {
            get {
                return this.energyCostField;
            }
            set {
                this.energyCostField = value;
                this.RaisePropertyChanged("energyCost");
                this.energyCostFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool energyCostSpecified {
            get {
                return this.energyCostFieldSpecified;
            }
            set {
                this.energyCostFieldSpecified = value;
                this.RaisePropertyChanged("energyCostSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double tollCost {
            get {
                return this.tollCostField;
            }
            set {
                this.tollCostField = value;
                this.RaisePropertyChanged("tollCost");
                this.tollCostFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tollCostSpecified {
            get {
                return this.tollCostFieldSpecified;
            }
            set {
                this.tollCostFieldSpecified = value;
                this.RaisePropertyChanged("tollCostSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class MultiCoordinateOnRoadWaypoint : com.ptvgroup.xserver.xroute.InputWaypoint {

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class Node : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.geometry.Coordinate coordinateField;
        private com.ptvgroup.xserver.xroute.NodeType typeField;
        private int[] eventIndicesField;
        private int polylineIndexField;
        private bool polylineIndexFieldSpecified;
        private bool violatedField;
        private bool violatedFieldSpecified;

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
        public com.ptvgroup.xserver.xroute.NodeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("eventIndices", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int[] eventIndices {
            get {
                return this.eventIndicesField;
            }
            set {
                this.eventIndicesField = value;
                this.RaisePropertyChanged("eventIndices");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int polylineIndex {
            get {
                return this.polylineIndexField;
            }
            set {
                this.polylineIndexField = value;
                this.RaisePropertyChanged("polylineIndex");
                this.polylineIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool polylineIndexSpecified {
            get {
                return this.polylineIndexFieldSpecified;
            }
            set {
                this.polylineIndexFieldSpecified = value;
                this.RaisePropertyChanged("polylineIndexSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class OffRoadWaypoint : com.ptvgroup.xserver.xroute.InputWaypoint {

        private com.ptvgroup.xserver.routing.OffRoadRouteLocation locationField;
        private com.ptvgroup.xserver.xroute.TourStopOptions tourStopOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("location", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.OffRoadRouteLocation location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
                this.RaisePropertyChanged("location");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tourStopOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TourStopOptions tourStopOptions {
            get {
                return this.tourStopOptionsField;
            }
            set {
                this.tourStopOptionsField = value;
                this.RaisePropertyChanged("tourStopOptions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class OnRoadWaypoint : com.ptvgroup.xserver.xroute.InputWaypoint {

        private com.ptvgroup.xserver.routing.OnRoadRouteLocation locationField;
        private com.ptvgroup.xserver.xroute.TourStopOptions tourStopOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("location", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.OnRoadRouteLocation location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
                this.RaisePropertyChanged("location");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tourStopOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TourStopOptions tourStopOptions {
            get {
                return this.tourStopOptionsField;
            }
            set {
                this.tourStopOptionsField = value;
                this.RaisePropertyChanged("tourStopOptions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class PathWaypoint : com.ptvgroup.xserver.xroute.InputWaypoint {

        private string encodedPathField;

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class PolylineOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private bool elevationsField;
        private bool elevationsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool elevations {
            get {
                return this.elevationsField;
            }
            set {
                this.elevationsField = value;
                this.RaisePropertyChanged("elevations");
                this.elevationsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool elevationsSpecified {
            get {
                return this.elevationsFieldSpecified;
            }
            set {
                this.elevationsFieldSpecified = value;
                this.RaisePropertyChanged("elevationsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class PositionAtStop : com.ptvgroup.xserver.xroute.VehiclePosition {

        private int waypointIndexField;
        private com.ptvgroup.xserver.tourplanning.ServiceStatus serviceStatusField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int waypointIndex {
            get {
                return this.waypointIndexField;
            }
            set {
                this.waypointIndexField = value;
                this.RaisePropertyChanged("waypointIndex");
            }
        }

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class PositionEnRoute : com.ptvgroup.xserver.xroute.VehiclePosition {

        private com.ptvgroup.xserver.geometry.Coordinate currentLocationField;
        private int indexOfNextWaypointField;
        private int headingField;
        private bool headingFieldSpecified;
        private int headingToleranceField;
        private bool headingToleranceFieldSpecified;

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
        public int indexOfNextWaypoint {
            get {
                return this.indexOfNextWaypointField;
            }
            set {
                this.indexOfNextWaypointField = value;
                this.RaisePropertyChanged("indexOfNextWaypoint");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int heading {
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
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int headingTolerance {
            get {
                return this.headingToleranceField;
            }
            set {
                this.headingToleranceField = value;
                this.RaisePropertyChanged("headingTolerance");
                this.headingToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool headingToleranceSpecified {
            get {
                return this.headingToleranceFieldSpecified;
            }
            set {
                this.headingToleranceFieldSpecified = value;
                this.RaisePropertyChanged("headingToleranceSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ProfileRequest : com.ptvgroup.xserver.service.RequestBase {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ProfileResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.vehicleprofile.VehicleProfile vehicleProfileField;
        private com.ptvgroup.xserver.featurelayerprofile.FeatureLayerProfile featureLayerProfileField;
        private com.ptvgroup.xserver.routingprofile.RoutingProfile routingProfileField;
        private string mapLanguageField;
        private string userLanguageField;

                    [System.Xml.Serialization.XmlElementAttribute("vehicleProfile", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.vehicleprofile.VehicleProfile vehicleProfile {
            get {
                return this.vehicleProfileField;
            }
            set {
                this.vehicleProfileField = value;
                this.RaisePropertyChanged("vehicleProfile");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("featureLayerProfile", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.featurelayerprofile.FeatureLayerProfile featureLayerProfile {
            get {
                return this.featureLayerProfileField;
            }
            set {
                this.featureLayerProfileField = value;
                this.RaisePropertyChanged("featureLayerProfile");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("routingProfile", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.RoutingProfile routingProfile {
            get {
                return this.routingProfileField;
            }
            set {
                this.routingProfileField = value;
                this.RaisePropertyChanged("routingProfile");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mapLanguage {
            get {
                return this.mapLanguageField;
            }
            set {
                this.mapLanguageField = value;
                this.RaisePropertyChanged("mapLanguage");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string userLanguage {
            get {
                return this.userLanguageField;
            }
            set {
                this.userLanguageField = value;
                this.RaisePropertyChanged("userLanguage");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ReachableAreasOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routing.Horizon[] horizonsField;
        private com.ptvgroup.xserver.xroute.ReachableAreasCalculationMode calculationModeField;
        private bool calculationModeFieldSpecified;
        private com.ptvgroup.xserver.xroute.ReachableAreasDrivingDirection drivingDirectionField;
        private bool drivingDirectionFieldSpecified;
        private com.ptvgroup.xserver.timeconsideration.TimeConsideration timeConsiderationField;
        private string contentSnapshotIdField;
        private com.ptvgroup.xserver.routing.GeographicRestrictions geographicRestrictionsField;

                    [System.Xml.Serialization.XmlElementAttribute("horizons", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.Horizon[] horizons {
            get {
                return this.horizonsField;
            }
            set {
                this.horizonsField = value;
                this.RaisePropertyChanged("horizons");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xroute.ReachableAreasCalculationMode calculationMode {
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
        public com.ptvgroup.xserver.xroute.ReachableAreasDrivingDirection drivingDirection {
            get {
                return this.drivingDirectionField;
            }
            set {
                this.drivingDirectionField = value;
                this.RaisePropertyChanged("drivingDirection");
                this.drivingDirectionFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drivingDirectionSpecified {
            get {
                return this.drivingDirectionFieldSpecified;
            }
            set {
                this.drivingDirectionFieldSpecified = value;
                this.RaisePropertyChanged("drivingDirectionSpecified");
            }
        }
        
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ReachableAreasRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.routing.RouteLocation locationField;
        private com.ptvgroup.xserver.xroute.InputWaypoint waypointField;
        private com.ptvgroup.xserver.xroute.ReachableAreasOptions reachableAreasOptionsField;
        private com.ptvgroup.xserver.xroute.ReachableAreasResultFields reachableAreasResultFieldsField;

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

                    [System.Xml.Serialization.XmlElementAttribute("waypoint", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.InputWaypoint waypoint {
            get {
                return this.waypointField;
            }
            set {
                this.waypointField = value;
                this.RaisePropertyChanged("waypoint");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("reachableAreasOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.ReachableAreasOptions reachableAreasOptions {
            get {
                return this.reachableAreasOptionsField;
            }
            set {
                this.reachableAreasOptionsField = value;
                this.RaisePropertyChanged("reachableAreasOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("reachableAreasResultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.ReachableAreasResultFields reachableAreasResultFields {
            get {
                return this.reachableAreasResultFieldsField;
            }
            set {
                this.reachableAreasResultFieldsField = value;
                this.RaisePropertyChanged("reachableAreasResultFields");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ReachableAreasResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.geometry.EncodedGeometry[] polygonsField;
        private com.ptvgroup.xserver.xroute.ReachableAreasSegment[] segmentsField;

                    [System.Xml.Serialization.XmlElementAttribute("polygons", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.EncodedGeometry[] polygons {
            get {
                return this.polygonsField;
            }
            set {
                this.polygonsField = value;
                this.RaisePropertyChanged("polygons");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("segments", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.ReachableAreasSegment[] segments {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ReachableAreasResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xroute.ReachableAreasSegmentResultFields segmentsField;
        private bool polygonsField;
        private bool polygonsFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("segments", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.ReachableAreasSegmentResultFields segments {
            get {
                return this.segmentsField;
            }
            set {
                this.segmentsField = value;
                this.RaisePropertyChanged("segments");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool polygons {
            get {
                return this.polygonsField;
            }
            set {
                this.polygonsField = value;
                this.RaisePropertyChanged("polygons");
                this.polygonsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool polygonsSpecified {
            get {
                return this.polygonsFieldSpecified;
            }
            set {
                this.polygonsFieldSpecified = value;
                this.RaisePropertyChanged("polygonsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ReachableAreasSegment : object, System.ComponentModel.INotifyPropertyChanged {

        private double distanceField;
        private double travelTimeField;
        private com.ptvgroup.xserver.geometry.EncodedGeometry polylineField;
        private string idField;
        private int predecessorIndexField;
        private bool predecessorIndexFieldSpecified;

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
        public double travelTime {
            get {
                return this.travelTimeField;
            }
            set {
                this.travelTimeField = value;
                this.RaisePropertyChanged("travelTime");
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
        public int predecessorIndex {
            get {
                return this.predecessorIndexField;
            }
            set {
                this.predecessorIndexField = value;
                this.RaisePropertyChanged("predecessorIndex");
                this.predecessorIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool predecessorIndexSpecified {
            get {
                return this.predecessorIndexFieldSpecified;
            }
            set {
                this.predecessorIndexFieldSpecified = value;
                this.RaisePropertyChanged("predecessorIndexSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ReachableAreasSegmentResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool enabledField;
        private bool enabledFieldSpecified;
        private bool polylineField;
        private bool polylineFieldSpecified;
        private bool idField;
        private bool idFieldSpecified;
        private bool predecessorIndexField;
        private bool predecessorIndexFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
                this.RaisePropertyChanged("enabled");
                this.enabledFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enabledSpecified {
            get {
                return this.enabledFieldSpecified;
            }
            set {
                this.enabledFieldSpecified = value;
                this.RaisePropertyChanged("enabledSpecified");
            }
        }
        
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
        public bool id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
                this.idFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("idSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool predecessorIndex {
            get {
                return this.predecessorIndexField;
            }
            set {
                this.predecessorIndexField = value;
                this.RaisePropertyChanged("predecessorIndex");
                this.predecessorIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool predecessorIndexSpecified {
            get {
                return this.predecessorIndexFieldSpecified;
            }
            set {
                this.predecessorIndexFieldSpecified = value;
                this.RaisePropertyChanged("predecessorIndexSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ReachableLocation : object, System.ComponentModel.INotifyPropertyChanged {

        private double distanceField;
        private bool distanceFieldSpecified;
        private double travelTimeField;
        private bool travelTimeFieldSpecified;
        private int inputLocationIndexField;
        private bool inputLocationIndexFieldSpecified;

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
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int inputLocationIndex {
            get {
                return this.inputLocationIndexField;
            }
            set {
                this.inputLocationIndexField = value;
                this.RaisePropertyChanged("inputLocationIndex");
                this.inputLocationIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inputLocationIndexSpecified {
            get {
                return this.inputLocationIndexFieldSpecified;
            }
            set {
                this.inputLocationIndexFieldSpecified = value;
                this.RaisePropertyChanged("inputLocationIndexSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ReachableLocationsOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routing.Horizon horizonField;
        private com.ptvgroup.xserver.xroute.ReachableLocationsSearchType searchTypeField;
        private bool searchTypeFieldSpecified;
        private com.ptvgroup.xserver.timeconsideration.TimeConsideration timeConsiderationField;
        private string contentSnapshotIdField;
        private com.ptvgroup.xserver.routing.GeographicRestrictions geographicRestrictionsField;

                    [System.Xml.Serialization.XmlElementAttribute("horizon", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.Horizon horizon {
            get {
                return this.horizonField;
            }
            set {
                this.horizonField = value;
                this.RaisePropertyChanged("horizon");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xroute.ReachableLocationsSearchType searchType {
            get {
                return this.searchTypeField;
            }
            set {
                this.searchTypeField = value;
                this.RaisePropertyChanged("searchType");
                this.searchTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool searchTypeSpecified {
            get {
                return this.searchTypeFieldSpecified;
            }
            set {
                this.searchTypeFieldSpecified = value;
                this.RaisePropertyChanged("searchTypeSpecified");
            }
        }
        
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ReachableLocationsRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xroute.InputWaypoint waypointField;
        private com.ptvgroup.xserver.routing.RouteLocation[] locationsField;
        private com.ptvgroup.xserver.xroute.ReachableLocationsOptions reachableLocationsOptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("waypoint", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.InputWaypoint waypoint {
            get {
                return this.waypointField;
            }
            set {
                this.waypointField = value;
                this.RaisePropertyChanged("waypoint");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("locations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.RouteLocation[] locations {
            get {
                return this.locationsField;
            }
            set {
                this.locationsField = value;
                this.RaisePropertyChanged("locations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("reachableLocationsOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.ReachableLocationsOptions reachableLocationsOptions {
            get {
                return this.reachableLocationsOptionsField;
            }
            set {
                this.reachableLocationsOptionsField = value;
                this.RaisePropertyChanged("reachableLocationsOptions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ReachableLocationsResponse : com.ptvgroup.xserver.service.ResponseBase {

        private com.ptvgroup.xserver.xroute.ReachableLocation[] reachableLocationsField;
        private int[] unreachableLocationsField;

                    [System.Xml.Serialization.XmlElementAttribute("reachableLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.ReachableLocation[] reachableLocations {
            get {
                return this.reachableLocationsField;
            }
            set {
                this.reachableLocationsField = value;
                this.RaisePropertyChanged("reachableLocations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("unreachableLocations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int[] unreachableLocations {
            get {
                return this.unreachableLocationsField;
            }
            set {
                this.unreachableLocationsField = value;
                this.RaisePropertyChanged("unreachableLocations");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool waypointsField;
        private bool waypointsFieldSpecified;
        private com.ptvgroup.xserver.xroute.LegResultFields legsField;
        private com.ptvgroup.xserver.xroute.SegmentResultFields segmentsField;
        private bool nodesField;
        private bool nodesFieldSpecified;
        private com.ptvgroup.xserver.xroute.RouteEventType[] eventTypesField;
        private bool polylineField;
        private bool polylineFieldSpecified;
        private com.ptvgroup.xserver.xroute.TollResultFields tollField;
        private bool emissionsField;
        private bool emissionsFieldSpecified;
        private bool reportField;
        private bool reportFieldSpecified;
        private bool tourReportField;
        private bool tourReportFieldSpecified;
        private bool encodedPathField;
        private bool encodedPathFieldSpecified;
        private bool guidedNavigationRouteField;
        private bool guidedNavigationRouteFieldSpecified;
        private bool monetaryCostsReportField;
        private bool monetaryCostsReportFieldSpecified;
        private bool alternativeRoutesField;
        private bool alternativeRoutesFieldSpecified;
        private bool providerIdsField;
        private bool providerIdsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool waypoints {
            get {
                return this.waypointsField;
            }
            set {
                this.waypointsField = value;
                this.RaisePropertyChanged("waypoints");
                this.waypointsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool waypointsSpecified {
            get {
                return this.waypointsFieldSpecified;
            }
            set {
                this.waypointsFieldSpecified = value;
                this.RaisePropertyChanged("waypointsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("legs", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.LegResultFields legs {
            get {
                return this.legsField;
            }
            set {
                this.legsField = value;
                this.RaisePropertyChanged("legs");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("segments", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.SegmentResultFields segments {
            get {
                return this.segmentsField;
            }
            set {
                this.segmentsField = value;
                this.RaisePropertyChanged("segments");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nodes {
            get {
                return this.nodesField;
            }
            set {
                this.nodesField = value;
                this.RaisePropertyChanged("nodes");
                this.nodesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nodesSpecified {
            get {
                return this.nodesFieldSpecified;
            }
            set {
                this.nodesFieldSpecified = value;
                this.RaisePropertyChanged("nodesSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("eventTypes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.RouteEventType[] eventTypes {
            get {
                return this.eventTypesField;
            }
            set {
                this.eventTypesField = value;
                this.RaisePropertyChanged("eventTypes");
            }
        }

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
        
                    [System.Xml.Serialization.XmlElementAttribute("toll", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TollResultFields toll {
            get {
                return this.tollField;
            }
            set {
                this.tollField = value;
                this.RaisePropertyChanged("toll");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool emissions {
            get {
                return this.emissionsField;
            }
            set {
                this.emissionsField = value;
                this.RaisePropertyChanged("emissions");
                this.emissionsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emissionsSpecified {
            get {
                return this.emissionsFieldSpecified;
            }
            set {
                this.emissionsFieldSpecified = value;
                this.RaisePropertyChanged("emissionsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool report {
            get {
                return this.reportField;
            }
            set {
                this.reportField = value;
                this.RaisePropertyChanged("report");
                this.reportFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reportSpecified {
            get {
                return this.reportFieldSpecified;
            }
            set {
                this.reportFieldSpecified = value;
                this.RaisePropertyChanged("reportSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool tourReport {
            get {
                return this.tourReportField;
            }
            set {
                this.tourReportField = value;
                this.RaisePropertyChanged("tourReport");
                this.tourReportFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tourReportSpecified {
            get {
                return this.tourReportFieldSpecified;
            }
            set {
                this.tourReportFieldSpecified = value;
                this.RaisePropertyChanged("tourReportSpecified");
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
        public bool guidedNavigationRoute {
            get {
                return this.guidedNavigationRouteField;
            }
            set {
                this.guidedNavigationRouteField = value;
                this.RaisePropertyChanged("guidedNavigationRoute");
                this.guidedNavigationRouteFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool guidedNavigationRouteSpecified {
            get {
                return this.guidedNavigationRouteFieldSpecified;
            }
            set {
                this.guidedNavigationRouteFieldSpecified = value;
                this.RaisePropertyChanged("guidedNavigationRouteSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool monetaryCostsReport {
            get {
                return this.monetaryCostsReportField;
            }
            set {
                this.monetaryCostsReportField = value;
                this.RaisePropertyChanged("monetaryCostsReport");
                this.monetaryCostsReportFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monetaryCostsReportSpecified {
            get {
                return this.monetaryCostsReportFieldSpecified;
            }
            set {
                this.monetaryCostsReportFieldSpecified = value;
                this.RaisePropertyChanged("monetaryCostsReportSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool alternativeRoutes {
            get {
                return this.alternativeRoutesField;
            }
            set {
                this.alternativeRoutesField = value;
                this.RaisePropertyChanged("alternativeRoutes");
                this.alternativeRoutesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alternativeRoutesSpecified {
            get {
                return this.alternativeRoutesFieldSpecified;
            }
            set {
                this.alternativeRoutesFieldSpecified = value;
                this.RaisePropertyChanged("alternativeRoutesSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool providerIds {
            get {
                return this.providerIdsField;
            }
            set {
                this.providerIdsField = value;
                this.RaisePropertyChanged("providerIds");
                this.providerIdsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool providerIdsSpecified {
            get {
                return this.providerIdsFieldSpecified;
            }
            set {
                this.providerIdsFieldSpecified = value;
                this.RaisePropertyChanged("providerIdsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class RoadDescriptor : object, System.ComponentModel.INotifyPropertyChanged {

        private string roadNumberField;
        private string roadNameField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string roadNumber {
            get {
                return this.roadNumberField;
            }
            set {
                this.roadNumberField = value;
                this.RaisePropertyChanged("roadNumber");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string roadName {
            get {
                return this.roadNameField;
            }
            set {
                this.roadNameField = value;
                this.RaisePropertyChanged("roadName");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.CombinedTransportEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.CountryEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.ManeuverEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.RouteViolationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.TollEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.TourEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.UTCOffsetEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.WaypointEvent))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public abstract partial class RouteEvent : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xroute.RouteEventType eventTypeField;
        private bool eventTypeFieldSpecified;
        private System.DateTime startsAtField;
        private bool startsAtFieldSpecified;
        private com.ptvgroup.xserver.geometry.Coordinate coordinateField;
        private int nodeIndexField;
        private bool nodeIndexFieldSpecified;
        private double distanceFromStartField;
        private bool distanceFromStartFieldSpecified;
        private double travelTimeFromStartField;
        private bool travelTimeFromStartFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xroute.RouteEventType eventType {
            get {
                return this.eventTypeField;
            }
            set {
                this.eventTypeField = value;
                this.RaisePropertyChanged("eventType");
                this.eventTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventTypeSpecified {
            get {
                return this.eventTypeFieldSpecified;
            }
            set {
                this.eventTypeFieldSpecified = value;
                this.RaisePropertyChanged("eventTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime startsAt {
            get {
                return this.startsAtField;
            }
            set {
                this.startsAtField = value;
                this.RaisePropertyChanged("startsAt");
                this.startsAtFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startsAtSpecified {
            get {
                return this.startsAtFieldSpecified;
            }
            set {
                this.startsAtFieldSpecified = value;
                this.RaisePropertyChanged("startsAtSpecified");
            }
        }
        
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
        public int nodeIndex {
            get {
                return this.nodeIndexField;
            }
            set {
                this.nodeIndexField = value;
                this.RaisePropertyChanged("nodeIndex");
                this.nodeIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nodeIndexSpecified {
            get {
                return this.nodeIndexFieldSpecified;
            }
            set {
                this.nodeIndexFieldSpecified = value;
                this.RaisePropertyChanged("nodeIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double distanceFromStart {
            get {
                return this.distanceFromStartField;
            }
            set {
                this.distanceFromStartField = value;
                this.RaisePropertyChanged("distanceFromStart");
                this.distanceFromStartFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool distanceFromStartSpecified {
            get {
                return this.distanceFromStartFieldSpecified;
            }
            set {
                this.distanceFromStartFieldSpecified = value;
                this.RaisePropertyChanged("distanceFromStartSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double travelTimeFromStart {
            get {
                return this.travelTimeFromStartField;
            }
            set {
                this.travelTimeFromStartField = value;
                this.RaisePropertyChanged("travelTimeFromStart");
                this.travelTimeFromStartFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool travelTimeFromStartSpecified {
            get {
                return this.travelTimeFromStartFieldSpecified;
            }
            set {
                this.travelTimeFromStartFieldSpecified = value;
                this.RaisePropertyChanged("travelTimeFromStartSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class RouteOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.timeconsideration.TimeConsideration timeConsiderationField;
        private string contentSnapshotIdField;
        private string highPerformanceRoutingNetworkIdField;
        private com.ptvgroup.xserver.routing.GeographicRestrictions geographicRestrictionsField;
        private com.ptvgroup.xserver.xroute.PolylineOptions polylineOptionsField;
        private com.ptvgroup.xserver.xroute.EmissionOptions emissionOptionsField;
        private com.ptvgroup.xserver.xroute.EffectiveFuelConsumption effectiveFuelConsumptionField;
        private com.ptvgroup.xserver.xroute.TollOptions tollOptionsField;
        private com.ptvgroup.xserver.routing.RoutingType routingTypeField;
        private bool routingTypeFieldSpecified;
        private com.ptvgroup.xserver.xroute.TourRestrictions tourRestrictionsField;
        private com.ptvgroup.xserver.routing.RouteCalculationCriteria calculationCriteriaField;
        private bool calculationCriteriaFieldSpecified;
        private com.ptvgroup.xserver.routing.MonetaryCostOptions monetaryCostOptionsField;
        private string binaryFeatureLayerField;
        private com.ptvgroup.xserver.xroute.ETACalculationOptions etaCalculationOptionsField;
        private string currencyField;

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

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string highPerformanceRoutingNetworkId {
            get {
                return this.highPerformanceRoutingNetworkIdField;
            }
            set {
                this.highPerformanceRoutingNetworkIdField = value;
                this.RaisePropertyChanged("highPerformanceRoutingNetworkId");
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

                    [System.Xml.Serialization.XmlElementAttribute("polylineOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.PolylineOptions polylineOptions {
            get {
                return this.polylineOptionsField;
            }
            set {
                this.polylineOptionsField = value;
                this.RaisePropertyChanged("polylineOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("emissionOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.EmissionOptions emissionOptions {
            get {
                return this.emissionOptionsField;
            }
            set {
                this.emissionOptionsField = value;
                this.RaisePropertyChanged("emissionOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("effectiveFuelConsumption", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.EffectiveFuelConsumption effectiveFuelConsumption {
            get {
                return this.effectiveFuelConsumptionField;
            }
            set {
                this.effectiveFuelConsumptionField = value;
                this.RaisePropertyChanged("effectiveFuelConsumption");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tollOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TollOptions tollOptions {
            get {
                return this.tollOptionsField;
            }
            set {
                this.tollOptionsField = value;
                this.RaisePropertyChanged("tollOptions");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.routing.RoutingType routingType {
            get {
                return this.routingTypeField;
            }
            set {
                this.routingTypeField = value;
                this.RaisePropertyChanged("routingType");
                this.routingTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool routingTypeSpecified {
            get {
                return this.routingTypeFieldSpecified;
            }
            set {
                this.routingTypeFieldSpecified = value;
                this.RaisePropertyChanged("routingTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("tourRestrictions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TourRestrictions tourRestrictions {
            get {
                return this.tourRestrictionsField;
            }
            set {
                this.tourRestrictionsField = value;
                this.RaisePropertyChanged("tourRestrictions");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.routing.RouteCalculationCriteria calculationCriteria {
            get {
                return this.calculationCriteriaField;
            }
            set {
                this.calculationCriteriaField = value;
                this.RaisePropertyChanged("calculationCriteria");
                this.calculationCriteriaFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool calculationCriteriaSpecified {
            get {
                return this.calculationCriteriaFieldSpecified;
            }
            set {
                this.calculationCriteriaFieldSpecified = value;
                this.RaisePropertyChanged("calculationCriteriaSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("monetaryCostOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.MonetaryCostOptions monetaryCostOptions {
            get {
                return this.monetaryCostOptionsField;
            }
            set {
                this.monetaryCostOptionsField = value;
                this.RaisePropertyChanged("monetaryCostOptions");
            }
        }

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

                    [System.Xml.Serialization.XmlElementAttribute("etaCalculationOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.ETACalculationOptions etaCalculationOptions {
            get {
                return this.etaCalculationOptionsField;
            }
            set {
                this.etaCalculationOptionsField = value;
                this.RaisePropertyChanged("etaCalculationOptions");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
                this.RaisePropertyChanged("currency");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class RouteReport : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routing.RoutingType routingTypeField;
        private bool routingTypeFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.routing.RoutingType routingType {
            get {
                return this.routingTypeField;
            }
            set {
                this.routingTypeField = value;
                this.RaisePropertyChanged("routingType");
                this.routingTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool routingTypeSpecified {
            get {
                return this.routingTypeFieldSpecified;
            }
            set {
                this.routingTypeFieldSpecified = value;
                this.RaisePropertyChanged("routingTypeSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class RouteRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xroute.InputWaypoint[] waypointsField;
        private com.ptvgroup.xserver.xroute.RouteOptions routeOptionsField;
        private com.ptvgroup.xserver.xroute.ResultFields resultFieldsField;

                    [System.Xml.Serialization.XmlElementAttribute("waypoints", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.InputWaypoint[] waypoints {
            get {
                return this.waypointsField;
            }
            set {
                this.waypointsField = value;
                this.RaisePropertyChanged("waypoints");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("routeOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.RouteOptions routeOptions {
            get {
                return this.routeOptionsField;
            }
            set {
                this.routeOptionsField = value;
                this.RaisePropertyChanged("routeOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.ResultFields resultFields {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class RouteResponse : com.ptvgroup.xserver.service.ResponseBase {

        private double distanceField;
        private double travelTimeField;
        private com.ptvgroup.xserver.xroute.Waypoint[] waypointsField;
        private com.ptvgroup.xserver.xroute.Leg[] legsField;
        private com.ptvgroup.xserver.xroute.Segment[] segmentsField;
        private com.ptvgroup.xserver.xroute.Node[] nodesField;
        private com.ptvgroup.xserver.xroute.RouteEvent[] eventsField;
        private com.ptvgroup.xserver.geometry.EncodedGeometry polylineField;
        private com.ptvgroup.xserver.xroute.Toll tollField;
        private com.ptvgroup.xserver.emissions.Emissions emissionsField;
        private string encodedPathField;
        private byte[] guidedNavigationRouteField;
        private com.ptvgroup.xserver.xroute.TourReport tourReportField;
        private bool violatedField;
        private com.ptvgroup.xserver.xroute.RouteReport reportField;
        private com.ptvgroup.xserver.xroute.MonetaryCostsReport monetaryCostsReportField;
        private com.ptvgroup.xserver.xroute.ETACalculationReport etaCalculationReportField;
        private com.ptvgroup.xserver.xroute.AlternativeRoute[] alternativeRoutesField;
        private string[] providerIdsField;

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
        public double travelTime {
            get {
                return this.travelTimeField;
            }
            set {
                this.travelTimeField = value;
                this.RaisePropertyChanged("travelTime");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("waypoints", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.Waypoint[] waypoints {
            get {
                return this.waypointsField;
            }
            set {
                this.waypointsField = value;
                this.RaisePropertyChanged("waypoints");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("legs", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.Leg[] legs {
            get {
                return this.legsField;
            }
            set {
                this.legsField = value;
                this.RaisePropertyChanged("legs");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("segments", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.Segment[] segments {
            get {
                return this.segmentsField;
            }
            set {
                this.segmentsField = value;
                this.RaisePropertyChanged("segments");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("nodes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.Node[] nodes {
            get {
                return this.nodesField;
            }
            set {
                this.nodesField = value;
                this.RaisePropertyChanged("nodes");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("events", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.RouteEvent[] events {
            get {
                return this.eventsField;
            }
            set {
                this.eventsField = value;
                this.RaisePropertyChanged("events");
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

                    [System.Xml.Serialization.XmlElementAttribute("toll", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.Toll toll {
            get {
                return this.tollField;
            }
            set {
                this.tollField = value;
                this.RaisePropertyChanged("toll");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("emissions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.Emissions emissions {
            get {
                return this.emissionsField;
            }
            set {
                this.emissionsField = value;
                this.RaisePropertyChanged("emissions");
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

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
        public byte[] guidedNavigationRoute {
            get {
                return this.guidedNavigationRouteField;
            }
            set {
                this.guidedNavigationRouteField = value;
                this.RaisePropertyChanged("guidedNavigationRoute");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("tourReport", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TourReport tourReport {
            get {
                return this.tourReportField;
            }
            set {
                this.tourReportField = value;
                this.RaisePropertyChanged("tourReport");
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
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("report", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.RouteReport report {
            get {
                return this.reportField;
            }
            set {
                this.reportField = value;
                this.RaisePropertyChanged("report");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("monetaryCostsReport", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.MonetaryCostsReport monetaryCostsReport {
            get {
                return this.monetaryCostsReportField;
            }
            set {
                this.monetaryCostsReportField = value;
                this.RaisePropertyChanged("monetaryCostsReport");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("etaCalculationReport", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.ETACalculationReport etaCalculationReport {
            get {
                return this.etaCalculationReportField;
            }
            set {
                this.etaCalculationReportField = value;
                this.RaisePropertyChanged("etaCalculationReport");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("alternativeRoutes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.AlternativeRoute[] alternativeRoutes {
            get {
                return this.alternativeRoutesField;
            }
            set {
                this.alternativeRoutesField = value;
                this.RaisePropertyChanged("alternativeRoutes");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("providerIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] providerIds {
            get {
                return this.providerIdsField;
            }
            set {
                this.providerIdsField = value;
                this.RaisePropertyChanged("providerIds");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class RouteViolationEvent : com.ptvgroup.xserver.xroute.RouteEvent {

        private com.ptvgroup.xserver.xroute.RouteViolationType violationTypeField;
        private bool violationTypeFieldSpecified;
        private com.ptvgroup.xserver.xroute.ViolatedFeature violatedFeatureField;
        private com.ptvgroup.xserver.xroute.AccessType accessTypeField;
        private bool accessTypeFieldSpecified;
        private int relatedEventIndexField;
        private bool relatedEventIndexFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xroute.RouteViolationType violationType {
            get {
                return this.violationTypeField;
            }
            set {
                this.violationTypeField = value;
                this.RaisePropertyChanged("violationType");
                this.violationTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool violationTypeSpecified {
            get {
                return this.violationTypeFieldSpecified;
            }
            set {
                this.violationTypeFieldSpecified = value;
                this.RaisePropertyChanged("violationTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("violatedFeature", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.ViolatedFeature violatedFeature {
            get {
                return this.violatedFeatureField;
            }
            set {
                this.violatedFeatureField = value;
                this.RaisePropertyChanged("violatedFeature");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xroute.AccessType accessType {
            get {
                return this.accessTypeField;
            }
            set {
                this.accessTypeField = value;
                this.RaisePropertyChanged("accessType");
                this.accessTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accessTypeSpecified {
            get {
                return this.accessTypeFieldSpecified;
            }
            set {
                this.accessTypeFieldSpecified = value;
                this.RaisePropertyChanged("accessTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int relatedEventIndex {
            get {
                return this.relatedEventIndexField;
            }
            set {
                this.relatedEventIndexField = value;
                this.RaisePropertyChanged("relatedEventIndex");
                this.relatedEventIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relatedEventIndexSpecified {
            get {
                return this.relatedEventIndexFieldSpecified;
            }
            set {
                this.relatedEventIndexFieldSpecified = value;
                this.RaisePropertyChanged("relatedEventIndexSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class Segment : object, System.ComponentModel.INotifyPropertyChanged {

        private int startNodeIndexField;
        private bool startNodeIndexFieldSpecified;
        private int endNodeIndexField;
        private bool endNodeIndexFieldSpecified;
        private double distanceField;
        private double travelTimeField;
        private double travelSpeedField;
        private com.ptvgroup.xserver.emissions.Emissions emissionsField;
        private bool violatedField;
        private int[] eventIndicesField;
        private com.ptvgroup.xserver.segments.SegmentType typeField;
        private com.ptvgroup.xserver.geometry.EncodedGeometry polylineField;
        private com.ptvgroup.xserver.segments.SegmentAttributes attributesField;
        private com.ptvgroup.xserver.segments.CombinedTransportAttributes combinedTransportField;
        private string idField;
        private string providerIdField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int startNodeIndex {
            get {
                return this.startNodeIndexField;
            }
            set {
                this.startNodeIndexField = value;
                this.RaisePropertyChanged("startNodeIndex");
                this.startNodeIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startNodeIndexSpecified {
            get {
                return this.startNodeIndexFieldSpecified;
            }
            set {
                this.startNodeIndexFieldSpecified = value;
                this.RaisePropertyChanged("startNodeIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int endNodeIndex {
            get {
                return this.endNodeIndexField;
            }
            set {
                this.endNodeIndexField = value;
                this.RaisePropertyChanged("endNodeIndex");
                this.endNodeIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endNodeIndexSpecified {
            get {
                return this.endNodeIndexFieldSpecified;
            }
            set {
                this.endNodeIndexFieldSpecified = value;
                this.RaisePropertyChanged("endNodeIndexSpecified");
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
        public double travelSpeed {
            get {
                return this.travelSpeedField;
            }
            set {
                this.travelSpeedField = value;
                this.RaisePropertyChanged("travelSpeed");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("emissions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.Emissions emissions {
            get {
                return this.emissionsField;
            }
            set {
                this.emissionsField = value;
                this.RaisePropertyChanged("emissions");
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
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("eventIndices", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int[] eventIndices {
            get {
                return this.eventIndicesField;
            }
            set {
                this.eventIndicesField = value;
                this.RaisePropertyChanged("eventIndices");
            }
        }

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

                    [System.Xml.Serialization.XmlElementAttribute("attributes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.segments.SegmentAttributes attributes {
            get {
                return this.attributesField;
            }
            set {
                this.attributesField = value;
                this.RaisePropertyChanged("attributes");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class SegmentResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool enabledField;
        private bool enabledFieldSpecified;
        private bool emissionsField;
        private bool emissionsFieldSpecified;
        private bool polylineField;
        private bool polylineFieldSpecified;
        private bool descriptorsField;
        private bool descriptorsFieldSpecified;
        private bool roadAttributesField;
        private bool roadAttributesFieldSpecified;
        private string[] featureThemeIdsField;
        private bool idField;
        private bool idFieldSpecified;
        private bool providerIdField;
        private bool providerIdFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
                this.RaisePropertyChanged("enabled");
                this.enabledFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enabledSpecified {
            get {
                return this.enabledFieldSpecified;
            }
            set {
                this.enabledFieldSpecified = value;
                this.RaisePropertyChanged("enabledSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool emissions {
            get {
                return this.emissionsField;
            }
            set {
                this.emissionsField = value;
                this.RaisePropertyChanged("emissions");
                this.emissionsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emissionsSpecified {
            get {
                return this.emissionsFieldSpecified;
            }
            set {
                this.emissionsFieldSpecified = value;
                this.RaisePropertyChanged("emissionsSpecified");
            }
        }
        
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
        public bool roadAttributes {
            get {
                return this.roadAttributesField;
            }
            set {
                this.roadAttributesField = value;
                this.RaisePropertyChanged("roadAttributes");
                this.roadAttributesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool roadAttributesSpecified {
            get {
                return this.roadAttributesFieldSpecified;
            }
            set {
                this.roadAttributesFieldSpecified = value;
                this.RaisePropertyChanged("roadAttributesSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("featureThemeIds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] featureThemeIds {
            get {
                return this.featureThemeIdsField;
            }
            set {
                this.featureThemeIdsField = value;
                this.RaisePropertyChanged("featureThemeIds");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
                this.idFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("idSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class SideOfStreetRestrictionIgnoredLimitation : com.ptvgroup.xserver.service.ResultLimitation {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class Toll : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xroute.TollSummary summaryField;
        private com.ptvgroup.xserver.xroute.TollSection[] sectionsField;
        private com.ptvgroup.xserver.xroute.TollSystem[] systemsField;

                    [System.Xml.Serialization.XmlElementAttribute("summary", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TollSummary summary {
            get {
                return this.summaryField;
            }
            set {
                this.summaryField = value;
                this.RaisePropertyChanged("summary");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("sections", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TollSection[] sections {
            get {
                return this.sectionsField;
            }
            set {
                this.sectionsField = value;
                this.RaisePropertyChanged("sections");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("systems", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TollSystem[] systems {
            get {
                return this.systemsField;
            }
            set {
                this.systemsField = value;
                this.RaisePropertyChanged("systems");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class TollCost : object, System.ComponentModel.INotifyPropertyChanged {

        private double amountField;
        private string currencyField;
        private com.ptvgroup.xserver.xroute.PaymentMethod[] paymentMethodsField;
        private string[] electronicTollCollectionSubscriptionsField;
        private com.ptvgroup.xserver.types.Cost convertedCostField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
                this.RaisePropertyChanged("amount");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
                this.RaisePropertyChanged("currency");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("paymentMethods", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.PaymentMethod[] paymentMethods {
            get {
                return this.paymentMethodsField;
            }
            set {
                this.paymentMethodsField = value;
                this.RaisePropertyChanged("paymentMethods");
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

                    [System.Xml.Serialization.XmlElementAttribute("convertedCost", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.Cost convertedCost {
            get {
                return this.convertedCostField;
            }
            set {
                this.convertedCostField = value;
                this.RaisePropertyChanged("convertedCost");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class TollEvent : com.ptvgroup.xserver.xroute.RouteEvent {

        private int sectionIndexField;
        private bool sectionIndexFieldSpecified;
        private string displayNameField;
        private com.ptvgroup.xserver.xroute.AccessType accessTypeField;
        private bool accessTypeFieldSpecified;
        private int relatedEventIndexField;
        private bool relatedEventIndexFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sectionIndex {
            get {
                return this.sectionIndexField;
            }
            set {
                this.sectionIndexField = value;
                this.RaisePropertyChanged("sectionIndex");
                this.sectionIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sectionIndexSpecified {
            get {
                return this.sectionIndexFieldSpecified;
            }
            set {
                this.sectionIndexFieldSpecified = value;
                this.RaisePropertyChanged("sectionIndexSpecified");
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

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xroute.AccessType accessType {
            get {
                return this.accessTypeField;
            }
            set {
                this.accessTypeField = value;
                this.RaisePropertyChanged("accessType");
                this.accessTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accessTypeSpecified {
            get {
                return this.accessTypeFieldSpecified;
            }
            set {
                this.accessTypeFieldSpecified = value;
                this.RaisePropertyChanged("accessTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int relatedEventIndex {
            get {
                return this.relatedEventIndexField;
            }
            set {
                this.relatedEventIndexField = value;
                this.RaisePropertyChanged("relatedEventIndex");
                this.relatedEventIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relatedEventIndexSpecified {
            get {
                return this.relatedEventIndexFieldSpecified;
            }
            set {
                this.relatedEventIndexFieldSpecified = value;
                this.RaisePropertyChanged("relatedEventIndexSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class TollOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private bool useDetailedTollField;
        private bool useDetailedTollFieldSpecified;
        private bool returnZeroCostsField;
        private bool returnZeroCostsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool useDetailedToll {
            get {
                return this.useDetailedTollField;
            }
            set {
                this.useDetailedTollField = value;
                this.RaisePropertyChanged("useDetailedToll");
                this.useDetailedTollFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useDetailedTollSpecified {
            get {
                return this.useDetailedTollFieldSpecified;
            }
            set {
                this.useDetailedTollFieldSpecified = value;
                this.RaisePropertyChanged("useDetailedTollSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool returnZeroCosts {
            get {
                return this.returnZeroCostsField;
            }
            set {
                this.returnZeroCostsField = value;
                this.RaisePropertyChanged("returnZeroCosts");
                this.returnZeroCostsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool returnZeroCostsSpecified {
            get {
                return this.returnZeroCostsFieldSpecified;
            }
            set {
                this.returnZeroCostsFieldSpecified = value;
                this.RaisePropertyChanged("returnZeroCostsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class TollResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool enabledField;
        private bool enabledFieldSpecified;
        private bool sectionsField;
        private bool sectionsFieldSpecified;
        private bool systemsField;
        private bool systemsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
                this.RaisePropertyChanged("enabled");
                this.enabledFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enabledSpecified {
            get {
                return this.enabledFieldSpecified;
            }
            set {
                this.enabledFieldSpecified = value;
                this.RaisePropertyChanged("enabledSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool sections {
            get {
                return this.sectionsField;
            }
            set {
                this.sectionsField = value;
                this.RaisePropertyChanged("sections");
                this.sectionsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sectionsSpecified {
            get {
                return this.sectionsFieldSpecified;
            }
            set {
                this.sectionsFieldSpecified = value;
                this.RaisePropertyChanged("sectionsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool systems {
            get {
                return this.systemsField;
            }
            set {
                this.systemsField = value;
                this.RaisePropertyChanged("systems");
                this.systemsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool systemsSpecified {
            get {
                return this.systemsFieldSpecified;
            }
            set {
                this.systemsFieldSpecified = value;
                this.RaisePropertyChanged("systemsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class TollSection : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xroute.TollCost costField;
        private com.ptvgroup.xserver.xroute.TollCost[] alternativeCostsField;
        private double officialDistanceField;
        private bool officialDistanceFieldSpecified;
        private com.ptvgroup.xserver.xroute.TollRoadType tollRoadTypeField;
        private bool tollRoadTypeFieldSpecified;
        private string countryField;
        private int tollSystemIndexField;
        private bool tollSystemIndexFieldSpecified;
        private int startNodeIndexField;
        private bool startNodeIndexFieldSpecified;
        private int endNodeIndexField;
        private bool endNodeIndexFieldSpecified;
        private string displayNameField;

                    [System.Xml.Serialization.XmlElementAttribute("cost", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TollCost cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
                this.RaisePropertyChanged("cost");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("alternativeCosts", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.TollCost[] alternativeCosts {
            get {
                return this.alternativeCostsField;
            }
            set {
                this.alternativeCostsField = value;
                this.RaisePropertyChanged("alternativeCosts");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double officialDistance {
            get {
                return this.officialDistanceField;
            }
            set {
                this.officialDistanceField = value;
                this.RaisePropertyChanged("officialDistance");
                this.officialDistanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool officialDistanceSpecified {
            get {
                return this.officialDistanceFieldSpecified;
            }
            set {
                this.officialDistanceFieldSpecified = value;
                this.RaisePropertyChanged("officialDistanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xroute.TollRoadType tollRoadType {
            get {
                return this.tollRoadTypeField;
            }
            set {
                this.tollRoadTypeField = value;
                this.RaisePropertyChanged("tollRoadType");
                this.tollRoadTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tollRoadTypeSpecified {
            get {
                return this.tollRoadTypeFieldSpecified;
            }
            set {
                this.tollRoadTypeFieldSpecified = value;
                this.RaisePropertyChanged("tollRoadTypeSpecified");
            }
        }
        
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
        public int tollSystemIndex {
            get {
                return this.tollSystemIndexField;
            }
            set {
                this.tollSystemIndexField = value;
                this.RaisePropertyChanged("tollSystemIndex");
                this.tollSystemIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tollSystemIndexSpecified {
            get {
                return this.tollSystemIndexFieldSpecified;
            }
            set {
                this.tollSystemIndexFieldSpecified = value;
                this.RaisePropertyChanged("tollSystemIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int startNodeIndex {
            get {
                return this.startNodeIndexField;
            }
            set {
                this.startNodeIndexField = value;
                this.RaisePropertyChanged("startNodeIndex");
                this.startNodeIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startNodeIndexSpecified {
            get {
                return this.startNodeIndexFieldSpecified;
            }
            set {
                this.startNodeIndexFieldSpecified = value;
                this.RaisePropertyChanged("startNodeIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int endNodeIndex {
            get {
                return this.endNodeIndexField;
            }
            set {
                this.endNodeIndexField = value;
                this.RaisePropertyChanged("endNodeIndex");
                this.endNodeIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endNodeIndexSpecified {
            get {
                return this.endNodeIndexFieldSpecified;
            }
            set {
                this.endNodeIndexFieldSpecified = value;
                this.RaisePropertyChanged("endNodeIndexSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class TollSummary : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.types.Cost[] costsField;
        private com.ptvgroup.xserver.xroute.CountryCost[] countriesField;

                    [System.Xml.Serialization.XmlElementAttribute("costs", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.Cost[] costs {
            get {
                return this.costsField;
            }
            set {
                this.costsField = value;
                this.RaisePropertyChanged("costs");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("countries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xroute.CountryCost[] countries {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class TollSystem : object, System.ComponentModel.INotifyPropertyChanged {

        private string nameField;
        private string operatorNameField;
        private string tariffVersionField;
        private System.DateTime tariffVersionValidFromField;
        private bool tariffVersionValidFromFieldSpecified;

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
        public string operatorName {
            get {
                return this.operatorNameField;
            }
            set {
                this.operatorNameField = value;
                this.RaisePropertyChanged("operatorName");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tariffVersion {
            get {
                return this.tariffVersionField;
            }
            set {
                this.tariffVersionField = value;
                this.RaisePropertyChanged("tariffVersion");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime tariffVersionValidFrom {
            get {
                return this.tariffVersionValidFromField;
            }
            set {
                this.tariffVersionValidFromField = value;
                this.RaisePropertyChanged("tariffVersionValidFrom");
                this.tariffVersionValidFromFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tariffVersionValidFromSpecified {
            get {
                return this.tariffVersionValidFromFieldSpecified;
            }
            set {
                this.tariffVersionValidFromFieldSpecified = value;
                this.RaisePropertyChanged("tariffVersionValidFromSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class TourEvent : com.ptvgroup.xserver.xroute.RouteEvent {

        private com.ptvgroup.xserver.tourplanning.TourEventType[] tourEventTypesField;
        private com.ptvgroup.xserver.tourplanning.TourViolation[] tourViolationsField;
        private double durationField;

                    [System.Xml.Serialization.XmlElementAttribute("tourEventTypes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.tourplanning.TourEventType[] tourEventTypes {
            get {
                return this.tourEventTypesField;
            }
            set {
                this.tourEventTypesField = value;
                this.RaisePropertyChanged("tourEventTypes");
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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class TourReport : object, System.ComponentModel.INotifyPropertyChanged {

        private bool violatedField;
        private bool violatedFieldSpecified;
        private System.DateTime startTimeField;
        private bool startTimeFieldSpecified;
        private double serviceTimeField;
        private bool serviceTimeFieldSpecified;
        private double drivingTimeField;
        private bool drivingTimeFieldSpecified;

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
        
                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime startTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
                this.RaisePropertyChanged("startTime");
                this.startTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startTimeSpecified {
            get {
                return this.startTimeFieldSpecified;
            }
            set {
                this.startTimeFieldSpecified = value;
                this.RaisePropertyChanged("startTimeSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class TourRestrictions : object, System.ComponentModel.INotifyPropertyChanged {

        private double maximumTravelTimePerTourField;
        private bool maximumTravelTimePerTourFieldSpecified;
        private double maximumDrivingTimePerTourField;
        private bool maximumDrivingTimePerTourFieldSpecified;
        private com.ptvgroup.xserver.tourplanning.WorkingHours workingHoursField;
        private com.ptvgroup.xserver.tourplanning.WorkLogbookSummary workLogbookSummaryField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class TourStopOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.time.Interval[] openingIntervalsField;
        private double serviceTimeField;
        private bool serviceTimeFieldSpecified;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class UTCOffsetEvent : com.ptvgroup.xserver.xroute.RouteEvent {

        private int utcOffsetField;
        private bool utcOffsetFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int utcOffset {
            get {
                return this.utcOffsetField;
            }
            set {
                this.utcOffsetField = value;
                this.RaisePropertyChanged("utcOffset");
                this.utcOffsetFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool utcOffsetSpecified {
            get {
                return this.utcOffsetFieldSpecified;
            }
            set {
                this.utcOffsetFieldSpecified = value;
                this.RaisePropertyChanged("utcOffsetSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class UnspecifiedMapDataLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private int indexField;
        private string pathField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
                this.RaisePropertyChanged("index");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
                this.RaisePropertyChanged("path");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.PositionAtStop))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.PositionEnRoute))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class ViolatedFeature : object, System.ComponentModel.INotifyPropertyChanged {

        private string themeIdField;
        private com.ptvgroup.xserver.types.KeyValuePair[] attributesField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class Waypoint : object, System.ComponentModel.INotifyPropertyChanged {

        private string nameField;
        private string countryField;
        private com.ptvgroup.xserver.geometry.Coordinate linkedCoordinateField;
        private com.ptvgroup.xserver.geometry.Coordinate referenceCoordinateField;
        private double linkDistanceField;
        private double linkTravelTimeField;
        private int nodeIndexField;
        private bool nodeIndexFieldSpecified;

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
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
                this.RaisePropertyChanged("country");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("linkedCoordinate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate linkedCoordinate {
            get {
                return this.linkedCoordinateField;
            }
            set {
                this.linkedCoordinateField = value;
                this.RaisePropertyChanged("linkedCoordinate");
            }
        }

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

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double linkDistance {
            get {
                return this.linkDistanceField;
            }
            set {
                this.linkDistanceField = value;
                this.RaisePropertyChanged("linkDistance");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double linkTravelTime {
            get {
                return this.linkTravelTimeField;
            }
            set {
                this.linkTravelTimeField = value;
                this.RaisePropertyChanged("linkTravelTime");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int nodeIndex {
            get {
                return this.nodeIndexField;
            }
            set {
                this.nodeIndexField = value;
                this.RaisePropertyChanged("nodeIndex");
                this.nodeIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nodeIndexSpecified {
            get {
                return this.nodeIndexFieldSpecified;
            }
            set {
                this.nodeIndexFieldSpecified = value;
                this.RaisePropertyChanged("nodeIndexSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class WaypointEvent : com.ptvgroup.xserver.xroute.RouteEvent {

        private int waypointIndexField;
        private bool waypointIndexFieldSpecified;
        private string waypointNameField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int waypointIndex {
            get {
                return this.waypointIndexField;
            }
            set {
                this.waypointIndexField = value;
                this.RaisePropertyChanged("waypointIndex");
                this.waypointIndexFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool waypointIndexSpecified {
            get {
                return this.waypointIndexFieldSpecified;
            }
            set {
                this.waypointIndexFieldSpecified = value;
                this.RaisePropertyChanged("waypointIndexSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string waypointName {
            get {
                return this.waypointNameField;
            }
            set {
                this.waypointNameField = value;
                this.RaisePropertyChanged("waypointName");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public partial class WaypointNotLinkedLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string parameterField;
        private int[] waypointIndicesField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
                this.RaisePropertyChanged("parameter");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("waypointIndices", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int[] waypointIndices {
            get {
                return this.waypointIndicesField;
            }
            set {
                this.waypointIndicesField = value;
                this.RaisePropertyChanged("waypointIndices");
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public enum AccessType {
        /**
         * Indicates the entering of a range of segments.
         */
        ENTER,

        /**
         * Indicates the exiting of a range of segments.
         */
        EXIT,

        /**
         * Indicates that the range is very small.
         */
        PASS
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public enum ManeuverType {
        /**
         * Denotes the departure at an <a href="xroute.html#com.ptvgroup.xserver.xroute.OnRoadWaypoint">OnRoadWaypoint</a>.
         */
        START,

        /**
         * Denotes the departure at an <a href="xroute.html#com.ptvgroup.xserver.xroute.OffRoadWaypoint">OffRoadWaypoint</a> to begin the route to the left.
         */
        START_LEFT,

        /**
         * Denotes the departure at an <a href="xroute.html#com.ptvgroup.xserver.xroute.OffRoadWaypoint">OffRoadWaypoint</a> to begin the route to the right.
         */
        START_RIGHT,

        /**
         * Denotes the arrival at an <a href="xroute.html#com.ptvgroup.xserver.xroute.OnRoadWaypoint">OnRoadWaypoint</a>.
         */
        ARRIVE,

        /**
         * Denotes the arrival at an <a href="xroute.html#com.ptvgroup.xserver.xroute.OffRoadWaypoint">OffRoadWaypoint</a> if the waypoint is on the left.
         */
        ARRIVE_LEFT,

        /**
         * Denotes the arrival at an <a href="xroute.html#com.ptvgroup.xserver.xroute.OffRoadWaypoint">OffRoadWaypoint</a> if the waypoint is on the right.
         */
        ARRIVE_RIGHT,

        /**
         * Indicates to follow the current road.
* Usually such a maneuver occurs when the road attributation changes although the road goes straight.
         */
        CONTINUE,

        /**
         * Indicates to stay on the straight lane.
* This is usually in fork-shaped intersections with more than two spikes.
         */
        KEEP_STRAIGHT,

        /**
         * Indicates to keep left or to take the left lanee.
* This usually occurs in Y-shaped intersections.
         */
        KEEP_LEFT,

        /**
         * Indicates to keep right or to take the right lane.
* This usually occurs in Y-shaped intersections.
         */
        KEEP_RIGHT,

        /**
         * Indicates to turn half left at a crossing where at least one additional trailing road exists.
* Usually this occurs at T- or X-shaped crossings on urban or country roads.
* Even if the name of the turning road does not change a maneuver will be created.
         */
        TURN_HALF_LEFT,

        /**
         * Indicates to turn left at a crossing where at least one additional trailing road exists.
* Usually this occurs at T- or X-shaped crossings on urban or country roads.
* Even if the name of the turning road does not change a maneuver will be created.
         */
        TURN_LEFT,

        /**
         * Indicates to turn sharp left at a crossing where at least one additional trailing road exists.
* Usually this occurs at T- or X-shaped crossings on urban or country roads.
* Even if the name of the turning road does not change a maneuver will be created.
         */
        TURN_SHARP_LEFT,

        /**
         * Indicates to turn half right at a crossing where at least one additional trailing road exists.
* Usually this occurs at T- or X-shaped crossings on urban or country roads.
* Even if the name of the turning road does not change a maneuver will be created.
         */
        TURN_HALF_RIGHT,

        /**
         * Indicates to turn right at a crossing where at least one additional trailing road exists.
* Usually this occurs at T- or X-shaped crossings on urban or country roads.
* Even if the name of the turning road does not change a maneuver will be created.
         */
        TURN_RIGHT,

        /**
         * Indicates to turn sharp right at a crossing where at least one additional trailing road exists.
* Usually this occurs at T- or X-shaped crossings on urban or country roads.
* Even if the name of the turning road does not change a maneuver will be created.
         */
        TURN_SHARP_RIGHT,

        /**
         * Indicates to make a U-turn. Either at the same road or at structurally separated roads.
* The <a href="xroute.html#com.ptvgroup.xserver.xroute.ManeuverEvent.relativeDirection">ManeuverEvent.relativeDirection</a> indicates whether to turn left or right.
         */
        MAKE_U_TURN,

        /**
         * Indicates to enter a roundabout to the left and leave it at the given roundaboutExit.
* Only drivable roads of the roundabout are counted.
         */
        TAKE_ROUNDABOUT_LEFT,

        /**
         * Indicates to enter a roundabout to the right and leave it at the given roundaboutExit.
* Only drivable roads of the roundabout are counted.
         */
        TAKE_ROUNDABOUT_RIGHT,

        /**
         * Indicates to take a railferry or a ferryboat. There is no direction available in this case.
         */
        TAKE_COMBINED_TRANSPORT,

        /**
         * Indicates to enter a highway/freeway/major road straight.
         */
        ENTER,

        /**
         * Indicates to enter a highway/freeway/major road to the left.
         */
        ENTER_LEFT,

        /**
         * Indicates to enter a highway/freeway/major road to the right.
         */
        ENTER_RIGHT,

        /**
         * Indicates to leave a highway/freeway/major road straight.
         */
        EXIT,

        /**
         * Indicates to leave a highway/freeway/major road to the left.
         */
        EXIT_LEFT,

        /**
         * Indicates to leave a highway/freeway/major road to the right.
         */
        EXIT_RIGHT,

        /**
         * Indicates to change straight to another highway/freeway at an interchange.
         */
        CHANGE,

        /**
         * Indicates to change to the left to another highway/freeway at an interchange.
         */
        CHANGE_LEFT,

        /**
         * Indicates to change to the right to another highway/freeway at an interchange.
         */
        CHANGE_RIGHT
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public enum NodeType {
        /**
         * Node is present in the underlying routing network.
         */
        NETWORK_NODE,

        /**
         * Virtual <a href="xroute.html#com.ptvgroup.xserver.xroute.Node">node</a> on a <a href="xroute.html#com.ptvgroup.xserver.xroute.Segment">segment</a> in the underlying routing network to which an <a href="xroute.html#com.ptvgroup.xserver.xroute.NodeType.INPUT_NODE">NodeType.INPUT_NODE</a> is linked.
         */
        LINK_NODE,

        /**
         * Virtual <a href="xroute.html#com.ptvgroup.xserver.xroute.Node">node</a> representing a user provided <a href="xroute.html#com.ptvgroup.xserver.xroute.InputWaypoint">input waypoint</a>.
         */
        INPUT_NODE
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public enum PaymentMethod {
        /**
         * Pay with an electronic toll collection system for which a subscription is required.
         */
        ELECTRONIC_TOLL_COLLECTION_SUBSCRIPTION,

        /**
         * Pay with some electronic toll collection system for which no prior subscription is required.
         */
        ELECTRONIC_TOLL_COLLECTION,

        /**
         * Pay with cash at a toll booth.
         */
        CASH,

        /**
         * Pay with credit card at a toll booth.
         */
        CREDIT_CARD,

        /**
         * Fallback value to be substituted for enumeration values which were added in an API version that is newer than the request version. When using the current API, this value will never be returned.
         */
        UNSPECIFIED
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public enum ReachableAreasCalculationMode {
        /**
         * The calculation is fast but produces a polygon which gives only a rough overview on the reachable areas.
* Use this mode to get a quick response on large horizons.
         */
        PERFORMANCE,

        /**
         * The calculation produces an exact polygon for the reachable areas including minor roads but is less performant.
* Use this mode to get good results and with small horizons.
* It is strongly recommended to call the operation asynchronously as the response times tend to be much longer.
         */
        QUALITY
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public enum ReachableAreasDrivingDirection {
        /**
         * Indicates an inbound routing from destination to start, i.e. from where the location can be reached
* within the given horizon.
* Use this value to calculate the catchment area, e.g. of a school or a hospital.
         */
        INBOUND,

        /**
         * Indicates an outbound routing from start to destination, i.e. what area can be reached from the location
* within the given horizon.
* Use this value to calculate which can be covered e.g. by an emergency service such as a fire department.
         */
        OUTBOUND
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public enum ReachableLocationsSearchType {
        /**
         * The location should be reachable from the waypoint in a certain horizon.
         */
        LOCATION_REACHABLE_FROM_WAYPOINT,

        /**
         * The waypoint should be reachable from the location in a certain horizon.
         */
        WAYPOINT_REACHABLE_FROM_LOCATION
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public enum RouteEventType {
        /**
         * This event type indicates that the driver has to take an action, e.g. turn left or right.
         */
        MANEUVER_EVENT,

        /**
         * This event type indicates that a tour information is available at this position.
         */
        TOUR_EVENT,

        /**
         * This event type indicates that a toll road is entered, exited or a toll booth is passed.
         */
        TOLL_EVENT,

        /**
         * This event type indicates that a waypoint is reached by the route.
         */
        WAYPOINT_EVENT,

        /**
         * This event type indicates that there is a route violation starting or ending at this position.
         */
        ROUTE_VIOLATION_EVENT,

        /**
         * This event type indicates that the offset to UTC changes.
         */
        UTC_OFFSET_EVENT,

        /**
         * This event type indicates that a border between countries or subdivisions is crossed, i.e. the country code changes.
         */
        COUNTRY_EVENT,

        /**
         * This event type indicates that a combined transport is entered or exited.
         */
        COMBINED_TRANSPORT_EVENT
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public enum RouteViolationType {
        /**
         * The violated segment is prohibited in general for the current vehicle. See <a href="segments.html#com.ptvgroup.xserver.segments.RoadAttributes.prohibited">road attribute 'prohibited'</a>.
         */
        PROHIBITED,

        /**
         * The violated segment is prohibited except for delivery reasons but delivery is disallowed for the current vehicle. See <a href="segments.html#com.ptvgroup.xserver.segments.RoadAttributes.deliveryOnly">road attribute 'deliveryOnly'</a>.
         */
        DELIVERY_ONLY,

        /**
         * The violated segment is prohibited because it is flagged as urban. See <a href="segments.html#com.ptvgroup.xserver.segments.RoadAttributes.urban">road attribute 'urban'</a>.
         */
        URBAN,

        /**
         * The violated segment is prohibited because it is flagged as residents only for the current vehicle. See <a href="segments.html#com.ptvgroup.xserver.segments.RoadAttributes.residentsOnly">road attribute 'residentsOnly'</a>.
         */
        RESIDENTS_ONLY,

        /**
         * A point with restricted access, e.g. a gate or a bollard was passed.
         */
        RESTRICTED_ACCESS,

        /**
         * The violated segment has an attribute from some enabled Feature Layer theme
* which prohibits to pass with the current vehicle (e.g. a weight or height restriction).
         */
        FEATURE,

        /**
         * The violated segment is a ferry or a piggyback prohibited for the current vehicle.
         */
        COMBINED_TRANSPORT,

        /**
         * Fallback value to be substituted for enumeration values which were added in an API version that is newer than the request version.
         */
        UNSPECIFIED
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xroute.xserver.ptvgroup.com")]
    public enum TollRoadType {
        /**
         * A general toll road.
         */
        GENERAL,

        /**
         * The toll is charged because a whole city is subject to toll.
         */
        CITY,

        /**
         * The toll is charged because of a bridge.
         */
        BRIDGE,

        /**
         * The toll is charged because of a tunnel.
         */
        TUNNEL,

        /**
         * The toll is charged because of a ferry.
         */
        FERRY,

        /**
         * The toll is charged because of a mountain pass.
         */
        MOUNTAIN_PASS,

        /**
         * Fallback value to be substituted for enumeration values which were added in an API version that is newer than the request version. When using the current API, this value will never be returned.
         */
        UNSPECIFIED
    }


}
