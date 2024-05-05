using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : State
{
    public Chase chase;
    public bool isPlayerDetected;

    public override State RunState()
    {
        if (isPlayerDetected)
        {
            return chase;
        }

        return this;
    }
}
