﻿namespace Singleton;

/// <summary>
/// Singleton
/// </summary>
public class Logger
{
    private static Logger? _instance;

    private static readonly Lazy<Logger> _lazyLogger =
        new Lazy<Logger>(() => new Logger());

    /// <summary>
    /// Instance
    /// </summary>
    public static Logger? Instance
    {
        get
        {
            //if (_instance == null)
            //{
            //    _instance = new Logger();
            //}
            //return _instance;

            return _lazyLogger.Value;
        }
    }

    protected Logger()
    {
        Console.WriteLine("Ctor invoked!");
    }

    /// <summary>
    /// SingletonOperation
    /// </summary> 
    public void Log(string message)
    {
        Console.WriteLine($"Message to log: {message}");
    }


}
