using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : State
{
    public Chase chase;
    public bool isPlayerDetected;

    [SerializeField] private float patrolSpeed;

    [SerializeField] public int pointIndex;

    [SerializeField] private Transform[] points;

    [SerializeField] public Rigidbody2D enemyRb;



    public void EnemyPatrol()
    {
        if(!isPlayerDetected)
        if (Vector2.Distance(transform.position, points[pointIndex].position) < 0.01f)
        {
            pointIndex += 1;

            if (pointIndex == points.Length)
            {
                pointIndex = 0;
            }
        }

        transform.position = Vector2.Lerp(transform.position, points[pointIndex].position, patrolSpeed * Time.deltaTime);
    }

    public override State RunState()
    {
        if (isPlayerDetected)
        {
            return chase;
        }

        return this;
    }
}
