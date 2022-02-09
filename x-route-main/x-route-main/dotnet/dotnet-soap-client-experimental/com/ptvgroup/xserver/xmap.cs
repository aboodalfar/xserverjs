// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.xmap 
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public interface XMap {


            [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
            [System.ServiceModel.FaultContractAttribute(typeof(com.ptvgroup.xserver.exceptions.XServerFault), Action="", Name="XServerWebFault", Namespace="http://exceptions.xserver.ptvgroup.com")]
            [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
            [System.ServiceModel.ServiceKnownTypeAttribute(typeof(com.ptvgroup.xserver.service.ResponseBase))]
            [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
            com.ptvgroup.xserver.xmap.renderMapResponse renderMap(com.ptvgroup.xserver.xmap.renderMap request);

    }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="renderMap", WrapperNamespace="http://xmap.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class renderMap {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmap.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xmap.MapRequest request;

                public renderMap() {
                }

                public renderMap(com.ptvgroup.xserver.xmap.MapRequest request) {
                    this.request = request;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
            [System.ServiceModel.MessageContractAttribute(WrapperName="renderMapResponse", WrapperNamespace="http://xmap.xserver.ptvgroup.com", IsWrapped=true)]
            public partial class renderMapResponse {

                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmap.xserver.ptvgroup.com", Order=0)]
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public com.ptvgroup.xserver.xmap.MapResponse @return;

                public renderMapResponse() {
                }

                public renderMapResponse(com.ptvgroup.xserver.xmap.MapResponse @return) {
                    this.@return = @return;
                }
            }



    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XMapChannel : com.ptvgroup.xserver.xmap.XMap, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XMapClient : System.ServiceModel.ClientBase<com.ptvgroup.xserver.xmap.XMap>, com.ptvgroup.xserver.xmap.XMap {

        public XMapClient() :
            this("http://localhost:50000/services/ws/XMap/experimental") {
        }

        public XMapClient(string baseUri ) :
            this(new System.ServiceModel.BasicHttpBinding { MaxReceivedMessageSize = System.Int32.MaxValue }, new System.ServiceModel.EndpointAddress(baseUri+"/services/ws/XMap/experimental/")) {
        }

        public XMapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress) {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.ptvgroup.xserver.xmap.renderMapResponse com.ptvgroup.xserver.xmap.XMap.renderMap(com.ptvgroup.xserver.xmap.renderMap request) {
            return base.Channel.renderMap(request);
        }

        public com.ptvgroup.xserver.xmap.MapResponse renderMap(com.ptvgroup.xserver.xmap.MapRequest request) {
            com.ptvgroup.xserver.xmap.renderMap inValue = new com.ptvgroup.xserver.xmap.renderMap();
            inValue.request = request;
            com.ptvgroup.xserver.xmap.renderMapResponse retVal = ((com.ptvgroup.xserver.xmap.XMap)(this)).renderMap(inValue);
            return retVal.@return;
        }


   }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class Feature : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private com.ptvgroup.xserver.geometry.Coordinate referenceCoordinateField;
        private com.ptvgroup.xserver.xmap.PixelPoint referencePixelPointField;
        private com.ptvgroup.xserver.xmap.PixelBoundingBox pixelBoundingBoxField;
        private string iconReferenceField;
        private string themeIdField;
        private com.ptvgroup.xserver.types.KeyValuePair[] attributesField;

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

                    [System.Xml.Serialization.XmlElementAttribute("referencePixelPoint", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmap.PixelPoint referencePixelPoint {
            get {
                return this.referencePixelPointField;
            }
            set {
                this.referencePixelPointField = value;
                this.RaisePropertyChanged("referencePixelPoint");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("pixelBoundingBox", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmap.PixelBoundingBox pixelBoundingBox {
            get {
                return this.pixelBoundingBoxField;
            }
            set {
                this.pixelBoundingBoxField = value;
                this.RaisePropertyChanged("pixelBoundingBox");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string iconReference {
            get {
                return this.iconReferenceField;
            }
            set {
                this.iconReferenceField = value;
                this.RaisePropertyChanged("iconReference");
            }
        }

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class ImageOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.xmap.ImageFormat formatField;
        private bool formatFieldSpecified;
        private int heightField;
        private bool heightFieldSpecified;
        private int widthField;
        private bool widthFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xmap.ImageFormat format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
                this.RaisePropertyChanged("format");
                this.formatFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool formatSpecified {
            get {
                return this.formatFieldSpecified;
            }
            set {
                this.formatFieldSpecified = value;
                this.RaisePropertyChanged("formatSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
                this.RaisePropertyChanged("height");
                this.heightFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified {
            get {
                return this.heightFieldSpecified;
            }
            set {
                this.heightFieldSpecified = value;
                this.RaisePropertyChanged("heightSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
                this.RaisePropertyChanged("width");
                this.widthFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified {
            get {
                return this.widthFieldSpecified;
            }
            set {
                this.widthFieldSpecified = value;
                this.RaisePropertyChanged("widthSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class MapOptions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.timeconsideration.TimeConsideration timeConsiderationField;
        private string contentSnapshotIdField;
        private bool showOnlyRelevantByTimeField;
        private bool showOnlyRelevantByTimeFieldSpecified;
        private string[] layersField;
        private string[] preferredRouteTypesField;
        private bool showCopyrightField;
        private bool showCopyrightFieldSpecified;
        private bool drawIconsField;
        private bool drawIconsFieldSpecified;

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
        public bool showOnlyRelevantByTime {
            get {
                return this.showOnlyRelevantByTimeField;
            }
            set {
                this.showOnlyRelevantByTimeField = value;
                this.RaisePropertyChanged("showOnlyRelevantByTime");
                this.showOnlyRelevantByTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showOnlyRelevantByTimeSpecified {
            get {
                return this.showOnlyRelevantByTimeFieldSpecified;
            }
            set {
                this.showOnlyRelevantByTimeFieldSpecified = value;
                this.RaisePropertyChanged("showOnlyRelevantByTimeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("layers", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] layers {
            get {
                return this.layersField;
            }
            set {
                this.layersField = value;
                this.RaisePropertyChanged("layers");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("preferredRouteTypes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] preferredRouteTypes {
            get {
                return this.preferredRouteTypesField;
            }
            set {
                this.preferredRouteTypesField = value;
                this.RaisePropertyChanged("preferredRouteTypes");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool showCopyright {
            get {
                return this.showCopyrightField;
            }
            set {
                this.showCopyrightField = value;
                this.RaisePropertyChanged("showCopyright");
                this.showCopyrightFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showCopyrightSpecified {
            get {
                return this.showCopyrightFieldSpecified;
            }
            set {
                this.showCopyrightFieldSpecified = value;
                this.RaisePropertyChanged("showCopyrightSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool drawIcons {
            get {
                return this.drawIconsField;
            }
            set {
                this.drawIconsField = value;
                this.RaisePropertyChanged("drawIcons");
                this.drawIconsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drawIconsSpecified {
            get {
                return this.drawIconsFieldSpecified;
            }
            set {
                this.drawIconsFieldSpecified = value;
                this.RaisePropertyChanged("drawIconsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class MapRequest : com.ptvgroup.xserver.service.RequestBase {

        private com.ptvgroup.xserver.xmap.MapSection mapSectionField;
        private com.ptvgroup.xserver.xmap.MapOptions mapOptionsField;
        private com.ptvgroup.xserver.xmap.ImageOptions imageOptionsField;
        private com.ptvgroup.xserver.xmap.ResultFields resultFieldsField;

                    [System.Xml.Serialization.XmlElementAttribute("mapSection", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmap.MapSection mapSection {
            get {
                return this.mapSectionField;
            }
            set {
                this.mapSectionField = value;
                this.RaisePropertyChanged("mapSection");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("mapOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmap.MapOptions mapOptions {
            get {
                return this.mapOptionsField;
            }
            set {
                this.mapOptionsField = value;
                this.RaisePropertyChanged("mapOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("imageOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmap.ImageOptions imageOptions {
            get {
                return this.imageOptionsField;
            }
            set {
                this.imageOptionsField = value;
                this.RaisePropertyChanged("imageOptions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("resultFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmap.ResultFields resultFields {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class MapResponse : com.ptvgroup.xserver.service.ResponseBase {

        private byte[] imageField;
        private double zoomField;
        private com.ptvgroup.xserver.geometry.Bounds boundsField;
        private com.ptvgroup.xserver.xmap.Feature[] featuresField;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
        public byte[] image {
            get {
                return this.imageField;
            }
            set {
                this.imageField = value;
                this.RaisePropertyChanged("image");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double zoom {
            get {
                return this.zoomField;
            }
            set {
                this.zoomField = value;
                this.RaisePropertyChanged("zoom");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("bounds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Bounds bounds {
            get {
                return this.boundsField;
            }
            set {
                this.boundsField = value;
                this.RaisePropertyChanged("bounds");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("features", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmap.Feature[] features {
            get {
                return this.featuresField;
            }
            set {
                this.featuresField = value;
                this.RaisePropertyChanged("features");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xmap.MapSectionByBounds))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xmap.MapSectionByCenter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xmap.MapSectionByTileKey))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public abstract partial class MapSection : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class MapSectionByBounds : com.ptvgroup.xserver.xmap.MapSection {

        private com.ptvgroup.xserver.geometry.Bounds boundsField;

                    [System.Xml.Serialization.XmlElementAttribute("bounds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Bounds bounds {
            get {
                return this.boundsField;
            }
            set {
                this.boundsField = value;
                this.RaisePropertyChanged("bounds");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class MapSectionByCenter : com.ptvgroup.xserver.xmap.MapSection {

        private com.ptvgroup.xserver.geometry.Coordinate centerCoordinateField;
        private double zoomField;

                    [System.Xml.Serialization.XmlElementAttribute("centerCoordinate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate centerCoordinate {
            get {
                return this.centerCoordinateField;
            }
            set {
                this.centerCoordinateField = value;
                this.RaisePropertyChanged("centerCoordinate");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double zoom {
            get {
                return this.zoomField;
            }
            set {
                this.zoomField = value;
                this.RaisePropertyChanged("zoom");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class MapSectionByTileKey : com.ptvgroup.xserver.xmap.MapSection {

        private int zoomLevelField;
        private int xField;
        private int yField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int zoomLevel {
            get {
                return this.zoomLevelField;
            }
            set {
                this.zoomLevelField = value;
                this.RaisePropertyChanged("zoomLevel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("x");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("y");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class PixelBoundingBox : object, System.ComponentModel.INotifyPropertyChanged {

        private int leftField;
        private int topField;
        private int rightField;
        private int bottomField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int left {
            get {
                return this.leftField;
            }
            set {
                this.leftField = value;
                this.RaisePropertyChanged("left");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int top {
            get {
                return this.topField;
            }
            set {
                this.topField = value;
                this.RaisePropertyChanged("top");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int right {
            get {
                return this.rightField;
            }
            set {
                this.rightField = value;
                this.RaisePropertyChanged("right");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int bottom {
            get {
                return this.bottomField;
            }
            set {
                this.bottomField = value;
                this.RaisePropertyChanged("bottom");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class PixelPoint : object, System.ComponentModel.INotifyPropertyChanged {

        private int xField;
        private int yField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("x");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("y");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class ResultFields : object, System.ComponentModel.INotifyPropertyChanged {

        private bool imageField;
        private bool imageFieldSpecified;
        private string[] featureThemeIdsField;
        private bool iconReferenceField;
        private bool iconReferenceFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool image {
            get {
                return this.imageField;
            }
            set {
                this.imageField = value;
                this.RaisePropertyChanged("image");
                this.imageFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool imageSpecified {
            get {
                return this.imageFieldSpecified;
            }
            set {
                this.imageFieldSpecified = value;
                this.RaisePropertyChanged("imageSpecified");
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
        public bool iconReference {
            get {
                return this.iconReferenceField;
            }
            set {
                this.iconReferenceField = value;
                this.RaisePropertyChanged("iconReference");
                this.iconReferenceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool iconReferenceSpecified {
            get {
                return this.iconReferenceFieldSpecified;
            }
            set {
                this.iconReferenceFieldSpecified = value;
                this.RaisePropertyChanged("iconReferenceSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public partial class TileResponse : com.ptvgroup.xserver.service.ResponseBase {

        private byte[] imageField;
        private double zoomField;
        private com.ptvgroup.xserver.xmap.Feature[] featuresField;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
        public byte[] image {
            get {
                return this.imageField;
            }
            set {
                this.imageField = value;
                this.RaisePropertyChanged("image");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double zoom {
            get {
                return this.zoomField;
            }
            set {
                this.zoomField = value;
                this.RaisePropertyChanged("zoom");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("features", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xmap.Feature[] features {
            get {
                return this.featuresField;
            }
            set {
                this.featuresField = value;
                this.RaisePropertyChanged("features");
            }
        }


    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public enum ContentType {
        /**
         * An image is provided solely Base64 encoded.
         */
        IMAGE,

        /**
         * A response is returned according the definition of <a href="xmap.html#com.ptvgroup.xserver.xmap.TileResponse">TileResponse</a>.
         */
        JSON
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmap.xserver.ptvgroup.com")]
    public enum ImageFormat {
        /**
         * Image is provided in <em>Portable Network Graphics</em> format.
         */
        PNG,

        /**
         * Image is provided in <em> Joint Photographic Experts Group</em> format.
         */
        JPG
    }


}
