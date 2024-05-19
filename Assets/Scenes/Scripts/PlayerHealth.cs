using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject HealEffects;
    public float value = 100;
    public Animator animator;

    public GameObject gameplayUI;
    public GameObject gameOverScreen;
    public AudioSource TheEnd;
    public AudioSource Fon;
    public RectTransform valueRectTransfrom;

    private float _maxValue;

    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            PlayerisDead();
        }

        DrawHealthBar();
        
    }

    private void DrawHealthBar()
    {
        valueRectTransfrom.anchorMax = new Vector2(value / _maxValue, 1);
    }
    private void PlayerisDead()
    {
        gameplayUI.SetActive(false);
        gameOverScreen.SetActive(true);
        GetComponent<PlayerController>().enabled = false;
        GetComponent<cameraRotation>().enabled = false;
        GetComponent<CharacterController>().enabled = false;
        animator.SetTrigger("death");
        TheEnd.Play();
        Fon.enabled = false;

    }
    // Start is called before the first frame update
   private void Start()
    {
        _maxValue = value;
        DrawHealthBar();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddHealth(float amount)
    {
        value += amount;
        if (value > _maxValue)
        {
            value = _maxValue;
        }

        value = Mathf.Clamp(value, 0, _maxValue);
    }
}
