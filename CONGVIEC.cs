//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_JobApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONGVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONGVIEC()
        {
            this.UNGTUYEN = new HashSet<UNGTUYEN>();
        }
    
        public string jobid { get; set; }
        public string userid { get; set; }
        public string tencv { get; set; }
        public string ngaytao { get; set; }
        public string vitri { get; set; }
        public string mucluong { get; set; }
        public string linhvuc { get; set; }
        public string thongtin { get; set; }
        public string phucloi { get; set; }
        public string yeucau { get; set; }
        public Nullable<int> soluong { get; set; }
        public string noilamviec { get; set; }
        public string diadiem { get; set; }
        public string handangki { get; set; }
        public string trangthai { get; set; }
        public Nullable<int> dadangki { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNGTUYEN> UNGTUYEN { get; set; }
    }
}
