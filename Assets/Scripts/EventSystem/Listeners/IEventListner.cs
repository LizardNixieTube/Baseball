using UnityEngine;

public interface IEventListener<T>
{
    void OnEventRaised(T data);
}
