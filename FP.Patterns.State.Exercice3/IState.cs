namespace FP.Patterns.State.Exercice3
{
    public interface IState
    {
        void InsertingCoin();
        void EjectingCoin();
        void SelectiongItem();
        void DispensingItem();
        void ChangeState(IState state);
    }
}
