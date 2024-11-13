using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStats : MonoBehaviour
{

    [SerializeField] protected int health;
    [SerializeField] protected float speed;
    [SerializeField] protected int mana;
    [SerializeField] protected int attack;
    [SerializeField] protected int defense;
    [SerializeField] protected float luck;

    protected abstract void Attack();

    protected abstract void Run();
}
