using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.models
{
    public class CompanyGroupCreateViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        [MaxLength(160)]
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
