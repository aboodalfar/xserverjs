// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.exceptions 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class SuppressedXServerException : object, System.ComponentModel.INotifyPropertyChanged {

        private string messageField;
        private com.ptvgroup.xserver.exceptions.XServerFault faultInfoField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("faultInfo", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.exceptions.XServerFault faultInfo {
            get {
                return this.faultInfoField;
            }
            set {
                this.faultInfoField = value;
                this.RaisePropertyChanged("faultInfo");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class AccessDeniedFault : com.ptvgroup.xserver.exceptions.RejectedRequestFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class AmbiguousInsertionPositionFault : com.ptvgroup.xserver.exceptions.TripStructureFault {
        
    private string orderIdField;
    private com.ptvgroup.xserver.xtour.TaskType taskTypeField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId {
            get {
                return this.orderIdField;
            }
            set {
                this.orderIdField = value;
                this.RaisePropertyChanged("orderId");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xtour.TaskType taskType {
            get {
                return this.taskTypeField;
            }
            set {
                this.taskTypeField = value;
                this.RaisePropertyChanged("taskType");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class ConfigurationFault : com.ptvgroup.xserver.exceptions.SetupFault {
        
    private string fileNameField;
    private string parameterField;
    private string valueField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
                this.RaisePropertyChanged("fileName");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
                this.RaisePropertyChanged("parameter");
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

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class DataNotAvailableFault : com.ptvgroup.xserver.exceptions.InvalidRequestFault {
        
    private string parameterField;
    private string valueField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
                this.RaisePropertyChanged("parameter");
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

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class DeliveryBeforePickupFault : com.ptvgroup.xserver.exceptions.TripStructureFault {
        
    private string orderIdField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId {
            get {
                return this.orderIdField;
            }
            set {
                this.orderIdField = value;
                this.RaisePropertyChanged("orderId");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class DepotVisitFault : com.ptvgroup.xserver.exceptions.TourStructureFault {
        
    private string orderIdField;
    private string siteIdField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId {
            get {
                return this.orderIdField;
            }
            set {
                this.orderIdField = value;
                this.RaisePropertyChanged("orderId");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string siteId {
            get {
                return this.siteIdField;
            }
            set {
                this.siteIdField = value;
                this.RaisePropertyChanged("siteId");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class DistanceMatrixIdNotFoundFault : com.ptvgroup.xserver.exceptions.InvalidRequestFault {
        
    private string distanceMatrixIdField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string distanceMatrixId {
            get {
                return this.distanceMatrixIdField;
            }
            set {
                this.distanceMatrixIdField = value;
                this.RaisePropertyChanged("distanceMatrixId");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class DuplicateProfileFault : com.ptvgroup.xserver.exceptions.SetupFault {
        
    private string fileNameField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
                this.RaisePropertyChanged("fileName");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class InternalErrorFault : com.ptvgroup.xserver.exceptions.XServerFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class InvalidFetchTypeFault : com.ptvgroup.xserver.exceptions.InvalidRequestFault {
        
    private string jobIdField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string jobId {
            get {
                return this.jobIdField;
            }
            set {
                this.jobIdField = value;
                this.RaisePropertyChanged("jobId");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class InvalidLoadingSequenceFault : com.ptvgroup.xserver.exceptions.TripStructureFault {
        
    private string siteIdField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string siteId {
            get {
                return this.siteIdField;
            }
            set {
                this.siteIdField = value;
                this.RaisePropertyChanged("siteId");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class InvalidProfileNameFault : com.ptvgroup.xserver.exceptions.InvalidRequestFault {
        
    private string profileField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
                this.RaisePropertyChanged("profile");
            }
        }

    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.AmbiguousInsertionPositionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DataNotAvailableFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DeliveryBeforePickupFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DepotVisitFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DistanceMatrixIdNotFoundFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidFetchTypeFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidLoadingSequenceFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidProfileNameFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidTaskSequenceFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidTourRequestFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidValueFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.LicenseViolationFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.MissingParameterFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.OrderAlreadyPlannedFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.ParameterConflictFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.SingleDepotPerTourRestrictionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.SingleTripPerTourRestrictionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.StopStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TourStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TransformFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripDepotStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripsMergedFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.UTCOffsetNotDeterminableFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class InvalidRequestFault : com.ptvgroup.xserver.exceptions.XServerFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class InvalidTaskSequenceFault : com.ptvgroup.xserver.exceptions.StopStructureFault {
        
    private string orderIdField;
    private com.ptvgroup.xserver.xtour.TaskType taskTypeField;
    private int taskIndexField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId {
            get {
                return this.orderIdField;
            }
            set {
                this.orderIdField = value;
                this.RaisePropertyChanged("orderId");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xtour.TaskType taskType {
            get {
                return this.taskTypeField;
            }
            set {
                this.taskTypeField = value;
                this.RaisePropertyChanged("taskType");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int taskIndex {
            get {
                return this.taskIndexField;
            }
            set {
                this.taskIndexField = value;
                this.RaisePropertyChanged("taskIndex");
            }
        }

    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.AmbiguousInsertionPositionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DeliveryBeforePickupFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DepotVisitFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidLoadingSequenceFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidTaskSequenceFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.OrderAlreadyPlannedFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.SingleDepotPerTourRestrictionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.SingleTripPerTourRestrictionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.StopStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TourStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripDepotStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripsMergedFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class InvalidTourRequestFault : com.ptvgroup.xserver.exceptions.InvalidRequestFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class InvalidValueFault : com.ptvgroup.xserver.exceptions.InvalidRequestFault {
        
    private string parameterField;
    private string valueField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
                this.RaisePropertyChanged("parameter");
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

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class LicenseFault : com.ptvgroup.xserver.exceptions.SetupFault {
        
    private string[] unlicensedServicesField;
    
                    [System.Xml.Serialization.XmlElementAttribute("unlicensedServices", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] unlicensedServices {
            get {
                return this.unlicensedServicesField;
            }
            set {
                this.unlicensedServicesField = value;
                this.RaisePropertyChanged("unlicensedServices");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class LicenseViolationFault : com.ptvgroup.xserver.exceptions.InvalidRequestFault {
        
    private string keyField;
    
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

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class MissingParameterFault : com.ptvgroup.xserver.exceptions.InvalidRequestFault {
        
    private string parameterField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
                this.RaisePropertyChanged("parameter");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class OrderAlreadyPlannedFault : com.ptvgroup.xserver.exceptions.InvalidTourRequestFault {
        
    private string orderIdField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId {
            get {
                return this.orderIdField;
            }
            set {
                this.orderIdField = value;
                this.RaisePropertyChanged("orderId");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class ParameterConflictFault : com.ptvgroup.xserver.exceptions.InvalidRequestFault {
        
    private string parameterAField;
    private string parameterBField;
    private string valueAField;
    private string valueBField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parameterA {
            get {
                return this.parameterAField;
            }
            set {
                this.parameterAField = value;
                this.RaisePropertyChanged("parameterA");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parameterB {
            get {
                return this.parameterBField;
            }
            set {
                this.parameterBField = value;
                this.RaisePropertyChanged("parameterB");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueA {
            get {
                return this.valueAField;
            }
            set {
                this.valueAField = value;
                this.RaisePropertyChanged("valueA");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueB {
            get {
                return this.valueBField;
            }
            set {
                this.valueBField = value;
                this.RaisePropertyChanged("valueB");
            }
        }

    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.ProcessingTimedOutFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.RouteNotFoundFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.WaypointNotLinkableFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class ProcessingFault : com.ptvgroup.xserver.exceptions.XServerFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class ProcessingTimedOutFault : com.ptvgroup.xserver.exceptions.ProcessingFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class QueueOverflowFault : com.ptvgroup.xserver.exceptions.RejectedRequestFault {
        
    

    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.AccessDeniedFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.QueueOverflowFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.RequestDeletedFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.RequestTimedOutFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.ServiceNotConfiguredFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class RejectedRequestFault : com.ptvgroup.xserver.exceptions.XServerFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class RequestDeletedFault : com.ptvgroup.xserver.exceptions.RejectedRequestFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class RequestTimedOutFault : com.ptvgroup.xserver.exceptions.RejectedRequestFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class RouteNotFoundFault : com.ptvgroup.xserver.exceptions.ProcessingFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class ServiceNotConfiguredFault : com.ptvgroup.xserver.exceptions.RejectedRequestFault {
        
    private string serviceField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
                this.RaisePropertyChanged("service");
            }
        }

    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.ConfigurationFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DuplicateProfileFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.LicenseFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class SetupFault : com.ptvgroup.xserver.exceptions.XServerFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class SingleDepotPerTourRestrictionFault : com.ptvgroup.xserver.exceptions.TourStructureFault {
        
    private string vehicleIdField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vehicleId {
            get {
                return this.vehicleIdField;
            }
            set {
                this.vehicleIdField = value;
                this.RaisePropertyChanged("vehicleId");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class SingleTripPerTourRestrictionFault : com.ptvgroup.xserver.exceptions.TourStructureFault {
        
    private string vehicleIdField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vehicleId {
            get {
                return this.vehicleIdField;
            }
            set {
                this.vehicleIdField = value;
                this.RaisePropertyChanged("vehicleId");
            }
        }

    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidTaskSequenceFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class StopStructureFault : com.ptvgroup.xserver.exceptions.TripStructureFault {
        
    private int stopIndexField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int stopIndex {
            get {
                return this.stopIndexField;
            }
            set {
                this.stopIndexField = value;
                this.RaisePropertyChanged("stopIndex");
            }
        }

    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.AmbiguousInsertionPositionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DeliveryBeforePickupFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DepotVisitFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidLoadingSequenceFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidTaskSequenceFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.SingleDepotPerTourRestrictionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.SingleTripPerTourRestrictionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.StopStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripDepotStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripsMergedFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class TourStructureFault : com.ptvgroup.xserver.exceptions.InvalidTourRequestFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class TransformFault : com.ptvgroup.xserver.exceptions.InvalidRequestFault {
        
    private com.ptvgroup.xserver.geometry.Coordinate wrongCoordinateField;
    private string sridField;
    
                    [System.Xml.Serialization.XmlElementAttribute("wrongCoordinate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.geometry.Coordinate wrongCoordinate {
            get {
                return this.wrongCoordinateField;
            }
            set {
                this.wrongCoordinateField = value;
                this.RaisePropertyChanged("wrongCoordinate");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string srid {
            get {
                return this.sridField;
            }
            set {
                this.sridField = value;
                this.RaisePropertyChanged("srid");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class TripDepotStructureFault : com.ptvgroup.xserver.exceptions.TripStructureFault {
        
    private string orderIdField;
    private com.ptvgroup.xserver.xtour.TaskType taskTypeField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderId {
            get {
                return this.orderIdField;
            }
            set {
                this.orderIdField = value;
                this.RaisePropertyChanged("orderId");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.xtour.TaskType taskType {
            get {
                return this.taskTypeField;
            }
            set {
                this.taskTypeField = value;
                this.RaisePropertyChanged("taskType");
            }
        }

    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.AmbiguousInsertionPositionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DeliveryBeforePickupFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidLoadingSequenceFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidTaskSequenceFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.StopStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripDepotStructureFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class TripStructureFault : com.ptvgroup.xserver.exceptions.TourStructureFault {
        
    private string vehicleIdField;
    private string tripIdField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vehicleId {
            get {
                return this.vehicleIdField;
            }
            set {
                this.vehicleIdField = value;
                this.RaisePropertyChanged("vehicleId");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tripId {
            get {
                return this.tripIdField;
            }
            set {
                this.tripIdField = value;
                this.RaisePropertyChanged("tripId");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class TripsMergedFault : com.ptvgroup.xserver.exceptions.TourStructureFault {
        
    private string vehicleIdField;
    private string tripIdAField;
    private string tripIdBField;
    private string objectIdField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vehicleId {
            get {
                return this.vehicleIdField;
            }
            set {
                this.vehicleIdField = value;
                this.RaisePropertyChanged("vehicleId");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tripIdA {
            get {
                return this.tripIdAField;
            }
            set {
                this.tripIdAField = value;
                this.RaisePropertyChanged("tripIdA");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tripIdB {
            get {
                return this.tripIdBField;
            }
            set {
                this.tripIdBField = value;
                this.RaisePropertyChanged("tripIdB");
            }
        }
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string objectId {
            get {
                return this.objectIdField;
            }
            set {
                this.objectIdField = value;
                this.RaisePropertyChanged("objectId");
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class UTCOffsetNotDeterminableFault : com.ptvgroup.xserver.exceptions.InvalidRequestFault {
        
    

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class WaypointNotLinkableFault : com.ptvgroup.xserver.exceptions.ProcessingFault {
        
    private int[] waypointIndicesField;
    
                    [System.Xml.Serialization.XmlElementAttribute("waypointIndices", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int[] waypointIndices {
            get {
                return this.waypointIndicesField;
            }
            set {
                this.waypointIndicesField = value;
                this.RaisePropertyChanged("waypointIndices");
            }
        }

    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.AccessDeniedFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.AmbiguousInsertionPositionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.ConfigurationFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DataNotAvailableFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DeliveryBeforePickupFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DepotVisitFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DistanceMatrixIdNotFoundFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.DuplicateProfileFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InternalErrorFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidFetchTypeFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidLoadingSequenceFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidProfileNameFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidRequestFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidTaskSequenceFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidTourRequestFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.InvalidValueFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.LicenseFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.LicenseViolationFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.MissingParameterFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.OrderAlreadyPlannedFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.ParameterConflictFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.ProcessingFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.ProcessingTimedOutFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.QueueOverflowFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.RejectedRequestFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.RequestDeletedFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.RequestTimedOutFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.RouteNotFoundFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.ServiceNotConfiguredFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.SetupFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.SingleDepotPerTourRestrictionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.SingleTripPerTourRestrictionFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.StopStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TourStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TransformFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripDepotStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripStructureFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.TripsMergedFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.UTCOffsetNotDeterminableFault))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.exceptions.WaypointNotLinkableFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exceptions.xserver.ptvgroup.com")]
    public partial class XServerFault : object, System.ComponentModel.INotifyPropertyChanged {
        
    private string hintField;
    
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hint {
            get {
                return this.hintField;
            }
            set {
                this.hintField = value;
                this.RaisePropertyChanged("hint");
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
