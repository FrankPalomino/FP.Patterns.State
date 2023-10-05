namespace FP.Patterns.State
{
    public class AvailableServerState : ServerState
    {
        public override void Response()
        {
            Console.WriteLine("Available 200");
        }
    }
}
