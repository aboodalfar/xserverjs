// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.time 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://time.xserver.ptvgroup.com")]
    public partial class GDFTimeDomain : com.ptvgroup.xserver.time.Interval {

        private string timeDomainField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string timeDomain {
            get {
                return this.timeDomainField;
            }
            set {
                this.timeDomainField = value;
                this.RaisePropertyChanged("timeDomain");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.time.GDFTimeDomain))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.time.StartDurationInterval))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.time.StartEndInterval))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://time.xserver.ptvgroup.com")]
    public abstract partial class Interval : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://time.xserver.ptvgroup.com")]
    public partial class StartDurationInterval : com.ptvgroup.xserver.time.Interval {

        private System.DateTime startField;
        private double durationField;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
                this.RaisePropertyChanged("start");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double duration {
            get {
                return this.durationField;
            }
            set {
                this.durationField = value;
                this.RaisePropertyChanged("duration");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://time.xserver.ptvgroup.com")]
    public partial class StartEndInterval : com.ptvgroup.xserver.time.Interval {

        private System.DateTime startField;
        private System.DateTime endField;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
                this.RaisePropertyChanged("start");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime end {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
                this.RaisePropertyChanged("end");
            }
        }


    }



}
