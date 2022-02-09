// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.featurelayerprofile 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://featurelayerprofile.xserver.ptvgroup.com")]
    public partial class CountrySpecificParameter : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.featurelayerprofile.FeatureLayerRule[] rulesField;
        private com.ptvgroup.xserver.featurelayerprofile.FeatureLayerProperty[] propertiesField;
        private com.ptvgroup.xserver.featurelayerprofile.FeatureLayerAction[] actionsField;
        private string idField;
        private bool enabledField;
        private bool enabledFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("rules", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.featurelayerprofile.FeatureLayerRule[] rules {
            get {
                return this.rulesField;
            }
            set {
                this.rulesField = value;
                this.RaisePropertyChanged("rules");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("properties", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.featurelayerprofile.FeatureLayerProperty[] properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
                this.RaisePropertyChanged("properties");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("actions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.featurelayerprofile.FeatureLayerAction[] actions {
            get {
                return this.actionsField;
            }
            set {
                this.actionsField = value;
                this.RaisePropertyChanged("actions");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://featurelayerprofile.xserver.ptvgroup.com")]
    public partial class FeatureLayerAction : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.featurelayerprofile.FeatureLayerActionType idField;
        private bool enabledField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.featurelayerprofile.FeatureLayerActionType id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
                this.RaisePropertyChanged("enabled");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://featurelayerprofile.xserver.ptvgroup.com")]
    public partial class FeatureLayerProfile : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.types.KeyValuePair[] parametersField;
        private com.ptvgroup.xserver.featurelayerprofile.Theme[] themesField;

                    [System.Xml.Serialization.XmlElementAttribute("parameters", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.KeyValuePair[] parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
                this.RaisePropertyChanged("parameters");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("themes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.featurelayerprofile.Theme[] themes {
            get {
                return this.themesField;
            }
            set {
                this.themesField = value;
                this.RaisePropertyChanged("themes");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://featurelayerprofile.xserver.ptvgroup.com")]
    public partial class FeatureLayerProperty : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private bool enabledField;

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
        public bool enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
                this.RaisePropertyChanged("enabled");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://featurelayerprofile.xserver.ptvgroup.com")]
    public partial class FeatureLayerRule : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private bool enabledField;

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
        public bool enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
                this.RaisePropertyChanged("enabled");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://featurelayerprofile.xserver.ptvgroup.com")]
    public partial class FeatureResultProperty : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private bool enabledField;

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
        public bool enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
                this.RaisePropertyChanged("enabled");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://featurelayerprofile.xserver.ptvgroup.com")]
    public partial class Theme : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.featurelayerprofile.CountrySpecificParameter[] countrySpecificParametersField;
        private com.ptvgroup.xserver.featurelayerprofile.FeatureResultProperty[] featureResultPropertiesField;
        private string idField;
        private bool enabledField;
        private bool enabledFieldSpecified;
        private int priorityLevelField;
        private bool priorityLevelFieldSpecified;
        private string[] featureScenariosField;

                    [System.Xml.Serialization.XmlElementAttribute("countrySpecificParameters", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.featurelayerprofile.CountrySpecificParameter[] countrySpecificParameters {
            get {
                return this.countrySpecificParametersField;
            }
            set {
                this.countrySpecificParametersField = value;
                this.RaisePropertyChanged("countrySpecificParameters");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("featureResultProperties", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.featurelayerprofile.FeatureResultProperty[] featureResultProperties {
            get {
                return this.featureResultPropertiesField;
            }
            set {
                this.featureResultPropertiesField = value;
                this.RaisePropertyChanged("featureResultProperties");
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
        public int priorityLevel {
            get {
                return this.priorityLevelField;
            }
            set {
                this.priorityLevelField = value;
                this.RaisePropertyChanged("priorityLevel");
                this.priorityLevelFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool priorityLevelSpecified {
            get {
                return this.priorityLevelFieldSpecified;
            }
            set {
                this.priorityLevelFieldSpecified = value;
                this.RaisePropertyChanged("priorityLevelSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("featureScenarios", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] featureScenarios {
            get {
                return this.featureScenariosField;
            }
            set {
                this.featureScenariosField = value;
                this.RaisePropertyChanged("featureScenarios");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://featurelayerprofile.xserver.ptvgroup.com")]
    public enum FeatureLayerActionType {
        /**
         * Defines every action.
         */
        ALL,

        /**
         * Applies a penalty to a segment, when calculating a route.
         */
        BONUS_MALUS,

        /**
         * Provides the real speed on a segment.
         */
        SET_ABSOLUTE_SPEED,

        /**
         * Provides information about the time zone
         */
        SET_TIME_ZONE,

        /**
         * Provides the freeflow speed on a segment.
         */
        SET_FREEFLOW_SPEED,

        /**
         * Provides information on display.
         */
        SET_DISPLAY_CLASS,

        /**
         * Provides network modifications.
         */
        SET_NETWORK_ATTRIBUTES,

        /**
         * Provides the waiting time on a segment.
         */
        SET_WAITING_TIME
    }


}
