//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assessments.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssessmentCheckoffItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentCheckoffItem()
        {
            this.UserAssessmentCheckoffItems = new HashSet<UserAssessmentCheckoffItem>();
        }
    
        public int ID { get; set; }
        public int TranslationID { get; set; }
        public int AssessmentQuestionID { get; set; }
        public int AssessmentLevelID { get; set; }
        public int CheckOffItemOrder { get; set; }
    
        public virtual AssessmentQuestion AssessmentQuestion { get; set; }
        public virtual Translation Translation { get; set; }
        public virtual AssessmentLevel AssessmentLevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAssessmentCheckoffItem> UserAssessmentCheckoffItems { get; set; }
    }
}
