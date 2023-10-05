namespace FP.Patterns.State.Exercice1
{
    public class DrinkSelectedState : MachineState
    {
        public override void Response()
        {
            Console.WriteLine("Drink selected");
        }
    }
}
