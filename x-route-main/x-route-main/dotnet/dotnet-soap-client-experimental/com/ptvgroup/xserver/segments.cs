// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.segments 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://segments.xserver.ptvgroup.com")]
    public partial class CombinedTransportAttributes : object, System.ComponentModel.INotifyPropertyChanged {

        private string nameField;
        private com.ptvgroup.xserver.segments.CombinedTransportType typeField;

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
        public com.ptvgroup.xserver.segments.CombinedTransportType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://segments.xserver.ptvgroup.com")]
    public partial class Feature : object, System.ComponentModel.INotifyPropertyChanged {

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://segments.xserver.ptvgroup.com")]
    public partial class RoadAttributes : object, System.ComponentModel.INotifyPropertyChanged {

        private bool prohibitedField;
        private bool tollField;
        private bool urbanField;
        private bool residentsOnlyField;
        private bool pedestrianZoneField;
        private bool oneWayField;
        private bool roundaboutField;
        private bool rampField;
        private bool bridgeField;
        private bool tunnelField;
        private bool deliveryOnlyField;
        private bool allowedForEmergencyField;
        private string lowEmissionZoneTypeField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool prohibited {
            get {
                return this.prohibitedField;
            }
            set {
                this.prohibitedField = value;
                this.RaisePropertyChanged("prohibited");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool toll {
            get {
                return this.tollField;
            }
            set {
                this.tollField = value;
                this.RaisePropertyChanged("toll");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool urban {
            get {
                return this.urbanField;
            }
            set {
                this.urbanField = value;
                this.RaisePropertyChanged("urban");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool residentsOnly {
            get {
                return this.residentsOnlyField;
            }
            set {
                this.residentsOnlyField = value;
                this.RaisePropertyChanged("residentsOnly");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool pedestrianZone {
            get {
                return this.pedestrianZoneField;
            }
            set {
                this.pedestrianZoneField = value;
                this.RaisePropertyChanged("pedestrianZone");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool oneWay {
            get {
                return this.oneWayField;
            }
            set {
                this.oneWayField = value;
                this.RaisePropertyChanged("oneWay");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool roundabout {
            get {
                return this.roundaboutField;
            }
            set {
                this.roundaboutField = value;
                this.RaisePropertyChanged("roundabout");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ramp {
            get {
                return this.rampField;
            }
            set {
                this.rampField = value;
                this.RaisePropertyChanged("ramp");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool bridge {
            get {
                return this.bridgeField;
            }
            set {
                this.bridgeField = value;
                this.RaisePropertyChanged("bridge");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool tunnel {
            get {
                return this.tunnelField;
            }
            set {
                this.tunnelField = value;
                this.RaisePropertyChanged("tunnel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deliveryOnly {
            get {
                return this.deliveryOnlyField;
            }
            set {
                this.deliveryOnlyField = value;
                this.RaisePropertyChanged("deliveryOnly");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowedForEmergency {
            get {
                return this.allowedForEmergencyField;
            }
            set {
                this.allowedForEmergencyField = value;
                this.RaisePropertyChanged("allowedForEmergency");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lowEmissionZoneType {
            get {
                return this.lowEmissionZoneTypeField;
            }
            set {
                this.lowEmissionZoneTypeField = value;
                this.RaisePropertyChanged("lowEmissionZoneType");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://segments.xserver.ptvgroup.com")]
    public partial class SegmentAttributes : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.segments.SegmentDescriptors descriptorsField;
        private com.ptvgroup.xserver.segments.RoadAttributes roadAttributesField;
        private com.ptvgroup.xserver.segments.Feature[] featuresField;

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

                    [System.Xml.Serialization.XmlElementAttribute("roadAttributes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.segments.RoadAttributes roadAttributes {
            get {
                return this.roadAttributesField;
            }
            set {
                this.roadAttributesField = value;
                this.RaisePropertyChanged("roadAttributes");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("features", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.segments.Feature[] features {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://segments.xserver.ptvgroup.com")]
    public partial class SegmentDescriptors : object, System.ComponentModel.INotifyPropertyChanged {

        private string countryField;
        private string roadNameField;
        private string roadNumberField;
        private int networkClassField;

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
        public string roadName {
            get {
                return this.roadNameField;
            }
            set {
                this.roadNameField = value;
                this.RaisePropertyChanged("roadName");
            }
        }

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
        public int networkClass {
            get {
                return this.networkClassField;
            }
            set {
                this.networkClassField = value;
                this.RaisePropertyChanged("networkClass");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://segments.xserver.ptvgroup.com")]
    public enum CombinedTransportType {
        /**
         * The combined transport is by boat, i.e. by a ferry.
* Transport by boat can be avoided or prohibited during route calculation using the parameter
* <a href="routingprofile.html#com.ptvgroup.xserver.routingprofile.CombinedTransport.boatPenalty">CombinedTransport.boatPenalty</a>.
         */
        BOAT,

        /**
         * The combined transport is by rail, i.e. on a train.
* Transport by rail can be avoided or prohibited during route calculation using the parameter
* <a href="routingprofile.html#com.ptvgroup.xserver.routingprofile.CombinedTransport.railPenalty">CombinedTransport.railPenalty</a>.
         */
        RAIL
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://segments.xserver.ptvgroup.com")]
    public enum SegmentDirection {
        /**
         * Describes the direction from start node to end node with respect to the digitization direction.
         */
        POLYLINE_DIRECTION,

        /**
         * Describes the direction from end node to start node with respect to the digitization direction.
         */
        REVERSE_POLYLINE_DIRECTION,

        /**
         * Describes both directions.
         */
        BOTH,

        /**
         * Fallback value to be substituted for enumeration values which were added in an API version that is newer than the request version. When using the current API, this value will never be returned.
         */
        UNSPECIFIED
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://segments.xserver.ptvgroup.com")]
    public enum SegmentType {
        /**
         * This segment is a network segment.
         */
        NETWORK_SEGMENT,

        /**
         * This segment is a virtual one, but not a network segment. It links the input coordinate
* to the routing network and does not have <a href="segments.html#com.ptvgroup.xserver.segments.SegmentAttributes">SegmentAttributes</a>.
         */
        LINK_SEGMENT,

        /**
         * This segment is a combined transport, i.e. the vehicle is carried by some other vehicle such as a boat or a train.
* The <a href="segments.html#com.ptvgroup.xserver.segments.CombinedTransportAttributes">CombinedTransportAttributes</a> are available only for segments of this type.
         */
        COMBINED_TRANSPORT,

        /**
         * This segment is a virtual one which denotes that the vehicle is not driving. Thus, the segment
* has distance and travelSpeed 0 and does not have a polyline nor <a href="segments.html#com.ptvgroup.xserver.segments.SegmentAttributes">SegmentAttributes</a>.
* <ul>
* <li>Border crossings which are not a combined transport.
* Start and end node have the same location but are in different
* countries. The travelTime equals 0.</li>
* <li>When the driver is making a break or a rest, during service and other waiting periods.
* For those waiting segments start and end nodes are equal.</li>
* </ul>
         */
        NOT_DRIVING
    }


}
