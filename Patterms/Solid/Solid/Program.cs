using Solid;
//
Computer computer = new Computer("Mac", 2000);
// SaveComputer saver = new SaveComputer();
// saver.SaveToFile("out.dat", computer);
ISaveComputer save = new SaveComputerToFile();
save.Save("data.txt", computer);

// Дочерный класс должен обеспичивать тот-же функ, что базовый класс и никак не менять - 3
// Дочерный класс должен рассширять тот функ, который базовом классе, но не меняить его
// static void Foo()
// {
//     Computer computer = new Computer("Sony Vaio", 10000);
//     Computer computer2 = new Computer("MacBook Air", 10000);
//     computer2.SetData("Sony");
// }
//
// Foo();

// Не надо создавать абстракртные, где много методов - 4
// Нужно создать спец-интерфейсы для каждого класса

// ILine line = new Line();
// line.DrawLine();
// ICircle circle = new Circle();
// circle.DrawCircle();
// IRect rect = new Rectangle();
// rect.DrawRect();
//
// ModelForm form = new ModelForm(1, 24, "Bahram");
// WebFramework framework = new WebFramework();
// framework.Save(form);