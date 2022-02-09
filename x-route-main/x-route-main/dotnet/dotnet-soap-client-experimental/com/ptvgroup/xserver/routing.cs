// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.routing 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public partial class CountryIgnoredLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string ignoredCountryCodeField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ignoredCountryCode {
            get {
                return this.ignoredCountryCodeField;
            }
            set {
                this.ignoredCountryCodeField = value;
                this.RaisePropertyChanged("ignoredCountryCode");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public partial class DistanceBasedHorizon : com.ptvgroup.xserver.routing.Horizon {

        private double distanceField;

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


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public partial class GeographicRestrictions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routing.SearchSpaceBounds searchSpaceBoundsField;
        private string[] allowedCountriesField;
        private string[] prohibitedCountriesField;

                    [System.Xml.Serialization.XmlElementAttribute("searchSpaceBounds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.routing.SearchSpaceBounds searchSpaceBounds {
            get {
                return this.searchSpaceBoundsField;
            }
            set {
                this.searchSpaceBoundsField = value;
                this.RaisePropertyChanged("searchSpaceBounds");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("allowedCountries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] allowedCountries {
            get {
                return this.allowedCountriesField;
            }
            set {
                this.allowedCountriesField = value;
                this.RaisePropertyChanged("allowedCountries");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("prohibitedCountries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] prohibitedCountries {
            get {
                return this.prohibitedCountriesField;
            }
            set {
                this.prohibitedCountriesField = value;
                this.RaisePropertyChanged("prohibitedCountries");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public partial class GeographicRestrictionsIgnoredLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string ignoredParameterField;
        private string relatedParameterField;
        private string ignoredValueField;
        private string relatedValueField;

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
        public string relatedParameter {
            get {
                return this.relatedParameterField;
            }
            set {
                this.relatedParameterField = value;
                this.RaisePropertyChanged("relatedParameter");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ignoredValue {
            get {
                return this.ignoredValueField;
            }
            set {
                this.ignoredValueField = value;
                this.RaisePropertyChanged("ignoredValue");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string relatedValue {
            get {
                return this.relatedValueField;
            }
            set {
                this.relatedValueField = value;
                this.RaisePropertyChanged("relatedValue");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.routing.DistanceBasedHorizon))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.routing.TravelTimeBasedHorizon))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public abstract partial class Horizon : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public partial class MonetaryCostOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private double costPerKilometerField;
        private bool costPerKilometerFieldSpecified;
        private double workingCostPerHourField;
        private bool workingCostPerHourFieldSpecified;
        private double costPerEnergyUnitField;
        private bool costPerEnergyUnitFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double costPerKilometer {
            get {
                return this.costPerKilometerField;
            }
            set {
                this.costPerKilometerField = value;
                this.RaisePropertyChanged("costPerKilometer");
                this.costPerKilometerFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costPerKilometerSpecified {
            get {
                return this.costPerKilometerFieldSpecified;
            }
            set {
                this.costPerKilometerFieldSpecified = value;
                this.RaisePropertyChanged("costPerKilometerSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double workingCostPerHour {
            get {
                return this.workingCostPerHourField;
            }
            set {
                this.workingCostPerHourField = value;
                this.RaisePropertyChanged("workingCostPerHour");
                this.workingCostPerHourFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool workingCostPerHourSpecified {
            get {
                return this.workingCostPerHourFieldSpecified;
            }
            set {
                this.workingCostPerHourFieldSpecified = value;
                this.RaisePropertyChanged("workingCostPerHourSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double costPerEnergyUnit {
            get {
                return this.costPerEnergyUnitField;
            }
            set {
                this.costPerEnergyUnitField = value;
                this.RaisePropertyChanged("costPerEnergyUnit");
                this.costPerEnergyUnitFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costPerEnergyUnitSpecified {
            get {
                return this.costPerEnergyUnitFieldSpecified;
            }
            set {
                this.costPerEnergyUnitFieldSpecified = value;
                this.RaisePropertyChanged("costPerEnergyUnitSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public partial class OffRoadRouteLocation : com.ptvgroup.xserver.routing.RouteLocation {

        private com.ptvgroup.xserver.geometry.Coordinate offRoadCoordinateField;
        private com.ptvgroup.xserver.geometry.Coordinate roadAccessCoordinateField;
        private com.ptvgroup.xserver.routing.SideOfStreetRestriction sideOfStreetRestrictionField;
        private bool sideOfStreetRestrictionFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("offRoadCoordinate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate offRoadCoordinate {
            get {
                return this.offRoadCoordinateField;
            }
            set {
                this.offRoadCoordinateField = value;
                this.RaisePropertyChanged("offRoadCoordinate");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("roadAccessCoordinate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate roadAccessCoordinate {
            get {
                return this.roadAccessCoordinateField;
            }
            set {
                this.roadAccessCoordinateField = value;
                this.RaisePropertyChanged("roadAccessCoordinate");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.routing.SideOfStreetRestriction sideOfStreetRestriction {
            get {
                return this.sideOfStreetRestrictionField;
            }
            set {
                this.sideOfStreetRestrictionField = value;
                this.RaisePropertyChanged("sideOfStreetRestriction");
                this.sideOfStreetRestrictionFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sideOfStreetRestrictionSpecified {
            get {
                return this.sideOfStreetRestrictionFieldSpecified;
            }
            set {
                this.sideOfStreetRestrictionFieldSpecified = value;
                this.RaisePropertyChanged("sideOfStreetRestrictionSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public partial class OnRoadRouteLocation : com.ptvgroup.xserver.routing.RouteLocation {

        private com.ptvgroup.xserver.geometry.Coordinate coordinateField;
        private bool considerAlternativeNearByRoadsField;
        private bool considerAlternativeNearByRoadsFieldSpecified;

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
        public bool considerAlternativeNearByRoads {
            get {
                return this.considerAlternativeNearByRoadsField;
            }
            set {
                this.considerAlternativeNearByRoadsField = value;
                this.RaisePropertyChanged("considerAlternativeNearByRoads");
                this.considerAlternativeNearByRoadsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool considerAlternativeNearByRoadsSpecified {
            get {
                return this.considerAlternativeNearByRoadsFieldSpecified;
            }
            set {
                this.considerAlternativeNearByRoadsFieldSpecified = value;
                this.RaisePropertyChanged("considerAlternativeNearByRoadsSpecified");
            }
        }
        

    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.routing.OffRoadRouteLocation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.routing.OnRoadRouteLocation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public abstract partial class RouteLocation : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public partial class SearchSpaceBounds : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.routing.RestrictionMode restrictionModeField;
        private bool restrictionModeFieldSpecified;
        private com.ptvgroup.xserver.geometry.Bounds customBoundsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.routing.RestrictionMode restrictionMode {
            get {
                return this.restrictionModeField;
            }
            set {
                this.restrictionModeField = value;
                this.RaisePropertyChanged("restrictionMode");
                this.restrictionModeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restrictionModeSpecified {
            get {
                return this.restrictionModeFieldSpecified;
            }
            set {
                this.restrictionModeFieldSpecified = value;
                this.RaisePropertyChanged("restrictionModeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("customBounds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Bounds customBounds {
            get {
                return this.customBoundsField;
            }
            set {
                this.customBoundsField = value;
                this.RaisePropertyChanged("customBounds");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public partial class SubdivisionFallbackLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string requestedSubdivisionCodeField;
        private string fallbackCountryCodeField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestedSubdivisionCode {
            get {
                return this.requestedSubdivisionCodeField;
            }
            set {
                this.requestedSubdivisionCodeField = value;
                this.RaisePropertyChanged("requestedSubdivisionCode");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fallbackCountryCode {
            get {
                return this.fallbackCountryCodeField;
            }
            set {
                this.fallbackCountryCodeField = value;
                this.RaisePropertyChanged("fallbackCountryCode");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public partial class TravelTimeBasedHorizon : com.ptvgroup.xserver.routing.Horizon {

        private double travelTimeField;

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


    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public enum RestrictionMode {
        /**
         * No restriction by bounding box.
         */
        NONE,

        /**
         * Use a bounding box automatically calculated from the route locations to restrict the search space.
         */
        AUTOMATIC,

        /**
         * Use the custom bounding box to restrict the search space.
         */
        CUSTOM
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public enum RouteCalculationCriteria {
        /**
         * Calculate the route according to the best abstract costs based on distance time weighting and penalties.
         */
        ABSTRACT_COSTS,

        /**
         * Calculate the route according to the best monetary costs based on the parameters in the <a href="routing.html#com.ptvgroup.xserver.routing.MonetaryCostOptions">monetary cost options</a> and including toll costs.<br />
* If set, it is required to specify a <a href="xroute.html#com.ptvgroup.xserver.xroute.RouteOptions.currency">currency</a> in the route options.
         */
        MONETARY_COSTS
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public enum RoutingType {
        /**
         * Route calculation based on a standard algorithm. Heuristic elements are used to improve performance. If this element is used as input it the routing is forced to use the conventional algorithm.
         */
        CONVENTIONAL,

        /**
         * This element is used only as input. It indicates that the service tries to use a high-performance routing network, and if no adequate data is found conventional routing is used instead.
         */
        HIGH_PERFORMANCE_ROUTING_WITH_FALLBACK_CONVENTIONAL,

        /**
         * High-performance route calculation based on pre-calculated, profile-dependent additional routing networks. If it is used as input and no such network which fits the current profile settings is available an exception is thrown.
         */
        HIGH_PERFORMANCE_ROUTING
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://routing.xserver.ptvgroup.com")]
    public enum SideOfStreetRestriction {
        /**
         * No restrictions on the side of the street, both sides can be used.
         */
        ANY_SIDE,

        /**
         * The street side on which the location is situated should be used.
         */
        SAME_SIDE_AS_LOCATION
    }


}
