namespace CompanyAPI.entities
{
    public class Goal
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CompanyId { get; set; }
    }
}
