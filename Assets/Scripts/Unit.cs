using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [Header("Identification")] 
    public string entityName;
    [Header("HEALTH")] 
    public float health;
    public float maxHealth;
    public float defense;
    public bool invulnerable;
    public float speed;
    [SerializeField] protected Rigidbody2D rb;
    
    public virtual void TakeDamage(float damageTaken)
    {
        if (!invulnerable)
        {
            health -= damageTaken - defense;
            health = Mathf.Clamp(health, 0f, maxHealth);
            //onHitDamageNumber.Spawn(transform.position, damage);
            if (health <= 0)
            {
                OnKillEffects();
            }
        }
    }
    public virtual void Heal(float healing)
    {
        health += healing;
        health = Mathf.Clamp(health, 0f, maxHealth);
    }
    protected virtual void OnKillEffects()
    {
        Destroy(gameObject);
    }
}
