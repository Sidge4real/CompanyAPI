using CompanyAPI.entities;

namespace CompanyAPI.services
{
    public interface IGoalData
    {
        IEnumerable<Goal> GetAll();
        Goal Get(int id);
        void Add(Goal goal);
    }
    public class GoalData : IGoalData
    {
        private static List<Goal> goals;
        static GoalData()
        {
            goals= new List<Goal>() 
            {
                new Goal() {Id=1, Description="lorem upsem", Name="mobile development", Image="worldofmobile.png", CompanyId=2},
                new Goal() {Id=2, Description="lorem upsem", Name="web development", Image="websites.png", CompanyId=4},
                new Goal() {Id=3, Description="lorem upsem", Name="data & software security", Image="servers.png", CompanyId=1}
            };
        }
        public Goal Get(int id)
        {
            var goal = goals.FirstOrDefault(a => a.Id == id);
            return goal;
        }

        public IEnumerable<Goal> GetAll()
        {
            return goals;
        }
        public void Add(Goal goal)
        {
            goal.Id = goals.Max(x => x.Id) + 1;
            goals.Add(goal);
        }
    }
}