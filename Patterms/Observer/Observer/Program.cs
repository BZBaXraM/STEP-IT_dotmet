Store cola = new(false, "Cola Zero", 1.20);

var customer = new CustomerObserver("Аида Аласкарова", cola);
Console.WriteLine();
var customer2 = new CustomerObserver("Чингиз Ахмедов", cola);
Console.WriteLine();
var customer3 = new CustomerObserver("Надир Заманов", cola);
Console.WriteLine();

Thread.Sleep(2000);
cola.IsAvailable = true;
cola.RemoveSubscriber(customer);