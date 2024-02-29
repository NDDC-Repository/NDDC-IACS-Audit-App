using System;
using System.Collections.Generic;

namespace NDDC_IACS_Audit.Models
{
    public partial class Checklist
    {
        public int Id { get; set; }
        public string? ChecklistItem { get; set; }
        public bool? Checked { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
