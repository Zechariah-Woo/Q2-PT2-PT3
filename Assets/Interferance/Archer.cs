using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : PlayerStats
{
    private void Start()
    {
        Attack();
        Run();
    }

    protected override void Run()
    {
        Debug.Log("Archer Runs");
    }

    protected override void Attack()
    {
        Debug.Log("Archer Attacks Goblin");
    }
}
