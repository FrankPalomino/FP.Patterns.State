namespace FP.Patterns.State.Exercice4
{
    public class CardInsertedState : IState
    {
        private readonly AtmMachine _atm;

        public CardInsertedState(AtmMachine atm)
        {
            _atm = atm;
        }

        public void EjectingCard()
        {
            Console.WriteLine($"Thanks for using ATM!\nCard is Ejecting...");
            _atm.SetState(new NoCardState(_atm));
        }

        public void EnteringPin()
        {
            Console.WriteLine($"Checking the PIN...");
            Console.WriteLine($"The PIN is correct");
            _atm.SetState(new HasPinState(_atm));

        }

        public void InsertingCard()
        {
            Console.WriteLine($"One card is already inside, don't inserting one more");
        }

        public void RequestingCash()
        {
            Console.WriteLine($"Please enter the PIN first!");
        }
    }
}
