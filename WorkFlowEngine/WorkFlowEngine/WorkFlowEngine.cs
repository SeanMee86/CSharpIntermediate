namespace WorkFlowEngine
{
    class WorkFlowEngine
    {
        public static void Run(WorkFlow workFlow)
        {
            foreach (var activity in workFlow.GetActivities())
                activity.Execute();
        }
    }
}
