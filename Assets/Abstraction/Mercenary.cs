using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercenary : NPCStats
{
    private void Start()
    {
        Movement();
        TookDamage();
    }
    protected override void TookDamage()
    {
        Debug.Log("Mercenary hits Archer");
    }

    protected override void Movement()
    {
        Debug.Log("Mercenary walks");
    }
}
