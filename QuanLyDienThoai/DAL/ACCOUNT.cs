//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDienThoai.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACCOUNT
    {
        public string EMAIL { get; set; }
        public string ID_CUSTOMER { get; set; }
        public string PASSWORD { get; set; }
        public string CONFIRMPASSWORD { get; set; }
        public Nullable<bool> ISEMAILVERIFY { get; set; }
        public Nullable<System.Guid> ACTIVATIONCODE { get; set; }
        public string RESETPASSWORDCODE { get; set; }
        public string ID_ACCOUNT { get; set; }
        public string TYPE_ACCOUNT { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}
