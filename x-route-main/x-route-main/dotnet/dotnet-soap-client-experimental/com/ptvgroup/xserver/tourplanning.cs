// Version: 2.25-experimental
// Build: 1.0.56236

namespace com.ptvgroup.xserver.tourplanning 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class Arrived : com.ptvgroup.xserver.tourplanning.ServiceStatus {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class DistanceViolation : com.ptvgroup.xserver.tourplanning.TourViolation {

        private double exceedanceField;
        private bool exceedanceFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double exceedance {
            get {
                return this.exceedanceField;
            }
            set {
                this.exceedanceField = value;
                this.RaisePropertyChanged("exceedance");
                this.exceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exceedanceSpecified {
            get {
                return this.exceedanceFieldSpecified;
            }
            set {
                this.exceedanceFieldSpecified = value;
                this.RaisePropertyChanged("exceedanceSpecified");
            }
        }
        

    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.DrivingTimeRegulationLogbookSummary_EU_EC_561_2006))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public abstract partial class DrivingTimeRegulationLogbookSummary : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class DrivingTimeRegulationLogbookSummary_EU_EC_561_2006 : com.ptvgroup.xserver.tourplanning.DrivingTimeRegulationLogbookSummary {

        private double accumulatedDrivingTimeSinceLastBreakField;
        private bool accumulatedDrivingTimeSinceLastBreakFieldSpecified;
        private double accumulatedDrivingTimeSinceLastDailyRestField;
        private bool accumulatedDrivingTimeSinceLastDailyRestFieldSpecified;
        private double elapsedTimeSinceEndOfLastDailyRestField;
        private bool elapsedTimeSinceEndOfLastDailyRestFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double accumulatedDrivingTimeSinceLastBreak {
            get {
                return this.accumulatedDrivingTimeSinceLastBreakField;
            }
            set {
                this.accumulatedDrivingTimeSinceLastBreakField = value;
                this.RaisePropertyChanged("accumulatedDrivingTimeSinceLastBreak");
                this.accumulatedDrivingTimeSinceLastBreakFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accumulatedDrivingTimeSinceLastBreakSpecified {
            get {
                return this.accumulatedDrivingTimeSinceLastBreakFieldSpecified;
            }
            set {
                this.accumulatedDrivingTimeSinceLastBreakFieldSpecified = value;
                this.RaisePropertyChanged("accumulatedDrivingTimeSinceLastBreakSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double accumulatedDrivingTimeSinceLastDailyRest {
            get {
                return this.accumulatedDrivingTimeSinceLastDailyRestField;
            }
            set {
                this.accumulatedDrivingTimeSinceLastDailyRestField = value;
                this.RaisePropertyChanged("accumulatedDrivingTimeSinceLastDailyRest");
                this.accumulatedDrivingTimeSinceLastDailyRestFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accumulatedDrivingTimeSinceLastDailyRestSpecified {
            get {
                return this.accumulatedDrivingTimeSinceLastDailyRestFieldSpecified;
            }
            set {
                this.accumulatedDrivingTimeSinceLastDailyRestFieldSpecified = value;
                this.RaisePropertyChanged("accumulatedDrivingTimeSinceLastDailyRestSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double elapsedTimeSinceEndOfLastDailyRest {
            get {
                return this.elapsedTimeSinceEndOfLastDailyRestField;
            }
            set {
                this.elapsedTimeSinceEndOfLastDailyRestField = value;
                this.RaisePropertyChanged("elapsedTimeSinceEndOfLastDailyRest");
                this.elapsedTimeSinceEndOfLastDailyRestFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool elapsedTimeSinceEndOfLastDailyRestSpecified {
            get {
                return this.elapsedTimeSinceEndOfLastDailyRestFieldSpecified;
            }
            set {
                this.elapsedTimeSinceEndOfLastDailyRestFieldSpecified = value;
                this.RaisePropertyChanged("elapsedTimeSinceEndOfLastDailyRestSpecified");
            }
        }
        

    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.DrivingTimeRegulationOptions_US_FMCSA_395_2013))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public abstract partial class DrivingTimeRegulationOptions : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class DrivingTimeRegulationOptions_US_FMCSA_395_2013 : com.ptvgroup.xserver.tourplanning.DrivingTimeRegulationOptions {

        private bool thirtyFourHourRestartRuleField;
        private bool thirtyFourHourRestartRuleFieldSpecified;
        private com.ptvgroup.xserver.tourplanning.WeeklyOnDutyHoursLimit_US_FMCSA_395_2013 weeklyOnDutyHoursLimitField;
        private bool weeklyOnDutyHoursLimitFieldSpecified;
        private string twentyFourHourPeriodStartsAtField;
        private bool thirtyMinuteBreakRuleField;
        private bool thirtyMinuteBreakRuleFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool thirtyFourHourRestartRule {
            get {
                return this.thirtyFourHourRestartRuleField;
            }
            set {
                this.thirtyFourHourRestartRuleField = value;
                this.RaisePropertyChanged("thirtyFourHourRestartRule");
                this.thirtyFourHourRestartRuleFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool thirtyFourHourRestartRuleSpecified {
            get {
                return this.thirtyFourHourRestartRuleFieldSpecified;
            }
            set {
                this.thirtyFourHourRestartRuleFieldSpecified = value;
                this.RaisePropertyChanged("thirtyFourHourRestartRuleSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.tourplanning.WeeklyOnDutyHoursLimit_US_FMCSA_395_2013 weeklyOnDutyHoursLimit {
            get {
                return this.weeklyOnDutyHoursLimitField;
            }
            set {
                this.weeklyOnDutyHoursLimitField = value;
                this.RaisePropertyChanged("weeklyOnDutyHoursLimit");
                this.weeklyOnDutyHoursLimitFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weeklyOnDutyHoursLimitSpecified {
            get {
                return this.weeklyOnDutyHoursLimitFieldSpecified;
            }
            set {
                this.weeklyOnDutyHoursLimitFieldSpecified = value;
                this.RaisePropertyChanged("weeklyOnDutyHoursLimitSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string twentyFourHourPeriodStartsAt {
            get {
                return this.twentyFourHourPeriodStartsAtField;
            }
            set {
                this.twentyFourHourPeriodStartsAtField = value;
                this.RaisePropertyChanged("twentyFourHourPeriodStartsAt");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool thirtyMinuteBreakRule {
            get {
                return this.thirtyMinuteBreakRuleField;
            }
            set {
                this.thirtyMinuteBreakRuleField = value;
                this.RaisePropertyChanged("thirtyMinuteBreakRule");
                this.thirtyMinuteBreakRuleFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool thirtyMinuteBreakRuleSpecified {
            get {
                return this.thirtyMinuteBreakRuleFieldSpecified;
            }
            set {
                this.thirtyMinuteBreakRuleFieldSpecified = value;
                this.RaisePropertyChanged("thirtyMinuteBreakRuleSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class MaximumNumberOfCustomerStopsViolation : com.ptvgroup.xserver.tourplanning.TourViolation {

        private int exceedanceField;
        private bool exceedanceFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int exceedance {
            get {
                return this.exceedanceField;
            }
            set {
                this.exceedanceField = value;
                this.RaisePropertyChanged("exceedance");
                this.exceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exceedanceSpecified {
            get {
                return this.exceedanceFieldSpecified;
            }
            set {
                this.exceedanceFieldSpecified = value;
                this.RaisePropertyChanged("exceedanceSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class MaximumQuantityScenarioViolation : com.ptvgroup.xserver.tourplanning.TourViolation {

        private double[] exceedanceField;

                    [System.Xml.Serialization.XmlElementAttribute("exceedance", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double[] exceedance {
            get {
                return this.exceedanceField;
            }
            set {
                this.exceedanceField = value;
                this.RaisePropertyChanged("exceedance");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class MixedLoadingProhibitionsViolation : com.ptvgroup.xserver.tourplanning.TourViolation {

        private com.ptvgroup.xserver.xtour.MixedLoadingProhibition[] mixedLoadingProhibitionsField;

                    [System.Xml.Serialization.XmlElementAttribute("mixedLoadingProhibitions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.xtour.MixedLoadingProhibition[] mixedLoadingProhibitions {
            get {
                return this.mixedLoadingProhibitionsField;
            }
            set {
                this.mixedLoadingProhibitionsField = value;
                this.RaisePropertyChanged("mixedLoadingProhibitions");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class MultiDayWorkingHours : com.ptvgroup.xserver.tourplanning.WorkingHours {

        private com.ptvgroup.xserver.tourplanning.RestPositions dailyRestPositionsField;
        private bool dailyRestPositionsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.tourplanning.RestPositions dailyRestPositions {
            get {
                return this.dailyRestPositionsField;
            }
            set {
                this.dailyRestPositionsField = value;
                this.RaisePropertyChanged("dailyRestPositions");
                this.dailyRestPositionsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dailyRestPositionsSpecified {
            get {
                return this.dailyRestPositionsFieldSpecified;
            }
            set {
                this.dailyRestPositionsFieldSpecified = value;
                this.RaisePropertyChanged("dailyRestPositionsSpecified");
            }
        }
        

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class PositionViolation : com.ptvgroup.xserver.tourplanning.TourViolation {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class QualificationViolation : com.ptvgroup.xserver.tourplanning.TourViolation {

        private string[] qualificationsField;

                    [System.Xml.Serialization.XmlElementAttribute("qualifications", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] qualifications {
            get {
                return this.qualificationsField;
            }
            set {
                this.qualificationsField = value;
                this.RaisePropertyChanged("qualifications");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class ReachabilityViolation : com.ptvgroup.xserver.tourplanning.TourViolation {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class RouteViolation : com.ptvgroup.xserver.tourplanning.TourViolation {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class ServiceCompleted : com.ptvgroup.xserver.tourplanning.ServiceStatus {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class ServiceStarted : com.ptvgroup.xserver.tourplanning.ServiceStatus {

        private double performedServiceTimeField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double performedServiceTime {
            get {
                return this.performedServiceTimeField;
            }
            set {
                this.performedServiceTimeField = value;
                this.RaisePropertyChanged("performedServiceTime");
            }
        }


    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.Arrived))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.ServiceCompleted))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.ServiceStarted))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public abstract partial class ServiceStatus : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class SingleDayWorkingHours : com.ptvgroup.xserver.tourplanning.WorkingHours {



    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class TimeViolation : com.ptvgroup.xserver.tourplanning.TourViolation {

        private double exceedanceField;
        private bool exceedanceFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double exceedance {
            get {
                return this.exceedanceField;
            }
            set {
                this.exceedanceField = value;
                this.RaisePropertyChanged("exceedance");
                this.exceedanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exceedanceSpecified {
            get {
                return this.exceedanceFieldSpecified;
            }
            set {
                this.exceedanceFieldSpecified = value;
                this.RaisePropertyChanged("exceedanceSpecified");
            }
        }
        

    }
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.DistanceViolation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.MaximumNumberOfCustomerStopsViolation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.MaximumQuantityScenarioViolation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.MixedLoadingProhibitionsViolation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.PositionViolation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.QualificationViolation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.ReachabilityViolation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.RouteViolation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.TimeViolation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class TourViolation : object, System.ComponentModel.INotifyPropertyChanged {

        private bool causedByThisEventField;
        private bool causedByThisEventFieldSpecified;
        private com.ptvgroup.xserver.tourplanning.TourViolationType typeField;
        private bool typeFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool causedByThisEvent {
            get {
                return this.causedByThisEventField;
            }
            set {
                this.causedByThisEventField = value;
                this.RaisePropertyChanged("causedByThisEvent");
                this.causedByThisEventFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool causedByThisEventSpecified {
            get {
                return this.causedByThisEventFieldSpecified;
            }
            set {
                this.causedByThisEventFieldSpecified = value;
                this.RaisePropertyChanged("causedByThisEventSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.tourplanning.TourViolationType type {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class WorkLogbookSummary : object, System.ComponentModel.INotifyPropertyChanged {

        private System.DateTime lastTimeTheDriverWorkedField;
        private com.ptvgroup.xserver.tourplanning.DrivingTimeRegulationLogbookSummary drivingTimeRegulationLogbookSummaryField;
        private com.ptvgroup.xserver.tourplanning.WorkingTimeDirectiveLogbookSummary workingTimeDirectiveLogbookSummaryField;

                    [System.Xml.Serialization.XmlAttributeAttribute(DataType="dateTime")]
        public System.DateTime lastTimeTheDriverWorked {
            get {
                return this.lastTimeTheDriverWorkedField;
            }
            set {
                this.lastTimeTheDriverWorkedField = value;
                this.RaisePropertyChanged("lastTimeTheDriverWorked");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("drivingTimeRegulationLogbookSummary", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.tourplanning.DrivingTimeRegulationLogbookSummary drivingTimeRegulationLogbookSummary {
            get {
                return this.drivingTimeRegulationLogbookSummaryField;
            }
            set {
                this.drivingTimeRegulationLogbookSummaryField = value;
                this.RaisePropertyChanged("drivingTimeRegulationLogbookSummary");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("workingTimeDirectiveLogbookSummary", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.tourplanning.WorkingTimeDirectiveLogbookSummary workingTimeDirectiveLogbookSummary {
            get {
                return this.workingTimeDirectiveLogbookSummaryField;
            }
            set {
                this.workingTimeDirectiveLogbookSummaryField = value;
                this.RaisePropertyChanged("workingTimeDirectiveLogbookSummary");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.MultiDayWorkingHours))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.SingleDayWorkingHours))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public abstract partial class WorkingHours : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.tourplanning.DrivingTimeRegulation drivingTimeRegulationField;
        private bool drivingTimeRegulationFieldSpecified;
        private com.ptvgroup.xserver.tourplanning.WorkingTimeDirective workingTimeDirectiveField;
        private bool workingTimeDirectiveFieldSpecified;
        private com.ptvgroup.xserver.tourplanning.DrivingTimeRegulationOptions drivingTimeRegulationOptionsField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.tourplanning.DrivingTimeRegulation drivingTimeRegulation {
            get {
                return this.drivingTimeRegulationField;
            }
            set {
                this.drivingTimeRegulationField = value;
                this.RaisePropertyChanged("drivingTimeRegulation");
                this.drivingTimeRegulationFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drivingTimeRegulationSpecified {
            get {
                return this.drivingTimeRegulationFieldSpecified;
            }
            set {
                this.drivingTimeRegulationFieldSpecified = value;
                this.RaisePropertyChanged("drivingTimeRegulationSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.tourplanning.WorkingTimeDirective workingTimeDirective {
            get {
                return this.workingTimeDirectiveField;
            }
            set {
                this.workingTimeDirectiveField = value;
                this.RaisePropertyChanged("workingTimeDirective");
                this.workingTimeDirectiveFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool workingTimeDirectiveSpecified {
            get {
                return this.workingTimeDirectiveFieldSpecified;
            }
            set {
                this.workingTimeDirectiveFieldSpecified = value;
                this.RaisePropertyChanged("workingTimeDirectiveSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlElementAttribute("drivingTimeRegulationOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.tourplanning.DrivingTimeRegulationOptions drivingTimeRegulationOptions {
            get {
                return this.drivingTimeRegulationOptionsField;
            }
            set {
                this.drivingTimeRegulationOptionsField = value;
                this.RaisePropertyChanged("drivingTimeRegulationOptions");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.tourplanning.WorkingTimeDirectiveLogbookSummary_EU_2002_15_EC))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public abstract partial class WorkingTimeDirectiveLogbookSummary : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public partial class WorkingTimeDirectiveLogbookSummary_EU_2002_15_EC : com.ptvgroup.xserver.tourplanning.WorkingTimeDirectiveLogbookSummary {

        private double accumulatedWorkingTimeSinceLastBreakField;
        private bool accumulatedWorkingTimeSinceLastBreakFieldSpecified;
        private double elapsedTimeSinceEndOfLastDailyRestField;
        private bool elapsedTimeSinceEndOfLastDailyRestFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double accumulatedWorkingTimeSinceLastBreak {
            get {
                return this.accumulatedWorkingTimeSinceLastBreakField;
            }
            set {
                this.accumulatedWorkingTimeSinceLastBreakField = value;
                this.RaisePropertyChanged("accumulatedWorkingTimeSinceLastBreak");
                this.accumulatedWorkingTimeSinceLastBreakFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accumulatedWorkingTimeSinceLastBreakSpecified {
            get {
                return this.accumulatedWorkingTimeSinceLastBreakFieldSpecified;
            }
            set {
                this.accumulatedWorkingTimeSinceLastBreakFieldSpecified = value;
                this.RaisePropertyChanged("accumulatedWorkingTimeSinceLastBreakSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double elapsedTimeSinceEndOfLastDailyRest {
            get {
                return this.elapsedTimeSinceEndOfLastDailyRestField;
            }
            set {
                this.elapsedTimeSinceEndOfLastDailyRestField = value;
                this.RaisePropertyChanged("elapsedTimeSinceEndOfLastDailyRest");
                this.elapsedTimeSinceEndOfLastDailyRestFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool elapsedTimeSinceEndOfLastDailyRestSpecified {
            get {
                return this.elapsedTimeSinceEndOfLastDailyRestFieldSpecified;
            }
            set {
                this.elapsedTimeSinceEndOfLastDailyRestFieldSpecified = value;
                this.RaisePropertyChanged("elapsedTimeSinceEndOfLastDailyRestSpecified");
            }
        }
        

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public enum DrivingTimeRegulation {
        /**
         * No restriction of drivers' working hours.
         */
        NONE,

        /**
         * Regulation (EC) No 561/2006 of the European Parliament and of the Council.
         */
        EU_EC_561_2006,

        /**
         * Hours of Service (HOS) regulation as issued by the Federal Motor Carrier Safety Administration (FMCSA).
         */
        US_FMCSA_395_2013
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public enum RestPositions {
        /**
         * Indicates that a rest is planned directly after every trip of the tour, except after the last trip.
         */
        BETWEEN_ALL_TRIPS,

        /**
         * Indicates that a rest may be planned after each trip of the tour if necessary, except after the last trip.
         */
        BETWEEN_TRIPS,

        /**
         * Indicates that a rest may be scheduled anytime and anywhere necessary, even within a trip and even en route between two stops.
         */
        ANYWHERE
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public enum TourEventType {
        /**
         * Indicates a driving period.
         */
        DRIVING,

        /**
         * Indicates a service period.
         */
        SERVICE,

        /**
         * Indicates a waiting period.
         */
        WAITING,

        /**
         * Indicates a break period.
         */
        BREAK,

        /**
         * Indicates a daily rest period.
         */
        DAILY_REST,

        /**
         * Indicates the start of a trip.
         */
        TRIP_START,

        /**
         * Indicates the end of a trip.
         */
        TRIP_END,

        /**
         * Indicates the start of a tour.
         */
        TOUR_START,

        /**
         * Indicates the end of a tour.
         */
        TOUR_END
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public enum TourViolationType {
        /**
         * Indicates a violation of the planning horizon.
* This is caused by a tour event that begins outside the planning horizon.
* This violation is repeated for all subsequent events of the current tour.
         */
        PLANNING_HORIZON,

        /**
         * Indicates a violation of the operating interval of the driver.
* This is caused by a tour event that begins outside of the operating intervals of the driver of the current tour.
* This violation is repeated for all subsequent events of the current trip.
         */
        OPERATING_INTERVAL,

        /**
         * Indicates a violation of the tour start interval of the vehicle.
* This violation is only included at tour start events.
         */
        TOUR_START_INTERVAL,

        /**
         * Indicates a violation of the opening interval(s) of the current site.
* This is caused by service that begins after the end of the last opening interval of the current site.
* This violation is repeated for all subsequent events of the current stop.
         */
        OPENING_INTERVAL,

        /**
         * Indicates a violation of the maximum allowed travel time per tour.
* This violation is repeated for all subsequent events of the current tour.
         */
        MAXIMUM_TRAVEL_TIME_PER_TOUR,

        /**
         * Indicates a violation of the maximum allowed driving time per tour.
* This violation is repeated for all subsequent events of the current tour.
         */
        MAXIMUM_DRIVING_TIME_PER_TOUR,

        /**
         * Indicates that a daily rest for European drivers' working hours is not at the end of a trip.
* The expected position for a daily rest is at the end of a trip.
* Daily rests at other positions are only scheduled if they are absolutely necessary to conform to the European drivers' working hours.
* This violation is only included at tour events of the violated daily rest.
         */
        REST_POSITION,

        /**
         * Indicates a violation of the maximum quantity scenario of the used vehicle.
* This violation is repeated for all subsequent events for which the maximum quantity of the vehicle is exceeded.
         */
        MAXIMUM_QUANTITY_SCENARIO,

        /**
         * Indicates a violation of the vehicle equipment required for the currently loaded orders.
* This violation is repeated for all subsequent events for which a vehicle equipment
* is missing.
         */
        VEHICLE_EQUIPMENT,

        /**
         * Indicates a violation of the maximum allowed travel time per driver as specified by the drivers' <a href="tourplanning.html#com.ptvgroup.xserver.tourplanning.WorkingHours">working hours</a> restriction.
* Travel time prior to tour start as specified by the <a href="tourplanning.html#com.ptvgroup.xserver.tourplanning.WorkLogbookSummary">work logbook summary</a> is also considered for this check.
* This violation is repeated for all subsequent events of the current tour.
         */
        MAXIMUM_TRAVEL_TIME_PER_DRIVER,

        /**
         * Indicates a violation of the maximum allowed driving time per driver as specified by the drivers' <a href="tourplanning.html#com.ptvgroup.xserver.tourplanning.WorkingHours">working hours</a> restriction.
* Driving time prior to tour start as specified by the <a href="tourplanning.html#com.ptvgroup.xserver.tourplanning.WorkLogbookSummary">work logbook summary</a> is also considered for this check.
* This violation is repeated for all subsequent events of the current tour.
         */
        MAXIMUM_DRIVING_TIME_PER_DRIVER,

        /**
         * Indicates a violation of the trip start interval.
* This violation is only included at trip start events.
         */
        TRIP_START_INTERVAL,

        /**
         * Indicates a violation of the maximum allowed number of stops per tour.
* This violation only occurs at events of type <a href="tourplanning.html#com.ptvgroup.xserver.tourplanning.TourEventType.SERVICE">service</a> at customer stops and is repeated for all subsequent events.
         */
        MAXIMUM_NUMBER_OF_CUSTOMER_STOPS,

        /**
         * Indicates a violation of the customer stop position in trip.
* This violation only occurs at events of type <a href="tourplanning.html#com.ptvgroup.xserver.tourplanning.TourEventType.SERVICE">service</a> at customer stops when a position in trip set for this site and the current customer stop is not the first/last one in the trip.
         */
        CUSTOMER_STOP_POSITION_IN_TRIP,

        /**
         * Indicates a violation of the trip section numbers.
* This violation only occurs at events of type <a href="tourplanning.html#com.ptvgroup.xserver.tourplanning.TourEventType.SERVICE">service</a> at customer stops when the previous trip section number is higher than the one at this customer site.
         */
        TRIP_SECTION,

        /**
         * Indicates a violation of the maximum allowed distance per tour.
* This violation is repeated for all subsequent events of the current tour.
         */
        MAXIMUM_DISTANCE,

        /**
         * Indicates a violation of a mixed loading prohibition.
* This violation only occurs at events of type <a href="tourplanning.html#com.ptvgroup.xserver.tourplanning.TourEventType.SERVICE">service</a>.
         */
        MIXED_LOADING_PROHIBITION,

        /**
         * Indicates a violation where the route between two locations is calculated with <a href="xroute.html#com.ptvgroup.xserver.xroute.RouteViolationType">route violations</a>.
* This violation only occurs at events of type <a href="tourplanning.html#com.ptvgroup.xserver.tourplanning.TourEventType.DRIVING">driving</a>.
         */
        ROUTE,

        /**
         * Indicates a violation where the route between two locations was calculated by direct distance instead of the road network.
* This violation only occurs at events of type <a href="tourplanning.html#com.ptvgroup.xserver.tourplanning.TourEventType.DRIVING">driving</a>.
         */
        REACHABILITY,

        /**
         * Fallback value to be substituted for enumeration values which were added in an API version that is newer than the request version. When using the current API, this value will never be returned.
         */
        UNSPECIFIED
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public enum WeeklyOnDutyHoursLimit_US_FMCSA_395_2013 {
        /**
         * Defines a limit of 60 on duty hours on a rolling period of 7 consecutive days.
         */
        SEVEN_DAYS_SIXTY_HOURS_ON_DUTY,

        /**
         * Defines a limit of 70 on duty hours on a rolling period of 8 consecutive days.
         */
        EIGHT_DAYS_SEVENTY_HOURS_ON_DUTY
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tourplanning.xserver.ptvgroup.com")]
    public enum WorkingTimeDirective {
        /**
         * No restriction by working law.
         */
        NONE,

        /**
         * Enables directive 2002/15/EC of the European Parliament and of the Council "on the organisation of the working time of persons performing mobile road transport activities".
         */
        EU_2002_15_EC
    }


}
