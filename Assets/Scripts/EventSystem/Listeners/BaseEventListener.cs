using UnityEngine;
using UnityEngine.Events;

public abstract class BaseEventListener<T, E, UER> : MonoBehaviour,
     IEventListener<T> where E : BaseEvent<T> where UER : UnityEvent<T>
{
    [SerializeField] private E m_GameEvent;
    public E GameEvent { get { return m_GameEvent; } set { m_GameEvent = value; } }

    [SerializeField] private UER m_UnityEventResponse;

    private void OnEnable()
    {
        if(m_GameEvent == null) { return; }

        GameEvent.AddListner(this);
    }

    private void OnDisable()
    {
       if(m_GameEvent == null) { return; }

        GameEvent.RemoveListener(this);
    }

    public void OnEventRaised(T data)
    {
        if (m_UnityEventResponse != null)
        {
            m_UnityEventResponse.Invoke(data);
        }
    }
}

