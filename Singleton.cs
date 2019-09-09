using System;

public sealed class AnimalsList
{
    private static AnimalsList animal = null;
    private static readonly object padlock = new object();

    AnimalsList()
    {
    }

    public static AnimalsList Animal
    {
        get
        {
            lock (padlock)
            {
                if (animalslist == null)
                {
                    animalslist = new AnimalsList();
                }
                return animalslist;
            }
        }
    }
}
