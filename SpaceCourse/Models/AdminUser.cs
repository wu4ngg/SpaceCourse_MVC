//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpaceCourse.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdminUser
    {
        public int id_admin { get; set; }
    
        public virtual User User { get; set; }
    }
}