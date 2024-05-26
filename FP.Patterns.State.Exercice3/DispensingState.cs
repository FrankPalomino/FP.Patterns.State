namespace FP.Patterns.State.Exercice3
{
    public class DispensingState : IState
    {
        private readonly VendingMachine _vendingMachine;

        public DispensingState(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }

        public void ChangeState(IState state)
        {
            _vendingMachine.ChangeState(state);
        }

        public void DispensingItem()
        {
            _vendingMachine.RemoveStock();
            Console.WriteLine("Item dispensed, process finished");
        }

        public void EjectingCoin()
        {
            _vendingMachine.ChangeState(new NoCoinState(_vendingMachine));
            Console.WriteLine("Process canceling, coin ejected");
        }

        public void InsertingCoin()
        {
            Console.WriteLine("There are enough money");
        }

        public void SelectiongItem()
        {
            Console.WriteLine("Item changed");
        }
    }
}
