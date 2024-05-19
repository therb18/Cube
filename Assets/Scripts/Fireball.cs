using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;
    public float lifetime;

    private void FixedUpdate()
    {
        MoveFixedUpdate();
    }

    private void MoveFixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);

        if (collision.gameObject.TryGetComponent<PlayerController>(out PlayerController player))
            return;
        if (collision.gameObject.TryGetComponent<Fireball>(out Fireball fireball))
            return;
        DestroyFireball();
    }

    private void DestroyFireball()
    {
        Destroy(gameObject);
    }

    private void Start()
    {
        Invoke("Destroy Fireball", lifetime);
    }
}
