namespace FP.Patterns.State.Exercice1
{
    public class Machine
    {
        private MachineState _state;
        private List<Drink> _drinks;
        private int _money;

        public Machine()
        {
            _state = new NoMoneyState();
            _drinks = new List<Drink>()
            {
                new Drink() { Name = "Coke" },
            };
        }

        public void SetState(MachineState state)
        {
            _state = state;
        }

        public void Response()
        {
            _state.Response();
        }

        public void AddMoney(int money)
        {
            _money += money;
            SetState(new WithMoneyState());
        }

        public void SelectDrink(Drink drink)
        {
            if (_money >= 0)
            {
                SetState(new DrinkSelectedState());
            }
            else
            {
                SetState(new NoMoneyState());
            }
        }

        public void GiveDrink()
        {
            if (_drinks.Count > 0)
            {
                SetState(new DrinkSelledState());
                _drinks.RemoveAt(0);
            }
            else
            {
                SetState(new NoDrinkState());
            }
        }
    }
}
