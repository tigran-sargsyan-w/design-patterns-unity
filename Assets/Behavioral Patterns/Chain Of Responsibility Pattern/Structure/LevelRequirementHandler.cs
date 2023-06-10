namespace ChainOfResponsibilityPattern
{
    public class LevelRequirementHandler : AccessHandler
    {
        protected override bool CheckAccess()
        {
            // Checking for the required level
            // Return true if condition is met, otherwise false
            return true;
        }
    }
}