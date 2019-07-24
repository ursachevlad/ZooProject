using System;

public sealed class Singleton
{
    private static Singleton animalslist = null;
    private static readonly object padlock = new object();

    Singleton()
    {
    }

    public static Singleton AnimalsList
    {
        get
        {
            lock (padlock)
            {
                if (animalslist == null)
                {
                    animalslist = new Singleton();
                }
                return animalslist;
            }
        }
    }
}
