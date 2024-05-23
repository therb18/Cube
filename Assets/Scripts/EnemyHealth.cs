using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public float value = 100;
    public Animator animator;
    public AudioSource Audio;

    public bool IsAlive()
    {
        return value > 0;
    }
    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            EnemyDeath();
        }
        else
        {
            animator.SetTrigger("hit");
        }
    }

    private void EnemyDeath()
    {
        animator.SetTrigger("death");
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<EnemyAI>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        Audio.Play();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

