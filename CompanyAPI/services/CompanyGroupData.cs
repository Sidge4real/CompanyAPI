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
