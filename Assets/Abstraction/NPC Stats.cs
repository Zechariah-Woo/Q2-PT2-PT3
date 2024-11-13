using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCStats : MonoBehaviour
{
    [SerializeField] protected int health;
    [SerializeField] protected int attack;
    [SerializeField] protected float speed;
    [SerializeField] protected int defense;
 

    protected abstract void Movement();

    protected abstract void Attack();

}
