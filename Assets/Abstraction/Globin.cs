using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : NPCStats


{
    [SerializeField] private Archer archer;

    private void Start()
    {
       
        Movement();
        TookDamage();
        Damage(30);
    }

    protected override void Movement()
    {
        Debug.Log("Goblin moves");
    }
    
    protected override void TookDamage()
    {
        Debug.Log("Goblin got punched");
    }

    public void Damage (int Damage)
    {

        Debug.Log("Goblin Health: " + health);
        health -= Damage;
        Debug.Log("Goblin new health: " + health);
    }
}
