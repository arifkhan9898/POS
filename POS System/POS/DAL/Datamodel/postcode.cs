//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Datamodel
{
    using System;
    using System.Collections.Generic;
    
    public partial class postcode
    {
        public postcode()
        {
            this.addresses = new HashSet<address>();
        }
    
        public int id { get; set; }
        public string code { get; set; }
    
        public virtual ICollection<address> addresses { get; set; }
    }
}
