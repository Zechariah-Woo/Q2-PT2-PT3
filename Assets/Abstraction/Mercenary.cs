using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercenary : NPCStats
{
    private void Start()
    {
        Movement();
        Attack();
            
    }
    protected override void Attack()
    {
        Debug.Log("Mercenary hits Archer");
    }

    protected override void Movement()
    {
        Debug.Log("Mercenary walks");
    }
}
