// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.profile 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://profile.xserver.ptvgroup.com")]
    public partial class RequestProfile : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.vehicleprofile.VehicleProfile vehicleProfileField;
        private com.ptvgroup.xserver.featurelayerprofile.FeatureLayerProfile featureLayerProfileField;
        private com.ptvgroup.xserver.routingprofile.RoutingProfile routingProfileField;
        private com.ptvgroup.xserver.renderingprofile.RenderingProfile renderingProfileField;
        private com.ptvgroup.xserver.clusterplanningprofile.ClusterPlanningProfile clusterPlanningProfileField;
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

                    [System.Xml.Serialization.XmlElementAttribute("renderingProfile", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.renderingprofile.RenderingProfile renderingProfile {
            get {
                return this.renderingProfileField;
            }
            set {
                this.renderingProfileField = value;
                this.RaisePropertyChanged("renderingProfile");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("clusterPlanningProfile", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.clusterplanningprofile.ClusterPlanningProfile clusterPlanningProfile {
            get {
                return this.clusterPlanningProfileField;
            }
            set {
                this.clusterPlanningProfileField = value;
                this.RaisePropertyChanged("clusterPlanningProfile");
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


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }



}
