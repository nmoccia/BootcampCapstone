//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BootcampCapstone
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Registrations = new HashSet<Registration>();
        }
    
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneHome { get; set; }
        public string phoneCell { get; set; }
        public string phoneOffice { get; set; }
        public string companyName { get; set; }
        public string branchLocation { get; set; }
        public Nullable<int> foodID { get; set; }
        public string additionalInfo { get; set; }
    
        public virtual Food Food { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
