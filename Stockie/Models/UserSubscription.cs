//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stockie.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserSubscription
    {
        public string Id { get; set; }
        public string UserIdFK { get; set; }
        public string SubscriptionTermIdFK { get; set; }
        public System.DateTime DateActivated { get; set; }
        public bool Active { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual SubscriptionTerm SubscriptionTerm { get; set; }
    }
}
