using CompanyAPI.entities;

namespace CompanyAPI.services
{
    public interface ICompanyGroupData
    {
        IEnumerable<CompanyGroup> GetAll();
        CompanyGroup Get(int id);
    }
    public class CompanyGroupData : ICompanyGroupData
    {
        private static List<CompanyGroup> companyGroups;

        public CompanyGroupData()
        {
            companyGroups = new List<CompanyGroup>
        {
            new CompanyGroup { Id = 1, Name = "Company Group A", Companies = new List<Company>() },
            new CompanyGroup { Id = 2, Name = "Company Group B", Companies = new List<Company>() }
        };

        }

        public CompanyGroup Get(int id)
        {
            var companyGroup = companyGroups.FirstOrDefault(async => async.Id == id);
            return companyGroup;
        }

        public IEnumerable<CompanyGroup> GetAll()
        {
            return companyGroups;
        }
    }

}
