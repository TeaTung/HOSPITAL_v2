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
    
    public partial class RELATIONSHIP
    {
        public int RELATIONSHIP_ID { get; set; }
        public Nullable<int> PATIENT_ID { get; set; }
        public string TYPE { get; set; }
        public string NAME { get; set; }
    
        public virtual PATIENT PATIENT { get; set; }
    }
}
