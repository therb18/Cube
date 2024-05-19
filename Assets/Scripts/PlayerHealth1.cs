using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth1 : MonoBehaviour
{
    public float value = 100;
    public RectTransform valueRectTransform;
    public GameObject gameplayUI;
    public GameObject gameOverScreen;
    public GameObject PauseButton;

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
    private void PlayerisDead()
    {
        PauseButton.SetActive(false);
        gameplayUI.SetActive(false);
        gameOverScreen.SetActive(true);
        GetComponent<PlayerController>().enabled = false;
        GetComponent<cameraRotation>().enabled = false;
        GetComponent<CharacterController>().enabled = false;

    }

    private void DrawHealthBar() => valueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);    // Start is called before the first frame update
    void Start()
    {
        _maxValue = value;
        DrawHealthBar();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
