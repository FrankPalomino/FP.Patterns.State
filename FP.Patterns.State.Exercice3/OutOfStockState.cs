namespace FP.Patterns.State.Exercice3
{
    public class OutOfStockState : IState
    {
        private readonly VendingMachine _vendingMachine;

        public OutOfStockState(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }

        public void ChangeState(IState state)
        {
            _vendingMachine.ChangeState(state);
        }

        public void DispensingItem()
        {
            Console.WriteLine("Machine has no Items, Sorry!");
        }

        public void EjectingCoin()
        {
            Console.WriteLine("Machine has no Items, Sorry!");
        }

        public void InsertingCoin()
        {
            Console.WriteLine("Machine has no Items, Sorry!");
        }

        public void SelectiongItem()
        {
            Console.WriteLine("Machine has no items, Sorry!");
        }
    }
}
