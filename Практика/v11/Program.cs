using System;

abstract class Mammal
{
    protected string? name;
    protected int age;
    protected double weight;
    protected abstract string Description { get; set; }
    protected Mammal(string? name, int age, double weight)
    {
        this.name = name;
        this.age = age;
        this.weight = weight;
    }
    public abstract void PrintInformation();
}
abstract class Animal : Mammal
{
    protected Animal(string? name, int age, double weight) :
    base(name, age, weight)
    { }
    protected abstract void Voice();
}
class People : Mammal
{
    protected override string Description { get; set; } = "Человек - общественное существо, " +
    "обладающее разумом и сознанием";
    private double height;
    public People(string? name, int age, double weight, double height) :
    base(name, age, weight)
    {
        this.height = height;
    }
    public override void PrintInformation()
    {
        Console.WriteLine("Информация о человеке");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Вес: {weight} кг");
        Console.WriteLine($"Рост: {height} см");
        Console.WriteLine($"Описание:");
        Console.WriteLine(Description);
    }
}
class Dog : Animal
{
    protected override string Description { get; set; } = "Собака " +
    "— домашнее животное, одно из наиболее популярных животных-компаньонов.";
    public Dog(string? name, int age, double weight) :
    base(name, age, weight)
    { }
    protected override void Voice()
    {
        Console.WriteLine("Гав!");
    }
    public override void PrintInformation()
    {
        Console.WriteLine("Информация о собаке");
        Console.WriteLine($"Кличка: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Вес: {weight} кг");
        Console.Write("Голос: ");
        Voice();
        Console.WriteLine($"Описание:");
        Console.WriteLine(Description);
    }
}
class Cow : Animal
{
    protected override string Description { get; set; } = "Корова - самка крупного " +
    "рогатого скота.";
    public Cow(string? name, int age, double weight) : base(name, age, weight) { }
    protected override void Voice()
    {
        Console.WriteLine("МУУУ!");
    }
    public override void PrintInformation()
    {
        Console.WriteLine("Информация о корове");
        Console.WriteLine($"Кличка: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Вес: {weight}");
        Console.Write("Голос: ");
        Voice();
        Console.WriteLine($"Описание:");
        Console.WriteLine(Description);
    }
}
class Program
{
    static void Print(Mammal[] mammals, ref int i)
    {
        for (int j = 0; j < i; j++)
        {
            Console.WriteLine("\n**********************************************************************");
            Console.WriteLine($" Информация о млекопитающем №{j + 1} ");
            mammals[j].PrintInformation();
            Console.WriteLine("**********************************************************************");
        }
    }
    static void Append(Mammal[] mammals, int n, ref int i)
    {
        int command;
        do
        {
            Console.Clear();
            Console.WriteLine("\n**********************************************************************");
            Console.WriteLine(" Добавить информацию о млекопитающем ");
            Console.WriteLine("1. Человек");
            Console.WriteLine("2. Собака");
            Console.WriteLine("3. Корова");
            Console.WriteLine("0. Назад");
            Console.WriteLine("**********************************************************************");
            Console.Write("\nВыберите млекопитающее: ");
            command = Convert.ToInt32(Console.ReadLine());
            switch (command)
            {
                case 1:
                    string? name;
                    int age;
                    double weight, height;
                    Console.Write("Введите имя: ");
                    name = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите возраст: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите вес: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите рост: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    mammals[i] = new People(name, age, weight, height);
                    i++;
                    break;
                case 2:
                    Console.Write("Введите кличку: ");
                    name = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите возраст: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите вес: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                    mammals[i] = new Dog(name, age, weight);
                    i++;
                    break;
                case 3:
                    Console.Write("Введите кличку: ");
                    name = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите возраст: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите вес: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                    mammals[i] = new Cow(name, age, weight);
                    i++;
                    break;
                case 0:
                    Console.WriteLine("Назад!");
                    break;
                default:
                    Console.WriteLine("Неверная команда! Нажмите для продолжения...");
                    Console.ReadKey();
                    break;
            }
        } while ((command != 0) && (i < n));
    }
    static void Main()
    {
        int n, command;
        int i = 0;
        Console.Write("Введите количество млекопитающих: ");
        n = Convert.ToInt32(Console.ReadLine());
        Mammal[] mammals = new Mammal[n];
        do
        {
            Console.Clear();
            Console.WriteLine("\n**********************************************************************");
            Console.WriteLine(" Меню ");
            Console.WriteLine("1. Добавить информацию о млекопитающем");
            Console.WriteLine("2. Вывести информацию о млекопитающих");
            Console.WriteLine("0. Выход");
            Console.WriteLine("**********************************************************************");
            Console.Write("\nВведите команду: ");
            command = Convert.ToInt32(Console.ReadLine());
            switch (command)
            {
                case 1:
                    if (i < n)
                    {
                        Append(mammals, n, ref i);
                    }
                    else
                    {
                        Console.WriteLine("Достигнут лимит млекопитающих! Нажмите для продолжения...");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    Console.Clear();
                    Print(mammals, ref i);
                    Console.WriteLine("Нажмите для продолжения...");
                    Console.ReadKey();
                    break;
                case 0:
                    Console.WriteLine("Выход из программы!");
                    break;
                default:
                    Console.WriteLine("Неверная команда! Нажмите для продолжения...");
                    Console.ReadKey();
                    break;
            }
        } while (command != 0);
    }
}
