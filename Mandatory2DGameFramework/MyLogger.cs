using System;
using System.Collections.Generic;
using System.Diagnostics;

public class MyLogger
{
    private static MyLogger _instance;
    private List<TraceListener> _listeners = new List<TraceListener>();

    private MyLogger() { }

    public static MyLogger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new MyLogger();
            }
            return _instance;
        }
    }

    public void AddListener(TraceListener listener)
    {
        _listeners.Add(listener);
    }

    public void RemoveListener(TraceListener listener)
    {
        _listeners.Remove(listener);
    }

    public void Log(string message)
    {
        foreach (var listener in _listeners)
        {
            listener.WriteLine(message);
        }
    }
}