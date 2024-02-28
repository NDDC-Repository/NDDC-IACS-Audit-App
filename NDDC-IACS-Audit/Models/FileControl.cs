using System;
using System.Collections.Generic;

namespace NDDC_IACS_Audit.Models
{
    public partial class FileControl
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Originator { get; set; }
        public string? OriginatorName { get; set; }
        public int? DirectorateId { get; set; }
        public string? NatureOfTransaction { get; set; }
        public decimal? RequestedAmount { get; set; }
        public decimal? VettedAmount { get; set; }
        public string? Observations { get; set; }
        public string? Remarks { get; set; }
        public string? Code { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
