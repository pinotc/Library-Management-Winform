//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUTHU
    {
        public int SoPhieuThu { get; set; }
        public int idDocGia { get; set; }
        public int SoTienThu { get; set; }
        public System.DateTime NgayLap { get; set; }
    
        public virtual DOCGIA DOCGIA { get; set; }
    }
}
