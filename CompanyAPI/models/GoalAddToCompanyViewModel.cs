using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.models
{
    public class GoalAddToCompanyViewModel
    {
        [Required]
        public int GoalId { get; set; }
    }

}
