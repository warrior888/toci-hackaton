//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GhostRider.Tournament.Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class groupparticipants
    {
        public int id { get; set; }
        public Nullable<int> groupsid { get; set; }
        public Nullable<int> participantsid { get; set; }
    
        public virtual groups groups { get; set; }
        public virtual participants participants { get; set; }
    }
}