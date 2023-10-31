using CompanyAPI.entities;

namespace CompanyAPI.services
{
    public interface ICompanyData
    {
        IEnumerable<Company> GetAll();
        Company Get(int id);
    }
    public class CompanyData : ICompanyData
    {
        private static List<Company> companies;
        public CompanyData()
        {
            companies = new List<Company>
    {
        new Company
        {
            Id = 1,
            Name = "Company A",
            Description = "Description of Company A",
            GroupId = 1,
            Image = "company_a.jpg",
            Sector = "Sector A",
            Goals = new List<Goal>() 
        },
        new Company
        {
            Id = 2,
            Name = "Company B",
            Description = "Description of Company B",
            GroupId = 2,
            Image = "company_b.jpg",
            Sector = "Sector B",
            Goals = new List<Goal>() 
        },
       
    };

        }
        public Company Get(int id)
        {
            var company = companies.FirstOrDefault(a => a.Id == id);
            return company;
        }

        public IEnumerable<Company> GetAll()
        {
            return companies;
        }
    }
}