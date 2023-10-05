namespace FP.Patterns.State.Exercice1
{
    public class NoMoneyState : MachineState
    {
        public override void Response()
        {
            Console.WriteLine("No money");
        }
    }
}
