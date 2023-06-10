namespace ChainOfResponsibilityPattern
{
    public class TaskCompletionHandler : AccessHandler
    {
        protected override bool CheckAccess()
        {
            // Check if the tasks are completed
            // Return true if condition is met, otherwise false
            return true;
        }
    }
}