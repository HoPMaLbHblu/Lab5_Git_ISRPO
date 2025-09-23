//void SayHello()
//{
//    Console.WriteLine("Hello"); // void SayHello() => Console.WriteLine("Hello");
//}
//SayHello();
//void Game()
//{
//    string myGame = "GTA V";
//    Console.WriteLine(myGame);
//}
//Game();

//Console.WriteLine("Введите своё имя: ");
//string? name = Console.ReadLine();
//Console.WriteLine("Введите ваш язык (русский,немецкий,английский): ");
//string lang = Console.ReadLine()!.ToLower();
//void SayHelloRU() => Console.WriteLine($"Привет {name}!");
//void SayHelloEN() => Console.WriteLine($"Hello {name}!");
//void SayHelloDE() => Console.WriteLine($"Gutten Tag {name}!");

//switch (lang)
//{
//    case "английский": SayHelloEN(); break;
//    case "русский": SayHelloRU(); break;
//    case "немецкий": SayHelloDE(); break;
//    default: Console.WriteLine("Язык не найден!"); break;
//}
//void Print(string message)
//{
//    Console.WriteLine(message);
//}
//Print("Hello");
//Console.WriteLine("Как тебя зовут?");
//Console.WriteLine("Введите своё имя: ");
//string? name = Console.ReadLine();
//Print($"Твоё имя: {name}");
//void Sum(int y, int x)
//{
//    int res = x + y;
//    Console.WriteLine($"{x} + {y} = {res}");
//}
//Sum(10, 20);
//Console.WriteLine("Введите переменную x: ");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите переменную y: ");
//int y = int.Parse(Console.ReadLine());
//Sum(x, y);
//void PrintPerson(string personName, int age)
//{
//    Console.WriteLine($"Имя: {personName}, возраст: {age}");
//}
//PrintPerson("Dan", 18);
//void Person(string name, int age = 18, string vuz = "ВФ ВолГУ")
//{
//    Console.WriteLine($"Имя: {name}\nВозраст: {age}\nВуз: {vuz}");
//}
//Person("Dan");
//Person("Dan", 25);
//Person("Dan", 30, "МГУ");
//string GetMsg()
//{
//    return "Hello";
//}
//Console.WriteLine(GetMsg());
//int Sum(int a, int b)
//{
//    return a + b;
//}
//Console.WriteLine(Sum(10,20)); 
//int num = int.Parse(Console.ReadLine());
//void CheckValue(int  num)
//{
//    if (num < 0)
//    {
//        Console.WriteLine("Отрицательное число");
//        return;
//    }
//    Console.WriteLine("Положительное число");
//}
//CheckValue(num);
//string GetMsg()
//{
//    return "Hello";
//}
//string msg = GetMsg();
//Console.WriteLine(msg);
//void PrintMsg(string msg)
//{
//    Console.WriteLine(msg);
//}
//PrintMsg(GetMsg());
//void PrintPerson(string name, int age)
//{
//    if (age > 120 || age < 1)
//    {
//        Console.WriteLine("Недопустимый возраст");
//        return;
//    }
//    Console.WriteLine($"Имя: {name} Возраст: {age}");

//}
//PrintPerson("Alex", 32);
//PrintPerson("dunkan", 1234);
//Random random = new Random();
//int num = random.Next(0, 100);
//Console.WriteLine($"Случайное число: {num}");
//double randomDouble  = random.NextDouble();
//Console.WriteLine($"Случайное число: {randomDouble}");

//void ShowWelcomeMsg() => Console.WriteLine("Добро пожаловать в консольный прогноз погоды!");
//void ShowGoodbyeMsg() => Console.WriteLine("Спасибо за использование нашего прогноза! Хорошего дня!");
//string GetWeather()
//{
//    string[] weathers = ["Солнечно", "Облачно", "Дождь", "Снег", "Гроза"];
//    Random random = new Random();
//    int index = random.Next(weathers.Length);
//    return weathers[index];
//}
//ShowWelcomeMsg();
//string currentWeather = GetWeather();
//Console.WriteLine($"Погода на сегодня: {currentWeather}");
//ShowGoodbyeMsg();
int Factorial(int n)
{
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}
int fact1 = Factorial(1);
int fact2 = Factorial(4);
int fact3 = Factorial(25);
Console.WriteLine($"Факториал числа 1: {fact1}\nФакториал числа 4: {fact2}\nФакториал числа 25: {fact3}");

