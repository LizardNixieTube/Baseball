using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEvent<T>: ScriptableObject
{
    //List of event to invoke when the event is raise
    private readonly List<IEventListener<T>> m_EventListeners = new List<IEventListener<T>>();


    public void Raise(T data)
    {
        for(int i = m_EventListeners.Count - 1; i >= 0; --i)
        {
            m_EventListeners[i].OnEventRaised(data);
        }
    }

    public void AddListner(IEventListener<T> listener) 
    {
        if(!m_EventListeners.Contains(listener)) m_EventListeners.Add(listener);
    }

    public void RemoveListener(IEventListener<T> listener)
    {
        if (m_EventListeners.Contains(listener)) m_EventListeners.Remove(listener);
    }
}
