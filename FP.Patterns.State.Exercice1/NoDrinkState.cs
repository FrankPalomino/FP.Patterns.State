namespace FP.Patterns.State.Exercice1
{
    public class NoDrinkState : MachineState
    {
        public override void Response()
        {
            Console.WriteLine("No drink");
        }
    }
}
