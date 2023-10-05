namespace FP.Patterns.State.Exercice1
{
    public class WithMoneyState : MachineState
    {
        public override void Response()
        {
            Console.WriteLine("Available 200");
        }
    }
}
