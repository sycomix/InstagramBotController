//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstagramBotController
{
    using System;
    using System.Collections.Generic;
    
    public partial class Follower
    {
        public int id { get; set; }
        public int account { get; set; }
        public int follower1 { get; set; }
    
        public virtual Account Account1 { get; set; }
        public virtual Account Account2 { get; set; }
    }
}
