//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasswordManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Password
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Website { get; set; }
        public string UserName { get; set; }
        public byte[] Password1 { get; set; }
        public string PasswordHash { get; set; }
        public byte[] PasswordIVHash { get; set; }
    }
}
