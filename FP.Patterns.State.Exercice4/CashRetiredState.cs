namespace FP.Patterns.State.Exercice4
{
    public class CashRetiredState : IState
    {
        private readonly AtmMachine _atm;

        public CashRetiredState(AtmMachine atm)
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
            Console.WriteLine($"The PIN is already validated!");
        }

        public void InsertingCard()
        {
            Console.WriteLine($"One card is already inside, don't inserting one more");
        }

        public void RequestingCash()
        {
            Console.WriteLine($"Please enter the new amount that you want to withdraw");
            _atm.SetState(new CashRetiredState(_atm));
        }
    }
}
