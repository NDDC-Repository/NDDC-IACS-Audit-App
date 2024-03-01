using System.ComponentModel.DataAnnotations.Schema;

namespace NDDC_IACS_Audit.Models
{
    public partial class FileControl
    {
        [NotMapped]
        public int SrNo { get; set; }
        
    }
}
