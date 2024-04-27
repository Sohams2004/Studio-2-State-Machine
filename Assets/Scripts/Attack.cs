using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : State
{
    public Patrol patrol;
    public bool isPatrolling;

    public override State RunState()
    {
        if(isPatrolling && patrol.isPlayerDetected is false)
        {
            return patrol;
        }
        return this;
    }
}
