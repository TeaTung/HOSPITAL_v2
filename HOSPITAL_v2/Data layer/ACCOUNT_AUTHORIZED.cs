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
    
    public partial class ACCOUNT_AUTHORIZED
    {
        public int ID { get; set; }
        public Nullable<int> DOCTOR_ID { get; set; }
        public string CONTENT { get; set; }
    
        public virtual DOCTOR DOCTOR { get; set; }
    }
}
