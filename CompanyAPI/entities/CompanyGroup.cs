namespace CompanyAPI.entities
{
    public class CompanyGroup
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long Id { get; set; }
        public string Image { get; set; }
        public List<Company> Companies { get; set; }
    }
}
