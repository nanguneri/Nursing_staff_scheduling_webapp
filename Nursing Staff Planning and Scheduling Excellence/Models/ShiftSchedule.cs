//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NursingStaffPlanningandSchedulingExcellence.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShiftSchedule
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public Nullable<int> ShiftId { get; set; }
    }
}
