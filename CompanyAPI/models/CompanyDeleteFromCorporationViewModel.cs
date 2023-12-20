using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.models
{
    public class CompanyDeleteFromCorporationViewModel
    {
        [Required]
        public int CompanyId { get; set; }
    }

}
