using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform fireballSourceTransform;
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(fireballPrefab, fireballSourceTransform.position, fireballSourceTransform.rotation);
        }
    }
}
