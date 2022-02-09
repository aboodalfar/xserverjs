// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.dima 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dima.xserver.ptvgroup.com")]
    public partial class DirectDistance : com.ptvgroup.xserver.dima.DistanceMode {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.timeconsideration.TimeConsideration timeConsiderationField;
        private string contentSnapshotIdField;
        private string highPerformanceRoutingNetworkIdField;
        private com.ptvgroup.xserver.routing.GeographicRestrictions geographicRestrictionsField;
        private double detourFactorField;
        private bool detourFactorFieldSpecified;
        private double averageSpeedField;
        private bool averageSpeedFieldSpecified;
        private com.ptvgroup.xserver.routing.RoutingType routingTypeField;
        private bool routingTypeFieldSpecified;
        private bool persistTollCostsField;
        private bool persistTollCostsFieldSpecified;
        private string currencyField;
        private string binaryFeatureLayerField;
        private bool useDetailedTollField;
        private bool useDetailedTollFieldSpecified;

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

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double detourFactor {
            get {
                return this.detourFactorField;
            }
            set {
                this.detourFactorField = value;
                this.RaisePropertyChanged("detourFactor");
                this.detourFactorFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool detourFactorSpecified {
            get {
                return this.detourFactorFieldSpecified;
            }
            set {
                this.detourFactorFieldSpecified = value;
                this.RaisePropertyChanged("detourFactorSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double averageSpeed {
            get {
                return this.averageSpeedField;
            }
            set {
                this.averageSpeedField = value;
                this.RaisePropertyChanged("averageSpeed");
                this.averageSpeedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool averageSpeedSpecified {
            get {
                return this.averageSpeedFieldSpecified;
            }
            set {
                this.averageSpeedFieldSpecified = value;
                this.RaisePropertyChanged("averageSpeedSpecified");
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
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool persistTollCosts {
            get {
                return this.persistTollCostsField;
            }
            set {
                this.persistTollCostsField = value;
                this.RaisePropertyChanged("persistTollCosts");
                this.persistTollCostsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool persistTollCostsSpecified {
            get {
                return this.persistTollCostsFieldSpecified;
            }
            set {
                this.persistTollCostsFieldSpecified = value;
                this.RaisePropertyChanged("persistTollCostsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixProgress : com.ptvgroup.xserver.jobs.JobProgress {

        private com.ptvgroup.xserver.dima.ProgressStatus statusField;
        private double calculationProgressField;
        private bool calculationProgressFieldSpecified;
        private com.ptvgroup.xserver.routing.RoutingType routingTypeField;
        private bool routingTypeFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.dima.ProgressStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double calculationProgress {
            get {
                return this.calculationProgressField;
            }
            set {
                this.calculationProgressField = value;
                this.RaisePropertyChanged("calculationProgress");
                this.calculationProgressFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool calculationProgressSpecified {
            get {
                return this.calculationProgressFieldSpecified;
            }
            set {
                this.calculationProgressFieldSpecified = value;
                this.RaisePropertyChanged("calculationProgressSpecified");
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
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dima.xserver.ptvgroup.com")]
    public partial class DistanceMatrixSummary : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private int numberOfStartLocationsField;
        private int numberOfDestinationLocationsField;
        private double percentageOfDirectDistanceRelationsField;
        private com.ptvgroup.xserver.routing.RoutingType routingTypeField;
        private bool routingTypeFieldSpecified;
        private string labelField;

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
        public int numberOfStartLocations {
            get {
                return this.numberOfStartLocationsField;
            }
            set {
                this.numberOfStartLocationsField = value;
                this.RaisePropertyChanged("numberOfStartLocations");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfDestinationLocations {
            get {
                return this.numberOfDestinationLocationsField;
            }
            set {
                this.numberOfDestinationLocationsField = value;
                this.RaisePropertyChanged("numberOfDestinationLocations");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double percentageOfDirectDistanceRelations {
            get {
                return this.percentageOfDirectDistanceRelationsField;
            }
            set {
                this.percentageOfDirectDistanceRelationsField = value;
                this.RaisePropertyChanged("percentageOfDirectDistanceRelations");
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


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.dima.DirectDistance))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.dima.ExistingDistanceMatrix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.EstimateByReferenceMatrix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.ExistingDistanceMatrixPerVehicle))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dima.xserver.ptvgroup.com")]
    public abstract partial class DistanceMode : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dima.xserver.ptvgroup.com")]
    public partial class ExistingDistanceMatrix : com.ptvgroup.xserver.dima.DistanceMode {

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dima.xserver.ptvgroup.com")]
    public enum ProgressStatus {
        /**
         * Indicates that some tasks have to be done before calculating the matrix. For example loading high-performance routing networks.
         */
        PREPROCESSING,

        /**
         * The actual progress of this state is available in <a href="dima.html#com.ptvgroup.xserver.dima.DistanceMatrixProgress.calculationProgress">DistanceMatrixProgress.calculationProgress</a>.
         */
        CALCULATING_MATRIX,

        /**
         * Indicates that the calculation of the distance matrix is finished.
         */
        DONE
    }


}
