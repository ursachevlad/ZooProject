using System;

public sealed class AnimalsList
{
    private static AnimalsList instance = null;
    private static readonly object padlock = new object();

    AnimalsList()
    {
    }

    public static AnimalsList Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new AnimalsList();
                }
                return instance;
            }
        }
    }
}
