// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.jobs 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jobs.xserver.ptvgroup.com")]
    public partial class BulkProgress : com.ptvgroup.xserver.jobs.JobProgress {

        private int remainingField;
        private int successfulField;
        private int failedField;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int remaining {
            get {
                return this.remainingField;
            }
            set {
                this.remainingField = value;
                this.RaisePropertyChanged("remaining");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int successful {
            get {
                return this.successfulField;
            }
            set {
                this.successfulField = value;
                this.RaisePropertyChanged("successful");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int failed {
            get {
                return this.failedField;
            }
            set {
                this.failedField = value;
                this.RaisePropertyChanged("failed");
            }
        }


    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jobs.xserver.ptvgroup.com")]
    public partial class Job : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private com.ptvgroup.xserver.jobs.JobStatus statusField;
        private com.ptvgroup.xserver.jobs.JobProgress progressField;
        private int elapsedTimeField;

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
        public com.ptvgroup.xserver.jobs.JobStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("progress", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.jobs.JobProgress progress {
            get {
                return this.progressField;
            }
            set {
                this.progressField = value;
                this.RaisePropertyChanged("progress");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int elapsedTime {
            get {
                return this.elapsedTimeField;
            }
            set {
                this.elapsedTimeField = value;
                this.RaisePropertyChanged("elapsedTime");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.dima.DistanceMatrixProgress))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.jobs.BulkProgress))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xcluster.ClusterPlanningProgress))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xdata.HighPerformanceRoutingNetworkProgress))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(com.ptvgroup.xserver.xtour.TourPlanProgress))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jobs.xserver.ptvgroup.com")]
    public abstract partial class JobProgress : object, System.ComponentModel.INotifyPropertyChanged {



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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jobs.xserver.ptvgroup.com")]
    public partial class JobRequest : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jobs.xserver.ptvgroup.com")]
    public partial class WatchRequest : object, System.ComponentModel.INotifyPropertyChanged {

        private string idField;
        private int progressUpdatePeriodField;
        private bool progressUpdatePeriodFieldSpecified;
        private int maximumPollingPeriodField;
        private bool maximumPollingPeriodFieldSpecified;

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
        public int progressUpdatePeriod {
            get {
                return this.progressUpdatePeriodField;
            }
            set {
                this.progressUpdatePeriodField = value;
                this.RaisePropertyChanged("progressUpdatePeriod");
                this.progressUpdatePeriodFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool progressUpdatePeriodSpecified {
            get {
                return this.progressUpdatePeriodFieldSpecified;
            }
            set {
                this.progressUpdatePeriodFieldSpecified = value;
                this.RaisePropertyChanged("progressUpdatePeriodSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumPollingPeriod {
            get {
                return this.maximumPollingPeriodField;
            }
            set {
                this.maximumPollingPeriodField = value;
                this.RaisePropertyChanged("maximumPollingPeriod");
                this.maximumPollingPeriodFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumPollingPeriodSpecified {
            get {
                return this.maximumPollingPeriodFieldSpecified;
            }
            set {
                this.maximumPollingPeriodFieldSpecified = value;
                this.RaisePropertyChanged("maximumPollingPeriodSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jobs.xserver.ptvgroup.com")]
    public enum JobStatus {
        /**
         * Job has been enqueued.
         */
        QUEUING,

        /**
         * Job is currently running.
         */
        RUNNING,

        /**
         * Stop has been requested, the job will terminate its calculation as soon as possible.
         */
        STOPPING,

        /**
         * Job has completed successfully.
         */
        SUCCEEDED,

        /**
         * Job has failed with an exception.
         */
        FAILED,

        /**
         * The job was deleted by the user.
         */
        DELETED,

        /**
         * The job is in an unknown state. For example a given ID is unknown or the job
* has already been fetched and has therefore been deleted from the underlying persistent store.
         */
        UNKNOWN
    }


}
