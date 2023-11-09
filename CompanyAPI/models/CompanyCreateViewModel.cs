using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.models
{
    public class CompanyCreateViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        [MaxLength(160)]
        public string Description { get; set; }
        public long GroupId { get; set; }
        public string Image { get; set; }
        public string Sector { get; set; }
    }
}
