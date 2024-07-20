namespace FP.Patterns.State.Exercice4
{
    public interface IState
    {
        void InsertingCard();
        void EjectingCard();
        void EnteringPin();
        void RequestingCash();
    }
}
