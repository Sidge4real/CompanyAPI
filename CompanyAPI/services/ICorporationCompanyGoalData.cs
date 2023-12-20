using CompanyAPI.entities;

namespace CompanyAPI.services
{
    public interface ICorporationCompanyGoalData
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompany(int id);
        void AddCompany(Company company);
        void DeleteCompany(Company company);
        void UpdateCompany(Company company);
        IEnumerable<Corporation> GetCorporations();
        Corporation GetCorporation(int id);
        void AddCorporation(Corporation group);
        void DeleteCorporation(Corporation group);
        void UpdateCorporation(Corporation group);
        IEnumerable<Goal> GetGoals();
        Goal GetGoal(int id);
        void AddGoal(Goal goal);
        void DeleteGoal(Goal goal);
        void UpdateGoal(Goal goal);
        void AddGoalToCompany(Company company, Goal goal);
        void AddCompanyToCorporation(Corporation corporation, Company company);
        void DeleteGoalFromCompany(Company company, Goal goal);
        void DeleteCompanyFromCorporation(Corporation corporation, Company company);
    }
}
