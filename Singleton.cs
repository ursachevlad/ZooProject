using System;

public sealed class AnimalsList
{
    private static AnimalsList instance = null;
    private string Name {get; set;}
    private string Category { get; set; }
    private static readonly object syncLock = new object();

    private Singleton()
    {
        Console.WriteLine("Singleton Intance");
        Name = "BlackBeauty";
        Category = "Horse";
    }

    public static AnimalsList Instance
    {
        get
        {
            lock (syncLock)
            {
                if (instance == null)
                {
                    instance = new AnimalsList();
                }
                return instance;
            }
        }
    }

    public void Show()
    {
        Console.WriteLine("Animals list as a database");
    }
}
