using System.Collections.Generic;

namespace WorkFlowEngine
{
    class WorkFlow : IWorkFlow
    {
        private readonly List<IActivity> activites;

        public WorkFlow()
        {
            this.activites = new List<IActivity>();
        }
        public void AddActivity(IActivity activity)
        {
            this.activites.Add(activity);
        }

        public void RemoveActivity(IActivity activity)
        {
            this.activites.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return this.activites;
        }
    }
}
