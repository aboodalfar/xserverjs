// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.routingprofile 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class CombinedTransport : object, System.ComponentModel.INotifyPropertyChanged {

        private int boatPenaltyField;
        private bool boatPenaltyFieldSpecified;
        private int railPenaltyField;
        private bool railPenaltyFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int boatPenalty {
            get {
                return this.boatPenaltyField;
            }
            set {
                this.boatPenaltyField = value;
                this.RaisePropertyChanged("boatPenalty");
                this.boatPenaltyFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool boatPenaltySpecified {
            get {
                return this.boatPenaltyFieldSpecified;
            }
            set {
                this.boatPenaltyFieldSpecified = value;
                this.RaisePropertyChanged("boatPenaltySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int railPenalty {
            get {
                return this.railPenaltyField;
            }
            set {
                this.railPenaltyField = value;
                this.RaisePropertyChanged("railPenalty");
                this.railPenaltyFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool railPenaltySpecified {
            get {
                return this.railPenaltyFieldSpecified;
            }
            set {
                this.railPenaltyFieldSpecified = value;
                this.RaisePropertyChanged("railPenaltySpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class Course : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routingprofile.Violations violationsField;
        private com.ptvgroup.xserver.routingprofile.Network networkField;
        private com.ptvgroup.xserver.routingprofile.Toll tollField;
        private com.ptvgroup.xserver.routingprofile.SpecialAreas specialAreasField;
        private com.ptvgroup.xserver.routingprofile.CombinedTransport combinedTransportField;
        private com.ptvgroup.xserver.routingprofile.Maneuver maneuverField;
        private double distanceTimeWeightingField;
        private bool distanceTimeWeightingFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("violations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.Violations violations {
            get {
                return this.violationsField;
            }
            set {
                this.violationsField = value;
                this.RaisePropertyChanged("violations");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("network", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.Network network {
            get {
                return this.networkField;
            }
            set {
                this.networkField = value;
                this.RaisePropertyChanged("network");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("toll", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.Toll toll {
            get {
                return this.tollField;
            }
            set {
                this.tollField = value;
                this.RaisePropertyChanged("toll");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("specialAreas", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.SpecialAreas specialAreas {
            get {
                return this.specialAreasField;
            }
            set {
                this.specialAreasField = value;
                this.RaisePropertyChanged("specialAreas");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("combinedTransport", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.CombinedTransport combinedTransport {
            get {
                return this.combinedTransportField;
            }
            set {
                this.combinedTransportField = value;
                this.RaisePropertyChanged("combinedTransport");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("maneuver", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.Maneuver maneuver {
            get {
                return this.maneuverField;
            }
            set {
                this.maneuverField = value;
                this.RaisePropertyChanged("maneuver");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double distanceTimeWeighting {
            get {
                return this.distanceTimeWeightingField;
            }
            set {
                this.distanceTimeWeightingField = value;
                this.RaisePropertyChanged("distanceTimeWeighting");
                this.distanceTimeWeightingFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool distanceTimeWeightingSpecified {
            get {
                return this.distanceTimeWeightingFieldSpecified;
            }
            set {
                this.distanceTimeWeightingFieldSpecified = value;
                this.RaisePropertyChanged("distanceTimeWeightingSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class ExcludeByNetworkClass : object, System.ComponentModel.INotifyPropertyChanged {

        private string[] minimumDistancesFromWaypointField;

                    [System.Xml.Serialization.XmlElementAttribute("minimumDistancesFromWaypoint", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] minimumDistancesFromWaypoint {
            get {
                return this.minimumDistancesFromWaypointField;
            }
            set {
                this.minimumDistancesFromWaypointField = value;
                this.RaisePropertyChanged("minimumDistancesFromWaypoint");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class IntersectionTurnCosts : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routingprofile.TurnStrategy turnStrategyField;
        private bool turnStrategyFieldSpecified;
        private string customTurnStrategyField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.routingprofile.TurnStrategy turnStrategy {
            get {
                return this.turnStrategyField;
            }
            set {
                this.turnStrategyField = value;
                this.RaisePropertyChanged("turnStrategy");
                this.turnStrategyFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool turnStrategySpecified {
            get {
                return this.turnStrategyFieldSpecified;
            }
            set {
                this.turnStrategyFieldSpecified = value;
                this.RaisePropertyChanged("turnStrategySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string customTurnStrategy {
            get {
                return this.customTurnStrategyField;
            }
            set {
                this.customTurnStrategyField = value;
                this.RaisePropertyChanged("customTurnStrategy");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class Linking : object, System.ComponentModel.INotifyPropertyChanged {

        private double maximumDistanceToSegmentField;
        private bool maximumDistanceToSegmentFieldSpecified;
        private int minimumNetworkClassField;
        private bool minimumNetworkClassFieldSpecified;
        private int maximumNetworkClassField;
        private bool maximumNetworkClassFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumDistanceToSegment {
            get {
                return this.maximumDistanceToSegmentField;
            }
            set {
                this.maximumDistanceToSegmentField = value;
                this.RaisePropertyChanged("maximumDistanceToSegment");
                this.maximumDistanceToSegmentFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumDistanceToSegmentSpecified {
            get {
                return this.maximumDistanceToSegmentFieldSpecified;
            }
            set {
                this.maximumDistanceToSegmentFieldSpecified = value;
                this.RaisePropertyChanged("maximumDistanceToSegmentSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int minimumNetworkClass {
            get {
                return this.minimumNetworkClassField;
            }
            set {
                this.minimumNetworkClassField = value;
                this.RaisePropertyChanged("minimumNetworkClass");
                this.minimumNetworkClassFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimumNetworkClassSpecified {
            get {
                return this.minimumNetworkClassFieldSpecified;
            }
            set {
                this.minimumNetworkClassFieldSpecified = value;
                this.RaisePropertyChanged("minimumNetworkClassSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumNetworkClass {
            get {
                return this.maximumNetworkClassField;
            }
            set {
                this.maximumNetworkClassField = value;
                this.RaisePropertyChanged("maximumNetworkClass");
                this.maximumNetworkClassFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumNetworkClassSpecified {
            get {
                return this.maximumNetworkClassFieldSpecified;
            }
            set {
                this.maximumNetworkClassFieldSpecified = value;
                this.RaisePropertyChanged("maximumNetworkClassSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class Maneuver : object, System.ComponentModel.INotifyPropertyChanged {

        private int uTurnCostField;
        private bool uTurnCostFieldSpecified;
        private int highPerformanceRoutingUTurnCostField;
        private bool highPerformanceRoutingUTurnCostFieldSpecified;
        private bool considerTurningBansField;
        private bool considerTurningBansFieldSpecified;
        private bool useFastTurningBanHeuristicField;
        private bool useFastTurningBanHeuristicFieldSpecified;
        private com.ptvgroup.xserver.routingprofile.IntersectionTurnCosts intersectionTurnCostsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int uTurnCost {
            get {
                return this.uTurnCostField;
            }
            set {
                this.uTurnCostField = value;
                this.RaisePropertyChanged("uTurnCost");
                this.uTurnCostFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uTurnCostSpecified {
            get {
                return this.uTurnCostFieldSpecified;
            }
            set {
                this.uTurnCostFieldSpecified = value;
                this.RaisePropertyChanged("uTurnCostSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int highPerformanceRoutingUTurnCost {
            get {
                return this.highPerformanceRoutingUTurnCostField;
            }
            set {
                this.highPerformanceRoutingUTurnCostField = value;
                this.RaisePropertyChanged("highPerformanceRoutingUTurnCost");
                this.highPerformanceRoutingUTurnCostFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool highPerformanceRoutingUTurnCostSpecified {
            get {
                return this.highPerformanceRoutingUTurnCostFieldSpecified;
            }
            set {
                this.highPerformanceRoutingUTurnCostFieldSpecified = value;
                this.RaisePropertyChanged("highPerformanceRoutingUTurnCostSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool considerTurningBans {
            get {
                return this.considerTurningBansField;
            }
            set {
                this.considerTurningBansField = value;
                this.RaisePropertyChanged("considerTurningBans");
                this.considerTurningBansFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool considerTurningBansSpecified {
            get {
                return this.considerTurningBansFieldSpecified;
            }
            set {
                this.considerTurningBansFieldSpecified = value;
                this.RaisePropertyChanged("considerTurningBansSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool useFastTurningBanHeuristic {
            get {
                return this.useFastTurningBanHeuristicField;
            }
            set {
                this.useFastTurningBanHeuristicField = value;
                this.RaisePropertyChanged("useFastTurningBanHeuristic");
                this.useFastTurningBanHeuristicFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useFastTurningBanHeuristicSpecified {
            get {
                return this.useFastTurningBanHeuristicFieldSpecified;
            }
            set {
                this.useFastTurningBanHeuristicFieldSpecified = value;
                this.RaisePropertyChanged("useFastTurningBanHeuristicSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("intersectionTurnCosts", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.IntersectionTurnCosts intersectionTurnCosts {
            get {
                return this.intersectionTurnCostsField;
            }
            set {
                this.intersectionTurnCostsField = value;
                this.RaisePropertyChanged("intersectionTurnCosts");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class Network : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routingprofile.PenaltiesByNetworkClass penaltiesByNetworkClassField;
        private int rampPenaltyField;
        private bool rampPenaltyFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("penaltiesByNetworkClass", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.PenaltiesByNetworkClass penaltiesByNetworkClass {
            get {
                return this.penaltiesByNetworkClassField;
            }
            set {
                this.penaltiesByNetworkClassField = value;
                this.RaisePropertyChanged("penaltiesByNetworkClass");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int rampPenalty {
            get {
                return this.rampPenaltyField;
            }
            set {
                this.rampPenaltyField = value;
                this.RaisePropertyChanged("rampPenalty");
                this.rampPenaltyFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rampPenaltySpecified {
            get {
                return this.rampPenaltyFieldSpecified;
            }
            set {
                this.rampPenaltyFieldSpecified = value;
                this.RaisePropertyChanged("rampPenaltySpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class PenaltiesByNetworkClass : object, System.ComponentModel.INotifyPropertyChanged {

        private int[] penaltiesField;

                    [System.Xml.Serialization.XmlElementAttribute("penalties", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int[] penalties {
            get {
                return this.penaltiesField;
            }
            set {
                this.penaltiesField = value;
                this.RaisePropertyChanged("penalties");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class RoutingProfile : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routingprofile.Linking linkingField;
        private com.ptvgroup.xserver.routingprofile.SearchSpace searchSpaceField;
        private com.ptvgroup.xserver.routingprofile.Course courseField;

                    [System.Xml.Serialization.XmlElementAttribute("linking", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.Linking linking {
            get {
                return this.linkingField;
            }
            set {
                this.linkingField = value;
                this.RaisePropertyChanged("linking");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("searchSpace", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.SearchSpace searchSpace {
            get {
                return this.searchSpaceField;
            }
            set {
                this.searchSpaceField = value;
                this.RaisePropertyChanged("searchSpace");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("course", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.Course course {
            get {
                return this.courseField;
            }
            set {
                this.courseField = value;
                this.RaisePropertyChanged("course");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class SearchSpace : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routingprofile.ExcludeByNetworkClass excludeByNetworkClassField;
        private double heuristicAggressivenessField;
        private bool heuristicAggressivenessFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("excludeByNetworkClass", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routingprofile.ExcludeByNetworkClass excludeByNetworkClass {
            get {
                return this.excludeByNetworkClassField;
            }
            set {
                this.excludeByNetworkClassField = value;
                this.RaisePropertyChanged("excludeByNetworkClass");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double heuristicAggressiveness {
            get {
                return this.heuristicAggressivenessField;
            }
            set {
                this.heuristicAggressivenessField = value;
                this.RaisePropertyChanged("heuristicAggressiveness");
                this.heuristicAggressivenessFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heuristicAggressivenessSpecified {
            get {
                return this.heuristicAggressivenessFieldSpecified;
            }
            set {
                this.heuristicAggressivenessFieldSpecified = value;
                this.RaisePropertyChanged("heuristicAggressivenessSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class SpecialAreas : object, System.ComponentModel.INotifyPropertyChanged {

        private int residentsOnlyPenaltyField;
        private bool residentsOnlyPenaltyFieldSpecified;
        private int urbanPenaltyField;
        private bool urbanPenaltyFieldSpecified;
        private int minimumUrbanNetworkClassField;
        private bool minimumUrbanNetworkClassFieldSpecified;
        private int forbiddenLowEmissionZonePenaltyField;
        private bool forbiddenLowEmissionZonePenaltyFieldSpecified;
        private int deliveryOnlyPenaltyField;
        private bool deliveryOnlyPenaltyFieldSpecified;
        private int deliveryOnlyGateCostField;
        private bool deliveryOnlyGateCostFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int residentsOnlyPenalty {
            get {
                return this.residentsOnlyPenaltyField;
            }
            set {
                this.residentsOnlyPenaltyField = value;
                this.RaisePropertyChanged("residentsOnlyPenalty");
                this.residentsOnlyPenaltyFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool residentsOnlyPenaltySpecified {
            get {
                return this.residentsOnlyPenaltyFieldSpecified;
            }
            set {
                this.residentsOnlyPenaltyFieldSpecified = value;
                this.RaisePropertyChanged("residentsOnlyPenaltySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int urbanPenalty {
            get {
                return this.urbanPenaltyField;
            }
            set {
                this.urbanPenaltyField = value;
                this.RaisePropertyChanged("urbanPenalty");
                this.urbanPenaltyFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool urbanPenaltySpecified {
            get {
                return this.urbanPenaltyFieldSpecified;
            }
            set {
                this.urbanPenaltyFieldSpecified = value;
                this.RaisePropertyChanged("urbanPenaltySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int minimumUrbanNetworkClass {
            get {
                return this.minimumUrbanNetworkClassField;
            }
            set {
                this.minimumUrbanNetworkClassField = value;
                this.RaisePropertyChanged("minimumUrbanNetworkClass");
                this.minimumUrbanNetworkClassFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimumUrbanNetworkClassSpecified {
            get {
                return this.minimumUrbanNetworkClassFieldSpecified;
            }
            set {
                this.minimumUrbanNetworkClassFieldSpecified = value;
                this.RaisePropertyChanged("minimumUrbanNetworkClassSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int forbiddenLowEmissionZonePenalty {
            get {
                return this.forbiddenLowEmissionZonePenaltyField;
            }
            set {
                this.forbiddenLowEmissionZonePenaltyField = value;
                this.RaisePropertyChanged("forbiddenLowEmissionZonePenalty");
                this.forbiddenLowEmissionZonePenaltyFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool forbiddenLowEmissionZonePenaltySpecified {
            get {
                return this.forbiddenLowEmissionZonePenaltyFieldSpecified;
            }
            set {
                this.forbiddenLowEmissionZonePenaltyFieldSpecified = value;
                this.RaisePropertyChanged("forbiddenLowEmissionZonePenaltySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int deliveryOnlyPenalty {
            get {
                return this.deliveryOnlyPenaltyField;
            }
            set {
                this.deliveryOnlyPenaltyField = value;
                this.RaisePropertyChanged("deliveryOnlyPenalty");
                this.deliveryOnlyPenaltyFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deliveryOnlyPenaltySpecified {
            get {
                return this.deliveryOnlyPenaltyFieldSpecified;
            }
            set {
                this.deliveryOnlyPenaltyFieldSpecified = value;
                this.RaisePropertyChanged("deliveryOnlyPenaltySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int deliveryOnlyGateCost {
            get {
                return this.deliveryOnlyGateCostField;
            }
            set {
                this.deliveryOnlyGateCostField = value;
                this.RaisePropertyChanged("deliveryOnlyGateCost");
                this.deliveryOnlyGateCostFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deliveryOnlyGateCostSpecified {
            get {
                return this.deliveryOnlyGateCostFieldSpecified;
            }
            set {
                this.deliveryOnlyGateCostFieldSpecified = value;
                this.RaisePropertyChanged("deliveryOnlyGateCostSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class Toll : object, System.ComponentModel.INotifyPropertyChanged {

        private int tollPenaltyField;
        private bool tollPenaltyFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int tollPenalty {
            get {
                return this.tollPenaltyField;
            }
            set {
                this.tollPenaltyField = value;
                this.RaisePropertyChanged("tollPenalty");
                this.tollPenaltyFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tollPenaltySpecified {
            get {
                return this.tollPenaltyFieldSpecified;
            }
            set {
                this.tollPenaltyFieldSpecified = value;
                this.RaisePropertyChanged("tollPenaltySpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public partial class Violations : object, System.ComponentModel.INotifyPropertyChanged {

        private bool enabledField;
        private bool enabledFieldSpecified;
        private int costField;
        private bool costFieldSpecified;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routingprofile.xserver.ptvgroup.com")]
    public enum TurnStrategy {
        /**
         * No additional cost is applied.
         */
        NONE,

        /**
         * Additional costs are applied on driver side turns.
         */
        PREFER_PASSENGER_SIDE_TURNS,

        /**
         * Custom costs are applied.
         */
        CUSTOM
    }


}
