using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : State
{
    public Attack attack;
    [SerializeField] bool isInAttackRange;

    public override State RunState()
    {
        if (isInAttackRange)
        {
            return attack;
        }

        return this;
    }
}
