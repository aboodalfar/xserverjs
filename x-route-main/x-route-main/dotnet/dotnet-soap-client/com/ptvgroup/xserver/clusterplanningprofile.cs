// Version: 2.25
// Build: 1.0.56236

namespace com.ptvgroup.xserver.clusterplanningprofile 
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://clusterplanningprofile.xserver.ptvgroup.com")]
    public partial class ClusterPlanningProfile : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.clusterplanningprofile.Clustering clusteringField;
        private com.ptvgroup.xserver.clusterplanningprofile.Covering coveringField;
        private com.ptvgroup.xserver.clusterplanningprofile.VisitPlanning visitPlanningField;
        private com.ptvgroup.xserver.clusterplanningprofile.VisitSequencing visitSequencingField;
        private double solverTimeLimitField;
        private bool solverTimeLimitFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("clustering", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.clusterplanningprofile.Clustering clustering {
            get {
                return this.clusteringField;
            }
            set {
                this.clusteringField = value;
                this.RaisePropertyChanged("clustering");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("covering", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.clusterplanningprofile.Covering covering {
            get {
                return this.coveringField;
            }
            set {
                this.coveringField = value;
                this.RaisePropertyChanged("covering");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("visitPlanning", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.clusterplanningprofile.VisitPlanning visitPlanning {
            get {
                return this.visitPlanningField;
            }
            set {
                this.visitPlanningField = value;
                this.RaisePropertyChanged("visitPlanning");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("visitSequencing", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.clusterplanningprofile.VisitSequencing visitSequencing {
            get {
                return this.visitSequencingField;
            }
            set {
                this.visitSequencingField = value;
                this.RaisePropertyChanged("visitSequencing");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double solverTimeLimit {
            get {
                return this.solverTimeLimitField;
            }
            set {
                this.solverTimeLimitField = value;
                this.RaisePropertyChanged("solverTimeLimit");
                this.solverTimeLimitFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool solverTimeLimitSpecified {
            get {
                return this.solverTimeLimitFieldSpecified;
            }
            set {
                this.solverTimeLimitFieldSpecified = value;
                this.RaisePropertyChanged("solverTimeLimitSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://clusterplanningprofile.xserver.ptvgroup.com")]
    public partial class Clustering : object, System.ComponentModel.INotifyPropertyChanged {

        private int compactnessLevelField;
        private bool compactnessLevelFieldSpecified;
        private double approximationToleranceField;
        private bool approximationToleranceFieldSpecified;
        private bool performPreprocessingStepField;
        private bool performPreprocessingStepFieldSpecified;
        private bool boostActivityImportanceField;
        private bool boostActivityImportanceFieldSpecified;
        private int maximumNumberOfIterationsField;
        private bool maximumNumberOfIterationsFieldSpecified;
        private double minimumRelativeImprovementField;
        private bool minimumRelativeImprovementFieldSpecified;
        private int maximumNumberOfStartsField;
        private bool maximumNumberOfStartsFieldSpecified;
        private int maximumNumberOfSamplingsField;
        private bool maximumNumberOfSamplingsFieldSpecified;
        private int numberOfNearestNeighborsField;
        private bool numberOfNearestNeighborsFieldSpecified;
        private com.ptvgroup.xserver.clusterplanningprofile.ReassignmentMethod reassignmentMethodField;
        private bool reassignmentMethodFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int compactnessLevel {
            get {
                return this.compactnessLevelField;
            }
            set {
                this.compactnessLevelField = value;
                this.RaisePropertyChanged("compactnessLevel");
                this.compactnessLevelFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compactnessLevelSpecified {
            get {
                return this.compactnessLevelFieldSpecified;
            }
            set {
                this.compactnessLevelFieldSpecified = value;
                this.RaisePropertyChanged("compactnessLevelSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double approximationTolerance {
            get {
                return this.approximationToleranceField;
            }
            set {
                this.approximationToleranceField = value;
                this.RaisePropertyChanged("approximationTolerance");
                this.approximationToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approximationToleranceSpecified {
            get {
                return this.approximationToleranceFieldSpecified;
            }
            set {
                this.approximationToleranceFieldSpecified = value;
                this.RaisePropertyChanged("approximationToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool performPreprocessingStep {
            get {
                return this.performPreprocessingStepField;
            }
            set {
                this.performPreprocessingStepField = value;
                this.RaisePropertyChanged("performPreprocessingStep");
                this.performPreprocessingStepFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool performPreprocessingStepSpecified {
            get {
                return this.performPreprocessingStepFieldSpecified;
            }
            set {
                this.performPreprocessingStepFieldSpecified = value;
                this.RaisePropertyChanged("performPreprocessingStepSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool boostActivityImportance {
            get {
                return this.boostActivityImportanceField;
            }
            set {
                this.boostActivityImportanceField = value;
                this.RaisePropertyChanged("boostActivityImportance");
                this.boostActivityImportanceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool boostActivityImportanceSpecified {
            get {
                return this.boostActivityImportanceFieldSpecified;
            }
            set {
                this.boostActivityImportanceFieldSpecified = value;
                this.RaisePropertyChanged("boostActivityImportanceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumNumberOfIterations {
            get {
                return this.maximumNumberOfIterationsField;
            }
            set {
                this.maximumNumberOfIterationsField = value;
                this.RaisePropertyChanged("maximumNumberOfIterations");
                this.maximumNumberOfIterationsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumNumberOfIterationsSpecified {
            get {
                return this.maximumNumberOfIterationsFieldSpecified;
            }
            set {
                this.maximumNumberOfIterationsFieldSpecified = value;
                this.RaisePropertyChanged("maximumNumberOfIterationsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double minimumRelativeImprovement {
            get {
                return this.minimumRelativeImprovementField;
            }
            set {
                this.minimumRelativeImprovementField = value;
                this.RaisePropertyChanged("minimumRelativeImprovement");
                this.minimumRelativeImprovementFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimumRelativeImprovementSpecified {
            get {
                return this.minimumRelativeImprovementFieldSpecified;
            }
            set {
                this.minimumRelativeImprovementFieldSpecified = value;
                this.RaisePropertyChanged("minimumRelativeImprovementSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumNumberOfStarts {
            get {
                return this.maximumNumberOfStartsField;
            }
            set {
                this.maximumNumberOfStartsField = value;
                this.RaisePropertyChanged("maximumNumberOfStarts");
                this.maximumNumberOfStartsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumNumberOfStartsSpecified {
            get {
                return this.maximumNumberOfStartsFieldSpecified;
            }
            set {
                this.maximumNumberOfStartsFieldSpecified = value;
                this.RaisePropertyChanged("maximumNumberOfStartsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumNumberOfSamplings {
            get {
                return this.maximumNumberOfSamplingsField;
            }
            set {
                this.maximumNumberOfSamplingsField = value;
                this.RaisePropertyChanged("maximumNumberOfSamplings");
                this.maximumNumberOfSamplingsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumNumberOfSamplingsSpecified {
            get {
                return this.maximumNumberOfSamplingsFieldSpecified;
            }
            set {
                this.maximumNumberOfSamplingsFieldSpecified = value;
                this.RaisePropertyChanged("maximumNumberOfSamplingsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfNearestNeighbors {
            get {
                return this.numberOfNearestNeighborsField;
            }
            set {
                this.numberOfNearestNeighborsField = value;
                this.RaisePropertyChanged("numberOfNearestNeighbors");
                this.numberOfNearestNeighborsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfNearestNeighborsSpecified {
            get {
                return this.numberOfNearestNeighborsFieldSpecified;
            }
            set {
                this.numberOfNearestNeighborsFieldSpecified = value;
                this.RaisePropertyChanged("numberOfNearestNeighborsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public com.ptvgroup.xserver.clusterplanningprofile.ReassignmentMethod reassignmentMethod {
            get {
                return this.reassignmentMethodField;
            }
            set {
                this.reassignmentMethodField = value;
                this.RaisePropertyChanged("reassignmentMethod");
                this.reassignmentMethodFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reassignmentMethodSpecified {
            get {
                return this.reassignmentMethodFieldSpecified;
            }
            set {
                this.reassignmentMethodFieldSpecified = value;
                this.RaisePropertyChanged("reassignmentMethodSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://clusterplanningprofile.xserver.ptvgroup.com")]
    public partial class Covering : object, System.ComponentModel.INotifyPropertyChanged {

        private double approximationToleranceField;
        private bool approximationToleranceFieldSpecified;
        private bool performPreprocessingStepField;
        private bool performPreprocessingStepFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double approximationTolerance {
            get {
                return this.approximationToleranceField;
            }
            set {
                this.approximationToleranceField = value;
                this.RaisePropertyChanged("approximationTolerance");
                this.approximationToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approximationToleranceSpecified {
            get {
                return this.approximationToleranceFieldSpecified;
            }
            set {
                this.approximationToleranceFieldSpecified = value;
                this.RaisePropertyChanged("approximationToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool performPreprocessingStep {
            get {
                return this.performPreprocessingStepField;
            }
            set {
                this.performPreprocessingStepField = value;
                this.RaisePropertyChanged("performPreprocessingStep");
                this.performPreprocessingStepFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool performPreprocessingStepSpecified {
            get {
                return this.performPreprocessingStepFieldSpecified;
            }
            set {
                this.performPreprocessingStepFieldSpecified = value;
                this.RaisePropertyChanged("performPreprocessingStepSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://clusterplanningprofile.xserver.ptvgroup.com")]
    public partial class OvernightStay : object, System.ComponentModel.INotifyPropertyChanged {

        private double approximationToleranceField;
        private bool approximationToleranceFieldSpecified;
        private bool performPreprocessingStepField;
        private bool performPreprocessingStepFieldSpecified;
        private int maximumNumberOfIterationsField;
        private bool maximumNumberOfIterationsFieldSpecified;
        private int numberOfNearestNeighborsField;
        private bool numberOfNearestNeighborsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double approximationTolerance {
            get {
                return this.approximationToleranceField;
            }
            set {
                this.approximationToleranceField = value;
                this.RaisePropertyChanged("approximationTolerance");
                this.approximationToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approximationToleranceSpecified {
            get {
                return this.approximationToleranceFieldSpecified;
            }
            set {
                this.approximationToleranceFieldSpecified = value;
                this.RaisePropertyChanged("approximationToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool performPreprocessingStep {
            get {
                return this.performPreprocessingStepField;
            }
            set {
                this.performPreprocessingStepField = value;
                this.RaisePropertyChanged("performPreprocessingStep");
                this.performPreprocessingStepFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool performPreprocessingStepSpecified {
            get {
                return this.performPreprocessingStepFieldSpecified;
            }
            set {
                this.performPreprocessingStepFieldSpecified = value;
                this.RaisePropertyChanged("performPreprocessingStepSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumNumberOfIterations {
            get {
                return this.maximumNumberOfIterationsField;
            }
            set {
                this.maximumNumberOfIterationsField = value;
                this.RaisePropertyChanged("maximumNumberOfIterations");
                this.maximumNumberOfIterationsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumNumberOfIterationsSpecified {
            get {
                return this.maximumNumberOfIterationsFieldSpecified;
            }
            set {
                this.maximumNumberOfIterationsFieldSpecified = value;
                this.RaisePropertyChanged("maximumNumberOfIterationsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfNearestNeighbors {
            get {
                return this.numberOfNearestNeighborsField;
            }
            set {
                this.numberOfNearestNeighborsField = value;
                this.RaisePropertyChanged("numberOfNearestNeighbors");
                this.numberOfNearestNeighborsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfNearestNeighborsSpecified {
            get {
                return this.numberOfNearestNeighborsFieldSpecified;
            }
            set {
                this.numberOfNearestNeighborsFieldSpecified = value;
                this.RaisePropertyChanged("numberOfNearestNeighborsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://clusterplanningprofile.xserver.ptvgroup.com")]
    public partial class VisitPlanning : object, System.ComponentModel.INotifyPropertyChanged {

        private com.ptvgroup.xserver.clusterplanningprofile.OvernightStay overnightStayField;
        private com.ptvgroup.xserver.clusterplanningprofile.WorkloadBalancing workloadBalancingField;
        private com.ptvgroup.xserver.clusterplanningprofile.Workload workloadField;
        private int compactnessLevelField;
        private bool compactnessLevelFieldSpecified;
        private int dailyDistanceWeightField;
        private bool dailyDistanceWeightFieldSpecified;
        private int weeklyDistanceWeightField;
        private bool weeklyDistanceWeightFieldSpecified;
        private double approximationToleranceField;
        private bool approximationToleranceFieldSpecified;
        private bool performPreprocessingStepField;
        private bool performPreprocessingStepFieldSpecified;
        private int maximumNumberOfIterationsField;
        private bool maximumNumberOfIterationsFieldSpecified;
        private double minimumRelativeImprovementField;
        private bool minimumRelativeImprovementFieldSpecified;

                    [System.Xml.Serialization.XmlElementAttribute("overnightStay", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.clusterplanningprofile.OvernightStay overnightStay {
            get {
                return this.overnightStayField;
            }
            set {
                this.overnightStayField = value;
                this.RaisePropertyChanged("overnightStay");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("workloadBalancing", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.clusterplanningprofile.WorkloadBalancing workloadBalancing {
            get {
                return this.workloadBalancingField;
            }
            set {
                this.workloadBalancingField = value;
                this.RaisePropertyChanged("workloadBalancing");
            }
        }

                    [System.Xml.Serialization.XmlElementAttribute("workload", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public com.ptvgroup.xserver.clusterplanningprofile.Workload workload {
            get {
                return this.workloadField;
            }
            set {
                this.workloadField = value;
                this.RaisePropertyChanged("workload");
            }
        }

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int compactnessLevel {
            get {
                return this.compactnessLevelField;
            }
            set {
                this.compactnessLevelField = value;
                this.RaisePropertyChanged("compactnessLevel");
                this.compactnessLevelFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compactnessLevelSpecified {
            get {
                return this.compactnessLevelFieldSpecified;
            }
            set {
                this.compactnessLevelFieldSpecified = value;
                this.RaisePropertyChanged("compactnessLevelSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int dailyDistanceWeight {
            get {
                return this.dailyDistanceWeightField;
            }
            set {
                this.dailyDistanceWeightField = value;
                this.RaisePropertyChanged("dailyDistanceWeight");
                this.dailyDistanceWeightFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dailyDistanceWeightSpecified {
            get {
                return this.dailyDistanceWeightFieldSpecified;
            }
            set {
                this.dailyDistanceWeightFieldSpecified = value;
                this.RaisePropertyChanged("dailyDistanceWeightSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int weeklyDistanceWeight {
            get {
                return this.weeklyDistanceWeightField;
            }
            set {
                this.weeklyDistanceWeightField = value;
                this.RaisePropertyChanged("weeklyDistanceWeight");
                this.weeklyDistanceWeightFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weeklyDistanceWeightSpecified {
            get {
                return this.weeklyDistanceWeightFieldSpecified;
            }
            set {
                this.weeklyDistanceWeightFieldSpecified = value;
                this.RaisePropertyChanged("weeklyDistanceWeightSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double approximationTolerance {
            get {
                return this.approximationToleranceField;
            }
            set {
                this.approximationToleranceField = value;
                this.RaisePropertyChanged("approximationTolerance");
                this.approximationToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approximationToleranceSpecified {
            get {
                return this.approximationToleranceFieldSpecified;
            }
            set {
                this.approximationToleranceFieldSpecified = value;
                this.RaisePropertyChanged("approximationToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool performPreprocessingStep {
            get {
                return this.performPreprocessingStepField;
            }
            set {
                this.performPreprocessingStepField = value;
                this.RaisePropertyChanged("performPreprocessingStep");
                this.performPreprocessingStepFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool performPreprocessingStepSpecified {
            get {
                return this.performPreprocessingStepFieldSpecified;
            }
            set {
                this.performPreprocessingStepFieldSpecified = value;
                this.RaisePropertyChanged("performPreprocessingStepSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumNumberOfIterations {
            get {
                return this.maximumNumberOfIterationsField;
            }
            set {
                this.maximumNumberOfIterationsField = value;
                this.RaisePropertyChanged("maximumNumberOfIterations");
                this.maximumNumberOfIterationsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumNumberOfIterationsSpecified {
            get {
                return this.maximumNumberOfIterationsFieldSpecified;
            }
            set {
                this.maximumNumberOfIterationsFieldSpecified = value;
                this.RaisePropertyChanged("maximumNumberOfIterationsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double minimumRelativeImprovement {
            get {
                return this.minimumRelativeImprovementField;
            }
            set {
                this.minimumRelativeImprovementField = value;
                this.RaisePropertyChanged("minimumRelativeImprovement");
                this.minimumRelativeImprovementFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimumRelativeImprovementSpecified {
            get {
                return this.minimumRelativeImprovementFieldSpecified;
            }
            set {
                this.minimumRelativeImprovementFieldSpecified = value;
                this.RaisePropertyChanged("minimumRelativeImprovementSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://clusterplanningprofile.xserver.ptvgroup.com")]
    public partial class VisitSequencing : object, System.ComponentModel.INotifyPropertyChanged {

        private double approximationToleranceField;
        private bool approximationToleranceFieldSpecified;
        private bool performPreprocessingStepField;
        private bool performPreprocessingStepFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double approximationTolerance {
            get {
                return this.approximationToleranceField;
            }
            set {
                this.approximationToleranceField = value;
                this.RaisePropertyChanged("approximationTolerance");
                this.approximationToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approximationToleranceSpecified {
            get {
                return this.approximationToleranceFieldSpecified;
            }
            set {
                this.approximationToleranceFieldSpecified = value;
                this.RaisePropertyChanged("approximationToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool performPreprocessingStep {
            get {
                return this.performPreprocessingStepField;
            }
            set {
                this.performPreprocessingStepField = value;
                this.RaisePropertyChanged("performPreprocessingStep");
                this.performPreprocessingStepFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool performPreprocessingStepSpecified {
            get {
                return this.performPreprocessingStepFieldSpecified;
            }
            set {
                this.performPreprocessingStepFieldSpecified = value;
                this.RaisePropertyChanged("performPreprocessingStepSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://clusterplanningprofile.xserver.ptvgroup.com")]
    public partial class Workload : object, System.ComponentModel.INotifyPropertyChanged {

        private int orderScoreWeightField;
        private bool orderScoreWeightFieldSpecified;
        private int numberOfStartsField;
        private bool numberOfStartsFieldSpecified;
        private double solverTimeLimitPerStartField;
        private bool solverTimeLimitPerStartFieldSpecified;
        private int numberOfNearestNeighborsField;
        private bool numberOfNearestNeighborsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int orderScoreWeight {
            get {
                return this.orderScoreWeightField;
            }
            set {
                this.orderScoreWeightField = value;
                this.RaisePropertyChanged("orderScoreWeight");
                this.orderScoreWeightFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderScoreWeightSpecified {
            get {
                return this.orderScoreWeightFieldSpecified;
            }
            set {
                this.orderScoreWeightFieldSpecified = value;
                this.RaisePropertyChanged("orderScoreWeightSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfStarts {
            get {
                return this.numberOfStartsField;
            }
            set {
                this.numberOfStartsField = value;
                this.RaisePropertyChanged("numberOfStarts");
                this.numberOfStartsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfStartsSpecified {
            get {
                return this.numberOfStartsFieldSpecified;
            }
            set {
                this.numberOfStartsFieldSpecified = value;
                this.RaisePropertyChanged("numberOfStartsSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double solverTimeLimitPerStart {
            get {
                return this.solverTimeLimitPerStartField;
            }
            set {
                this.solverTimeLimitPerStartField = value;
                this.RaisePropertyChanged("solverTimeLimitPerStart");
                this.solverTimeLimitPerStartFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool solverTimeLimitPerStartSpecified {
            get {
                return this.solverTimeLimitPerStartFieldSpecified;
            }
            set {
                this.solverTimeLimitPerStartFieldSpecified = value;
                this.RaisePropertyChanged("solverTimeLimitPerStartSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int numberOfNearestNeighbors {
            get {
                return this.numberOfNearestNeighborsField;
            }
            set {
                this.numberOfNearestNeighborsField = value;
                this.RaisePropertyChanged("numberOfNearestNeighbors");
                this.numberOfNearestNeighborsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfNearestNeighborsSpecified {
            get {
                return this.numberOfNearestNeighborsFieldSpecified;
            }
            set {
                this.numberOfNearestNeighborsFieldSpecified = value;
                this.RaisePropertyChanged("numberOfNearestNeighborsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://clusterplanningprofile.xserver.ptvgroup.com")]
    public partial class WorkloadBalancing : object, System.ComponentModel.INotifyPropertyChanged {

        private double approximationToleranceField;
        private bool approximationToleranceFieldSpecified;
        private bool performPreprocessingStepField;
        private bool performPreprocessingStepFieldSpecified;
        private int maximumNumberOfIterationsField;
        private bool maximumNumberOfIterationsFieldSpecified;

                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public double approximationTolerance {
            get {
                return this.approximationToleranceField;
            }
            set {
                this.approximationToleranceField = value;
                this.RaisePropertyChanged("approximationTolerance");
                this.approximationToleranceFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approximationToleranceSpecified {
            get {
                return this.approximationToleranceFieldSpecified;
            }
            set {
                this.approximationToleranceFieldSpecified = value;
                this.RaisePropertyChanged("approximationToleranceSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool performPreprocessingStep {
            get {
                return this.performPreprocessingStepField;
            }
            set {
                this.performPreprocessingStepField = value;
                this.RaisePropertyChanged("performPreprocessingStep");
                this.performPreprocessingStepFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool performPreprocessingStepSpecified {
            get {
                return this.performPreprocessingStepFieldSpecified;
            }
            set {
                this.performPreprocessingStepFieldSpecified = value;
                this.RaisePropertyChanged("performPreprocessingStepSpecified");
            }
        }
        
                    [System.Xml.Serialization.XmlAttributeAttribute()]
        public int maximumNumberOfIterations {
            get {
                return this.maximumNumberOfIterationsField;
            }
            set {
                this.maximumNumberOfIterationsField = value;
                this.RaisePropertyChanged("maximumNumberOfIterations");
                this.maximumNumberOfIterationsFieldSpecified = true;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumNumberOfIterationsSpecified {
            get {
                return this.maximumNumberOfIterationsFieldSpecified;
            }
            set {
                this.maximumNumberOfIterationsFieldSpecified = value;
                this.RaisePropertyChanged("maximumNumberOfIterationsSpecified");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://clusterplanningprofile.xserver.ptvgroup.com")]
    public enum ReassignmentMethod {
        /**
         * Assign locations at territory edges to the territory in which it probably fits best. Might cause territories to be slightly more unbalanced than specified in the request.
         */
        DECIDE,

        /**
         * Only conduct definite assignments to reduce the problem. Other locations are left unassigned for the next iteration.
         */
        REDUCE
    }


}
