using System;

class Ancestor
{
    protected string name;

    public virtual void Print()
    {
        Console.WriteLine("I am an ancestor.");
    }
}

class Child : Ancestor
{
    public Child(string name)
    {
        this.name = name;
    }

    public override void Print()
    {
        Console.WriteLine("I am a child named {0}.", name);
    }
}

class Grandchild : Child
{
    private string patronymic;

    public Grandchild(string name, string patronymic) : base(name)
    {
        this.patronymic = patronymic;
    }

    public void PrintFullname()
    {
        Console.WriteLine("My full name is {0} {1} {2}.", name, patronymic, "Surname");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ancestor[] people = new Ancestor[3];
        people[0] = new Ancestor();
        people[1] = new Child("Alice");
        people[2] = new Grandchild("Bob", "Charlie");

        foreach (Ancestor person in people)
        {
            person.Print();
            if (person is Grandchild)
            {
                ((Grandchild)person).PrintFullname();
            }
        }
    }
}
