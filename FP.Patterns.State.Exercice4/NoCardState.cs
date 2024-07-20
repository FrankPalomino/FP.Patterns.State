namespace FP.Patterns.State.Exercice4
{
    public class NoCardState : IState
    {
        private readonly AtmMachine _atm;

        public NoCardState(AtmMachine atm)
        {
            _atm = atm;
        }

        public void EjectingCard()
        {
            Console.WriteLine($"No Card is inserted. Please insert a card!");
        }

        public void EnteringPin()
        {
            Console.WriteLine($"No Card is inserted. Please insert a card!");
        }

        public void InsertingCard()
        {
            Console.WriteLine($"Card is inside.\nEnter your PIN please.");
            _atm.SetState(new CardInsertedState(_atm));
        }

        public void RequestingCash()
        {
            Console.WriteLine($"No Card is inserted. Please insert a card!");
        }
    }
}
