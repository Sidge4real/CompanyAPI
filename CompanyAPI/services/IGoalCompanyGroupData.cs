using CompanyAPI.entities;

namespace CompanyAPI.services
{
    public interface IGoalCompanyGroupData
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompany(int id);
        void AddCompany(Company company);
        void DeleteCompany(Company company);
        void UpdateCompany(Company company);
        IEnumerable<CompanyGroup> GetCorporations();
        CompanyGroup GetCorporation(int id);
        void AddCorporation(CompanyGroup group);
        void DeleteCorporation(CompanyGroup group);
        void UpdateCorporation(CompanyGroup group);
        IEnumerable<Goal> GetGoals();
        Goal GetGoal(int id);
        void AddGoal(Goal goal);
        void DeleteGoal(Goal goal);
        void UpdateGoal(Goal goal);
    }
}
