namespace CompanyAPI.entities
{
    public class Company
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public long GroupId { get; set; }
        public string Image { get; set; }
        public string Sector { get; set; }
        public int CorporationId { get; set; }
        public Corporation Corporation { get; set; }
        public ICollection<Goal> Goals { get; set; }

    }
}
