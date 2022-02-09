// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.vehicleprofile 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public partial class Axle : object, System.ComponentModel.INotifyPropertyChanged {

        private double axleLoadField;
        private bool axleLoadFieldSpecified;
        private int numberOfAxlesField;
        private bool numberOfAxlesFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double axleLoad {
            get {
                return this.axleLoadField;
            }
            set {
                this.axleLoadField = value;
                this.RaisePropertyChanged("axleLoad");
                this.axleLoadFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool axleLoadSpecified {
            get {
                return this.axleLoadFieldSpecified;
            }
            set {
                this.axleLoadFieldSpecified = value;
                this.RaisePropertyChanged("axleLoadSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfAxles {
            get {
                return this.numberOfAxlesField;
            }
            set {
                this.numberOfAxlesField = value;
                this.RaisePropertyChanged("numberOfAxles");
                this.numberOfAxlesFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfAxlesSpecified {
            get {
                return this.numberOfAxlesFieldSpecified;
            }
            set {
                this.numberOfAxlesFieldSpecified = value;
                this.RaisePropertyChanged("numberOfAxlesSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public partial class Dimensions : object, System.ComponentModel.INotifyPropertyChanged {

        private double heightField;
        private bool heightFieldSpecified;
        private double heightAboveFrontAxleField;
        private bool heightAboveFrontAxleFieldSpecified;
        private double lengthField;
        private bool lengthFieldSpecified;
        private double widthField;
        private bool widthFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double height {
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
        public double heightAboveFrontAxle {
            get {
                return this.heightAboveFrontAxleField;
            }
            set {
                this.heightAboveFrontAxleField = value;
                this.RaisePropertyChanged("heightAboveFrontAxle");
                this.heightAboveFrontAxleFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightAboveFrontAxleSpecified {
            get {
                return this.heightAboveFrontAxleFieldSpecified;
            }
            set {
                this.heightAboveFrontAxleFieldSpecified = value;
                this.RaisePropertyChanged("heightAboveFrontAxleSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
                this.RaisePropertyChanged("length");
                this.lengthFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lengthSpecified {
            get {
                return this.lengthFieldSpecified;
            }
            set {
                this.lengthFieldSpecified = value;
                this.RaisePropertyChanged("lengthSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double width {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public partial class Engine : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.vehicleprofile.EngineType engineTypeField;
        private bool engineTypeFieldSpecified;
        private int cylinderCapacityField;
        private bool cylinderCapacityFieldSpecified;
        private com.ptvgroup.xserver.vehicleprofile.FuelType fuelTypeField;
        private bool fuelTypeFieldSpecified;
        private double bioFuelRatioField;
        private bool bioFuelRatioFieldSpecified;
        private double fuelConsumptionField;
        private bool fuelConsumptionFieldSpecified;
        private com.ptvgroup.xserver.vehicleprofile.EmissionTechnology emissionTechnologyField;
        private bool emissionTechnologyFieldSpecified;
        private bool particleFilterInstalledField;
        private bool particleFilterInstalledFieldSpecified;
        private com.ptvgroup.xserver.vehicleprofile.ParticleReductionClass particleReductionClassField;
        private bool particleReductionClassFieldSpecified;
        private com.ptvgroup.xserver.vehicleprofile.EmissionStandardEU emissionStandardEUField;
        private bool emissionStandardEUFieldSpecified;
        private com.ptvgroup.xserver.vehicleprofile.EmissionStandardAustralia emissionStandardAustraliaField;
        private bool emissionStandardAustraliaFieldSpecified;
        private string lowEmissionZoneTypesField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.vehicleprofile.EngineType engineType {
            get {
                return this.engineTypeField;
            }
            set {
                this.engineTypeField = value;
                this.RaisePropertyChanged("engineType");
                this.engineTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool engineTypeSpecified {
            get {
                return this.engineTypeFieldSpecified;
            }
            set {
                this.engineTypeFieldSpecified = value;
                this.RaisePropertyChanged("engineTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int cylinderCapacity {
            get {
                return this.cylinderCapacityField;
            }
            set {
                this.cylinderCapacityField = value;
                this.RaisePropertyChanged("cylinderCapacity");
                this.cylinderCapacityFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cylinderCapacitySpecified {
            get {
                return this.cylinderCapacityFieldSpecified;
            }
            set {
                this.cylinderCapacityFieldSpecified = value;
                this.RaisePropertyChanged("cylinderCapacitySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.vehicleprofile.FuelType fuelType {
            get {
                return this.fuelTypeField;
            }
            set {
                this.fuelTypeField = value;
                this.RaisePropertyChanged("fuelType");
                this.fuelTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fuelTypeSpecified {
            get {
                return this.fuelTypeFieldSpecified;
            }
            set {
                this.fuelTypeFieldSpecified = value;
                this.RaisePropertyChanged("fuelTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double bioFuelRatio {
            get {
                return this.bioFuelRatioField;
            }
            set {
                this.bioFuelRatioField = value;
                this.RaisePropertyChanged("bioFuelRatio");
                this.bioFuelRatioFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bioFuelRatioSpecified {
            get {
                return this.bioFuelRatioFieldSpecified;
            }
            set {
                this.bioFuelRatioFieldSpecified = value;
                this.RaisePropertyChanged("bioFuelRatioSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double fuelConsumption {
            get {
                return this.fuelConsumptionField;
            }
            set {
                this.fuelConsumptionField = value;
                this.RaisePropertyChanged("fuelConsumption");
                this.fuelConsumptionFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fuelConsumptionSpecified {
            get {
                return this.fuelConsumptionFieldSpecified;
            }
            set {
                this.fuelConsumptionFieldSpecified = value;
                this.RaisePropertyChanged("fuelConsumptionSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.vehicleprofile.EmissionTechnology emissionTechnology {
            get {
                return this.emissionTechnologyField;
            }
            set {
                this.emissionTechnologyField = value;
                this.RaisePropertyChanged("emissionTechnology");
                this.emissionTechnologyFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emissionTechnologySpecified {
            get {
                return this.emissionTechnologyFieldSpecified;
            }
            set {
                this.emissionTechnologyFieldSpecified = value;
                this.RaisePropertyChanged("emissionTechnologySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool particleFilterInstalled {
            get {
                return this.particleFilterInstalledField;
            }
            set {
                this.particleFilterInstalledField = value;
                this.RaisePropertyChanged("particleFilterInstalled");
                this.particleFilterInstalledFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool particleFilterInstalledSpecified {
            get {
                return this.particleFilterInstalledFieldSpecified;
            }
            set {
                this.particleFilterInstalledFieldSpecified = value;
                this.RaisePropertyChanged("particleFilterInstalledSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.vehicleprofile.ParticleReductionClass particleReductionClass {
            get {
                return this.particleReductionClassField;
            }
            set {
                this.particleReductionClassField = value;
                this.RaisePropertyChanged("particleReductionClass");
                this.particleReductionClassFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool particleReductionClassSpecified {
            get {
                return this.particleReductionClassFieldSpecified;
            }
            set {
                this.particleReductionClassFieldSpecified = value;
                this.RaisePropertyChanged("particleReductionClassSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.vehicleprofile.EmissionStandardEU emissionStandardEU {
            get {
                return this.emissionStandardEUField;
            }
            set {
                this.emissionStandardEUField = value;
                this.RaisePropertyChanged("emissionStandardEU");
                this.emissionStandardEUFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emissionStandardEUSpecified {
            get {
                return this.emissionStandardEUFieldSpecified;
            }
            set {
                this.emissionStandardEUFieldSpecified = value;
                this.RaisePropertyChanged("emissionStandardEUSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.vehicleprofile.EmissionStandardAustralia emissionStandardAustralia {
            get {
                return this.emissionStandardAustraliaField;
            }
            set {
                this.emissionStandardAustraliaField = value;
                this.RaisePropertyChanged("emissionStandardAustralia");
                this.emissionStandardAustraliaFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emissionStandardAustraliaSpecified {
            get {
                return this.emissionStandardAustraliaFieldSpecified;
            }
            set {
                this.emissionStandardAustraliaFieldSpecified = value;
                this.RaisePropertyChanged("emissionStandardAustraliaSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lowEmissionZoneTypes {
            get {
                return this.lowEmissionZoneTypesField;
            }
            set {
                this.lowEmissionZoneTypesField = value;
                this.RaisePropertyChanged("lowEmissionZoneTypes");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public partial class LegalCondition : object, System.ComponentModel.INotifyPropertyChanged {

        private bool isEmergencyField;
        private bool isEmergencyFieldSpecified;
        private bool isDeliveryField;
        private bool isDeliveryFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isEmergency {
            get {
                return this.isEmergencyField;
            }
            set {
                this.isEmergencyField = value;
                this.RaisePropertyChanged("isEmergency");
                this.isEmergencyFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEmergencySpecified {
            get {
                return this.isEmergencyFieldSpecified;
            }
            set {
                this.isEmergencyFieldSpecified = value;
                this.RaisePropertyChanged("isEmergencySpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isDelivery {
            get {
                return this.isDeliveryField;
            }
            set {
                this.isDeliveryField = value;
                this.RaisePropertyChanged("isDelivery");
                this.isDeliveryFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDeliverySpecified {
            get {
                return this.isDeliveryFieldSpecified;
            }
            set {
                this.isDeliveryFieldSpecified = value;
                this.RaisePropertyChanged("isDeliverySpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public partial class Load : object, System.ComponentModel.INotifyPropertyChanged {

        private string hazardousGoodsTypesField;
        private com.ptvgroup.xserver.vehicleprofile.LoadType loadTypeField;
        private bool loadTypeFieldSpecified;
        private com.ptvgroup.xserver.vehicleprofile.TunnelRestrictionCode tunnelRestrictionCodeField;
        private bool tunnelRestrictionCodeFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hazardousGoodsTypes {
            get {
                return this.hazardousGoodsTypesField;
            }
            set {
                this.hazardousGoodsTypesField = value;
                this.RaisePropertyChanged("hazardousGoodsTypes");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.vehicleprofile.LoadType loadType {
            get {
                return this.loadTypeField;
            }
            set {
                this.loadTypeField = value;
                this.RaisePropertyChanged("loadType");
                this.loadTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool loadTypeSpecified {
            get {
                return this.loadTypeFieldSpecified;
            }
            set {
                this.loadTypeFieldSpecified = value;
                this.RaisePropertyChanged("loadTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.vehicleprofile.TunnelRestrictionCode tunnelRestrictionCode {
            get {
                return this.tunnelRestrictionCodeField;
            }
            set {
                this.tunnelRestrictionCodeField = value;
                this.RaisePropertyChanged("tunnelRestrictionCode");
                this.tunnelRestrictionCodeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tunnelRestrictionCodeSpecified {
            get {
                return this.tunnelRestrictionCodeFieldSpecified;
            }
            set {
                this.tunnelRestrictionCodeFieldSpecified = value;
                this.RaisePropertyChanged("tunnelRestrictionCodeSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public partial class SpeedRangesByNetworkClass : object, System.ComponentModel.INotifyPropertyChanged {

        private double[] maximumSpeedsField;
        private double[] minimumSpeedsField;

                    [System.Xml.Serialization.XmlElementAttribute("maximumSpeeds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double[] maximumSpeeds {
            get {
                return this.maximumSpeedsField;
            }
            set {
                this.maximumSpeedsField = value;
                this.RaisePropertyChanged("maximumSpeeds");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("minimumSpeeds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double[] minimumSpeeds {
            get {
                return this.minimumSpeedsField;
            }
            set {
                this.minimumSpeedsField = value;
                this.RaisePropertyChanged("minimumSpeeds");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public partial class Speeds : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.vehicleprofile.SpeedRangesByNetworkClass speedRangesByNetworkClassField;
        private double speedForLinkDistanceField;
        private bool speedForLinkDistanceFieldSpecified;
        private double maximumSpeedField;
        private bool maximumSpeedFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("speedRangesByNetworkClass", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.vehicleprofile.SpeedRangesByNetworkClass speedRangesByNetworkClass {
            get {
                return this.speedRangesByNetworkClassField;
            }
            set {
                this.speedRangesByNetworkClassField = value;
                this.RaisePropertyChanged("speedRangesByNetworkClass");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double speedForLinkDistance {
            get {
                return this.speedForLinkDistanceField;
            }
            set {
                this.speedForLinkDistanceField = value;
                this.RaisePropertyChanged("speedForLinkDistance");
                this.speedForLinkDistanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool speedForLinkDistanceSpecified {
            get {
                return this.speedForLinkDistanceFieldSpecified;
            }
            set {
                this.speedForLinkDistanceFieldSpecified = value;
                this.RaisePropertyChanged("speedForLinkDistanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maximumSpeed {
            get {
                return this.maximumSpeedField;
            }
            set {
                this.maximumSpeedField = value;
                this.RaisePropertyChanged("maximumSpeed");
                this.maximumSpeedFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumSpeedSpecified {
            get {
                return this.maximumSpeedFieldSpecified;
            }
            set {
                this.maximumSpeedFieldSpecified = value;
                this.RaisePropertyChanged("maximumSpeedSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public partial class VehicleProfile : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.vehicleprofile.Engine engineField;
        private com.ptvgroup.xserver.vehicleprofile.Weight weightField;
        private com.ptvgroup.xserver.vehicleprofile.Dimensions dimensionsField;
        private com.ptvgroup.xserver.vehicleprofile.Axle axleField;
        private com.ptvgroup.xserver.vehicleprofile.LegalCondition legalConditionField;
        private com.ptvgroup.xserver.vehicleprofile.Load loadField;
        private com.ptvgroup.xserver.vehicleprofile.Speeds speedsField;
        private com.ptvgroup.xserver.vehicleprofile.DriveType driveTypeField;
        private bool driveTypeFieldSpecified;
        private int yearOfManufactureField;
        private bool yearOfManufactureFieldSpecified;
        private int numberOfPassengersField;
        private bool numberOfPassengersFieldSpecified;
        private int numberOfTrailersField;
        private bool numberOfTrailersFieldSpecified;
        private string preferredRouteTypesField;
        private string unrestrictedRouteTypesField;
        private string restrictedRouteTypesField;
        private string highlyRestrictedRouteTypesField;
        private string prohibitedRouteTypesField;
        private string electronicTollCollectionSubscriptionsField;

                    [System.Xml.Serialization.XmlElementAttribute("engine", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.vehicleprofile.Engine engine {
            get {
                return this.engineField;
            }
            set {
                this.engineField = value;
                this.RaisePropertyChanged("engine");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("weight", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.vehicleprofile.Weight weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
                this.RaisePropertyChanged("weight");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("dimensions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.vehicleprofile.Dimensions dimensions {
            get {
                return this.dimensionsField;
            }
            set {
                this.dimensionsField = value;
                this.RaisePropertyChanged("dimensions");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("axle", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.vehicleprofile.Axle axle {
            get {
                return this.axleField;
            }
            set {
                this.axleField = value;
                this.RaisePropertyChanged("axle");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("legalCondition", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.vehicleprofile.LegalCondition legalCondition {
            get {
                return this.legalConditionField;
            }
            set {
                this.legalConditionField = value;
                this.RaisePropertyChanged("legalCondition");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("load", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.vehicleprofile.Load load {
            get {
                return this.loadField;
            }
            set {
                this.loadField = value;
                this.RaisePropertyChanged("load");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("speeds", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.vehicleprofile.Speeds speeds {
            get {
                return this.speedsField;
            }
            set {
                this.speedsField = value;
                this.RaisePropertyChanged("speeds");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.vehicleprofile.DriveType driveType {
            get {
                return this.driveTypeField;
            }
            set {
                this.driveTypeField = value;
                this.RaisePropertyChanged("driveType");
                this.driveTypeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool driveTypeSpecified {
            get {
                return this.driveTypeFieldSpecified;
            }
            set {
                this.driveTypeFieldSpecified = value;
                this.RaisePropertyChanged("driveTypeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int yearOfManufacture {
            get {
                return this.yearOfManufactureField;
            }
            set {
                this.yearOfManufactureField = value;
                this.RaisePropertyChanged("yearOfManufacture");
                this.yearOfManufactureFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yearOfManufactureSpecified {
            get {
                return this.yearOfManufactureFieldSpecified;
            }
            set {
                this.yearOfManufactureFieldSpecified = value;
                this.RaisePropertyChanged("yearOfManufactureSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfPassengers {
            get {
                return this.numberOfPassengersField;
            }
            set {
                this.numberOfPassengersField = value;
                this.RaisePropertyChanged("numberOfPassengers");
                this.numberOfPassengersFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfPassengersSpecified {
            get {
                return this.numberOfPassengersFieldSpecified;
            }
            set {
                this.numberOfPassengersFieldSpecified = value;
                this.RaisePropertyChanged("numberOfPassengersSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfTrailers {
            get {
                return this.numberOfTrailersField;
            }
            set {
                this.numberOfTrailersField = value;
                this.RaisePropertyChanged("numberOfTrailers");
                this.numberOfTrailersFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfTrailersSpecified {
            get {
                return this.numberOfTrailersFieldSpecified;
            }
            set {
                this.numberOfTrailersFieldSpecified = value;
                this.RaisePropertyChanged("numberOfTrailersSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string preferredRouteTypes {
            get {
                return this.preferredRouteTypesField;
            }
            set {
                this.preferredRouteTypesField = value;
                this.RaisePropertyChanged("preferredRouteTypes");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unrestrictedRouteTypes {
            get {
                return this.unrestrictedRouteTypesField;
            }
            set {
                this.unrestrictedRouteTypesField = value;
                this.RaisePropertyChanged("unrestrictedRouteTypes");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string restrictedRouteTypes {
            get {
                return this.restrictedRouteTypesField;
            }
            set {
                this.restrictedRouteTypesField = value;
                this.RaisePropertyChanged("restrictedRouteTypes");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string highlyRestrictedRouteTypes {
            get {
                return this.highlyRestrictedRouteTypesField;
            }
            set {
                this.highlyRestrictedRouteTypesField = value;
                this.RaisePropertyChanged("highlyRestrictedRouteTypes");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string prohibitedRouteTypes {
            get {
                return this.prohibitedRouteTypesField;
            }
            set {
                this.prohibitedRouteTypesField = value;
                this.RaisePropertyChanged("prohibitedRouteTypes");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string electronicTollCollectionSubscriptions {
            get {
                return this.electronicTollCollectionSubscriptionsField;
            }
            set {
                this.electronicTollCollectionSubscriptionsField = value;
                this.RaisePropertyChanged("electronicTollCollectionSubscriptions");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public partial class Weight : object, System.ComponentModel.INotifyPropertyChanged {

        private double emptyWeightField;
        private bool emptyWeightFieldSpecified;
        private double loadWeightField;
        private bool loadWeightFieldSpecified;
        private double totalPermittedWeightField;
        private bool totalPermittedWeightFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double emptyWeight {
            get {
                return this.emptyWeightField;
            }
            set {
                this.emptyWeightField = value;
                this.RaisePropertyChanged("emptyWeight");
                this.emptyWeightFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emptyWeightSpecified {
            get {
                return this.emptyWeightFieldSpecified;
            }
            set {
                this.emptyWeightFieldSpecified = value;
                this.RaisePropertyChanged("emptyWeightSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double loadWeight {
            get {
                return this.loadWeightField;
            }
            set {
                this.loadWeightField = value;
                this.RaisePropertyChanged("loadWeight");
                this.loadWeightFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool loadWeightSpecified {
            get {
                return this.loadWeightFieldSpecified;
            }
            set {
                this.loadWeightFieldSpecified = value;
                this.RaisePropertyChanged("loadWeightSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double totalPermittedWeight {
            get {
                return this.totalPermittedWeightField;
            }
            set {
                this.totalPermittedWeightField = value;
                this.RaisePropertyChanged("totalPermittedWeight");
                this.totalPermittedWeightFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalPermittedWeightSpecified {
            get {
                return this.totalPermittedWeightFieldSpecified;
            }
            set {
                this.totalPermittedWeightFieldSpecified = value;
                this.RaisePropertyChanged("totalPermittedWeightSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public enum DriveType {
        /**
         * All common motor vehicles, e.g. cars, trucks, motorcycles etc.
         */
        MOTOR_VEHICLE,

        /**
         * Bicycles and other vehicles with very limited engines such as e-bikes or mopeds.
         */
        BICYCLE,

        /**
         * Pedestrians
         */
        PEDESTRIAN
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public enum EmissionStandardAustralia {
        /**
         * The vehicle is not assigned an emission standard for Australia.
         */
        NONE,

        /**
         * Australian design rule 30.
         */
        ADR_30,

        /**
         * Australian design rule 70/00.
         */
        ADR_70_00,

        /**
         * Australian design rule 80/00.
         */
        ADR_80_00,

        /**
         * Australian design rule 80/02.
         */
        ADR_80_02,

        /**
         * Australian design rule 80/03.
         */
        ADR_80_03,

        /**
         * Australian design rule 80/04.
         */
        ADR_80_04,

        /**
         * Australian design rule 80/05.
         */
        ADR_80_05
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public enum EmissionStandardEU {
        /**
         * The vehicle is not assigned an emission standard for the European Union.
         */
        NONE,

        /**
         * Euro 0 standards (old standards 1988-1992).
         */
        EURO_0,

        /**
         * Euro 1 standards (also known as EC 93): Directives 91/441/EEC (passenger cars only) or 93/59/EEC (passenger cars and light trucks).
         */
        EURO_1,

        /**
         * Euro 2 standards (EC 96): Directives 94/12/EC and 96/69/EC for passenger cars, 2002/51/EC(row A)-2006/120/EC for motorcycle.
         */
        EURO_2,

        /**
         * Euro 3 standards (2000): Directives 98/69/EC for any vehicle, 2002/51/EC(row A)-2006/120/EC for motorcycle.
         */
        EURO_3,

        /**
         * Euro 4 standards (2005): Directives 98/69/EC and 2002/80/EC for any vehicle.
         */
        EURO_4,

        /**
         * Euro 5 standards (2008/9): Directive 715/2007/EC for any vehicle.
         */
        EURO_5,

        /**
         * Standards for enhanced environmentally friendly vehicles. The standard lies between the levels of Euro V and Euro VI.
         */
        EURO_EEV,

        /**
         * Euro 6 standards (2014): Directive 715/2007/EC for any vehicle. Includes 6a and 6b.
         */
        EURO_6,

        /**
         * Euro 6c standards (2017): for passenger cars and light trucks.
         */
        EURO_6c,

        /**
         * Euro 7 standards (to appear).
         */
        EURO_7
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public enum EmissionTechnology {
        /**
         * No emission reduction technology.
         */
        NONE,

        /**
         * Exhaust gas recirculation technology.
         */
        EXHAUST_GAS_RECIRCULATION,

        /**
         * Selective catalytic reduction.
         */
        SELECTIVE_CATALYTIC_REDUCTION
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public enum EngineType {
        /**
         * Combustion. Further distinction by FuelType.
         */
        COMBUSTION,

        /**
         * Electric. Includes energy sources like battery or hydrogen fuel cell.
         */
        ELECTRIC
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public enum FuelType {
        /**
         * Gasoline (also known as petrol or benzine).
         */
        GASOLINE,

        /**
         * Diesel.
         */
        DIESEL,

        /**
         * Compressed natural gas.
         */
        COMPRESSED_NATURAL_GAS,

        /**
         * Liquefied petroleum gas.
         */
        LIQUEFIED_PETROLEUM_GAS
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public enum LoadType {
        /**
         * The vehicle transports passengers.
         */
        PASSENGER,

        /**
         * The vehicle transports goods.
         */
        GOODS
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public enum ParticleReductionClass {
        /**
         * Particle reduction class PMK 0.
         */
        PMK_0,

        /**
         * Particle reduction class PMK 1.
         */
        PMK_1,

        /**
         * Particle reduction class PMK 2.
         */
        PMK_2,

        /**
         * Particle reduction class PMK 3.
         */
        PMK_3,

        /**
         * Particle reduction class PMK 4.
         */
        PMK_4
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vehicleprofile.xserver.ptvgroup.com")]
    public enum TunnelRestrictionCode {
        /**
         * No restrictions for the transport of dangerous goods.
         */
        NONE,

        /**
         * Passage forbidden through tunnels of category B, C, D and E.
         */
        B,

        /**
         * Passage forbidden through tunnels of category C, D and E.
         */
        C,

        /**
         * Passage forbidden through tunnels of category D and E.
         */
        D,

        /**
         * Passage forbidden through tunnels of category E.
         */
        E
    }


}
