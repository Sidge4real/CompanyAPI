namespace CompanyAPI.entities
{
    public class Company
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public string Description { get; set; }
        public long GroupId { get; set; }
        public string Image { get; set; }
        public string Sector { get; set; }
        public List<Goal> Goals { get; set; }
    }
}
