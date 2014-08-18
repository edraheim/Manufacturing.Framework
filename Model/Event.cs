//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manufacturing.Framework.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> AssetId { get; set; }
        public Nullable<int> EventType { get; set; }
        public string MetaData { get; set; }
    
        public virtual Asset Asset { get; set; }
        public virtual EventTypes AssociatedEventType { get; set; }
    }
}
