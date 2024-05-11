using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FireBallCaster : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform fireballSourceTransform;

    public float damage = 10;

    // Start is called before the first frame update
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
            FireBallCaster.GetComponent<FireBallCaster>.damage = damage;
        }
    }
    private class GetComponent<T>
    {
        internal static float damage;
    }
}
