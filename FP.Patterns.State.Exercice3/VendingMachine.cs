namespace FP.Patterns.State.Exercice3
{
    public class VendingMachine
    {
        private IState _state;
        private int _stock;

        public VendingMachine()
        {
            _state = new NoCoinState(this);
            _stock = 1;
        }

        public void RemoveStock()
        {
            _stock--;
            if( _stock == 0)
            {
                ChangeState(new OutOfStockState(this));
            }
        }

        public void AddStock(int stock)
        {
            _stock += stock;
            ChangeState(new NoCoinState(this));
        }

        public void ChangeState(IState state)
        {
            _state = state;
        }

        public void DispensingItem()
        {
            _state.DispensingItem();
        }

        public void EjectingCoin()
        {
            _state.EjectingCoin();
        }

        public void InsertingCoin()
        {
            _state.InsertingCoin();
        }

        public void SelectiongItem()
        {
            _state.SelectiongItem();
        }
    }
}
