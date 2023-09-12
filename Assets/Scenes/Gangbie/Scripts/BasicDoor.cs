using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDoor : Door
{
    protected override void Awake()
    {
        base.Awake();
    }

    public override void Open()
    {
    }

    public void Unlock(int step)
    {
        if (step == 1)
        {
            Debug.Log("Basic Door Unlocked");
            SetHingeAngle(openMinAngle, openMaxAngle);
        }
    }
}
