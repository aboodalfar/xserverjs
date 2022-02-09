// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.emissions 
{
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValueScenario_AUSTRALIAN_NGA_FACTORS_2015))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValueScenario_EMISIA_COPERT_AUSTRALIA_1_2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValueScenario_EN16258_2012))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValueScenario_EN16258_DEFRA_2014))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValueScenario_FRENCH_CO2E_DECREE_2017_639))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValueScenario_FRENCH_CO2_DECREE_2011_1336))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValueScenario_HBEFA_3_2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValueScenario_HBEFA_4))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public abstract partial class EmissionValueScenario : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValueScenario_AUSTRALIAN_NGA_FACTORS_2015 : com.ptvgroup.xserver.emissions.EmissionValueScenario {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_AUSTRALIAN_NGA_FACTORS_2015[] scenariosField;

                    [System.Xml.Serialization.XmlElementAttribute("scenarios", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_AUSTRALIAN_NGA_FACTORS_2015[] scenarios {
            get {
                return this.scenariosField;
            }
            set {
                this.scenariosField = value;
                this.RaisePropertyChanged("scenarios");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValueScenario_EMISIA_COPERT_AUSTRALIA_1_2 : com.ptvgroup.xserver.emissions.EmissionValueScenario {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EMISIA_COPERT_AUSTRALIA_1_2[] scenariosField;

                    [System.Xml.Serialization.XmlElementAttribute("scenarios", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EMISIA_COPERT_AUSTRALIA_1_2[] scenarios {
            get {
                return this.scenariosField;
            }
            set {
                this.scenariosField = value;
                this.RaisePropertyChanged("scenarios");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValueScenario_EN16258_2012 : com.ptvgroup.xserver.emissions.EmissionValueScenario {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EN16258_2012[] scenariosField;

                    [System.Xml.Serialization.XmlElementAttribute("scenarios", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EN16258_2012[] scenarios {
            get {
                return this.scenariosField;
            }
            set {
                this.scenariosField = value;
                this.RaisePropertyChanged("scenarios");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValueScenario_EN16258_DEFRA_2014 : com.ptvgroup.xserver.emissions.EmissionValueScenario {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EN16258_DEFRA_2014[] scenariosField;

                    [System.Xml.Serialization.XmlElementAttribute("scenarios", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EN16258_DEFRA_2014[] scenarios {
            get {
                return this.scenariosField;
            }
            set {
                this.scenariosField = value;
                this.RaisePropertyChanged("scenarios");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValueScenario_FRENCH_CO2E_DECREE_2017_639 : com.ptvgroup.xserver.emissions.EmissionValueScenario {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_FRENCH_CO2E_DECREE_2017_639[] scenariosField;

                    [System.Xml.Serialization.XmlElementAttribute("scenarios", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_FRENCH_CO2E_DECREE_2017_639[] scenarios {
            get {
                return this.scenariosField;
            }
            set {
                this.scenariosField = value;
                this.RaisePropertyChanged("scenarios");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValueScenario_FRENCH_CO2_DECREE_2011_1336 : com.ptvgroup.xserver.emissions.EmissionValueScenario {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_FRENCH_CO2_DECREE_2011_1336[] scenariosField;

                    [System.Xml.Serialization.XmlElementAttribute("scenarios", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_FRENCH_CO2_DECREE_2011_1336[] scenarios {
            get {
                return this.scenariosField;
            }
            set {
                this.scenariosField = value;
                this.RaisePropertyChanged("scenarios");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValueScenario_HBEFA_3_2 : com.ptvgroup.xserver.emissions.EmissionValueScenario {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_HBEFA_3_2[] scenariosField;

                    [System.Xml.Serialization.XmlElementAttribute("scenarios", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_HBEFA_3_2[] scenarios {
            get {
                return this.scenariosField;
            }
            set {
                this.scenariosField = value;
                this.RaisePropertyChanged("scenarios");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValueScenario_HBEFA_4 : com.ptvgroup.xserver.emissions.EmissionValueScenario {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_HBEFA_4[] scenariosField;

                    [System.Xml.Serialization.XmlElementAttribute("scenarios", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_HBEFA_4[] scenarios {
            get {
                return this.scenariosField;
            }
            set {
                this.scenariosField = value;
                this.RaisePropertyChanged("scenarios");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValues_AUSTRALIAN_NGA_FACTORS_2015))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValues_EMISIA_COPERT_AUSTRALIA_1_2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValues_EN16258_2012))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValues_EN16258_DEFRA_2014))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValues_FRENCH_CO2E_DECREE_2017_639))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValues_FRENCH_CO2_DECREE_2011_1336))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValues_HBEFA_3_2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.emissions.EmissionValues_HBEFA_4))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public abstract partial class EmissionValues : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.emissions.EmissionStandardType standardTypeField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.emissions.EmissionStandardType standardType {
            get {
                return this.standardTypeField;
            }
            set {
                this.standardTypeField = value;
                this.RaisePropertyChanged("standardType");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValues_AUSTRALIAN_NGA_FACTORS_2015 : com.ptvgroup.xserver.emissions.EmissionValues {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_AUSTRALIAN_NGA_FACTORS_2015 valueScenarioTypeField;
        private double fuelConsumptionField;
        private double energyUseTankToWheelField;
        private double co2eWellToWheelField;
        private double co2eTankToWheelField;
        private double co2TankToWheelField;
        private double ch4TankToWheelField;
        private double n2oTankToWheelField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_AUSTRALIAN_NGA_FACTORS_2015 valueScenarioType {
            get {
                return this.valueScenarioTypeField;
            }
            set {
                this.valueScenarioTypeField = value;
                this.RaisePropertyChanged("valueScenarioType");
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
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double energyUseTankToWheel {
            get {
                return this.energyUseTankToWheelField;
            }
            set {
                this.energyUseTankToWheelField = value;
                this.RaisePropertyChanged("energyUseTankToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2eWellToWheel {
            get {
                return this.co2eWellToWheelField;
            }
            set {
                this.co2eWellToWheelField = value;
                this.RaisePropertyChanged("co2eWellToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2eTankToWheel {
            get {
                return this.co2eTankToWheelField;
            }
            set {
                this.co2eTankToWheelField = value;
                this.RaisePropertyChanged("co2eTankToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2TankToWheel {
            get {
                return this.co2TankToWheelField;
            }
            set {
                this.co2TankToWheelField = value;
                this.RaisePropertyChanged("co2TankToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double ch4TankToWheel {
            get {
                return this.ch4TankToWheelField;
            }
            set {
                this.ch4TankToWheelField = value;
                this.RaisePropertyChanged("ch4TankToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double n2oTankToWheel {
            get {
                return this.n2oTankToWheelField;
            }
            set {
                this.n2oTankToWheelField = value;
                this.RaisePropertyChanged("n2oTankToWheel");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValues_EMISIA_COPERT_AUSTRALIA_1_2 : com.ptvgroup.xserver.emissions.EmissionValues {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EMISIA_COPERT_AUSTRALIA_1_2 valueScenarioTypeField;
        private double carbonDioxideField;
        private double fuelConsumptionField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EMISIA_COPERT_AUSTRALIA_1_2 valueScenarioType {
            get {
                return this.valueScenarioTypeField;
            }
            set {
                this.valueScenarioTypeField = value;
                this.RaisePropertyChanged("valueScenarioType");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double carbonDioxide {
            get {
                return this.carbonDioxideField;
            }
            set {
                this.carbonDioxideField = value;
                this.RaisePropertyChanged("carbonDioxide");
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
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValues_EN16258_2012 : com.ptvgroup.xserver.emissions.EmissionValues {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EN16258_2012 valueScenarioTypeField;
        private double fuelConsumptionField;
        private double energyUseTankToWheelField;
        private double energyUseWellToWheelField;
        private double co2eTankToWheelField;
        private double co2eWellToWheelField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EN16258_2012 valueScenarioType {
            get {
                return this.valueScenarioTypeField;
            }
            set {
                this.valueScenarioTypeField = value;
                this.RaisePropertyChanged("valueScenarioType");
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
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double energyUseTankToWheel {
            get {
                return this.energyUseTankToWheelField;
            }
            set {
                this.energyUseTankToWheelField = value;
                this.RaisePropertyChanged("energyUseTankToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double energyUseWellToWheel {
            get {
                return this.energyUseWellToWheelField;
            }
            set {
                this.energyUseWellToWheelField = value;
                this.RaisePropertyChanged("energyUseWellToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2eTankToWheel {
            get {
                return this.co2eTankToWheelField;
            }
            set {
                this.co2eTankToWheelField = value;
                this.RaisePropertyChanged("co2eTankToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2eWellToWheel {
            get {
                return this.co2eWellToWheelField;
            }
            set {
                this.co2eWellToWheelField = value;
                this.RaisePropertyChanged("co2eWellToWheel");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValues_EN16258_DEFRA_2014 : com.ptvgroup.xserver.emissions.EmissionValues {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EN16258_DEFRA_2014 valueScenarioTypeField;
        private double fuelConsumptionField;
        private double energyUseTankToWheelField;
        private double co2eTankToWheelField;
        private double co2eWellToWheelField;
        private double co2TankToWheelField;
        private double ch4TankToWheelField;
        private double n2oTankToWheelField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_EN16258_DEFRA_2014 valueScenarioType {
            get {
                return this.valueScenarioTypeField;
            }
            set {
                this.valueScenarioTypeField = value;
                this.RaisePropertyChanged("valueScenarioType");
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
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double energyUseTankToWheel {
            get {
                return this.energyUseTankToWheelField;
            }
            set {
                this.energyUseTankToWheelField = value;
                this.RaisePropertyChanged("energyUseTankToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2eTankToWheel {
            get {
                return this.co2eTankToWheelField;
            }
            set {
                this.co2eTankToWheelField = value;
                this.RaisePropertyChanged("co2eTankToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2eWellToWheel {
            get {
                return this.co2eWellToWheelField;
            }
            set {
                this.co2eWellToWheelField = value;
                this.RaisePropertyChanged("co2eWellToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2TankToWheel {
            get {
                return this.co2TankToWheelField;
            }
            set {
                this.co2TankToWheelField = value;
                this.RaisePropertyChanged("co2TankToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double ch4TankToWheel {
            get {
                return this.ch4TankToWheelField;
            }
            set {
                this.ch4TankToWheelField = value;
                this.RaisePropertyChanged("ch4TankToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double n2oTankToWheel {
            get {
                return this.n2oTankToWheelField;
            }
            set {
                this.n2oTankToWheelField = value;
                this.RaisePropertyChanged("n2oTankToWheel");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValues_FRENCH_CO2E_DECREE_2017_639 : com.ptvgroup.xserver.emissions.EmissionValues {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_FRENCH_CO2E_DECREE_2017_639 valueScenarioTypeField;
        private double co2eWellToWheelField;
        private double co2eTankToWheelField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_FRENCH_CO2E_DECREE_2017_639 valueScenarioType {
            get {
                return this.valueScenarioTypeField;
            }
            set {
                this.valueScenarioTypeField = value;
                this.RaisePropertyChanged("valueScenarioType");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2eWellToWheel {
            get {
                return this.co2eWellToWheelField;
            }
            set {
                this.co2eWellToWheelField = value;
                this.RaisePropertyChanged("co2eWellToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2eTankToWheel {
            get {
                return this.co2eTankToWheelField;
            }
            set {
                this.co2eTankToWheelField = value;
                this.RaisePropertyChanged("co2eTankToWheel");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValues_FRENCH_CO2_DECREE_2011_1336 : com.ptvgroup.xserver.emissions.EmissionValues {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_FRENCH_CO2_DECREE_2011_1336 valueScenarioTypeField;
        private double co2WellToWheelField;
        private double co2TankToWheelField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_FRENCH_CO2_DECREE_2011_1336 valueScenarioType {
            get {
                return this.valueScenarioTypeField;
            }
            set {
                this.valueScenarioTypeField = value;
                this.RaisePropertyChanged("valueScenarioType");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2WellToWheel {
            get {
                return this.co2WellToWheelField;
            }
            set {
                this.co2WellToWheelField = value;
                this.RaisePropertyChanged("co2WellToWheel");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double co2TankToWheel {
            get {
                return this.co2TankToWheelField;
            }
            set {
                this.co2TankToWheelField = value;
                this.RaisePropertyChanged("co2TankToWheel");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValues_HBEFA_3_2 : com.ptvgroup.xserver.emissions.EmissionValues {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_HBEFA_3_2 valueScenarioTypeField;
        private double fuelConsumptionField;
        private double hydrocarbonsField;
        private double methaneField;
        private double hydrocarbonsExceptMethaneField;
        private double carbonMonoxideField;
        private double carbonDioxideField;
        private double fossilCarbonDioxideField;
        private double sulphurDioxideField;
        private double nitrogenOxidesField;
        private double nitrogenDioxideField;
        private double nitrousOxideField;
        private double ammoniaField;
        private double benzeneField;
        private double particlesField;
        private double numberOfParticlesField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_HBEFA_3_2 valueScenarioType {
            get {
                return this.valueScenarioTypeField;
            }
            set {
                this.valueScenarioTypeField = value;
                this.RaisePropertyChanged("valueScenarioType");
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
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double hydrocarbons {
            get {
                return this.hydrocarbonsField;
            }
            set {
                this.hydrocarbonsField = value;
                this.RaisePropertyChanged("hydrocarbons");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double methane {
            get {
                return this.methaneField;
            }
            set {
                this.methaneField = value;
                this.RaisePropertyChanged("methane");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double hydrocarbonsExceptMethane {
            get {
                return this.hydrocarbonsExceptMethaneField;
            }
            set {
                this.hydrocarbonsExceptMethaneField = value;
                this.RaisePropertyChanged("hydrocarbonsExceptMethane");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double carbonMonoxide {
            get {
                return this.carbonMonoxideField;
            }
            set {
                this.carbonMonoxideField = value;
                this.RaisePropertyChanged("carbonMonoxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double carbonDioxide {
            get {
                return this.carbonDioxideField;
            }
            set {
                this.carbonDioxideField = value;
                this.RaisePropertyChanged("carbonDioxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double fossilCarbonDioxide {
            get {
                return this.fossilCarbonDioxideField;
            }
            set {
                this.fossilCarbonDioxideField = value;
                this.RaisePropertyChanged("fossilCarbonDioxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double sulphurDioxide {
            get {
                return this.sulphurDioxideField;
            }
            set {
                this.sulphurDioxideField = value;
                this.RaisePropertyChanged("sulphurDioxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double nitrogenOxides {
            get {
                return this.nitrogenOxidesField;
            }
            set {
                this.nitrogenOxidesField = value;
                this.RaisePropertyChanged("nitrogenOxides");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double nitrogenDioxide {
            get {
                return this.nitrogenDioxideField;
            }
            set {
                this.nitrogenDioxideField = value;
                this.RaisePropertyChanged("nitrogenDioxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double nitrousOxide {
            get {
                return this.nitrousOxideField;
            }
            set {
                this.nitrousOxideField = value;
                this.RaisePropertyChanged("nitrousOxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double ammonia {
            get {
                return this.ammoniaField;
            }
            set {
                this.ammoniaField = value;
                this.RaisePropertyChanged("ammonia");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double benzene {
            get {
                return this.benzeneField;
            }
            set {
                this.benzeneField = value;
                this.RaisePropertyChanged("benzene");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double particles {
            get {
                return this.particlesField;
            }
            set {
                this.particlesField = value;
                this.RaisePropertyChanged("particles");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double numberOfParticles {
            get {
                return this.numberOfParticlesField;
            }
            set {
                this.numberOfParticlesField = value;
                this.RaisePropertyChanged("numberOfParticles");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class EmissionValues_HBEFA_4 : com.ptvgroup.xserver.emissions.EmissionValues {

        private com.ptvgroup.xserver.emissions.EmissionValueScenarioType_HBEFA_4 valueScenarioTypeField;
        private double fuelConsumptionField;
        private double hydrocarbonsField;
        private double methaneField;
        private double hydrocarbonsExceptMethaneField;
        private double carbonMonoxideField;
        private double carbonDioxideField;
        private double fossilCarbonDioxideField;
        private double sulphurDioxideField;
        private double nitrogenOxidesField;
        private double nitrogenDioxideField;
        private double nitrousOxideField;
        private double ammoniaField;
        private double benzeneField;
        private double particlesField;
        private double numberOfParticlesField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.emissions.EmissionValueScenarioType_HBEFA_4 valueScenarioType {
            get {
                return this.valueScenarioTypeField;
            }
            set {
                this.valueScenarioTypeField = value;
                this.RaisePropertyChanged("valueScenarioType");
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
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double hydrocarbons {
            get {
                return this.hydrocarbonsField;
            }
            set {
                this.hydrocarbonsField = value;
                this.RaisePropertyChanged("hydrocarbons");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double methane {
            get {
                return this.methaneField;
            }
            set {
                this.methaneField = value;
                this.RaisePropertyChanged("methane");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double hydrocarbonsExceptMethane {
            get {
                return this.hydrocarbonsExceptMethaneField;
            }
            set {
                this.hydrocarbonsExceptMethaneField = value;
                this.RaisePropertyChanged("hydrocarbonsExceptMethane");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double carbonMonoxide {
            get {
                return this.carbonMonoxideField;
            }
            set {
                this.carbonMonoxideField = value;
                this.RaisePropertyChanged("carbonMonoxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double carbonDioxide {
            get {
                return this.carbonDioxideField;
            }
            set {
                this.carbonDioxideField = value;
                this.RaisePropertyChanged("carbonDioxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double fossilCarbonDioxide {
            get {
                return this.fossilCarbonDioxideField;
            }
            set {
                this.fossilCarbonDioxideField = value;
                this.RaisePropertyChanged("fossilCarbonDioxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double sulphurDioxide {
            get {
                return this.sulphurDioxideField;
            }
            set {
                this.sulphurDioxideField = value;
                this.RaisePropertyChanged("sulphurDioxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double nitrogenOxides {
            get {
                return this.nitrogenOxidesField;
            }
            set {
                this.nitrogenOxidesField = value;
                this.RaisePropertyChanged("nitrogenOxides");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double nitrogenDioxide {
            get {
                return this.nitrogenDioxideField;
            }
            set {
                this.nitrogenDioxideField = value;
                this.RaisePropertyChanged("nitrogenDioxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double nitrousOxide {
            get {
                return this.nitrousOxideField;
            }
            set {
                this.nitrousOxideField = value;
                this.RaisePropertyChanged("nitrousOxide");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double ammonia {
            get {
                return this.ammoniaField;
            }
            set {
                this.ammoniaField = value;
                this.RaisePropertyChanged("ammonia");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double benzene {
            get {
                return this.benzeneField;
            }
            set {
                this.benzeneField = value;
                this.RaisePropertyChanged("benzene");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double particles {
            get {
                return this.particlesField;
            }
            set {
                this.particlesField = value;
                this.RaisePropertyChanged("particles");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double numberOfParticles {
            get {
                return this.numberOfParticlesField;
            }
            set {
                this.numberOfParticlesField = value;
                this.RaisePropertyChanged("numberOfParticles");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public partial class Emissions : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.emissions.EmissionValues[] valuesField;

                    [System.Xml.Serialization.XmlElementAttribute("values", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.emissions.EmissionValues[] values {
            get {
                return this.valuesField;
            }
            set {
                this.valuesField = value;
                this.RaisePropertyChanged("values");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public enum EmissionStandardType {
        /**
         * The emission calculation based on the Handbook of Emission Factors for Road Transport (HBEFA). HBEFA 3.2 calculation reports values for all global warming gases and other harmful substances. The internal process is independently certificated and therefore is independent of any external organizations.
         */
        HBEFA_3_2,

        /**
         * The emission calculation based on the Handbook of Emission Factors for Road Transport (HBEFA). HBEFA 4 calculation reports values for all global warming gases and other harmful substances. The internal process is independently certificated and therefore is independent of any external organizations.
         */
        HBEFA_4,

        /**
         * The emission calculation based on the Computer Program to calculate Emissions from Road Transport (COPERT). The COPERT Australia emission calculation reports values for CO2 and fuel consumption.
         */
        EMISIA_COPERT_AUSTRALIA_1_2,

        /**
         * The emission calculation according to the European CEN standard (EN16258).
         */
        EN16258_2012,

        /**
         * Emission calculation according to the French CO2 decree uses various calculation factors for the average fuel consumption of a vehicle. Only the following biofuel blends are supported: E10, E85 and B30. These blends can be set using the VehicleParameters FUEL_TYPE and BIO_FUEL_RATIO.
         */
        FRENCH_CO2_DECREE_2011_1336,

        /**
         * The emission calculation based on the emission factors provided by the Department for Environment, Food &#38; Rural Affairs (Defra) in the United Kingdom , factors 2014.
         */
        EN16258_DEFRA_2014,

        /**
         * The emission calculation based on the Australian National Greenhouse Accounts (NGA), factors 2015. To specify the emission class and the year of manufacture for each vehicle.
         */
        AUSTRALIAN_NGA_FACTORS_2015,

        /**
         * Emission calculation according to the 2017 French CO2E decree uses various calculation factors for the average fuel consumption of a vehicle. Only the following biofuel blends are supported: E10, E85 and B30. These blends can be set using the VehicleParameters FUEL_TYPE and BIO_FUEL_RATIO.
         */
        FRENCH_CO2E_DECREE_2017_639
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public enum EmissionValueScenarioType_AUSTRALIAN_NGA_FACTORS_2015 {
        /**
         * The calculation of emissions is based on the current vehicle profile.
         */
        VEHICLE_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The average fuel consumption for a fleet in [l/100km] for liquid fuel types or [kg/100km] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        FLEET_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The average fuel consumption for a specific type of route in [l/100km] for liquid fuel types or [kg/100km] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        ROUTE_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The actual fuel consumption for this route in [l] for liquid fuel types or [kg] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        ACTUAL_FUEL_CONSUMPTION
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public enum EmissionValueScenarioType_EMISIA_COPERT_AUSTRALIA_1_2 {
        /**
         * The emissions are calculated on the current route, considering the current vehicle profile.
         */
        CURRENT_ROUTE
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public enum EmissionValueScenarioType_EN16258_2012 {
        /**
         * The calculation of emissions is based on the current vehicle profile.
         */
        VEHICLE_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The average fuel consumption for a fleet in [l/100km] for liquid fuel types or [kg/100km] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        FLEET_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The average fuel consumption for a specific type of route in [l/100km] for liquid fuel types or [kg/100km] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        ROUTE_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The actual fuel consumption for this route in [l] for liquid fuel types or [kg] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        ACTUAL_FUEL_CONSUMPTION,

        /**
         * The emissions based on the fuel consumption as it was calculated by the latest HBEFA version available.
         */
        HBEFA_BASED_FUEL_CONSUMPTION
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public enum EmissionValueScenarioType_EN16258_DEFRA_2014 {
        /**
         * The calculation of emissions is based on the current vehicle profile.
         */
        VEHICLE_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The average fuel consumption for a fleet in [l/100km] for liquid fuel types or [kg/100km] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        FLEET_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The average fuel consumption for a specific type of route in [l/100km] for liquid fuel types or [kg/100km] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        ROUTE_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The actual fuel consumption for this route in [l] for liquid fuel types or [kg] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        ACTUAL_FUEL_CONSUMPTION
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public enum EmissionValueScenarioType_FRENCH_CO2E_DECREE_2017_639 {
        /**
         * The calculation of emissions is based on the current vehicle profile.
         */
        VEHICLE_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The average fuel consumption for a fleet in [l/100km] for liquid fuel types or [kg/100km] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        FLEET_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The average fuel consumption for a specific type of route in [l/100km] for liquid fuel types or [kg/100km] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        ROUTE_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The actual fuel consumption for this route in [l] for liquid fuel types or [kg] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        ACTUAL_FUEL_CONSUMPTION
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public enum EmissionValueScenarioType_FRENCH_CO2_DECREE_2011_1336 {
        /**
         * The calculation of emissions is based on the current vehicle profile.
         */
        VEHICLE_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The average fuel consumption for a fleet in [l/100km] for liquid fuel types or [kg/100km] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        FLEET_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The average fuel consumption for a specific type of route in [l/100km] for liquid fuel types or [kg/100km] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        ROUTE_SPECIFIC_AVERAGE_FUEL_CONSUMPTION,

        /**
         * The actual fuel consumption for this route in [l] for liquid fuel types or [kg] for gaseous fuel types like COMPRESSED_NATURAL_GAS.
         */
        ACTUAL_FUEL_CONSUMPTION
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public enum EmissionValueScenarioType_HBEFA_3_2 {
        /**
         * The emissions are calculated on the current route, considering the current vehicle profile.
         */
        CURRENT_ROUTE
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://emissions.xserver.ptvgroup.com")]
    public enum EmissionValueScenarioType_HBEFA_4 {
        /**
         * The emissions are calculated on the current route, considering the current vehicle profile.
         */
        CURRENT_ROUTE
    }


}
