using System;
using UnityEngine;

public class Spellcard : MonoBehaviour
{
    [Header("[IDENTIFICATION]")]
    public string spellID;
    public Sprite spellImage;
    public string spellDescription;
    [Header("[STATS]")]
    public float cooldown;
    public float currentCooldownTime;
    public bool onCooldown;
    public AudioClip spellSound;
    public float spellSoundVolume;
    [Header("[CACHE]")]
    public PlayerController thisPlayer;
    

    public virtual void CastSpell()
    {
        if (!onCooldown)
        {
            onCooldown = true;
            currentCooldownTime = cooldown;
            SpellEffects();
            if (spellSound)
            {
                //play sound
            }
        }
    }

    protected virtual void SpellEffects()
    {
        
    }
    protected virtual void Update()
    {
        if (onCooldown)
        {
            currentCooldownTime -= Time.deltaTime;
            if (currentCooldownTime <= 0)
            {
                onCooldown = false;
            }   
        }
    }
}