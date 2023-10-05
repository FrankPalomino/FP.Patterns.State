namespace FP.Patterns.State
{
    public class CrashServerState : ServerState
    {
        public override void Response()
        {
            Console.WriteLine("Crash 503");
        }
    }
}
