using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.entities
{
    public class Goal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
