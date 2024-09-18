using System.ComponentModel.DataAnnotations;

namespace APIWEBASSEMBLy.Data.DTOs
{
    public class PostProductDTO
    {
        [Required]
        public string nombreAMMA { get; set; }
        public string descripcionAMMA { get; set; }
        public decimal precio { get; set; }

    }
}
