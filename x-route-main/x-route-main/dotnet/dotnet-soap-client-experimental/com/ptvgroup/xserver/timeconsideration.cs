// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.timeconsideration 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timeconsideration.xserver.ptvgroup.com")]
    public partial class ExactTimeConsiderationAtArrival : com.ptvgroup.xserver.timeconsideration.TimeConsideration {

        private System.DateTime referenceTimeField;
        private bool referenceTimeFieldSpecified;
        private bool simplifiedRouteCalculationField;
        private bool simplifiedRouteCalculationFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime referenceTime {
            get {
                return this.referenceTimeField;
            }
            set {
                this.referenceTimeField = value;
                this.RaisePropertyChanged("referenceTime");
                this.referenceTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referenceTimeSpecified {
            get {
                return this.referenceTimeFieldSpecified;
            }
            set {
                this.referenceTimeFieldSpecified = value;
                this.RaisePropertyChanged("referenceTimeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool simplifiedRouteCalculation {
            get {
                return this.simplifiedRouteCalculationField;
            }
            set {
                this.simplifiedRouteCalculationField = value;
                this.RaisePropertyChanged("simplifiedRouteCalculation");
                this.simplifiedRouteCalculationFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool simplifiedRouteCalculationSpecified {
            get {
                return this.simplifiedRouteCalculationFieldSpecified;
            }
            set {
                this.simplifiedRouteCalculationFieldSpecified = value;
                this.RaisePropertyChanged("simplifiedRouteCalculationSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timeconsideration.xserver.ptvgroup.com")]
    public partial class ExactTimeConsiderationAtStart : com.ptvgroup.xserver.timeconsideration.TimeConsideration {

        private System.DateTime referenceTimeField;
        private bool referenceTimeFieldSpecified;
        private bool simplifiedRouteCalculationField;
        private bool simplifiedRouteCalculationFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime referenceTime {
            get {
                return this.referenceTimeField;
            }
            set {
                this.referenceTimeField = value;
                this.RaisePropertyChanged("referenceTime");
                this.referenceTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referenceTimeSpecified {
            get {
                return this.referenceTimeFieldSpecified;
            }
            set {
                this.referenceTimeFieldSpecified = value;
                this.RaisePropertyChanged("referenceTimeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool simplifiedRouteCalculation {
            get {
                return this.simplifiedRouteCalculationField;
            }
            set {
                this.simplifiedRouteCalculationField = value;
                this.RaisePropertyChanged("simplifiedRouteCalculation");
                this.simplifiedRouteCalculationFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool simplifiedRouteCalculationSpecified {
            get {
                return this.simplifiedRouteCalculationFieldSpecified;
            }
            set {
                this.simplifiedRouteCalculationFieldSpecified = value;
                this.RaisePropertyChanged("simplifiedRouteCalculationSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timeconsideration.xserver.ptvgroup.com")]
    public partial class MultipleTravelTimesConsideration : com.ptvgroup.xserver.timeconsideration.TimeConsideration {

        private com.ptvgroup.xserver.time.StartEndInterval horizonField;

                    [System.Xml.Serialization.XmlElementAttribute("horizon", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.time.StartEndInterval horizon {
            get {
                return this.horizonField;
            }
            set {
                this.horizonField = value;
                this.RaisePropertyChanged("horizon");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timeconsideration.xserver.ptvgroup.com")]
    public partial class OptimisticTimeConsideration : com.ptvgroup.xserver.timeconsideration.TimeConsideration {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timeconsideration.xserver.ptvgroup.com")]
    public partial class SnapshotTimeConsideration : com.ptvgroup.xserver.timeconsideration.TimeConsideration {

        private System.DateTime referenceTimeField;
        private bool referenceTimeFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime referenceTime {
            get {
                return this.referenceTimeField;
            }
            set {
                this.referenceTimeField = value;
                this.RaisePropertyChanged("referenceTime");
                this.referenceTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referenceTimeSpecified {
            get {
                return this.referenceTimeFieldSpecified;
            }
            set {
                this.referenceTimeFieldSpecified = value;
                this.RaisePropertyChanged("referenceTimeSpecified");
            }
        }
        

    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.timeconsideration.ExactTimeConsiderationAtArrival))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.timeconsideration.ExactTimeConsiderationAtStart))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.timeconsideration.MultipleTravelTimesConsideration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.timeconsideration.OptimisticTimeConsideration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.timeconsideration.SnapshotTimeConsideration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.timeconsideration.TimeSpanConsideration))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timeconsideration.xserver.ptvgroup.com")]
    public abstract partial class TimeConsideration : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timeconsideration.xserver.ptvgroup.com")]
    public partial class TimeDependentContentIgnoredLimitation : com.ptvgroup.xserver.service.ResultLimitation {

        private string contentDescriptionField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contentDescription {
            get {
                return this.contentDescriptionField;
            }
            set {
                this.contentDescriptionField = value;
                this.RaisePropertyChanged("contentDescription");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timeconsideration.xserver.ptvgroup.com")]
    public partial class TimeSpanConsideration : com.ptvgroup.xserver.timeconsideration.TimeConsideration {

        private System.DateTime referenceTimeField;
        private bool referenceTimeFieldSpecified;
        private double timeSpanField;
        private bool timeSpanFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime referenceTime {
            get {
                return this.referenceTimeField;
            }
            set {
                this.referenceTimeField = value;
                this.RaisePropertyChanged("referenceTime");
                this.referenceTimeFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referenceTimeSpecified {
            get {
                return this.referenceTimeFieldSpecified;
            }
            set {
                this.referenceTimeFieldSpecified = value;
                this.RaisePropertyChanged("referenceTimeSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double timeSpan {
            get {
                return this.timeSpanField;
            }
            set {
                this.timeSpanField = value;
                this.RaisePropertyChanged("timeSpan");
                this.timeSpanFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeSpanSpecified {
            get {
                return this.timeSpanFieldSpecified;
            }
            set {
                this.timeSpanFieldSpecified = value;
                this.RaisePropertyChanged("timeSpanSpecified");
            }
        }
        

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timeconsideration.xserver.ptvgroup.com")]
    public enum TimeConsiderationScenario {
        /**
         * No time consideration is applied, all time-dependent features are regarded as not relevant.
         */
        NONE,

        /**
         * All features are taken into consideration, whose time domain matches the additionally defined reference time.
         */
        SNAPSHOT,

        /**
         * All features are taken into consideration, whose time domain matches the additionally defined reference time
* and duration. I.e. the time span must be totally covered by the feature's time domain.
         */
        TIME_SPAN,

        /**
         * All features are taken into consideration, whose time domain matches the current time along a calculated route,
* whereby the accompanying reference time is related to the routing start time.
* This scenario can only be used with xRoute.
         */
        EXACT_TIME_AT_START,

        /**
         * All features are taken into consideration, whose time domain matches the current time along a calculated route,
* whereby the accompanying reference time is related to the routing arrival time.
* This scenario can only be used with xRoute.
         */
        EXACT_TIME_AT_ARRIVAL,

        /**
         * If time-dependent alternatives for a segment are available, the best alternative is selected.
         */
        OPTIMISTIC
    }


}
