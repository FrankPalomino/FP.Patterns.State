using FP.Patterns.State.Exercice3;

VendingMachine vendingMachine = new VendingMachine();

Console.WriteLine("--Try without coin");
vendingMachine.DispensingItem();
vendingMachine.EjectingCoin();
vendingMachine.SelectiongItem();

Console.WriteLine("\n--Insert a coin 1");
vendingMachine.InsertingCoin();
vendingMachine.InsertingCoin();


Console.WriteLine("\n--Cancel Operation");
vendingMachine.EjectingCoin();

Console.WriteLine("\n--Insert a coin 2");
vendingMachine.InsertingCoin();
vendingMachine.DispensingItem();

Console.WriteLine("\n--Select an item");
vendingMachine.SelectiongItem();
vendingMachine.InsertingCoin();

Console.WriteLine("\n--Cancel Operation");
vendingMachine.EjectingCoin();

Console.WriteLine("\n--Insert a coin 3");
vendingMachine.InsertingCoin();
vendingMachine.SelectiongItem();
vendingMachine.DispensingItem();

Console.WriteLine("\n--Insert a coin 4");
vendingMachine.InsertingCoin();
vendingMachine.SelectiongItem();
vendingMachine.DispensingItem();

Console.WriteLine("\n--Restocking");
vendingMachine.AddStock(1);

Console.WriteLine("\n--Insert a coin 5");
vendingMachine.InsertingCoin();
vendingMachine.SelectiongItem();
vendingMachine.DispensingItem();