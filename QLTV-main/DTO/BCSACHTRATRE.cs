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
    
    public partial class BCSACHTRATRE
    {
        public System.DateTime Ngay { get; set; }
        public int idCuonSach { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public int SoNgayTre { get; set; }
    
        public virtual CUONSACH CUONSACH { get; set; }
    }
}
