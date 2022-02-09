// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.service 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class DeprecatedParameterLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string parameterField;

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class FeatureLayerMatchLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string themeIdField;
        private string[] countriesField;

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

                    [System.Xml.Serialization.XmlElementAttribute("countries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] countries {
            get {
                return this.countriesField;
            }
            set {
                this.countriesField = value;
                this.RaisePropertyChanged("countries");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class FeatureLayerNotAvailableLimitation : com.ptvgroup.xserver.service.ResultLimitation {

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class FeatureNotAvailableLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string featureField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string feature {
            get {
                return this.featureField;
            }
            set {
                this.featureField = value;
                this.RaisePropertyChanged("feature");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class FeatureNotLicensedLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string keyField;

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class GeometryOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.geometry.EncodedGeometryType[] responseGeometryTypesField;

                    [System.Xml.Serialization.XmlElementAttribute("responseGeometryTypes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.EncodedGeometryType[] responseGeometryTypes {
            get {
                return this.responseGeometryTypesField;
            }
            set {
                this.responseGeometryTypesField = value;
                this.RaisePropertyChanged("responseGeometryTypes");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class IntermediateResponseLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private com.ptvgroup.xserver.service.IntermediateResponseReason reasonField;
        private bool reasonFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.service.IntermediateResponseReason reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
                this.RaisePropertyChanged("reason");
                this.reasonFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reasonSpecified {
            get {
                return this.reasonFieldSpecified;
            }
            set {
                this.reasonFieldSpecified = value;
                this.RaisePropertyChanged("reasonSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class ObjectNotStoredLimitation : com.ptvgroup.xserver.service.ResultLimitation {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class ParameterIgnoredLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string ignoredParameterField;
        private string requiredParameterField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ignoredParameter {
            get {
                return this.ignoredParameterField;
            }
            set {
                this.ignoredParameterField = value;
                this.RaisePropertyChanged("ignoredParameter");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requiredParameter {
            get {
                return this.requiredParameterField;
            }
            set {
                this.requiredParameterField = value;
                this.RaisePropertyChanged("requiredParameter");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class ParameterInconsistencyLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string parameterField;
        private string valueField;

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


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xcluster.CoverLocationsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xcluster.OptimizeVisitSequenceRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xcluster.PlanClustersRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xcluster.PlanVisitsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.CreateContentSnapshotRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.CreateFeatureLayerRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.CreateHighPerformanceRoutingNetworkRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.DeleteContentSnapshotRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.DeleteFeatureLayerRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.DeleteHighPerformanceRoutingNetworkRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.ListContentSnapshotsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.ListFeatureLayersRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.ListHighPerformanceRoutingNetworksRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.SegmentsByCoordinateRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.SegmentsByIdRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.SegmentsByIntersectingPolylineRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.SegmentsBySurroundingPolygonRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.SegmentsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.TimeZoneRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.CreateAndGetDistanceMatrixRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.CreateDistanceMatrixRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.DeleteDistanceMatrixRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.ExtendDistanceMatrixRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.GetDistanceMatrixByLocationsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.GetDistanceMatrixByRelationsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.GetDistanceMatrixRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.ListDistanceMatricesRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.UpdateDistanceMatrixRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xload.PackBinsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xload.PackPositionedBinsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByAddressBulkRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByAddressRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByPositionBulkRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByPositionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByTextBulkRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchByTextRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchLocationsBulkRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.SearchLocationsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xmap.MapRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xmatch.MatchPositionsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xmatch.MatchTrackRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.ProfileRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.ReachableAreasRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.ReachableLocationsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.RouteRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ConfigurationFileRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ContentUpdateStatusRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ContentUpdateTriggerRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatusRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ConversionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.DataInformationRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.LicenseInformationRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ResetMetricsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.RestartModulesRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.RuntimeInformationRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ServerConfigurationRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ShutdownServerRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.StopDeleteRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.SupportPackageRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.ChangeToursRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.FindChangeToursProposalsRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.PlanToursRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.ToursInExecutionRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public abstract partial class RequestBase : object, System.ComponentModel.INotifyPropertyChanged {

        private string scopeField;
        private string storedProfileField;
        private com.ptvgroup.xserver.profile.RequestProfile requestProfileField;
        private string coordinateFormatField;
        private com.ptvgroup.xserver.service.GeometryOptions geometryOptionsField;
        private com.ptvgroup.xserver.service.Timeouts timeoutsField;
        private string[] userLogsField;

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

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string storedProfile {
            get {
                return this.storedProfileField;
            }
            set {
                this.storedProfileField = value;
                this.RaisePropertyChanged("storedProfile");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("requestProfile", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.profile.RequestProfile requestProfile {
            get {
                return this.requestProfileField;
            }
            set {
                this.requestProfileField = value;
                this.RaisePropertyChanged("requestProfile");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string coordinateFormat {
            get {
                return this.coordinateFormatField;
            }
            set {
                this.coordinateFormatField = value;
                this.RaisePropertyChanged("coordinateFormat");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("geometryOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.service.GeometryOptions geometryOptions {
            get {
                return this.geometryOptionsField;
            }
            set {
                this.geometryOptionsField = value;
                this.RaisePropertyChanged("geometryOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("timeouts", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.service.Timeouts timeouts {
            get {
                return this.timeoutsField;
            }
            set {
                this.timeoutsField = value;
                this.RaisePropertyChanged("timeouts");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("userLogs", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] userLogs {
            get {
                return this.userLogsField;
            }
            set {
                this.userLogsField = value;
                this.RaisePropertyChanged("userLogs");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.VoidResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xcluster.ClustersResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xcluster.VisitSequenceResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xcluster.VisitsResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.ContentSnapshotResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.ContentSnapshotsListResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.FeatureLayerResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.FeatureLayersListResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworksListResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.SegmentsResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.TimeZoneResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.DistanceMatrixListResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdima.DistanceMatrixResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xload.PackedBinsResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xload.PackedPositionedBinsResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.LocationsBulkResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.LocationsResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xmap.MapResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xmap.TileResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xmatch.PositionsResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xmatch.TrackResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.ProfileResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.ReachableAreasResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.ReachableLocationsResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.RouteResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ConfigurationFileResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ContentUpdateStatusResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ContentUpdateTriggerResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ContentUpdateTriggerStatusResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ConversionResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.DataInformationResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.LicenseInformation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.LogFileInformationResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.RuntimeInformation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.RuntimeMetrics))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.ServerConfigurationResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xruntime.SupportPackageResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.ChangeToursProposalsResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.ToursResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public abstract partial class ResponseBase : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.service.ResultLimitation[] resultLimitationsField;

                    [System.Xml.Serialization.XmlElementAttribute("resultLimitations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.service.ResultLimitation[] resultLimitations {
            get {
                return this.resultLimitationsField;
            }
            set {
                this.resultLimitationsField = value;
                this.RaisePropertyChanged("resultLimitations");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.routing.CountryIgnoredLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.routing.GeographicRestrictionsIgnoredLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.routing.SubdivisionFallbackLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.DeprecatedParameterLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.FeatureLayerMatchLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.FeatureLayerNotAvailableLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.FeatureNotAvailableLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.FeatureNotLicensedLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.IntermediateResponseLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.ObjectNotStoredLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.ParameterIgnoredLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.ParameterInconsistencyLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.UTCOffsetAmbigiousLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.service.UTCOffsetNotDeterminableLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.timeconsideration.TimeDependentContentIgnoredLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkAlreadyAvailableLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xlocate.CountryFallbackLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.ElevationsNotAvailableLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.HeadingIgnoredLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.HeadingToleranceIgnoredLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.SideOfStreetRestrictionIgnoredLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.UnspecifiedMapDataLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xroute.WaypointNotLinkedLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.NoValidInsertionPositionsFoundLimitation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class ResultLimitation : object, System.ComponentModel.INotifyPropertyChanged {

        private string messageField;
        private string hintField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hint {
            get {
                return this.hintField;
            }
            set {
                this.hintField = value;
                this.RaisePropertyChanged("hint");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class Timeouts : object, System.ComponentModel.INotifyPropertyChanged {

        private int queueingTimeoutField;
        private bool queueingTimeoutFieldSpecified;
        private int computationTimeoutField;
        private bool computationTimeoutFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int queueingTimeout {
            get {
                return this.queueingTimeoutField;
            }
            set {
                this.queueingTimeoutField = value;
                this.RaisePropertyChanged("queueingTimeout");
                this.queueingTimeoutFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool queueingTimeoutSpecified {
            get {
                return this.queueingTimeoutFieldSpecified;
            }
            set {
                this.queueingTimeoutFieldSpecified = value;
                this.RaisePropertyChanged("queueingTimeoutSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int computationTimeout {
            get {
                return this.computationTimeoutField;
            }
            set {
                this.computationTimeoutField = value;
                this.RaisePropertyChanged("computationTimeout");
                this.computationTimeoutFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool computationTimeoutSpecified {
            get {
                return this.computationTimeoutFieldSpecified;
            }
            set {
                this.computationTimeoutFieldSpecified = value;
                this.RaisePropertyChanged("computationTimeoutSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class UTCOffsetAmbigiousLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private int utcOffsetField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int utcOffset {
            get {
                return this.utcOffsetField;
            }
            set {
                this.utcOffsetField = value;
                this.RaisePropertyChanged("utcOffset");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class UTCOffsetNotDeterminableLimitation : com.ptvgroup.xserver.service.ResultLimitation {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public partial class VoidResponse : com.ptvgroup.xserver.service.ResponseBase {



    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.xserver.ptvgroup.com")]
    public enum IntermediateResponseReason {
        /**
         * The request was stopped by calling the <code>stopRequest</code> method from <a href="xruntime.html#com.ptvgroup.xserver.xruntime.XRuntime">XRuntime</a> for synchronous
* or a service specific <code>stopJob</code> method for asynchronous requests, respectively.
         */
        REQUEST_STOPPED,

        /**
         * The request was stopped due to a timeout. For further information see <a href="service.html#com.ptvgroup.xserver.service.Timeouts.computationTimeout">Timeouts.computationTimeout</a>.
         */
        REQUEST_TIMED_OUT
    }


}
