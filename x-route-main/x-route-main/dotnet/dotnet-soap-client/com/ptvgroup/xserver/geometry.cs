// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.geometry 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://geometry.xserver.ptvgroup.com")]
    public partial class Bounds : object, System.ComponentModel.INotifyPropertyChanged {

        private double minXField;
        private double maxXField;
        private double minYField;
        private double maxYField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double minX {
            get {
                return this.minXField;
            }
            set {
                this.minXField = value;
                this.RaisePropertyChanged("minX");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maxX {
            get {
                return this.maxXField;
            }
            set {
                this.maxXField = value;
                this.RaisePropertyChanged("maxX");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double minY {
            get {
                return this.minYField;
            }
            set {
                this.minYField = value;
                this.RaisePropertyChanged("minY");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maxY {
            get {
                return this.maxYField;
            }
            set {
                this.maxYField = value;
                this.RaisePropertyChanged("maxY");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://geometry.xserver.ptvgroup.com")]
    public partial class Coordinate : object, System.ComponentModel.INotifyPropertyChanged {

        private double xField;
        private double yField;
        private double zField;
        private bool zFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("x");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("y");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
                this.RaisePropertyChanged("z");
                this.zFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool zSpecified {
            get {
                return this.zFieldSpecified;
            }
            set {
                this.zFieldSpecified = value;
                this.RaisePropertyChanged("zSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://geometry.xserver.ptvgroup.com")]
    public partial class EncodedGeometry : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.geometry.Geometry plainField;
        private byte[] wkbField;
        private string wktField;
        private com.ptvgroup.xserver.geometry.KML kmlField;
        private string geoJSONField;

                    [System.Xml.Serialization.XmlElementAttribute("plain", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Geometry plain {
            get {
                return this.plainField;
            }
            set {
                this.plainField = value;
                this.RaisePropertyChanged("plain");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
        public byte[] wkb {
            get {
                return this.wkbField;
            }
            set {
                this.wkbField = value;
                this.RaisePropertyChanged("wkb");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wkt {
            get {
                return this.wktField;
            }
            set {
                this.wktField = value;
                this.RaisePropertyChanged("wkt");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("kml", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.KML kml {
            get {
                return this.kmlField;
            }
            set {
                this.kmlField = value;
                this.RaisePropertyChanged("kml");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string geoJSON {
            get {
                return this.geoJSONField;
            }
            set {
                this.geoJSONField = value;
                this.RaisePropertyChanged("geoJSON");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.geometry.GeometryCollection))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.geometry.Polygon))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.geometry.Polyline))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://geometry.xserver.ptvgroup.com")]
    public abstract partial class Geometry : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://geometry.xserver.ptvgroup.com")]
    public partial class GeometryCollection : com.ptvgroup.xserver.geometry.Geometry {

        private com.ptvgroup.xserver.geometry.Geometry[] geometriesField;

                    [System.Xml.Serialization.XmlElementAttribute("geometries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Geometry[] geometries {
            get {
                return this.geometriesField;
            }
            set {
                this.geometriesField = value;
                this.RaisePropertyChanged("geometries");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://geometry.xserver.ptvgroup.com")]
    public partial class KML : object, System.ComponentModel.INotifyPropertyChanged {

        private string kmlField;
        private string[] placemarksField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string kml {
            get {
                return this.kmlField;
            }
            set {
                this.kmlField = value;
                this.RaisePropertyChanged("kml");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("placemarks", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] placemarks {
            get {
                return this.placemarksField;
            }
            set {
                this.placemarksField = value;
                this.RaisePropertyChanged("placemarks");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://geometry.xserver.ptvgroup.com")]
    public partial class Polygon : com.ptvgroup.xserver.geometry.Geometry {

        private com.ptvgroup.xserver.geometry.Polyline[] polygonRingsField;

                    [System.Xml.Serialization.XmlElementAttribute("polygonRings", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Polyline[] polygonRings {
            get {
                return this.polygonRingsField;
            }
            set {
                this.polygonRingsField = value;
                this.RaisePropertyChanged("polygonRings");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://geometry.xserver.ptvgroup.com")]
    public partial class Polyline : com.ptvgroup.xserver.geometry.Geometry {

        private com.ptvgroup.xserver.geometry.Coordinate[] polylineField;

                    [System.Xml.Serialization.XmlElementAttribute("polyline", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate[] polyline {
            get {
                return this.polylineField;
            }
            set {
                this.polylineField = value;
                this.RaisePropertyChanged("polyline");
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://geometry.xserver.ptvgroup.com")]
    public enum EncodedGeometryType {
        /**
         * Response geometries shall be encoded using structured objects.
         */
        PLAIN,

        /**
         * Response geometries shall be encoded in WKB.
         */
        WKB,

        /**
         * Response geometries shall be encoded in WKT.
         */
        WKT,

        /**
         * Response geometries shall be encoded in KML.
         */
        KML,

        /**
         * Response geometries shall be encoded in GeoJSON.
         */
        GEOJSON
    }


}
