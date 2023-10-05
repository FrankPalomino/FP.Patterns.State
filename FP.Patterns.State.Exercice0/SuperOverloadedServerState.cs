namespace FP.Patterns.State
{
    public class SuperOverloadedServerState : ServerState
    {
        public override void Response()
        {
            Task.Delay(1000).Wait();
            Console.WriteLine("Available 200");
        }
    }
}
