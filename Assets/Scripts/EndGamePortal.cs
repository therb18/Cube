using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGamePortal : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        
        if (player != null)
        {
            SceneManager.LoadScene(3);
        }
    }
}
