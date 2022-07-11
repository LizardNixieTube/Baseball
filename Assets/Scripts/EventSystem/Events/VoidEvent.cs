using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Void Event", menuName ="Event/void")]
public class VoidEvent : BaseEvent<Void>
{
    public void Raise()
    {
        Raise(new Void());
    }
}
