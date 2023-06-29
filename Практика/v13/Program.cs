using System;
using System.Collections.Generic;
namespace AnimalSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LivingBeing> environment = new List<LivingBeing>();
            // Создаем окружающую среду с животными и травой
            environment.Add(new Fox(5));
            environment.Add(new Fox(3));
            environment.Add(new Rabbit());
            environment.Add(new Rabbit());
            environment.Add(new Grass());
            environment.Add(new Grass());
            environment.Add(new Grass());
            Simulate(environment);
        }
        static void Simulate(List<LivingBeing> environment)
        {
            bool foxesExist = false;
            bool rabbitsExist = false;
            foreach (var being in environment)
            {
                if (being is Fox)
                    foxesExist = true;
                else if (being is Rabbit)
                    rabbitsExist = true;
            }
            while (foxesExist && rabbitsExist)
            {
                List<LivingBeing> newEnvironment = new List<LivingBeing>();
                int foxCount = 0;
                int rabbitCount = 0;
                int grassCount = 0;
                foreach (var being in environment)
                {
                    if (being is Fox fox)
                    {
                        fox.Age++;
                        if (fox.Age <= 5)
                            foxCount++;

                        if (foxCount <= 5 && rabbitCount > 0)
                        {
                            // Лиса ест кролика
                            rabbitCount--;
                        }
                        else
                        {
                            // Лиса не может появиться или умирает от голода
                            continue;
                        }
                    }
                    else if (being is Rabbit)
                    {
                        rabbitCount++;
                        if (grassCount > 0)
                        {
                            // Кролик ест траву
                            grassCount--;
                        }
                        else
                        {
                            // Кролик умирает от голода
                            continue;
                        }
                    }
                    else if (being is Grass)
                    {
                        grassCount++;
                    }
                    newEnvironment.Add(being);
                }
                environment = newEnvironment;
                foxesExist = false;
                rabbitsExist = false;
                foreach (var being in environment)
                {
                    if (being is Fox)
                        foxesExist = true;
                    else if (being is Rabbit)
                        rabbitsExist = true;
                }
            }
            Console.WriteLine("Симуляция окончена.");
        }
    }
    abstract class LivingBeing
    {
        public int Age { get; set; }
    }
    class Fox : LivingBeing
    {
        public Fox(int age)
        {
            Age = age;
        }
    }
    class Rabbit : LivingBeing
    {
        // Пустое тело класса - ничего не добавляем
    }
    class Grass : LivingBeing
    {
        // Пустое тело класса - ничего не добавляем
    }
}
