//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOSPITAL_v2.Data_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEDICINE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDICINE()
        {
            this.TREATMENT_PLAN_MEDICINE = new HashSet<TREATMENT_PLAN_MEDICINE>();
        }
    
        public int MEDICINE_ID { get; set; }
        public string NAME { get; set; }
        public Nullable<int> PRICE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TREATMENT_PLAN_MEDICINE> TREATMENT_PLAN_MEDICINE { get; set; }
    }
}
