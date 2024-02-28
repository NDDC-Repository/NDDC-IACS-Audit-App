using System;
using System.Collections.Generic;

namespace NDDC_IACS_Audit.Models
{
    public partial class Directorate
    {
        public int Id { get; set; }
        public string? DirectorateName { get; set; }
        public DateTime? DateAdded { get; set; }
        public string? AddedBy { get; set; }
    }
}
