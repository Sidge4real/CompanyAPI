using CompanyAPI.contexts;
using CompanyAPI.entities;
using Microsoft.EntityFrameworkCore;

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

                context.SaveChanges();
            }
        }
        public void AddGoalToCompany(Company company, Goal goal)
        {
            if (company.Goals == null)
            {
                company.Goals = new List<Goal>();
            }
            company.Goals.Add(goal);

            context.SaveChanges();
        }
        public void DeleteGoalFromCompany(Company company, Goal goal)
        {
            if (company.Goals != null)
            {
                company.Goals.Remove(goal);

                context.SaveChanges();
            }
        }



        public Corporation GetCorporation(int id)
        {
            return context.corporations.Include(c => c.Companies).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Corporation> GetCorporations()
        {
            return context.corporations.Include(c => c.Companies); // include relation entitity
        }
        public void AddCorporation(Corporation group)
        {
            context.corporations.Add(group);
            context.SaveChanges();
        }

        public void DeleteCorporation(Corporation group)
        {
            context.corporations.Remove(group);
            context.SaveChanges();
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

            context.SaveChanges();
        }


        public void DeleteCompany(Company company)
        {
            context.companies.Remove(company);
            context.SaveChanges();
        }

        public Company GetCompany(int id)
        {
            return context.companies.Include(g => g.Goals).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Company> GetCompanies()
        {
            return context.companies.Include(g => g.Goals);
        }

        public void UpdateCompany(Company newCompany)
        {
            var old = GetCompany(newCompany.Id);
            if(old != null)
            {
                old.Name = newCompany.Name;
                old.Description = newCompany.Description;
                old.Image = newCompany.Image;
                old.Sector = newCompany.Sector;
                context.SaveChanges();
            }
        }
        public void AddCompanyToCorporation(Corporation corporation, Company company)
        {
            if (corporation.Companies == null)
            {
                corporation.Companies = new List<Company>();
            }
            corporation.Companies.Add(company);
            context.SaveChanges();
        }
        public void DeleteCompanyFromCorporation(Corporation corporation, Company company)
        {
            if (corporation.Companies != null)
            {
                corporation.Companies.Remove(company);

                context.SaveChanges();
            }
        }

    }
}
