namespace ChainOfResponsibilityPattern
{
    public class ItemCheckHandler : AccessHandler
    {
        protected override bool CheckAccess()
        {
            // Checking for required items
            // Return true if condition is met, otherwise false
            return true;
        }
    }
}