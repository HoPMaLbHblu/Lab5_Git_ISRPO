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
//int Factorial(int n)
//{
//    if (n == 1) return 1;
//    return n * Factorial(n - 1);
//}
//int fact1 = Factorial(1);
//int fact2 = Factorial(4);
//int fact3 = Factorial(25);
//Console.WriteLine($"Факториал числа 1: {fact1}\nФакториал числа 4: {fact2}\nФакториал числа 25: {fact3}");
//void Compare(int[] numbers1, int[] numbers2)
//{
//    int numbers1Sum = 0;
//    int numbers2Sum = 0;
//    foreach (int number in numbers1) numbers1Sum += number;
//    foreach (int number in numbers2) numbers2Sum += number;
//    if (numbers1Sum > numbers2Sum) Console.WriteLine("сумма чисел из массива numbers1 больше");
//    else if (numbers1Sum < numbers2Sum) Console.WriteLine("сумма чисел из массива numbers2 больше");
//    else Console.WriteLine("суммы чисел обоих массивов равны");
//    int Sum(int[] numbers)
//    {
//        int res = 0;
//        foreach(int number in numbers) res += number;
//        return res;
//    }
//}
//int[] numbers1 = [1, 2, 3];
//int[] numbers2 = [4, 5, 6];
//Compare(numbers1, numbers2);
//int Sum(int[] numbers)
//{
//    int limit = 0;
//    int res = 0;
//    foreach (int number in numbers)
//    {
//        if (IsPassed(number, limit)) res += number;
//    }
//    return res;
//    static bool IsPassed(int number, int lim)
//    {
//        return number > lim;
//    }
//}
//int[] numbers1 = [1, 2, 3];
//int[] numbers2 = [4, 5, 6];
//Console.WriteLine(Sum(numbers1));2
//Console.WriteLine(Sum(numbers2)); 

//задание 1
//тест:
//1. ничего
//2. void ShowWelcomeMessage()
//3.Метод вызовет ошибку компиляции / Метод выполнится с значениями по умолчанию
//4.void PrintNumber(int number)
//5. ничего, там все с ошибками
//задание 2
//string GreetUser(string name)
//{
//    Console.WriteLine($"Привет, {name}! Добро пожаловать в программу!");
//    return name;
//}
//GreetUser("dan");
//задание 3
//int AddNumbers(int a , int b)
//{
//    return a + b;
//}
//Console.WriteLine(AddNumbers(5, 12)); 
//задание 4
//bool isEven(int a)
//{
//    return a % 2 == 0;
//}
//Console.WriteLine(isEven(6)); 
//задание 5
//int FindMax(int[] arr)
//{
//    int max = arr[0];
//    for(int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i] > max) { max = arr[i];}
//    }
//    return max;
//}
//Console.WriteLine(FindMax([1,52,13,24,35]));
//задание 6
//double ConvertCelsiusToFahrenheit(int C)
//{
//    return C * 9 / 5 + 32;

//}
//Console.WriteLine(ConvertCelsiusToFahrenheit(5)); 
//задание 7
//int CountVowels(string str)
//{
//    string vowels = "aeiou";
//    int count = 0;
//    foreach (char ch in str)
//    {
//        if (vowels.Contains(ch)) count++;
//    }
//    return count;
//}
//Console.WriteLine(CountVowels("afbfdgdfgrtqreofsa")); 
//задание 8

//string GeneratePassword(int lenght)
//{
//    string chars = "abcdefghiklmnoprstqstuvwxyzABCDEFGHIKLMNOPRSTUVWXYZ1234567890";
//    Random rand = new Random();
//    char[] pass = new char[lenght];
//    for(int i = 0; i < lenght; i++)
//    {
//        pass[i] = chars[rand.Next(chars.Length)];
//    }
//    return new string(pass);
//}
//Console.WriteLine($"Password: {GeneratePassword(10)}"); 
//задание 9
//bool IsPalindrome(string str)
//{
//    string reversed = new string(str.Reverse().ToArray());
//    return str == reversed;
//}
//Console.WriteLine(IsPalindrome("шалаш"));
//задание 10
//int[] ReverseArray(int[] arr)
//{
//    int[] reversed = new int[arr.Length];
//    for(int i  = 0; i < arr.Length; i++)
//    {
//        reversed[i] = arr[arr.Length - 1 - i];
//    }

//    return reversed;
//}
//int[] reversed = ReverseArray(new int[] { 1, 2, 3, 4, 5 });
//Console.WriteLine(string.Join(',',reversed));
//задание 11
//int AddNums(int a = 2, int b = 3)
//{
//    return a + b;
//}
//int SubNums(int a = 2, int b = 3)
//{
//    return a - b;
//}
//int MultiNums(int a = 2, int b = 3)
//{
//    return a * b;
//}
//int DivNums(int a = 2, int b = 3)
//{
//    return a / b;
//}
//void Calc()
//{
//    Console.WriteLine("Выберите операцию:\n1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление\n");
//    int pick = int.Parse(Console.ReadLine());
//    switch(pick)
//    {
//        case 1: Console.WriteLine($"Результат сложения 2 + 3 = {AddNums()}"); break;
//        case 2: Console.WriteLine($"Результат вычитания 2 - 3 = {SubNums()}"); break;
//        case 3: Console.WriteLine($"Результат умножения 2 * 3 = {MultiNums()}"); break;
//        case 4: Console.WriteLine($"Результат деления 2 / 3 = {DivNums()}"); break;
//    }
//}
//Calc();
//задание 12
//bool isPrime(int num)
//{
//    if (num <= 1) return false;
//    for (int i = 2; i < num; i++)
//    {
//        if (num % i == 0) { return false; }
//    }
//    return true;
//}
//void PrimePrimesUpTo(int n)
//{
//    for(int i = 0; i < n; i++)
//    {
//        if (isPrime(i))
//        {
//            Console.Write($" {i}");
//        }
//    }
//}
//PrimePrimesUpTo(17);