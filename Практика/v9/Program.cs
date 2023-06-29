using System;

class Person
{
    public virtual void ReactToNewPerson()
    {
        Console.WriteLine("Hmm, a new person.");
    }
}

class Girl : Person
{
    public override void ReactToNewPerson()
    {
        Console.WriteLine("Oh, a new person! Maybe I can make a new friend.");
    }
}

class YoungMan : Person
{
    public override void ReactToNewPerson()
    {
        Console.WriteLine("Another person? Meh, I'm not in the mood for small talk.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[3];
        people[0] = new Person();
        people[1] = new Girl();
        people[2] = new YoungMan();

        foreach (Person p in people)
        {
            p.ReactToNewPerson();
        }
    }
}
