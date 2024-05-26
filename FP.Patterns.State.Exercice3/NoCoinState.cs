namespace FP.Patterns.State.Exercice3
{
    public class NoCoinState : IState
    {
        private readonly VendingMachine _vendingMachine;

        public NoCoinState(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }

        public void ChangeState(IState state)
        {
            _vendingMachine.ChangeState(state);
        }

        public void DispensingItem()
        {
            Console.WriteLine("Insert coin please");
        }

        public void EjectingCoin()
        {
            Console.WriteLine("No coin to ejecting");
        }

        public void InsertingCoin()
        {
            ChangeState(new HasCoinState(_vendingMachine));
            Console.WriteLine("Coin inserted");
        }

        public void SelectiongItem()
        {
            Console.WriteLine("Insert coin please");
        }
    }
}
