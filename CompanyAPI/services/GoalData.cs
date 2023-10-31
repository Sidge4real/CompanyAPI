using CompanyAPI.entities;

namespace CompanyAPI.services
{
    public interface IGoalData
    {
        IEnumerable<Goal> GetAll();
        Goal Get(int id);
    }
    public class GoalData : IGoalData
    {
        private static List<Goal> goals;
        public Goal Get(int id)
        {
            var goal = goals.FirstOrDefault(a => a.Id == id);
            return goal;
        }

        public IEnumerable<Goal> GetAll()
        {
            return goals;
        }
    }
}