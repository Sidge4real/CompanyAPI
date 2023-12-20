using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.models
{
    public class GoalDeleteFromCompanyViewModel
    {
        [Required]
        public int GoalId { get; set; }
    }
}
