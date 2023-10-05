using FP.Patterns.State.Exercice1;

Machine machine = new Machine();

machine.Response();

machine.AddMoney(10);

machine.Response();

machine.SelectDrink(new Drink());

machine.Response();

machine.GiveDrink();

machine.Response();

machine.GiveDrink();

machine.Response();