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
    
    public partial class COMPANY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPANY()
        {
            this.UNGTUYEN = new HashSet<UNGTUYEN>();
        }
    
        public string userid { get; set; }
        public string ten { get; set; }
        public string ngaythanhlap { get; set; }
        public string ngdungdau { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string masothue { get; set; }
        public string linhvuc { get; set; }
        public string email { get; set; }
        public string thongtin { get; set; }
        public string website { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNGTUYEN> UNGTUYEN { get; set; }
    }
}
