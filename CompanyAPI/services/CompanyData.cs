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