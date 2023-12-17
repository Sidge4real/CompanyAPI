using CompanyAPI.contexts;
using CompanyAPI.entities;

namespace CompanyAPI.services
{
    public class SqlGoalCompanyGroupData : ICorporationCompanyGoalData
    {
        private CorporationDbContext context;
        public SqlGoalCompanyGroupData(CorporationDbContext context)
        {
            this.context = context;
        }

        public Goal GetGoal(int id)
        {
            return context.goals.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Goal> GetGoals()
        {
            return context.goals;
        }
        public void AddGoal(Goal goal)
        {
            context.goals.Add(goal);
            context.SaveChanges();
        }

        public void DeleteGoal(Goal goal)
        {
            context.goals.Remove(goal);
            context.SaveChanges();
        }
        public void UpdateGoal(Goal newGoal)
        {
            var old = GetGoal(newGoal.Id);
            if (old != null)
            {
                old.Name = newGoal.Name;
                old.Image = newGoal.Image;
                old.Description = newGoal.Description;
                old.CompanyId = newGoal.CompanyId;

                context.SaveChanges();
            }
        }

        public Corporation GetCorporation(int id)
        {
            return context.corporations.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Corporation> GetCorporations()
        {
            return context.corporations;
        }
        public void AddCorporation(Corporation group)
        {
            context.corporations.Add(group);
        }

        public void DeleteCorporation(Corporation group)
        {
            context.corporations.Remove(group);
        }
        public void UpdateCorporation(Corporation newGroup)
        {
            var old = GetCorporation(newGroup.Id);
            if(old != null)
            {
                old.Name = newGroup.Name;
                old.Description = newGroup.Description;
                old.Image = newGroup.Image;
                context.SaveChanges();
            }
        }

        public void AddCompany(Company company)
        {
            context.companies.Add(company);
        }

        public void DeleteCompany(Company company)
        {
            context.companies.Remove(company);
        }

        public Company GetCompany(int id)
        {
            return context.companies.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Company> GetCompanies()
        {
            return context.companies;
        }

        public void UpdateCompany(Company newCompany)
        {
            var old = GetCompany(newCompany.Id);
            if(old != null)
            {
                old.Name = newCompany.Name;
                old.Description = newCompany.Description;
                old.GroupId = newCompany.GroupId;
                old.Image = newCompany.Image;
                old.Sector = newCompany.Sector;
                context.SaveChanges();
            }
        }
    }
}
