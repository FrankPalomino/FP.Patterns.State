namespace FP.Patterns.State.Exercice3
{
    public class HasCoinState : IState
    {
        private readonly VendingMachine _vendingMachine;

        public HasCoinState(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }

        public void ChangeState(IState state)
        {
            _vendingMachine.ChangeState(state);
        }

        public void DispensingItem()
        {
            Console.WriteLine("Select an item please");
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
            ChangeState(new DispensingState(_vendingMachine));
            Console.WriteLine("Product selected");
        }
    }
}
