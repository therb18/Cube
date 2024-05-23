using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FireballCaster : MonoBehaviour
{
    public Fireball fireballPrefab;
    public Transform fireballSourceTransform;
    public AudioSource Audio;

    public float damage = 10;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var fireball = Instantiate(fireballPrefab, fireballSourceTransform.position, fireballSourceTransform.rotation);
            fireball.damage = damage;
            Audio.Play();
        }
    }
}
