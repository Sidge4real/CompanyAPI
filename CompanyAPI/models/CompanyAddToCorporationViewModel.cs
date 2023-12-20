using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.models
{
    public class CompanyAddToCorporationViewModel
    {
        [Required]
        public int CompanyId { get; set; }
    }
}
