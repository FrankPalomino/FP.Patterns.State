namespace FP.Patterns.State.Exercice4
{
    public class AtmMachine
    {
        private IState _state;

        public AtmMachine()
        {
            _state = new NoCardState(this);
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void EjectingCard()
        {
            _state.EjectingCard();
        }

        public void EnteringPin()
        {
            _state.EnteringPin();
        }

        public void InsertingCard()
        {
            _state.InsertingCard();
        }

        public void RequestingCash()
        {
            _state.RequestingCash();
        }
    }
}
