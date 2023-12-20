using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long GroupId { get; set; }
        public string Image { get; set; }
        public string Sector { get; set; }
        public ICollection<Goal> Goals { get; set; } = new List<Goal>();
    }
}