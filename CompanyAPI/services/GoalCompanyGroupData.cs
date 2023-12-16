using CompanyAPI.entities;

namespace CompanyAPI.services
{
    public class GoalCompanyGroupDataInMemory : IGoalCompanyGroupData
    {
        private static List<Goal> goals;
        private static List<CompanyGroup> companyGroups;
        private static List<Company> companies;

        static GoalCompanyGroupDataInMemory()
        {
            companies = new List<Company>
            {
                new Company { Id = 1, Name = "Company A", Description = "Description of Company A", GroupId = 1, Image = "company_a.jpg", Sector = "Sector A" },
                new Company { Id = 2, Name = "Company B", Description = "Description of Company B", GroupId = 2, Image = "company_b.jpg", Sector = "Sector B" },
            };
            companyGroups = new List<CompanyGroup>
            {
                new CompanyGroup { Id = 1, Name = "Company Group A", Description="Lorem usam sem um", Image="CompanyA.jpg" },
                new CompanyGroup { Id = 2, Name = "Company Group B", Description="Lorem upsem som sum", Image="CompanyB.jpg" }
            };
            goals = new List<Goal>()
            {
                new Goal {Id=1, Description="lorem upsem", Name="mobile development", Image="worldofmobile.png", CompanyId=2},
                new Goal {Id=2, Description="lorem upsem", Name="web development", Image="websites.png", CompanyId=4},
                new Goal {Id=3, Description="lorem upsem", Name="data & software security", Image="servers.png", CompanyId=1}
            };
        }

        public Goal GetGoal(int id)
        {
            var goal = goals.FirstOrDefault(a => a.Id == id);
            return goal;
        }

        public IEnumerable<Goal> GetGoals()
        {
            return goals;
        }
        public void AddGoal(Goal goal)
        {
            goal.Id = goals.Max(x => x.Id) + 1;
            goals.Add(goal);
        }

        public void DeleteGoal(Goal goal)
        {
            goals.Remove(goal);
        }
        public void UpdateGoal(Goal goal)
        {
            var old = GetGoal(goal.Id);
            old.Name = goal.Name;
            old.Image = goal.Image;
            old.Description = goal.Description;
            old.CompanyId = goal.CompanyId;
        }

        public CompanyGroup GetCorporation(int id)
        {
            var companyGroup = companyGroups.FirstOrDefault(async => async.Id == id);
            return companyGroup;
        }

        public IEnumerable<CompanyGroup> GetCorporations()
        {
            return companyGroups;
        }
        public void AddCorporation(CompanyGroup group)
        {
            group.Id = companyGroups.Max(x => x.Id) + 1;
            companyGroups.Add(group);
        }

        public void DeleteCorporation(CompanyGroup group)
        {
            companyGroups.Remove(group);
        }
        public void UpdateCorporation(CompanyGroup group)
        {
            var old = GetCorporation(group.Id);
            old.Name = group.Name;
            old.Description = group.Description;
            old.Image = group.Image;
        }

        public void AddCompany(Company company)
        {
            company.Id = companies.Max(x => x.Id) + 1;
            companies.Add(company);
        }

        public void DeleteCompany(Company company)
        {
            companies.Remove(company);
        }

        public Company GetCompany(int id)
        {
            var company = companies.FirstOrDefault(a => a.Id == id);
            return company;
        }

        public IEnumerable<Company> GetCompanies()
        {
            return companies;
        }

        public void UpdateCompany(Company company)
        {
            var old = GetCompany(company.Id);
            old.Name = company.Name;
            old.Description = company.Description;
            old.GroupId = company.GroupId;
            old.Image = company.Image;
            old.Sector = company.Sector;
        }
    }
}
