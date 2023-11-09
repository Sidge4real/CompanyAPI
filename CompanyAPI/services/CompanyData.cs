using CompanyAPI.entities;

namespace CompanyAPI.services
{
    public interface ICompanyData
    {
        IEnumerable<Company> GetAll();
        Company Get(int id);
        void Add(Company company);
        void Delete(Company company);
        void Update(Company company);
    }
    public class CompanyData : ICompanyData
    {
        private static List<Company> companies;
        static CompanyData()
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
                    Sector = "Sector A"
                },
                new Company
                {
                    Id = 2,
                    Name = "Company B",
                    Description = "Description of Company B",
                    GroupId = 2,
                    Image = "company_b.jpg",
                    Sector = "Sector B" 
                },
            };
        }

        public void Add(Company company)
        {
            company.Id = companies.Max(x => x.Id) + 1;
            companies.Add(company);
        }

        public void Delete(Company company)
        {
            companies.Remove(company);
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

        public void Update(Company company)
        {
            var old = Get(company.Id);
            old.Name = company.Name;
            old.Description = company.Description;
            old.GroupId = company.GroupId;
            old.Image = company.Image;
            old.Sector = company.Sector;
        }
    }
}