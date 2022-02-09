// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.types 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://types.xserver.ptvgroup.com")]
    public partial class ConsumptionFactorAtSpeed : object, System.ComponentModel.INotifyPropertyChanged {

        private double speedField;
        private double factorField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double speed {
            get {
                return this.speedField;
            }
            set {
                this.speedField = value;
                this.RaisePropertyChanged("speed");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double factor {
            get {
                return this.factorField;
            }
            set {
                this.factorField = value;
                this.RaisePropertyChanged("factor");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://types.xserver.ptvgroup.com")]
    public partial class Cost : object, System.ComponentModel.INotifyPropertyChanged {

        private double amountField;
        private string currencyField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
                this.RaisePropertyChanged("amount");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
                this.RaisePropertyChanged("currency");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://types.xserver.ptvgroup.com")]
    public partial class IndexInterval : object, System.ComponentModel.INotifyPropertyChanged {

        private int startField;
        private int endField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
                this.RaisePropertyChanged("start");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int end {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
                this.RaisePropertyChanged("end");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://types.xserver.ptvgroup.com")]
    public partial class IndexPair : object, System.ComponentModel.INotifyPropertyChanged {

        private int firstField;
        private int secondField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int first {
            get {
                return this.firstField;
            }
            set {
                this.firstField = value;
                this.RaisePropertyChanged("first");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int second {
            get {
                return this.secondField;
            }
            set {
                this.secondField = value;
                this.RaisePropertyChanged("second");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://types.xserver.ptvgroup.com")]
    public partial class IndexPairInterval : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.types.IndexPair startField;
        private com.ptvgroup.xserver.types.IndexPair endField;

                    [System.Xml.Serialization.XmlElementAttribute("start", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.IndexPair start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
                this.RaisePropertyChanged("start");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("end", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.types.IndexPair end {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
                this.RaisePropertyChanged("end");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://types.xserver.ptvgroup.com")]
    public partial class KeyValuePair : object, System.ComponentModel.INotifyPropertyChanged {

        private string keyField;
        private string valueField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
                this.RaisePropertyChanged("key");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("value");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://types.xserver.ptvgroup.com")]
    public partial class Language : object, System.ComponentModel.INotifyPropertyChanged {

        private string codeField;
        private string nameField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://types.xserver.ptvgroup.com")]
    public partial class TimeZone : object, System.ComponentModel.INotifyPropertyChanged {

        private int utcOffsetField;
        private int includedDaylightSavingTimeField;
        private bool includedDaylightSavingTimeFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int utcOffset {
            get {
                return this.utcOffsetField;
            }
            set {
                this.utcOffsetField = value;
                this.RaisePropertyChanged("utcOffset");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int includedDaylightSavingTime {
            get {
                return this.includedDaylightSavingTimeField;
            }
            set {
                this.includedDaylightSavingTimeField = value;
                this.RaisePropertyChanged("includedDaylightSavingTime");
                this.includedDaylightSavingTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includedDaylightSavingTimeSpecified {
            get {
                return this.includedDaylightSavingTimeFieldSpecified;
            }
            set {
                this.includedDaylightSavingTimeFieldSpecified = value;
                this.RaisePropertyChanged("includedDaylightSavingTimeSpecified");
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
