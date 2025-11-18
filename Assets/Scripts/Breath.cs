using System;
using UnityEngine;

public class Breath : MonoBehaviour
{
    public float maxAmount;
    public float currentAmount;
    public float speed;

    private void Update()
    {
        currentAmount -= Time.deltaTime * speed;
        if (currentAmount < 0)
        {
            //lose
        }
    }
    //figure out breathing mechanic
}
