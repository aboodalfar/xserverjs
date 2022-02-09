// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.renderingprofile 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class ArrowsStyle : object, System.ComponentModel.INotifyPropertyChanged {

        private bool drawStrokeField;
        private bool drawStrokeFieldSpecified;
        private bool drawFillField;
        private bool drawFillFieldSpecified;
        private string strokeColorField;
        private string fillColorField;
        private double strokeOpacityField;
        private bool strokeOpacityFieldSpecified;
        private double fillOpacityField;
        private bool fillOpacityFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool drawStroke {
            get {
                return this.drawStrokeField;
            }
            set {
                this.drawStrokeField = value;
                this.RaisePropertyChanged("drawStroke");
                this.drawStrokeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drawStrokeSpecified {
            get {
                return this.drawStrokeFieldSpecified;
            }
            set {
                this.drawStrokeFieldSpecified = value;
                this.RaisePropertyChanged("drawStrokeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool drawFill {
            get {
                return this.drawFillField;
            }
            set {
                this.drawFillField = value;
                this.RaisePropertyChanged("drawFill");
                this.drawFillFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drawFillSpecified {
            get {
                return this.drawFillFieldSpecified;
            }
            set {
                this.drawFillFieldSpecified = value;
                this.RaisePropertyChanged("drawFillSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strokeColor {
            get {
                return this.strokeColorField;
            }
            set {
                this.strokeColorField = value;
                this.RaisePropertyChanged("strokeColor");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fillColor {
            get {
                return this.fillColorField;
            }
            set {
                this.fillColorField = value;
                this.RaisePropertyChanged("fillColor");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double strokeOpacity {
            get {
                return this.strokeOpacityField;
            }
            set {
                this.strokeOpacityField = value;
                this.RaisePropertyChanged("strokeOpacity");
                this.strokeOpacityFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool strokeOpacitySpecified {
            get {
                return this.strokeOpacityFieldSpecified;
            }
            set {
                this.strokeOpacityFieldSpecified = value;
                this.RaisePropertyChanged("strokeOpacitySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double fillOpacity {
            get {
                return this.fillOpacityField;
            }
            set {
                this.fillOpacityField = value;
                this.RaisePropertyChanged("fillOpacity");
                this.fillOpacityFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fillOpacitySpecified {
            get {
                return this.fillOpacityFieldSpecified;
            }
            set {
                this.fillOpacityFieldSpecified = value;
                this.RaisePropertyChanged("fillOpacitySpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class CountryStyle : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.renderingprofile.FeatureLayerThemeStyle[] featureLayerThemesField;
        private string countryCodesField;

                    [System.Xml.Serialization.XmlElementAttribute("featureLayerThemes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.FeatureLayerThemeStyle[] featureLayerThemes {
            get {
                return this.featureLayerThemesField;
            }
            set {
                this.featureLayerThemesField = value;
                this.RaisePropertyChanged("featureLayerThemes");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string countryCodes {
            get {
                return this.countryCodesField;
            }
            set {
                this.countryCodesField = value;
                this.RaisePropertyChanged("countryCodes");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class FeatureLayerThemeStyle : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.renderingprofile.IconStyle[] defaultIconsField;
        private com.ptvgroup.xserver.renderingprofile.IconStyle[] groupIconsField;
        private com.ptvgroup.xserver.renderingprofile.LabelingConflictResolution labelingConflictResolutionField;
        private com.ptvgroup.xserver.renderingprofile.TimeDependencyStyle timeDependencyStyleField;
        private com.ptvgroup.xserver.renderingprofile.RenderingStyle[] stylesField;
        private string idField;

                    [System.Xml.Serialization.XmlElementAttribute("defaultIcons", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.IconStyle[] defaultIcons {
            get {
                return this.defaultIconsField;
            }
            set {
                this.defaultIconsField = value;
                this.RaisePropertyChanged("defaultIcons");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("groupIcons", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.IconStyle[] groupIcons {
            get {
                return this.groupIconsField;
            }
            set {
                this.groupIconsField = value;
                this.RaisePropertyChanged("groupIcons");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("labelingConflictResolution", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.LabelingConflictResolution labelingConflictResolution {
            get {
                return this.labelingConflictResolutionField;
            }
            set {
                this.labelingConflictResolutionField = value;
                this.RaisePropertyChanged("labelingConflictResolution");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("timeDependencyStyle", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.TimeDependencyStyle timeDependencyStyle {
            get {
                return this.timeDependencyStyleField;
            }
            set {
                this.timeDependencyStyleField = value;
                this.RaisePropertyChanged("timeDependencyStyle");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("styles", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.RenderingStyle[] styles {
            get {
                return this.stylesField;
            }
            set {
                this.stylesField = value;
                this.RaisePropertyChanged("styles");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class FillStyle : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.renderingprofile.HatchStyle hatchField;
        private bool visibleField;
        private bool visibleFieldSpecified;
        private string colorField;
        private double opacityField;
        private bool opacityFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("hatch", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.HatchStyle hatch {
            get {
                return this.hatchField;
            }
            set {
                this.hatchField = value;
                this.RaisePropertyChanged("hatch");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool visible {
            get {
                return this.visibleField;
            }
            set {
                this.visibleField = value;
                this.RaisePropertyChanged("visible");
                this.visibleFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool visibleSpecified {
            get {
                return this.visibleFieldSpecified;
            }
            set {
                this.visibleFieldSpecified = value;
                this.RaisePropertyChanged("visibleSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
                this.RaisePropertyChanged("color");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double opacity {
            get {
                return this.opacityField;
            }
            set {
                this.opacityField = value;
                this.RaisePropertyChanged("opacity");
                this.opacityFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool opacitySpecified {
            get {
                return this.opacityFieldSpecified;
            }
            set {
                this.opacityFieldSpecified = value;
                this.RaisePropertyChanged("opacitySpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class GeometryStyle : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.renderingprofile.RenderLevel renderLevelField;
        private com.ptvgroup.xserver.renderingprofile.StrokeStyle strokeField;
        private com.ptvgroup.xserver.renderingprofile.PolygonStyle polygonField;
        private string displayRangeField;

                    [System.Xml.Serialization.XmlElementAttribute("renderLevel", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.RenderLevel renderLevel {
            get {
                return this.renderLevelField;
            }
            set {
                this.renderLevelField = value;
                this.RaisePropertyChanged("renderLevel");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("stroke", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.StrokeStyle stroke {
            get {
                return this.strokeField;
            }
            set {
                this.strokeField = value;
                this.RaisePropertyChanged("stroke");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("polygon", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.PolygonStyle polygon {
            get {
                return this.polygonField;
            }
            set {
                this.polygonField = value;
                this.RaisePropertyChanged("polygon");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayRange {
            get {
                return this.displayRangeField;
            }
            set {
                this.displayRangeField = value;
                this.RaisePropertyChanged("displayRange");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class HatchStyle : object, System.ComponentModel.INotifyPropertyChanged {

        private string colorField;
        private com.ptvgroup.xserver.renderingprofile.HatchType typeField;
        private bool typeFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
                this.RaisePropertyChanged("color");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.renderingprofile.HatchType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
                this.typeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
                this.RaisePropertyChanged("typeSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class IconAnchor : object, System.ComponentModel.INotifyPropertyChanged {

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class IconStyle : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.renderingprofile.RenderLevel renderLevelField;
        private com.ptvgroup.xserver.renderingprofile.IconAnchor anchorField;
        private com.ptvgroup.xserver.renderingprofile.Alignment alignmentField;
        private bool alignmentFieldSpecified;
        private string urlField;
        private string displayRangeField;

                    [System.Xml.Serialization.XmlElementAttribute("renderLevel", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.RenderLevel renderLevel {
            get {
                return this.renderLevelField;
            }
            set {
                this.renderLevelField = value;
                this.RaisePropertyChanged("renderLevel");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("anchor", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.IconAnchor anchor {
            get {
                return this.anchorField;
            }
            set {
                this.anchorField = value;
                this.RaisePropertyChanged("anchor");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.renderingprofile.Alignment alignment {
            get {
                return this.alignmentField;
            }
            set {
                this.alignmentField = value;
                this.RaisePropertyChanged("alignment");
                this.alignmentFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alignmentSpecified {
            get {
                return this.alignmentFieldSpecified;
            }
            set {
                this.alignmentFieldSpecified = value;
                this.RaisePropertyChanged("alignmentSpecified");
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

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayRange {
            get {
                return this.displayRangeField;
            }
            set {
                this.displayRangeField = value;
                this.RaisePropertyChanged("displayRange");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class LabelingConflictResolution : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.renderingprofile.Scope scopeField;
        private bool scopeFieldSpecified;
        private bool forceDisplayField;
        private bool forceDisplayFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.renderingprofile.Scope scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
                this.RaisePropertyChanged("scope");
                this.scopeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scopeSpecified {
            get {
                return this.scopeFieldSpecified;
            }
            set {
                this.scopeFieldSpecified = value;
                this.RaisePropertyChanged("scopeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool forceDisplay {
            get {
                return this.forceDisplayField;
            }
            set {
                this.forceDisplayField = value;
                this.RaisePropertyChanged("forceDisplay");
                this.forceDisplayFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool forceDisplaySpecified {
            get {
                return this.forceDisplayFieldSpecified;
            }
            set {
                this.forceDisplayFieldSpecified = value;
                this.RaisePropertyChanged("forceDisplaySpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class PolygonStyle : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.renderingprofile.StrokeStyle strokeField;
        private com.ptvgroup.xserver.renderingprofile.FillStyle fillField;

                    [System.Xml.Serialization.XmlElementAttribute("stroke", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.StrokeStyle stroke {
            get {
                return this.strokeField;
            }
            set {
                this.strokeField = value;
                this.RaisePropertyChanged("stroke");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("fill", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.FillStyle fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
                this.RaisePropertyChanged("fill");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class Range : object, System.ComponentModel.INotifyPropertyChanged {

        private int fromField;
        private int toField;
        private bool toFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int from {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
                this.RaisePropertyChanged("from");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int to {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
                this.RaisePropertyChanged("to");
                this.toFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toSpecified {
            get {
                return this.toFieldSpecified;
            }
            set {
                this.toFieldSpecified = value;
                this.RaisePropertyChanged("toSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class RenderLevel : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.renderingprofile.RenderBase renderBaseField;
        private bool renderBaseFieldSpecified;
        private string renderOffsetField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.renderingprofile.RenderBase renderBase {
            get {
                return this.renderBaseField;
            }
            set {
                this.renderBaseField = value;
                this.RaisePropertyChanged("renderBase");
                this.renderBaseFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool renderBaseSpecified {
            get {
                return this.renderBaseFieldSpecified;
            }
            set {
                this.renderBaseFieldSpecified = value;
                this.RaisePropertyChanged("renderBaseSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string renderOffset {
            get {
                return this.renderOffsetField;
            }
            set {
                this.renderOffsetField = value;
                this.RaisePropertyChanged("renderOffset");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class RenderingProfile : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.renderingprofile.CountryStyle[] countryStylesField;

                    [System.Xml.Serialization.XmlElementAttribute("countryStyles", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.CountryStyle[] countryStyles {
            get {
                return this.countryStylesField;
            }
            set {
                this.countryStylesField = value;
                this.RaisePropertyChanged("countryStyles");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class RenderingStyle : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.renderingprofile.Range[] rangesField;
        private com.ptvgroup.xserver.renderingprofile.RoadType[] roadTypesField;
        private com.ptvgroup.xserver.renderingprofile.GeometryStyle[] geometriesField;
        private com.ptvgroup.xserver.renderingprofile.IconStyle[] iconsField;
        private string displayClassField;
        private com.ptvgroup.xserver.renderingprofile.TimeRestriction timeRestrictionField;
        private bool timeRestrictionFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("ranges", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.Range[] ranges {
            get {
                return this.rangesField;
            }
            set {
                this.rangesField = value;
                this.RaisePropertyChanged("ranges");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("roadTypes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.RoadType[] roadTypes {
            get {
                return this.roadTypesField;
            }
            set {
                this.roadTypesField = value;
                this.RaisePropertyChanged("roadTypes");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("geometries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.GeometryStyle[] geometries {
            get {
                return this.geometriesField;
            }
            set {
                this.geometriesField = value;
                this.RaisePropertyChanged("geometries");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("icons", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.IconStyle[] icons {
            get {
                return this.iconsField;
            }
            set {
                this.iconsField = value;
                this.RaisePropertyChanged("icons");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayClass {
            get {
                return this.displayClassField;
            }
            set {
                this.displayClassField = value;
                this.RaisePropertyChanged("displayClass");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.renderingprofile.TimeRestriction timeRestriction {
            get {
                return this.timeRestrictionField;
            }
            set {
                this.timeRestrictionField = value;
                this.RaisePropertyChanged("timeRestriction");
                this.timeRestrictionFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeRestrictionSpecified {
            get {
                return this.timeRestrictionFieldSpecified;
            }
            set {
                this.timeRestrictionFieldSpecified = value;
                this.RaisePropertyChanged("timeRestrictionSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class StrokeStyle : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.renderingprofile.ArrowsStyle arrowsField;
        private string perpendicularOffsetField;
        private bool visibleField;
        private bool visibleFieldSpecified;
        private string widthField;
        private string colorField;
        private double opacityField;
        private bool opacityFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("arrows", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.ArrowsStyle arrows {
            get {
                return this.arrowsField;
            }
            set {
                this.arrowsField = value;
                this.RaisePropertyChanged("arrows");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string perpendicularOffset {
            get {
                return this.perpendicularOffsetField;
            }
            set {
                this.perpendicularOffsetField = value;
                this.RaisePropertyChanged("perpendicularOffset");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool visible {
            get {
                return this.visibleField;
            }
            set {
                this.visibleField = value;
                this.RaisePropertyChanged("visible");
                this.visibleFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool visibleSpecified {
            get {
                return this.visibleFieldSpecified;
            }
            set {
                this.visibleFieldSpecified = value;
                this.RaisePropertyChanged("visibleSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
                this.RaisePropertyChanged("width");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
                this.RaisePropertyChanged("color");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double opacity {
            get {
                return this.opacityField;
            }
            set {
                this.opacityField = value;
                this.RaisePropertyChanged("opacity");
                this.opacityFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool opacitySpecified {
            get {
                return this.opacityFieldSpecified;
            }
            set {
                this.opacityFieldSpecified = value;
                this.RaisePropertyChanged("opacitySpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public partial class TimeDependencyStyle : object, System.ComponentModel.INotifyPropertyChanged {

        private bool iconsWithClockField;
        private bool iconsWithClockFieldSpecified;
        private bool strokesDashedField;
        private bool strokesDashedFieldSpecified;
        private bool irrelevantIconsGrayedField;
        private bool irrelevantIconsGrayedFieldSpecified;
        private bool irrelevantStrokesGrayedField;
        private bool irrelevantStrokesGrayedFieldSpecified;
        private bool irrelevantPolygonsGrayedField;
        private bool irrelevantPolygonsGrayedFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool iconsWithClock {
            get {
                return this.iconsWithClockField;
            }
            set {
                this.iconsWithClockField = value;
                this.RaisePropertyChanged("iconsWithClock");
                this.iconsWithClockFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool iconsWithClockSpecified {
            get {
                return this.iconsWithClockFieldSpecified;
            }
            set {
                this.iconsWithClockFieldSpecified = value;
                this.RaisePropertyChanged("iconsWithClockSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool strokesDashed {
            get {
                return this.strokesDashedField;
            }
            set {
                this.strokesDashedField = value;
                this.RaisePropertyChanged("strokesDashed");
                this.strokesDashedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool strokesDashedSpecified {
            get {
                return this.strokesDashedFieldSpecified;
            }
            set {
                this.strokesDashedFieldSpecified = value;
                this.RaisePropertyChanged("strokesDashedSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool irrelevantIconsGrayed {
            get {
                return this.irrelevantIconsGrayedField;
            }
            set {
                this.irrelevantIconsGrayedField = value;
                this.RaisePropertyChanged("irrelevantIconsGrayed");
                this.irrelevantIconsGrayedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool irrelevantIconsGrayedSpecified {
            get {
                return this.irrelevantIconsGrayedFieldSpecified;
            }
            set {
                this.irrelevantIconsGrayedFieldSpecified = value;
                this.RaisePropertyChanged("irrelevantIconsGrayedSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool irrelevantStrokesGrayed {
            get {
                return this.irrelevantStrokesGrayedField;
            }
            set {
                this.irrelevantStrokesGrayedField = value;
                this.RaisePropertyChanged("irrelevantStrokesGrayed");
                this.irrelevantStrokesGrayedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool irrelevantStrokesGrayedSpecified {
            get {
                return this.irrelevantStrokesGrayedFieldSpecified;
            }
            set {
                this.irrelevantStrokesGrayedFieldSpecified = value;
                this.RaisePropertyChanged("irrelevantStrokesGrayedSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool irrelevantPolygonsGrayed {
            get {
                return this.irrelevantPolygonsGrayedField;
            }
            set {
                this.irrelevantPolygonsGrayedField = value;
                this.RaisePropertyChanged("irrelevantPolygonsGrayed");
                this.irrelevantPolygonsGrayedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool irrelevantPolygonsGrayedSpecified {
            get {
                return this.irrelevantPolygonsGrayedFieldSpecified;
            }
            set {
                this.irrelevantPolygonsGrayedFieldSpecified = value;
                this.RaisePropertyChanged("irrelevantPolygonsGrayedSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public enum Alignment {
        /**
         * The top left corner of the label.
         */
        TOP_LEFT,

        /**
         * The center of the top border of the label.
         */
        TOP_CENTER,

        /**
         * The top right corner of the label.
         */
        TOP_RIGHT,

        /**
         * The center of the left border of the label.
         */
        LEFT_CENTER,

        /**
         * The center of the label.
         */
        CENTER,

        /**
         * The center of the right border of the label.
         */
        RIGHT_CENTER,

        /**
         * The bottom left corner of the label.
         */
        BOTTOM_LEFT,

        /**
         * The center of the bottom border of the label.
         */
        BOTTOM_CENTER,

        /**
         * The bottom right corner of the label.
         */
        BOTTOM_RIGHT
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public enum HatchType {
        /**
         * Hatch pattern inclined from top left to bottom right.
         */
        LEFT_INCLINED,

        /**
         * Hatch pattern inclined from top right to bottom left.
         */
        RIGHT_INCLINED,

        /**
         * Vertical hatch pattern.
         */
        VERTICAL,

        /**
         * Horizontal hatch pattern.
         */
        HORIZONTAL
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public enum RenderBase {
        /**
         * Objects are drawn on top of the map. Nevertheless, several objects with value TOP can be ordered by choosing different renderOffset values.
         */
        TOP,

        /**
         * Objects are drawn relvative to the transport layer, i.e. roads, railways, etc..
         */
        TRANSPORT
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public enum RoadType {
        /**
         * Valid for motorways.
         */
        MOTORWAY_FREEWAY,

        /**
         * Valid for dual highways.
         */
        DUAL_CARRIAGE_HIGHWAY,

        /**
         * Valid for single highways.
         */
        SINGLE_CARRIAGE_HIGHWAY,

        /**
         * Valid for local major roads.
         */
        LOCAL_MAJOR_ROAD,

        /**
         * Valid for local minor roads.
         */
        LOCAL_MINOR_ROAD,

        /**
         * Valid for urban roads.
         */
        URBAN_ROAD,

        /**
         * Valid for pedestrian ways.
         */
        PEDESTRIAN_ZONE,

        /**
         * Valid for forest roads and walkways.
         */
        FORESTROADS_AND_WALKWAYS
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public enum Scope {
        /**
         * Labels of this theme shall not overlap any other label including those of the basemap, e.g. road or town names or road signs.
         */
        ALL,

        /**
         * Labels of this theme shall not overlap other labels of this or any other theme, but they may overlap labels of the basemap.
         */
        FEATURE_LAYER_LABELS
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://renderingprofile.xserver.ptvgroup.com")]
    public enum TimeRestriction {
        /**
         * All elements will be taken into account.
         */
        ALL,

        /**
         * Only elements without a restriction in validity will be taken into account.
         */
        UNRESTRICTED,

        /**
         * Only elements with a restriction in validity will be taken into account.
         */
        RESTRICTED
    }


}
