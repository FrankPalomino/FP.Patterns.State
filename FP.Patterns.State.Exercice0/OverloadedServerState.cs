namespace FP.Patterns.State
{
    public class OverloadedServerState : ServerState
    {
        public override void Response()
        {
            Task.Delay(500).Wait();
            Console.WriteLine("Available 200");
        }
    }
}
