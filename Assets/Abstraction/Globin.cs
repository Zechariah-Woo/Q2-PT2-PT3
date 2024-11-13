using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : NPCStats


{
    [SerializeField] private Mercenary mercenary;

    private void Start()
    {
       
        Movement();
        Attack();
        Damage(15);
    }

    protected override void Movement()
    {
        Debug.Log("Goblin moves");
    }
    
    protected override void Attack()
    {
        Debug.Log("Goblin Attacks player");
    }

    public void Damage (int Damage)
    {
        health -= Damage;
        Debug.Log("Goblin health: " + health);
    }
}
