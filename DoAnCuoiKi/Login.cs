//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnCuoiKi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        public int ID { get; set; }
        public string usn { get; set; }
        public string pw { get; set; }
        public int ID_Role { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
