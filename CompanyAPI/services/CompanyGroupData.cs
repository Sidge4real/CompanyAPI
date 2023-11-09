using CompanyAPI.entities;

namespace CompanyAPI.services
{
    public interface ICompanyGroupData
    {
        IEnumerable<CompanyGroup> GetAll();
        CompanyGroup Get(int id);
        void Add(CompanyGroup group);
        void Delete(CompanyGroup group);
    }
    public class CompanyGroupData : ICompanyGroupData
    {
        private static List<CompanyGroup> companyGroups;

        static CompanyGroupData()
        {
            companyGroups = new List<CompanyGroup>
        {
            new CompanyGroup { Id = 1, Name = "Company Group A", Description="Lorem usam sem um", Image="CompanyA.jpg" },
            new CompanyGroup { Id = 2, Name = "Company Group B", Description="Lorem upsem som sum", Image="CompanyB.jpg" }
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
        public void Add(CompanyGroup group)
        {
            group.Id = companyGroups.Max(x => x.Id) + 1;
            companyGroups.Add(group);
        }

        public void Delete(CompanyGroup group)
        {
            companyGroups.Remove(group);
        }
    }

}
