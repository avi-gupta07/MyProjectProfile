//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProjectProfile.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile_Industry_Intermediate_Table
    {
        public int PT_IW_ID { get; set; }
        public string profile_Email { get; set; }
        public int Industry_id { get; set; }
    
        public virtual Industry_Worked Industry_Worked { get; set; }
        public virtual Profile_table Profile_table { get; set; }
    }
}
