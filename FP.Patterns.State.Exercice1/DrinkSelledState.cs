namespace FP.Patterns.State.Exercice1
{
    public class DrinkSelledState : MachineState
    {
        public override void Response()
        {
            Console.WriteLine("Drink selled");
        }
    }
}
