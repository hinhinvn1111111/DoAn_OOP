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
    
    public partial class DiemChuan
    {
        public int ID { get; set; }
        public int ID_Truong { get; set; }
        public int ID_Nam { get; set; }
        public int ID_Nganh { get; set; }
        public string Khoi { get; set; }
        public Nullable<double> Diem { get; set; }
    
        public virtual NamTuyenSinh NamTuyenSinh { get; set; }
        public virtual Nganh Nganh { get; set; }
        public virtual Truong Truong { get; set; }
    }
}